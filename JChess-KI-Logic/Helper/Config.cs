using System;
using System.IO;

namespace JChess_KI_Logic.Helper
{
    class Config
    {
        private static Config instance = null;

        public static Config Instance 
        {
            get 
            {
                if(instance == null){
                    instance = new Config();
                }
                return instance;
            }
        }

        private const string CONFIG_NAME = "settings.cfg";
        private const char COMMENT_CHAR = '#';
        private const char SEPERATOR = '=';

        private Dictionary<string, string> configuration;
        private Config(){
            configuration = new Dictionary<string, string>();
            LoadConfig();
        }

        private void LoadConfig(){
            
            if(!File.Exists(CONFIG_NAME)){
                Logger.Instance.Fatal("Config: Settings does not Exist.");
                System.Environment.Exit(1);
            }

            foreach (string l in File.ReadLines(CONFIG_NAME))
            {  
                string line = l.Trim();
                if(line.StartsWith(COMMENT_CHAR))
                    continue;

                string[] conf = line.Split(SEPERATOR);
                if (conf.Length != 2){
                    Logger.Instance.Warning($"Config: Invalid Line Found: {line}");
                    continue;
                }
                SetConfig(conf[0].Trim(), conf[1].Trim());
            } 
        }

        public string GetConfig(string key){
            if(!configuration.ContainsKey(key)){
                Logger.Instance.Error($"Config Key \"{key}\" does not Exist");
                System.Environment.Exit(1);
            }

            return configuration[key];
        }

        public void SetConfig(string key, string value){
            if (configuration.ContainsKey(key)){
                configuration[key] = value;
                Logger.Instance.Debug($"Changed Config of \"{key}\" to the Value\"{value}\"");
            }else{
                configuration.Add(key, value);
                Logger.Instance.Debug($"Added new Config with Key \"{key}\" and Value\"{value}\"");
            }
        }

        public void SaveConfig(){
            using (StreamWriter file = new(CONFIG_NAME)){
                foreach (var item in configuration)
                {
                    file.WriteLine($"{item.Key}{SEPERATOR}{item.Value}");
                }
            }
        }
    }
}