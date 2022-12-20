using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    internal class GamerManager : IGamerService
    {
        IUserValidation _userValidation;

        public GamerManager(IUserValidation userValidation)
        {                                       //bu constructor ben gamer manager içinde bir validation
            _userValidation = userValidation;   // kullanacağım demek 
        }

        public void Add(Gamer gamer)

        {
            if (_userValidation.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt alındı");
            }
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(" Kayıt silindi");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }


    }
}
