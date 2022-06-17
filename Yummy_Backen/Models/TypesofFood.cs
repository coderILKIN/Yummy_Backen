using System.Collections.Generic;

namespace Yummy_Backen.Models
{
    public class TypesofFood
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string MenuLink { get; set; }

        public List<Meal> Meals { get; set; }
    }
}
