﻿using System;

namespace Convert_radians_to_degrees
{
	class Program
	{
		static void Main(string[] args)
		{
			double radians = double.Parse(Console.ReadLine());
			double degrees = radians * 180 / Math.PI;
			Console.WriteLine(Math.Round (degrees));
		}
	}
}
