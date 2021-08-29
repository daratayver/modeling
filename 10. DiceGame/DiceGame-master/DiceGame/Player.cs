using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiceGame
{
	public class Player
	{
		public Player()
		{
			MaskCombinations = new bool[13];
			Combinations = new int[13];
			CurrentCombination = new int[5];
		}
		public int[] CurrentCombination { get; set; }
		public bool[] MaskCombinations { get; set; }
		public int[] Combinations { get; set; }

		public int Total { get; set; }
		public int Sum { get; set; }
		public int Bonus { get; set; }
		public bool BonusReceived { get; set; }

		public void Count()
		{
			int[] dices = new int[6];
			int[] check = new int[Combinations.Length];

			Combinations.CopyTo(check, 0);

			foreach (var dice in CurrentCombination)
			{
				dices[dice - 1]++;
			}

			int smStraight = 0, lgStraight = 0;
			for (int i = 0; i < 6; i++)
			{
				Combinations[i] = dices[i] * (i + 1);

				if (dices[i] >= 1)
				{
					smStraight++;
					lgStraight++;
				}
				else
				{
					smStraight = 0;
					lgStraight = 0;
				}
				
				if (dices[i] >= 3)
				{
					Combinations[6] = CurrentCombination.Sum();

					if (dices[i] == 3)
					{
						foreach (var dice in dices)
						{
							if (dice == 2)
							{
								Combinations[8] = 25;
							}
						}
					}
				}

				if (dices[i] >= 4)
				{
					Combinations[7] = CurrentCombination.Sum();
				}

				if (dices[i] == 5)
				{
					Combinations[11] = 50;
				}
			}

			if (smStraight >= 4) Combinations[9] = 30;
			if (lgStraight == 5) Combinations[10] = 40;

			Combinations[12] = CurrentCombination.Sum();

			for (int i = 0; i < Combinations.Length; i++)
			{
				if (MaskCombinations[i])
				{
					Combinations[i] = check[i];
				}
			}
		}

		public void ChooseCombo(int inx)
		{
			MaskCombinations[inx] = true;

			if (inx < 6) Sum += Combinations[inx];
			if (Sum > 62) Bonus = 35;
			Total += Combinations[inx];

			if (!BonusReceived)
			{
				Total += Bonus;
				BonusReceived = true;
			}

			for (int i = 0; i < Combinations.Length; i++)
			{
				if (!MaskCombinations[i])
				{
					Combinations[i] = 0;
				}
			}
		}
	}
}
