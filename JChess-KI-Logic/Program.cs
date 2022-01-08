using System;
using System.Net;
using JChess_KI_Logic.Helper;
using JChess_KI_Logic.Logic;

namespace JChess_KI_Logic 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player(Config.Instance.GetConfig("PLAYER_NAME"));

            player.Start();
        }
    }
}