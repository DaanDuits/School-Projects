using System;
using System.Collections.Generic;

namespace ListOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> birds = new List<string>();
            birds.Add("uil");
            birds.Add("kraai");
            birds.Add("hond");
            birds.Add("papegaai");

            foreach(string bird in birds)
            {
                Console.WriteLine(bird);
            }

            List<string> birds2 = new List<string>();
            birds2.Add("meeuw");
            birds2.Add("duif");
            
            Console.WriteLine(" ");
            foreach (string bird in birds2)
            {
                Console.WriteLine(bird);
            }

            birds.AddRange(birds2);

            Console.WriteLine(" ");
            foreach (string bird in birds)
            {
                Console.WriteLine(bird);
            }

            birds.RemoveAt(birds.IndexOf("hond"));
            if(birds.Contains("kip"))
            {
                birds.RemoveAt(birds.IndexOf("kip"));
            }

            Console.WriteLine(" ");
            foreach (string bird in birds)
            {
                Console.WriteLine(bird);
            }
            Console.ReadLine();
        }
    }
}
