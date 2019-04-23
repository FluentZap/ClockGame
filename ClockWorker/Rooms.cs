using System;
using System.Collections.Generic;

namespace Clockwork
{
	
	public struct Location
	{
		public int X;
		public int Y;

		public Location (int x, int y)
		{
			X = x;
			Y = y;
		}
	}
	
	
	class Game
	{
		Random rnd = new Random();
        public int hours;
        public int mins;


        public void GetNewTime()
        {
            hours = rnd.Next(1, 12);
            mins = rnd.Next(1, 60);
        }


        public string getTime()
        {
            return (hours.ToString().Length < 2 ? "0" + hours.ToString() : hours.ToString()) + ":" + (mins.ToString().Length < 2 ? "0" + mins.ToString() : mins.ToString());
        }



        public int GetHour(string time)
        {
            int hour = int.Parse(time.Substring(0, 2));
            return hour;
        }

        public int GetMin(string time)
        {
            int min = int.Parse(time.Substring(3, 2));
            return min;
        }



        class Room
        {
            public List<Goblin> GoblinList = new List<Goblin>();

        }

		Dictionary<Location, Room> Dungeon = new Dictionary<Location, Room>();
		


        public string GetDiscription(Location pos)
        {
            if (!Dungeon.ContainsKey(pos))
            {
                PopulateRoom(pos);
            }
            string dis = "";
            int count = Dungeon[pos].GoblinList.Count;
            if (count == 1) dis += "You see 1 Goblin!";                    
            if (count == 0) dis += "You see nothing of threat...";                    
            if (count > 1) dis += "You see " + Dungeon[pos].GoblinList.Count + " Goblins! Oh my!";

            return dis;
        }




		
		void PopulateRoom(Location pos)
		{
            if (!Dungeon.ContainsKey(pos))
            {
                Dungeon.Add(pos, new Room());
            }
            int goblinCount = rnd.Next(1, 9);

            for (int i = 1; i < goblinCount; i++)
            {
				int goblinHP = rnd.Next(2, 9);
                Dungeon[pos].GoblinList.Add(new Goblin(goblinHP, "Kloorp" + i));
            }

		}
		
	}
	
	
	
	
}
