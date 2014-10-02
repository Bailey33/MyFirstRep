using System;

namespace MyFirstRep
{
	public class Player
	{
		public Player ()
		{
			Boolean dead = false;
			float playerx = 0;
			float playery = 0;
			float wallxr = 0;
			float wallyl = 0;
			float pSpeed = 1.0f;
			
		}
		
		public void Collision ()
		{
			if (playerx < wallxr)
			{
				pSpeed = 0.0f;
			}
			else
			{
				pSpeed = 1.0f;
			}
			
		
		}
	}
}

