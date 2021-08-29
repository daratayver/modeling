using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrbOfPredictions
{
	public partial class Form1 : Form
	{
		readonly MagicBall magicBall;
		public Form1()
		{
			InitializeComponent();
			answerLabel.Visible = false;
			magicBall = new MagicBall();
		}

		private void AnswerButton_Click(object sender, EventArgs e)
		{
			answerLabel.Text = magicBall.GetYesNo((double)probabilityValue.Value);

			answerLabel.Visible = true;
		}

		private void BallPanel_Click(object sender, EventArgs e)
		{
			ballLabel.Text = magicBall.GetAnswer();
		}

		private void BallLabel_Click(object sender, EventArgs e)
		{
			ballLabel.Text = magicBall.GetAnswer();
		}
	}
}
