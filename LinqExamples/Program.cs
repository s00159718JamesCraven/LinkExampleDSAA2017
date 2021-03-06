﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        public static List<Player> Players;
        public static List<GameScore> GameScores;
        static void Main(string[] args)
        {
            SeedPlayers();
            SeedScores();
        }

        public static void SeedPlayers()
        {
            Players = new List<Player>()
            {
                new Player { FirstName="Billy", SecondName = "Bragg", GamerTag="Wathca", PlayerId =1, XP =200 },
                new Player { FirstName="Martha", SecondName = "Abraham", GamerTag="Muffin", PlayerId =2, XP =500 },
                new Player { FirstName="Fred", SecondName = "Flinstones", GamerTag="YabaYaba", PlayerId =3, XP =300 }

            };
        }

        public static void SeedScores()
        {
            GameScores = new List<GameScore>()
            {
                new GameScore { GamerTag="Watcha", GameName="World of Goo", Score=200, scoredAt = DateTime.Parse("25/10/2016")  },
                new GameScore { GamerTag="Watcha", GameName="World of Goo", Score=1500, scoredAt = DateTime.Parse("29/10/2016")  },
                new GameScore { GamerTag="Muffin", GameName="World of Goo", Score=1200, scoredAt = DateTime.Parse("13/09/2016")  },
                new GameScore { GamerTag="Watcha", GameName="Witcher", Score=500, scoredAt = DateTime.Parse("09/09/2016")  },
            };

        }

    }
}
