using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsOfDiscreteRandomVariableSimulation
{
	class Processing
	{
		readonly Random random = new Random();
		public decimal CriticalValue { get => 9.488M; }

		public decimal Average { get; private set; }
		public decimal AverageError { get; private set; }
		public decimal Variance { get; private set; }
		public decimal VarianceError { get; private set; }

		public decimal ChiSquare { get; private set; }
		public bool ChiSquareTest { get; private set; }

		public decimal[] Probabilities { get; private set; }

		public void GetStatistics(decimal[] probs, int size, int N)
		{
			decimal[] statistics = new decimal[size];
			Probabilities = new decimal[size];
			for (int i = 0; i < N; i++)
			{
				var alpha = (decimal)random.NextDouble();

				for (int j = 0; j < size; j++)
				{
					alpha -= probs[j];

					if (alpha <= 0)
					{
						statistics[j]++;
						break;
					}
				}
			}

			for (int i = 0; i < size; i++)
			{
				Probabilities[i] = statistics[i] / N;
			}

			Average = 0;
			decimal E = 0;
			for (int i = 0; i < Probabilities.Length; i++)
			{
				var x = i + 1;
				Average += Probabilities[i] * x;
				E += probs[i] * x;
			}
			AverageError = Math.Abs((Average - E) / E);

			Variance = 0;
			decimal D = 0;
			for (int i = 0; i < Probabilities.Length; i++)
			{
				var x = i + 1;
				Variance += Probabilities[i] * x * x;
				D += probs[i] * x * x;
			}
			Variance -= Average * Average;
			D -= E * E;
			VarianceError = Math.Abs((Variance - D) / D);

			ChiSquare = 0;
			for (int i = 0; i < Probabilities.Length; i++)
			{
				ChiSquare += statistics[i] * statistics[i] / (N * probs[i]);
			}
			ChiSquare -= N;

			if (ChiSquare <= CriticalValue) ChiSquareTest = true;
			else ChiSquareTest = false;
		}
	}
}
