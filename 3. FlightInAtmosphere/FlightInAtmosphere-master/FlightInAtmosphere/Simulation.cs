using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightInAtmosphere
{
	class Simulation
	{
		private const decimal dt = 0.01M, g = 9.81M;
		public decimal Time { get; private set; }
		public bool IsFinished { get; private set; }
		//public decimal MaxY { get; private set; }
		//public decimal MaxX { get; private set; }
		public Body Body { get; private set; }
		public void NewSystem(decimal x, decimal y, decimal velocity, double angle, decimal mass, decimal size)
		{
			IsFinished = false;
			Time = 0;

			Body = new Body(x, y,
				velocity,
				angle,
				mass,
				size);

			//decimal fT = (Body.VelocityY + (decimal)Math.Sqrt((double)(Body.VelocityY * Body.VelocityY + 2 * g * y))) / g;
			//MaxY = y + Body.VelocityY * Body.VelocityY / (2 * g);
			//MaxX = (Body.VelocityX * fT);
			
		}

		public void NextState()
		{
			if (!IsFinished)
			{
				Time += dt;

				Body.NextState(dt, g);
			}

			if (Body.Y <= 0) IsFinished = true;
		}
	}
}
