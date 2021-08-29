using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticsOfEventGenerating
{
	public partial class Form1 : Form
	{
		readonly Statistics statistics;
		public Form1()
		{
			InitializeComponent();
			statistics = new Statistics();
		}

		private void ProbValue_ValueChanged(object sender, EventArgs e)
		{
			var prob5 = 1 - (prob1Value.Value + prob2Value.Value + prob3Value.Value + prob4Value.Value);
			if (prob5 < 0)
			{
				prob5Value.Text = "ERROR";
				prob5Value.BackColor = Color.Red;
				startButton.Enabled = false;
			}
			else
			{
				prob5Value.Text = prob5.ToString("f3");
				prob5Value.BackColor = Color.White;
				startButton.Enabled = true;
			}
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			int size = 5;
			decimal[] probs = new decimal[]
			{
				prob1Value.Value,
				prob2Value.Value,
				prob3Value.Value,
				prob4Value.Value,
				decimal.Parse(prob5Value.Text)
			};

			var frequency = statistics.GetStatistics(probs, size, (int)numberValue.Value);

			chart1.Series[0].Points.Clear();
			for (int i = 0; i < size; i++)
			{
				chart1.Series[0].Points.AddXY(i + 1, frequency[i]);
			}
		}
		//Вывод: с увеличением количества экспериментов,
		//погрешность вычисления эмпирических вероятностей уменьшается
	}
}
