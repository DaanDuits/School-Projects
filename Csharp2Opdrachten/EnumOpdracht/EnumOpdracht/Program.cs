using System;

namespace EnumOpdracht
{
    class Program
    {
        internal enum Colors
        {
            Red,
            Green,
            Yellow,
            Blue
        }
        static void Main(string[] args)
        {
            Colors[] colors = Enum.GetValues(typeof (Colors)) as Colors[];
            foreach(Colors color in colors)
            {
                Console.WriteLine(color);
            }
            Console.ReadLine();
            string value = Console.ReadLine();

            Colors parsedColor = (Colors)Enum.Parse(typeof (Colors), value);
        }
    }
}
