using System; 

namespace Dungeoncrawler

{

   internal class Program

   {

      static void Main(string[] args)

      {

         Console.WriteLine("Hello, You are in a dungeon");
         Console.WriteLine("It is dark, but you can see 2 pathways");
         Console.WriteLine("chose 1 or 2");
         string pressed = Console.ReadKey().ToString();
         if (pressed != "1")
    {
         Console.WriteLine("You died");
    }
        else
        {
             Console.WriteLine("You found the sex dungeon");
        }


      }

   }

}