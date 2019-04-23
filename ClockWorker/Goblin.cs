using System;

namespace Clockwork
{
	
	
	class Disposition
	{
		int Agree = 0;
		int Hostility = 0;
	}
	
	class Player
	{
		Location pos = new Location(10, 10);
		int Health = 0;
		int MaxHealth = 0;
		public string Name = "";
		
		public Player(int health, string name)
		{
			Health = health;
            MaxHealth = health;
			Name = name; 
		}

        public void Damage() {
            Health--;
        }
		
		
		public Location GetPos()
		{
			return pos;
		}

        public bool IsAlive()
        {
            if (Health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

	}
	
	class Goblin
	{
		string Name = "";
		int Health = 0;
		int MaxHealth = 0;
		Disposition mood = new Disposition();
		
		public Goblin(int health, string name)
		{
			Health = health;
			MaxHealth = health;
			Name = name;
		}
		
	}
	
	
	public class Clock
	{
		int HourHand = 0;
		int MinuteHand = 0;
	}
	
	
	//public ClockDisplay(int HourHand, int MinuteHand)
	//{
		
	//}
	
}