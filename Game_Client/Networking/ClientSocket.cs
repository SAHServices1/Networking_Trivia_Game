using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Game_Client.Networking
{
    class ClientSocket
    {

        private Socket socket;
        private byte[] buffer;
        ClientForm clientGUI;
        string username;
        public Boolean isConnected;


        public ClientSocket()
        {
            isConnected = false;
        }


        public void setUserName(string nm)
        {
            username = nm;
        }

        public void setForm(ClientForm frm)
        {
            clientGUI = frm;
        }

        public void Connect(string ipAddress, int port)
        {
            clientGUI.Invoke(clientGUI.updateTextBox, "Attempting to connect...");
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.BeginConnect(new IPEndPoint(IPAddress.Parse(ipAddress), port), ConnectCallback, null);
            }
            catch
            {
                clientGUI.Invoke(clientGUI.updateTextBox, "Error connecting to server.");
            }
        }

        public void send(string msg)
        {
            try
            {
                socket.Send(Encoding.UTF8.GetBytes(msg), SocketFlags.None);
            }
            catch
            {
                clientGUI.Invoke(clientGUI.updateTextBox, "Failed to send message.");
            }
        }

        private void ConnectCallback(IAsyncResult result)
        {
            
            if (socket.Connected)
            {
                clientGUI.Invoke(clientGUI.updateTextBox, "Connected to server.");
                isConnected = true;
                socket.EndConnect(result);
                send(username);
                buffer = new byte[1024];
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceivedCallback, null);
            }
            else
            {
                clientGUI.Invoke(clientGUI.updateTextBox, "Failed to connect.");
                return;
            }
        }

        private void ReceivedCallback(IAsyncResult result)
        {
            int bufLength = socket.EndReceive(result);
            byte[] packet = new byte[bufLength];
            Array.Copy(buffer, packet, packet.Length);
            String msg = Encoding.UTF8.GetString(packet);          

            if (msg[0] == 'Q' && Char.IsNumber(msg[1]))
            {
                clientGUI.Invoke(clientGUI.startQTimer);
                clientGUI.Invoke(clientGUI.submitButton, true); 
                clientGUI.Invoke(clientGUI.updateTextBox, msg);
            }
            
            else
            {
                clientGUI.Invoke(clientGUI.updateTextBox, "(Server): " + msg);
            }

            buffer = new byte[1024];
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceivedCallback, null);
        }

        public void disconnect()
        {
            try
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.BeginDisconnect(true, new AsyncCallback(DisconnectCallback), socket);
            }
            catch
            {
                clientGUI.Invoke(clientGUI.updateTextBox, "Error trying to disconnect!");
            }
        }

        private void DisconnectCallback(IAsyncResult ar)
        {
            Socket client = (Socket)ar.AsyncState;
            client.EndDisconnect(ar);

            clientGUI.Invoke(clientGUI.updateTextBox, "Disconnected from the server.");
        }

    }
}
