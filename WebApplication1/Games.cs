using System;

namespace WebApplication1
{
    public class Games
    {
        private int v1;
        private string v2;
        private DateTime dateTime;

        public int GameId { get; set; }

        public string GameName { get; set; }

        public string Data { get; set; }

        public DateTime GameExpire { get; set; }
        public Games(int game,string name,string data,DateTime expire)
        {
            GameId = game;
            GameName = name;
            Data = data;
            GameExpire = expire;

        }

      
    }
   
}
