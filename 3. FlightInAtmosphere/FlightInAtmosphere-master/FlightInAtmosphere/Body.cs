using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightInAtmosphere
{
	public class Body
	{
		private const decimal C = 0.15M, rho = 1.29M;
		public Body(decimal x, decimal y, decimal velocity, double angle, decimal mass, decimal size)
		{
			X = x;
			Y = y;

			Velocity = velocity;

			double a = angle * Math.PI / 180;
			decimal cosa = (decimal)Math.Cos(a);
			decimal sina = (decimal)Math.Sin(a);

			VelocityX = Velocity * cosa;
			VelocityY = Velocity * sina;

			Mass = mass;
			Size = size;

			K = 0.5M * C * rho * Size / Mass;
		}

		public decimal Mass { get; }
		public decimal Size { get; }
		public decimal K { get; }
		public decimal Velocity { get; private set; }
		public decimal VelocityX { get; private set; }
		public decimal VelocityY { get; private set; }
		public decimal X { get; private set; }
		public decimal Y { get; private set; }

		public void NextState(decimal dt, decimal g)
		{
			Velocity = (decimal)Math.Sqrt((double)(VelocityX * VelocityX + VelocityY * VelocityY));

			VelocityX -= K * VelocityX * Velocity * dt;

			VelocityY -= (g + K * VelocityY * Velocity) * dt;

			X += VelocityX * dt;

			Y += VelocityY * dt;
		}
	}
}
