using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.Name == "İnan" && gamer.LastName == "Akalın"
                && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else { return false; }
        }
    }
}
