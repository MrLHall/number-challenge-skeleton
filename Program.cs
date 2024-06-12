using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_challenge_skeleton
{
    internal class Program
    {
        static long[] numberbase(long number, int Base) //function called numberbase that take two perameters
        {
            long[] SolvedArray = new long[2];//change this
            SolvedArray[0]= 2; //change this
            SolvedArray[1]= 3; // code to do stuff - change this
            return SolvedArray; //passes out data - keep this
        }
        static void Main(string[] args)
        {
            long[] arrayButBetter= numberbase(2, 3); //create a array to hold the returned array from the funtion 
            Console.WriteLine(arrayButBetter[0]);
        }
    }
}
