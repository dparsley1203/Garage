using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero { MainColor = "Blue", MaximumOccupancy = 2 };
            Tesla modelS = new Tesla { MainColor = "Silver", MaximumOccupancy = 5 };
            Cessna mx410 = new Cessna { MainColor = "Orange", MaximumOccupancy = 5 };
            Ram truck = new Ram { MainColor = "Potato", MaximumOccupancy = 6 };

            //Another way of adding color
            // fxs.MainColor = "Blue";

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine();
            mx410.Drive();
            mx410.Turn("Around");
            mx410.Stop();
            Console.WriteLine();
            truck.Drive();
            truck.Turn("a U'ie");
            truck.Stop();


        }
    }
}
