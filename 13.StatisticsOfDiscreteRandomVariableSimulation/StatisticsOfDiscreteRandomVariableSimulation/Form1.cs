using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticsOfDiscreteRandomVariableSimulation
{
	public partial class Form1 : Form
	{
		readonly Processing processing;
		public Form1()
		{
			InitializeComponent();
			processing = new Processing();
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

			processing.GetStatistics(probs, size, (int)numberValue.Value);
			var frequency = processing.Probabilities;

			chart1.Series[0].Points.Clear();
			for (int i = 0; i < size; i++)
			{
				chart1.Series[0].Points.AddXY(i + 1, frequency[i]);
			}

			average.Text = processing.Average.ToString("F3") + " (error = " + decimal.Round(processing.AverageError * 100) + "%)";
			variance.Text = processing.Variance.ToString("F3") + " (error = " + decimal.Round(processing.VarianceError * 100) + "%)";

			chiSquared.Text = processing.ChiSquare.ToString("F3") + " <= " + processing.CriticalValue.ToString("F3") + " is ";
			
			if (processing.ChiSquareTest)
			{
				test.Text = "true";
				test.ForeColor = Color.Green;
			}
			else
			{
				test.Text = "false";
				test.ForeColor = Color.Red;
			}
		}
	}
}
