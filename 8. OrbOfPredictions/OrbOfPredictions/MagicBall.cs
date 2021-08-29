using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbOfPredictions
{
	public class MagicBall
	{
		sealed class Answer
		{
			public Answer(string text, double probability)
			{
				Text = text;
				Probability = probability;
			}
			public string Text { get; }
			public double Probability { get; }
		}

		readonly Random random = new Random();

		readonly Answer[] answers = new Answer[20]
		{
			new Answer("Very doubtful", 0.04),
			new Answer("Outlook not so good", 0.05),
			new Answer("My sources say no", 0.04),
			new Answer("My reply is no", 0.06),
			new Answer("Don’t count on it", 0.05),
			new Answer("Concentrate and ask again", 0.07),
			new Answer("Cannot predict now", 0.05),
			new Answer("Better not tell you now", 0.04),
			new Answer("Ask again later", 0.06),
			new Answer("Reply hazy, try again", 0.04),
			new Answer("Yes", 0.04),
			new Answer("Signs point to yes", 0.05),
			new Answer("Outlook good", 0.05),
			new Answer("Most likely", 0.04),
			new Answer("As I see it, yes", 0.06),
			new Answer("You may rely on it", 0.03),
			new Answer("Yes — definitely", 0.07),
			new Answer("Without a doubt", 0.04),
			new Answer("It is decidedly so", 0.06),
			new Answer("It is certain", 0.06)
		};

		public string GetAnswer()
		{
			var alpha = random.NextDouble();
			var answer = "";

			foreach (var p in answers)
			{
				alpha -= p.Probability;
				
				if (alpha <= 0)
				{
					answer = p.Text;
					break;
				}
			}

			return answer;
		}

		public string GetYesNo(double probability)
		{
			var alpha = random.NextDouble();

			if (alpha < probability)
			{
				return "YES!";
			}
			else
			{
				return "NO!";
			}
		}
	}
}
