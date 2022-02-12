using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSampleExpress {

    public class Program {

        static void Main(string[] args) {

           int[] scores = new int[] { 100, 97, 54, 88, 96 };

            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            foreach (int i in scoreQuery) {
                Console.WriteLine( i + " ");
            }           
        
     

        }
    }
}
