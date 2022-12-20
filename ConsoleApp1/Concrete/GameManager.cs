using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    internal class GameManager : IGameService
    {
        public void Discount(Game game, Gamer gamer, Campign campaign)
        {
            Console.WriteLine("yapılan indirim oranı = {0}" , campaign.CampaingRatio);
        }

        public void Sale(Game game, Gamer gamer, Campign campign)
        {
            Console.WriteLine("{0} oyunu {1} indirimle {2} kullanıcısına satıldı ", game.GameName,campign.CampaingRatio,gamer.LastName);
        }
    }
}
