using System;
using System.Linq;


namespace _2208InterviewQuestion2
{
    class Program
    {

        public static void braketMatch(string UI)
        {
            //string UI = "(sdsd)(sdsn)(Sd(sds))))))";

            double count = 0;
            int openBracket = 0;
            int closeBracket = 0;
            //seperast the string into an array by each letter

            //Console.WriteLine(UI);

            foreach (char c in UI)
            {
                if (c == '(')
                {
                    count++;
                    openBracket++;
                }
                if (c == ')')
                {
                    count--;
                    closeBracket++;
                }
            }

            Console.WriteLine("The string is {0}", UI);

            if(count != 0)
            {
                Console.WriteLine("there are {0} opening brackets, {1} closing brackets and the number of unmatched brasckets is {2}", openBracket, closeBracket, Math.Abs(count));
            }
            else
            {
                Console.WriteLine("there are {0} opening brackets, {1} closing brackets and 0 unmatched brackets!", openBracket, closeBracket);

            }


           
        }

        static void Main(string[] args)
        {
            braketMatch("(sdsd)(sdsn)(Sd(sds))");
           
        }
    }
}
