using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightWithoutAtmosphere
{
	public partial class Form1 : Form
	{
		private decimal t, x0, y0, v0, cosa, sina;
		private const decimal dt = 0.01M, g = 9.81M;
		private double time = 0;
		private bool flag = false;
		public Form1()
		{
			InitializeComponent();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			t += dt;

			decimal x = x0 + v0 * cosa * t;

			decimal y = y0 + v0 * sina * t - g * t * t / 2;

			chart1.Series[0].Points.AddXY(x, y);

			timeLabel.Text = "Time: " + time.ToString("0.00") + " c";

			time += 0.01;

			if (y <= 0)
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

				t = 0;

				x0 = 0;

				y0 = heightNumericUpDown.Value;

				v0 = speedNumericUpDown.Value;

				double a = (double)angleNumericUpDown.Value * Math.PI / 180;

				cosa = (decimal)Math.Cos(a);

				sina = (decimal)Math.Sin(a);

				chart1.Series[0].Points.AddXY(x0, y0);

				decimal fT = (v0 * sina + (decimal)Math.Sqrt((double)(v0 * v0 * sina * sina + 2 * g * y0))) / g;

				double maxH = (double)(y0 + v0 * v0 * sina * sina / (2 * g));
				chart1.ChartAreas[0].AxisY.Maximum = maxH > 1 ? maxH : 1;

				double S = (double)(v0 * fT * cosa);
				chart1.ChartAreas[0].AxisX.Maximum = S > 1 ? S : 1;

				flag = true;

				time = 0;

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
