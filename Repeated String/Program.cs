using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeated_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);
        }

        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            long  wholeWordRetationNo = n / s.Length;
            long reminderLetters = n % s.Length;
            if (s.Length == 1)
            {
                wholeWordRetationNo = n;
                reminderLetters = 0;
                return s=="a"? wholeWordRetationNo:0;
            }
            else
            {
               int noOfA = s.Count(l => l=='a');
                string remainingstring = s.Substring(0,(int)reminderLetters).ToString();
                int noOfAsInPartial = remainingstring.Count(l => l == 'a');
                return noOfA!=0?((noOfA * wholeWordRetationNo) + noOfAsInPartial) :0;
            }
        }
    }

    
}
