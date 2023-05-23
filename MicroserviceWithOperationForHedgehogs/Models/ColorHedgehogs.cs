namespace MicroserviceWithOperationForHedgehogs.Models
{
    public static class ColorHedgehogs
    {
        private static Dictionary<int, string> Colors = new Dictionary<int, string>
        {
            {0, "red" },
            {1,"green" },
            {2, "blue" }
        };

        public static string GetLolor(int idColor)
        {
            return Colors[idColor];
        }
    }
}
