using System;
namespace _01._08._2023
{
	internal class Barque:Transport,IWaterable
	{
		public void BySail()
		{
			Console.WriteLine("They use sails for movement");
		}
	}
}

