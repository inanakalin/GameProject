using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    internal interface IGameService
    {
        public void Sale(Game game, Gamer gamer, Campign campign);

        void Discount(Game game, Gamer gamer, Campign campaign);

    }
}
