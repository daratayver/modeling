using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
	public partial class Form1 : Form
	{
		Game game;
		Label[] Counts;
		public Form1()
		{
			InitializeComponent();

			Counts = new Label[13]
			{
				ones, twos, threes, fours, fives, sixes,
				threeKind, fourKind, fullHouse, smStraight, lgStraight, fiveKind, chance
			};
		}

		private void RollButton_Click(object sender, EventArgs e)
		{
			game.RollDices();

			for (int i = 0; i < 5; i++)
			{
				dicePanel.Controls[i].BackgroundImage = imageList1.Images[game.Player.CurrentCombination[i] - 1];
			}

			for (int i = 0; i < Counts.Length; i++)
			{
				if (!game.Player.MaskCombinations[i])
				{
					Counts[i].Text = game.Player.Combinations[i].ToString();
					Counts[i].BackColor = Color.Green;
				}
				else
				{
					Counts[i].BackColor = Color.Transparent;
				}
			}

			move.Text = game.Step + "/3";
		}

		private void Dice_Click(object sender, EventArgs e)
		{
			if (game.Step > 0)
			{
				var dice = ((Panel)sender);

				var ind = dicePanel.Controls.IndexOf(dice);
				game.Dices[ind].Selection = !game.Dices[ind].Selection;

				if (game.Dices[ind].Selection) dice.BackColor = Color.Transparent;
				else dice.BackColor = Color.Gray;
			}
		}

		private void PlayButton_Click(object sender, EventArgs e)
		{
			if (CheatingCheckBox.Checked)
			{
				game = new Game(true);
			}
			else
			{
				game = new Game();
			}

			foreach (Panel dice in dicePanel.Controls)
			{
				dice.BackgroundImage = imageList1.Images[0];
			}

			gamePanel.BringToFront();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			startPanel.BringToFront();
		}

		private void Combo_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < Counts.Length; i++)
			{
				if (sender == Counts[i] && !game.Player.MaskCombinations[i])
				{
					game.ChooseCombo(i);

					for (int j = 0; j < Counts.Length; j++)
					{
						Counts[j].Text = game.Player.Combinations[j].ToString();
						Counts[j].BackColor = Color.Transparent;
					}

					sum.Text = game.Player.Sum.ToString();
					bonus.Text = game.Player.Bonus.ToString();
					total.Text = game.Player.Total.ToString();

					for (int j = 0; j < dicePanel.Controls.Count; j++)
					{
						if (game.Dices[j].Selection)
							dicePanel.Controls[j].BackColor = Color.Transparent;
					}

					if (game.Player.MaskCombinations.All(x => x == true))
					{
						result.Text = game.Player.Total.ToString();
						endPanel.BringToFront();
					}

					move.Text = game.Step + "/3";

					break;
				}
			}
		}
	}
}
