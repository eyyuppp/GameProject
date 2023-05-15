using System;

namespace GameProject
{
    public class UserVerificationManager : IUserVerification
    {
        public bool Verification(List<Gamers> gamers, Gamers gamer)
        {
            foreach (var gamer1 in gamers)
            {
                if (gamer1==gamer)
                {
                    Console.WriteLine(gamer.FirstName + " oyuncusu doğrulandı..");
                    return true;
                }
            }
            Console.WriteLine(gamer.FirstName + " oyuncusu doğrulanmadı..");
            return false;
        }
    }
}

