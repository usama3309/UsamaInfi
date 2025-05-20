using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class Loopiteration
    {
        public void StartIteration() {

            Random random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                int randomnumber = random.Next(1, 101);

                Console.Write(randomnumber);

                if (randomnumber % 7 == 0) //if modulus is zero
                {
                    Console.Write(" Lucky number");
                }

                Console.WriteLine();

                if (i % 5 == 0)
                {
                    Console.WriteLine("____");
                }
            }

        }
    }
}
