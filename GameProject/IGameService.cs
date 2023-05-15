using System;
namespace GameProject
{
	public interface IGameService
	{
		void Add(List<Gamers> gamers,Gamers gamer);
        void Update(List<Gamers> gamers,Gamers gamer1, Gamers gamer2);
        void Delete(List<Gamers> gamers,Gamers gamer);
        void GamersList(List<Gamers> gamers);
    }
}

