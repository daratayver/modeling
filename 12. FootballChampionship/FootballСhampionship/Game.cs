using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballСhampionship
{
	class Game
	{
		public Game()
		{
			Teams = new string[32]
			{
				"Балтика",
				"Локомотив",
				"Луки-Энергия",
				"Енисей",
				"Торпедо",
				"Динамо",
				"Химки",
				"Рубин",
				"Авангард К",
				"Краснодар",
				"Тамбов",
				"Кр.Советов",
				"Волгарь",
				"Зенит",
				"Сызрань-2003",
				"Ростов",
				"Черноморец",
				"Спартак",
				"Чайка",
				"Анжи",
				"Н.Новгород",
				"Уфа",
				"Нефтехимик",
				"Урал",
				"Тюмень",
				"ЦСК",
				"Динамо Брл",
				"Оренбург",
				"Сахалин",
				"Арсенал",
				"СКА-Хабаровск",
				"Ахмат"
			};

			Matches = new List<Match>();
		}

		public IList<Match> Matches { get; private set; }
		public string[] Teams { get; private set; }

		public void GoChampionship()
		{
			for (int i = 0; i < 32; i+=2)
			{
				Matches.Add(new Match(Teams[i], Teams[i + 1]));
			}

			for (int i = 0; i < 16; i+=2)
			{
				Matches.Add(new Match(Matches[i].Winner, Matches[i + 1].Winner));
			}

			for (int i = 16; i < 24; i += 2)
			{
				Matches.Add(new Match(Matches[i].Winner, Matches[i + 1].Winner));
			}

			for (int i = 24; i < 28; i += 2)
			{
				Matches.Add(new Match(Matches[i].Winner, Matches[i + 1].Winner));
			}

			for (int i = 28; i < 30; i += 2)
			{
				Matches.Add(new Match(Matches[i].Winner, Matches[i + 1].Winner));
			}
		}


	}
}
