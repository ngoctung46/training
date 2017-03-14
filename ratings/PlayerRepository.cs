using System;
using System.Collections.Generic;

namespace ratings
{
	public static class PlayerRepository
	{
		public static List<Player> GetPlayers()
		{
			List<Player> data = new List<Player>();
			data.Add(new Player
			{
				Name = "Bill Evans",
				Game = "Tic Tac Toe",
				Rating = 4
			});
			data.Add(new Player
			{
				Name = "Oscart Peterson",
				Game = "Spin The Bottle",
				Rating = 5
			});
			data.Add(new Player
			{
				Name = "Dave Brubeck",
				Game = "Texas Hold'em Poker",
				Rating = 5
			});

			return data;
		}
				
			

	}
}
