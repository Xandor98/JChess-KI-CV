using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Xml.Serialization;
using JChess_KI_Logic.Helper;

namespace JChess_KI_Logic.Networking
{
	public class Client
	{
		private int port;
		private IPAddress address;
		private TcpClient clientSocket;
		private NetworkStream stream;
		private string response = String.Empty;

		private int ConnectionRetrys = 0;

		public Client(){

		}

		public Client(int port, IPAddress address)
		{
			Connect(address, port);
		}

		public void Connect(IPAddress address, int port){
			this.port = port;
			this.address = address;
			StartClient();
		}

		private void StartClient(){
			clientSocket = new TcpClient();
			Logger.Instance.Debug("Start Connecting");	
			try{
				Logger.Instance.Info($"Try connecting to {this.address.MapToIPv4().ToString()}:{this.port}");
				clientSocket.Connect(address, port);
				stream = clientSocket.GetStream();

				Logger.Instance.Info($"Successfull connected to {this.address.MapToIPv4().ToString()}:{this.port}");
			}catch (Exception e){
				if (ConnectionRetrys < 5){
					ConnectionRetrys++;
					Logger.Instance.Error("Could not connect to Server. I will try again ....");
					StartClient();
				}
				else
				{
					Logger.Instance.Fatal(e.ToString());
				}
			}
		}

		public void SendMessage(JChessMessage message)
		{
			using (var stringWriter = new System.IO.StringWriter())
			{
				var serializer = new XmlSerializer(typeof(JChessMessage));
				serializer.Serialize(stringWriter, message);

				string msgString = stringWriter.ToString();

				Logger.Instance.Debug($"SendMessage: MessageSend -> {msgString}");

				byte[] header = BitConverter.GetBytes(msgString.Length);
				if(BitConverter.IsLittleEndian){
					Array.Reverse(header);
				}

				byte[] headerToSend = new byte[4];
				header.CopyTo(headerToSend, 0);

				byte[] msg = Encoding.ASCII.GetBytes(msgString);

				stream.Write(headerToSend, 0, headerToSend.Length);
				stream.Write(msg, 0, msg.Length);
			}
		}

		public JChessMessage ReceiveMessage(){
			byte[] header = new byte[4];
			int headerRec = stream.Read(header, 0, header.Length);

			if(BitConverter.IsLittleEndian)
			{
				Array.Reverse(header);
			}
			int lenght = BitConverter.ToInt32(header);

			byte[] data = new byte[lenght];
			int bytesRec = stream.Read(data, 0, data.Length);
			String msg = Encoding.ASCII.GetString(data, 0, bytesRec);
			Logger.Instance.Debug($"ReceivedMessage: MessageReceived -> {msg}");

			using(var stringReader = new System.IO.StringReader(msg))
			{
				var serializer = new XmlSerializer(typeof(JChessMessage));
				return serializer.Deserialize(stringReader) as JChessMessage;
			}
		}

		public bool IsConnected() {
			return clientSocket.Connected;
		}

		public void ShutDownClient(){
			stream.Close();
			clientSocket.Close();
		}

	}
}
