using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
	public class Game
	{
		public Game(bool cheating = false)
		{
			Dices = new Dice[5];
			for (int i = 0; i < Dices.Length; i++)
			{
				Dices[i] = new Dice(cheating);
			}

			Player = new Player();

		}

		public int Step { get; private set; }
		public Dice[] Dices { get; private set; }
		public Player Player { get; private set; }

		public void RollDices()
		{
			if (Step < 3)
			{
				foreach (var dice in Dices)
				{
					if (dice.Selection)
					{
						var alpha = Dice.random.NextDouble();

						for (int i = 0; i < dice.Probability.Length; i++)
						{
							alpha -= dice.Probability[i];

							if (alpha <= 0)
							{
								dice.Position = (Dots)(Enum.GetValues(Dots.One.GetType())).GetValue(i);
								break;
							}
						}
					}
				}

				for (int i = 0; i < Dices.Length; i++)
				{
					Player.CurrentCombination[i] = (int)Dices[i].Position + 1;
				}

				Player.Count();
				Step++;
			}
		}

		public void ChooseCombo(int inx)
		{
			Player.ChooseCombo(inx);
			Step = 0;
			foreach (var dice in Dices)
			{
				dice.Selection = true;
			}
		}
	}
}
