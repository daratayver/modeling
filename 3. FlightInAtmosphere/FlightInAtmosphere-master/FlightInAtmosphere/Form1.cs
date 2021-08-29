using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightInAtmosphere
{
	public partial class Form1 : Form
	{
		private bool flag = false;

		private readonly Simulation simulation;
		public Form1()
		{
			InitializeComponent();

			simulation = new Simulation();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			simulation.NextState();

			chart1.Series[0].Points.AddXY(simulation.Body.X, simulation.Body.Y);

			timeLabel.Text = "Time: " + simulation.Time.ToString("0.00") + " c";

			if (simulation.IsFinished)
			{
				launchButton.ImageIndex = 2;

				flag = false;

				timer1.Stop();
			}
		}

		private void LaunchButton_Click(object sender, EventArgs e)
		{
			if (!timer1.Enabled && !flag)
			{
				chart1.Series[0].Points.Clear();

				simulation.NewSystem(0, heightNumericUpDown.Value,
					speedNumericUpDown.Value,
					(double)angleNumericUpDown.Value,
					weightNumericUpDown.Value,
					sizeNumericUpDown.Value);

				chart1.Series[0].Points.AddXY(simulation.Body.X, simulation.Body.Y);

				//chart1.ChartAreas[0].AxisY.Maximum = simulation.MaxY > 1 ? (double)simulation.MaxY : 1;
				//chart1.ChartAreas[0].AxisX.Maximum = simulation.MaxX > 1 ? (double)simulation.MaxX : 1;

				flag = true;

				launchButton.ImageIndex = 0;

				timer1.Start();
			}
			else if (flag && !timer1.Enabled)
			{
				launchButton.ImageIndex = 0;
				timer1.Start();
			}
			else if (flag && timer1.Enabled)
			{
				launchButton.ImageIndex = 1;
				timer1.Stop();
			}
		}
	}
}
