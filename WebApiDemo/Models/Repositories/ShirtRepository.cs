namespace WebApiDemo.Models.Repositories
{
    public static class ShirtRepository
    {
        private static List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt{ShirtId = 1, Brand="My Brand", Colour="Blue", Gender="Male", Price=30, Size=10},
            new Shirt{ShirtId = 2, Brand="My Brand", Colour="Black", Gender="Male", Price=35, Size=12},
            new Shirt{ShirtId = 3, Brand="Your Brand", Colour="Pink", Gender="Female", Price=28, Size=8},
            new Shirt{ShirtId = 4, Brand="Your Brand", Colour="Yellow", Gender="Female", Price=30, Size=9},
        };

        public static List<Shirt> GetShirts()
        {
            return shirts;
        }
        public static bool ShirtExists(int id)
        {
            return shirts.Any(x => x.ShirtId == id);
        }

        public static Shirt? GetShirtByID(int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id);
        }
    }
}
