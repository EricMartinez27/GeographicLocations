using System;
using libraryProject;

namespace consoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var locations = Fetching.GetDataFromHttp().GetAwaiter().GetResult();

            foreach(var location in locations)
            {
                Console.WriteLine($"{location.name}: [{location.position[0]}, {location.position[1]}]");
            }

        }
    }
}
