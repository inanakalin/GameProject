using GameProject;
using GameProject.Concrete;
using GameProject.Entities;

class Program
{
    private static void Main(string[] args)
    {
        GamerManager gamerManager = new GamerManager(new UserValidationManager());
        gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, IdentityNumber = 12345, LastName = "Akalın", Name = "İnan" });
    }
}