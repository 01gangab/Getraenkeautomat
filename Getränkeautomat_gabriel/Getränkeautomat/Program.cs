using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Getränkeautomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Automat automat = new Automat(
                new string[] { "cola", "fanta", "sprite", "hugo", "bier", "hirsch", "rox", "hefe"}, 
                new double[] { 2, 2, 2, 4, 2, 3, 2, 4 }, 
                new int[] { 5, 3, 5, 2, 3, 6, 4, 2 });


           
            


        }
    }
}
