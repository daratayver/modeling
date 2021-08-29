using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballСhampionship
{
	public partial class Form1 : Form
	{
		private Game game;
		public Form1()
		{
			InitializeComponent();
		}

		private void PlayButton_Click(object sender, EventArgs e)
		{
			game = new Game();
			game.GoChampionship();

			foreach (var c in Controls)
			{
				if (c.GetType() == typeof(Label))
				{
					Label label = (Label)c;
					if (label.Name.Contains("team"))
					{
						var l = label.Name.Remove(0, 4);
						var inx = int.Parse(l);
						var match = game.Matches[inx / 2];
						int t = inx % 2;

						var penalty = (match.Penalty[0] != 0 && match.Penalty[1] != 0) ? " p" + match.Penalty[t].ToString() : "";

						label.Text = match.Teams[t] + "   " + match.Score[t] + penalty;
					}
					else if (label.Name.Contains("result"))
					{
						label.Text = "Победитель: " + game.Matches.Last().Winner; 
					}
				}
			}
		}

		/*private void PlayButton_Click(object sender, EventArgs e)
		{
			var score1 = simulation.GetResult();
			var score2 = simulation.GetResult();

			score.Text = score1 + ":" + score2;
			if (score1 > score2) result.Text = "Победила команда " + team1.Text;
			else if (score1 < score2) result.Text = "Победила команда " + team2.Text;
			else result.Text = "Ничья";
		}

		private void Team_TextChanged(object sender, EventArgs e)
		{
			if (team1.TextLength > 0 && team2.TextLength > 0) playButton.Enabled = true;
			playButton.Enabled = false;
		}*/
	}
}
