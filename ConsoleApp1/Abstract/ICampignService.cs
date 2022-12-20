using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    internal interface ICampignService
    {
        void Add(Campign campaign);
        void Remove(Campign campaign);
        void Update(Campign campaign);
    }
}
