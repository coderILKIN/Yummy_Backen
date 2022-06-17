using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yummy_Backen.Models;

namespace Yummy_Backen.ViewModels
{
    public class YummyVM
    {
        public Hero Hero { get; set; }

        public About About { get; set; }

        public List<Choose> Chooses { get; set; }

        public List<Meal> Meals { get; set; }

        public List<TypesofFood> TypesofFoods{ get; set; }
    }
}
