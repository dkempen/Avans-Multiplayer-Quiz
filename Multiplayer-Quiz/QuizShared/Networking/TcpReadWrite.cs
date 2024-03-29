﻿using Newtonsoft.Json.Linq;
using System;
using System.Net.Sockets;
using System.Text;

namespace QuizShared.Networking
{
    static class TcpReadWrite
    {
        public static void Write(TcpClient client, JObject message)
        {
            byte[] bytesJson = Encoding.UTF8.GetBytes(message.ToString());
            byte[] bytesLength = BitConverter.GetBytes(bytesJson.Length);
            byte[] bytesToSend = new byte[bytesLength.Length + bytesJson.Length];
            Array.Copy(bytesLength, bytesToSend, bytesLength.Length);
            Array.Copy(bytesJson, 0, bytesToSend, 4, bytesJson.Length);

            client.GetStream().Write(bytesToSend, 0, bytesToSend.Length);
        }

        public static JObject Read(TcpClient client)
        {
            if (!client.Connected)
            {
                Console.WriteLine(@"Client not connected");
                throw new Exception();
            }

            NetworkStream stream = client.GetStream();
            byte[] lengthBytes = new Byte[4];
            StringBuilder message = new StringBuilder();
            try
            {
                stream.Read(lengthBytes, 0, lengthBytes.Length);
                int length = BitConverter.ToInt32(lengthBytes, 0);
                int totalSizeRead = 0;
                byte[] receiveBuffer = new byte[length];
                do
                {
                    var numberOfBytesRead = stream.Read(receiveBuffer, 0, receiveBuffer.Length - totalSizeRead);
                    totalSizeRead += numberOfBytesRead;
                    message.AppendFormat("{0}", Encoding.UTF8.GetString(receiveBuffer, 0, numberOfBytesRead));
                } while (totalSizeRead < length);
            }
            catch (Exception)
            {
                Console.WriteLine(@"Client has disconnected");
                throw;
            }
            return JObject.Parse(message.ToString());
        }
    }
}
