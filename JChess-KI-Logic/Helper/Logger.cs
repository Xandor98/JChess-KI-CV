using System;
using System.Globalization;

namespace JChess_KI_Logic.Helper
{
    class Logger
    {
        private static Logger instance = null;
        private const LogLevel defaultLevel = LogLevel.DEBUG;

        public static Logger Instance
        {
            get 
            {
                if(instance == null){
                    instance = new Logger();
                }
                return instance;
            }
        }

        public enum LogLevel : int
        {
            DEBUG = 0, INFO = 1, WARNING = 2, ERROR = 3, FATAL = 4
        }
        private Logger(){}
        
        private void Write(String message, LogLevel level){
            if(level < defaultLevel){
                return;
            }
            DateTime localDate = DateTime.Now;

            var cultureInfo = new CultureInfo("de-DE");

            string timeString = localDate.ToString(cultureInfo);
            string enumName = Enum.GetName(typeof(LogLevel), level);

            Console.WriteLine($"[{timeString}] - {enumName} - {message}");
        }

        public void Debug(string msg) {
            this.Write(msg, LogLevel.DEBUG);
        }

         public void Info(string msg) {
            this.Write(msg, LogLevel.INFO);
        }

         public void Warning(string msg) {
            this.Write(msg, LogLevel.WARNING);
        }

         public void Error(string msg) {
            this.Write(msg, LogLevel.ERROR);
        }
        
         public void Fatal(string msg) {
            this.Write(msg, LogLevel.FATAL);
        }
    }
}