using System;

namespace GameProject
{
    public class GameManager : IGameService
    {
         
        public void Add(List<Gamers> gamers, Gamers gamer)
        {
        gamers.Add(gamer);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncu eklendi..");
        }

        public void Delete(List<Gamers> gamers, Gamers gamer)
        {
            gamers.Remove(gamer);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncu silindi..");

        }

        public void GamersList(List<Gamers> gamers)
        {
            foreach (var game in gamers)
            {
                Console.WriteLine(game.FirstName);
            }
        }

        public void Update(List<Gamers> gamers,Gamers gamer1,Gamers gamer2)
        {
            Console.WriteLine(gamer1.FirstName + " " + gamer1.LastName +" oyuncusu "+ gamer2.FirstName + " " + gamer2.LastName+ " oyuncu ile güncelendi..");
            Console.WriteLine(gamer1.Id + " " + gamer2.Id);
            gamers[gamer1.Id-1] = gamer2;
        }
    }
}

