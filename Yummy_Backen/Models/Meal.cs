namespace Yummy_Backen.Models
{
    public class Meal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string About { get; set; }

        public double Price { get; set; }

        public int TypesofFoodId { get; set; }

        public TypesofFood TypesofFood { get; set; }

    }
}
