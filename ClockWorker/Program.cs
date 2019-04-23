using System;

namespace Clockwork
{
	class Program
	{
        static void Main(string[] args)
		{
			Console.WriteLine("Enter Player Name Clock Traveller..");
			string playerName = Console.ReadLine();
			Game myGame = new Game();
            ClockWorking clock = new ClockWorking();
			Player newPlayer = new Player(5, playerName);
            
            Console.WriteLine("You fall down a hole when you were not looking in front of you.");
            Console.WriteLine("You are now in a dark hole but see some stone around you.");

            Console.WriteLine(myGame.GetDiscription(newPlayer.GetPos()));

            while (newPlayer.IsAlive())
            {
                string userInput = Console.ReadLine();
                if (userInput.Contains("Talk") && userInput.Contains("Goblin"))
                {
                    Console.WriteLine("You make some sounds that you think they would understand, They do not...");
                }

                if (userInput.Contains("goblin") &&
                    userInput.Contains("attack") || 
                    userInput.Contains("throw") || 
                    userInput.Contains("hurt") || 
                    userInput.Contains("kill"))
                {
                    myGame.GetNewTime();
                    Console.WriteLine("The nearest goblin pulls out a clock and winds the hour hand.");
                    Console.WriteLine("A spark hits it and a fuze is lit. The Goblin looks at you and says it's " + myGame.getTime() + " how many degrees between hands!?");
                    Console.WriteLine("Answer or you go boom!");

                    while (newPlayer.IsAlive())
                    {
                        Console.Write("The time is " + myGame.getTime() + " how many degrees!? ");
						userInput = Console.ReadLine();

                        float goblinDegrees = clock.GetDegrees(myGame.mins, myGame.hours);
                        float playerDegrees = int.Parse(userInput);

                        if (playerDegrees > goblinDegrees - 20 && 
                            playerDegrees < goblinDegrees + 20)
                        {
                            Console.WriteLine("Ohh nooo, my bomb go BOOM!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Silly Human! BONK!");
                            newPlayer.Damage();
                        }

                    }

                    if (!newPlayer.IsAlive())
                    {
                        Console.WriteLine("Oh no " + newPlayer.Name + " went Booooooom!");                        
                    }



                }


            }
			

			
			
			//Console.WriteLine("Please enter the hour and minute format HH:MM")
			//Console.ReadLine()
		}
	}
}
