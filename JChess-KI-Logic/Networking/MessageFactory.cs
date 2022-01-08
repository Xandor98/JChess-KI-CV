using System;

namespace JChess_KI_Logic.Networking
{
    public class MessageFactory
    {
        public static JChessMessage createDrawResponseMessage(string uuid, bool accept)
        {
            JChessMessage msg = createBaseMessage(uuid, JChessMessageType.DrawResponse);
            
            DrawResponseMessage drawResponse = new DrawResponseMessage();
            drawResponse.accept = accept;

            msg.Item = drawResponse;
            return msg;
        }

        public static JChessMessage createRequestDrawMessage(string uuid, RequestDrawType requestDrawType)
        {
            JChessMessage msg = createBaseMessage(uuid, JChessMessageType.RequestDraw);
            
            RequestDrawMessage requestDraw = new RequestDrawMessage();
            requestDraw.reason = requestDrawType;

            msg.Item = requestDraw;
            return msg;
        }

        public static JChessMessage createMoveMessage(string uuid, MoveData data){
            JChessMessage msg = createBaseMessage(uuid, JChessMessageType.Move);
            
            MoveMessage move = new MoveMessage();
            move.move = data;

            msg.Item = data;
            return msg;
        }

        public static JChessMessage createLoginMessage(string uuid, string name){
            JChessMessage msg = createBaseMessage(uuid, JChessMessageType.Login);
            
            LoginMessage login = new LoginMessage();
            login.name = name;

            msg.Item = login;
            return msg;
        }
        public static JChessMessage createBaseMessage(string uuid, JChessMessageType type){
            JChessMessage msg = new JChessMessage();
            msg.playerId = uuid;
            msg.messageType = type;
            return msg;
        }
    }
}