using System;
using System.Collections.Generic;

namespace lab1
{
    public class GameAccount
    {
        public string UserName { get; set; }
        public int GamesCount { get; set; }
    public int CurrentRating
         {
           get
             {
                 int currentRating = 11;
                 foreach (var item in stats)
                 {
                     currentRating += item.RatingGame;
                 }

                 return currentRating;
             }
         }
        public List<Game> stats = new List<Game>();
        public GameAccount(string name)
        {
            UserName = name;
            GamesCount = 0;

        }

        public void WinGame(GameAccount opponentName, int rating)
        {
            if(rating >= CurrentRating)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Поточний рейтинг гравця має бути більший за рейтинг гри !");
            }
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Гра на мінусовий або рівний нулю рейтинг неможлива!");
            }
            this.GamesCount++;
            var Game = new Game(opponentName.UserName, 1, rating, GamesCount);
            stats.Add(Game);


        }
        public void LoseGame(GameAccount opponentName, int rating)
        {
            if (rating >= CurrentRating)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Поточний рейтинг гравця має бути більший за рейтинг гри !");
            }
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Гра на мінусовий або рівний нулю рейтинг неможлива!");
            }
       
            this.GamesCount++;
            var Game = new Game(opponentName.UserName, 0, -rating, GamesCount);
            stats.Add(Game);

        }

   public string GetStats()
        {
         var report = new System.Text.StringBuilder();

            int currentRating = 11;
            report.AppendLine("Opponetname :\tRating :\tResult :\tID :");
            foreach (var item in stats)
            {
                currentRating += item.RatingGame;
                 report.AppendLine($"{item.Opponetname}\t\t{currentRating}\t\t{item.Result}\t\t{item.ID}");
            }

         return report.ToString();      
    }
    }
}
