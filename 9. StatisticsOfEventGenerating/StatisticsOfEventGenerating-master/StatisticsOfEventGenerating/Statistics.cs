using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsOfEventGenerating
{
	class Statistics
	{
		readonly Random random = new Random();
		public decimal[] GetStatistics(decimal[] probs, int size, int number)
		{
			decimal[] statistics = new decimal[size];
			for (int i = 0; i < number; i++)
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
				statistics[i] = statistics[i] / number;
			}

			return statistics;
		}
	}
}
