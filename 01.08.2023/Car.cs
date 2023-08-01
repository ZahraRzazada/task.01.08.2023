using System;
namespace _01._08._2023
{
	internal class Car:Transport,ILandable
	{
		public void ByWheel()
		{
			Console.WriteLine("They use wheel for movement");
		}
	}
}

