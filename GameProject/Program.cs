namespace GameProject;
class Program
{
    static void Main(string[] args)
    {
        List<Gamers> gamers = new List<Gamers>();

        Gamers gamer1 = new Gamers();
        gamer1.Id = 1;
        gamer1.FirstName = "Eyyüp";
        gamer1.LastName = "Erdaoğan";
        gamer1.Date = "1998";
        gamer1.Indentity = "12345";

        Gamers gamer2 = new Gamers();
        gamer2.Id = 2;
        gamer2.FirstName = "Engin";
        gamer2.LastName = "Demiroğ";
        gamer2.Date = "1897";
        gamer2.Indentity = "38202";

        Gamers gamer3 = new Gamers();
        gamer3.Id = 3;
        gamer3.FirstName = "Hilal";
        gamer3.LastName = "Güneş";
        gamer3.Date = "2000";
        gamer3.Indentity = "3792";

        Gamers gamer4 = new Gamers();
        gamer4.Id = 4;
        gamer4.FirstName = "Hasan";
        gamer4.LastName = "Kaş";
        gamer4.Date = "2000";
        gamer4.Indentity = "3792";




        Console.WriteLine("------------------------------------");

        GameManager gameManager = new GameManager();
        gameManager.Add(gamers,gamer1);
        gameManager.Add(gamers, gamer2);
        gameManager.Add(gamers, gamer4);
        Console.WriteLine("------------------------------------");

       // gameManager.Delete(gamers, gamer2);
        gameManager.GamersList(gamers);
        Console.WriteLine("------------------------------------");

        gameManager.Update(gamers,gamer2, gamer3);
        Console.WriteLine("------------------------------------");

        gameManager.GamersList(gamers);
        Console.WriteLine("------------------------------------");
        UserVerificationManager userVerification = new UserVerificationManager();
        userVerification.Verification(gamers, gamer2);

        Console.Read();
    }
}

