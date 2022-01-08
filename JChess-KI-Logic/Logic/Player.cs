using System;
using System.Net;
using JChess_KI_Logic.Networking;
using JChess_KI_Logic.Helper;

namespace JChess_KI_Logic.Logic
{
    public class Player 
    {
        private Client self;
        private string name; 
        private Guid myuuid;
        private bool successLogin = false;
        private bool loginFail = false;

        public Player(string name){
            this.name = name;
            this.myuuid = Guid.NewGuid();

            self = new Client();
        }   

        public void Start(){
            IPAddress address = IPAddress.Parse(Config.Instance.GetConfig("IP_ADDRESS"));
            int port = Convert.ToInt32(Config.Instance.GetConfig("IP_PORT"));
            Logger.Instance.Debug($"Connecting to {address.MapToIPv4().ToString()}:{port}");
            self.Connect(address, port);
            Login();
        }

        private void Login(){
            while(!successLogin || !loginFail){
                JChessMessage msg = MessageFactory.createLoginMessage(this.myuuid.ToString(), this.name);
                self.SendMessage(msg);

                ProcessMessage(self.ReceiveMessage());
            }

            if(loginFail){
                Logger.Instance.Error("There was an error with the Login!");
                System.Environment.Exit(1);
            }
            Thread MessageReceiveThread = new Thread(this.StartMessageReceiverThread);
            MessageReceiveThread.Start();
        }
        
        private void StartMessageReceiverThread(){
            while(true){
                //TODO: Make Message Receiving a Queue
                ProcessMessage(self.ReceiveMessage());
            }
        }

        private void ProcessMessage(JChessMessage msg){
            switch(msg.messageType)
            {
                case JChessMessageType.Accept:
                    ProcessAcceptMessage((AcceptMessage) msg.Item);
                    break;
                case JChessMessageType.LoginReply:
                    ProcessLoginReply((LoginReplyMessage) msg.Item);
                    break;
                case JChessMessageType.Disconnect:
                    ProcessDisconnectMessage((DisconnectMessage) msg.Item);
                    break;
                case JChessMessageType.MatchFound:
                    ProcessMatchFoundMessage((MatchFoundMessage) msg.Item);
                    break;
                case JChessMessageType.MatchOver:
                    ProcessMatchOverMessage((MatchOverMessage) msg.Item);
                    break;
                case JChessMessageType.MatchStatus:
                    ProcessMatchStatusMessage((MatchStatusMessage) msg.Item);
                    break;
                case JChessMessageType.GameStart:
                    ProcessGameStartMessage((GameStartMessage) msg.Item);
                    break;
                case JChessMessageType.GameOver:
                    ProcessGameOverMessage((GameOverMessage) msg.Item);
                    break;
                case JChessMessageType.AwaitMove:
                    ProcessAwaitMoveMessage((AwaitMoveMessage) msg.Item);
                    break;
                case JChessMessageType.RequestDraw:
                    ProcessRequestDrawMessage((RequestDrawMessage) msg.Item);
                    break;
                case JChessMessageType.HeartBeat:
                    Logger.Instance.Debug("Got a Ping from Server");
                    break;
                default:
                    Logger.Instance.Warning($"No Handler for Type: {Enum.GetName(msg.messageType)}");
                    break;
            }
        }

        private void ProcessLoginReply(LoginReplyMessage msg){
            successLogin = true;
            this.myuuid = Guid.Parse(msg.newId);
            Logger.Instance.Info($"Login was Successfull. New UUID: {this.myuuid}");
        }

        private void ProcessAcceptMessage(AcceptMessage msg){
            switch (msg.errorTypeCode)
            {
                case ErrorType.NO_ERROR:
                    break;
                case ErrorType.ERROR:
                    break;
                case ErrorType.AWAIT_LOGIN:
                    Login();
                    break;
                case ErrorType.TIMEOUT:
                    break;
                case ErrorType.TOO_MANY_TRIES:
                    loginFail = true;
                    break;
                case ErrorType.UNSUPPORTED_OPERATION:
                    Logger.Instance.Error("Last Message Had an unsoported Move!");
                    break;
                case ErrorType.VERSION_MISMATCH:
                    break;
                case ErrorType.DUPLICATE_NAME:
                    this.name += "_origin";
                    break;
            }
        }

        private void ProcessDisconnectMessage(DisconnectMessage msg){

        }

        private void ProcessMatchFoundMessage(MatchFoundMessage msg){

        }

        private void ProcessMatchOverMessage(MatchOverMessage msg){

        }

        private void ProcessMatchStatusMessage(MatchStatusMessage msg){

        }

        private void ProcessGameStartMessage(GameStartMessage msg){

        }

        private void ProcessGameOverMessage(GameOverMessage msg){

        }

        private void ProcessAwaitMoveMessage(AwaitMoveMessage msg){

        }

        private void ProcessRequestDrawMessage(RequestDrawMessage msg){

        }
    }
}