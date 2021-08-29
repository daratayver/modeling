using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
	public enum Dots
	{
		One,
		Two,
		Three,
		Four,
		Five,
		Six
	}
	public class Dice
	{
		public static Random random;
		public Dice(bool cheating = false)
		{
			random = new Random();

			Position = Dots.One;
			Selection = true;
			Probability = new double[6];

			if (!cheating)
			{
				for (int i = 0; i < Probability.Length; i++)
				{
					Probability[i] = 1.0 / 6;
				}
			}
			else
			{
				var total = 100;
				for (int i = 0; i < Probability.Length - 1; i++)
				{
					var r = random.Next(total);
					Probability[i] = r / 100.0;
					total -= r;
				}
				Probability[Probability.Length - 1] = total / 100.0;
			}
		}
		public Dots Position { get; set; }
		public bool Selection { get; set; }

		public double[] Probability { get; set; }
	}
}
