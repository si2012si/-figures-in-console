using System;
using System.Collections.Generic;
using System.Text;

namespace figurisimeni
{
    class Sortirovka
    {
        
        public void LeftPiramid(string Name)
        {
            int count = 1;
            int probel;
            int longN = Name.Length;
            while (count < longN)
            {
                count++;
                Console.WriteLine(Name.Substring(0, count));
            }
            return;
        }
        public void Piramid(string Name)
        {
            int count = 1;
            int probel;
            int longN = Name.Length;
            {
                probel = longN;

                for (int i = 0; i < longN; i++)
                {
                    Console.WriteLine(new string(' ', probel) + Name.Substring(0, count) + Name.Substring(0, count) + new string(' ', probel));
                    count++;
                    probel--;
                }
            }
            return;
        }
        public void Romb(string Name)
        {
            int count = 1;
            int probel;
            int longN = Name.Length;
            {
                probel = longN;

                for (int i = 0; i <= longN; i++)
                {
                    Console.WriteLine(new string(' ', probel) + Name.Substring(0, count) + Name.Substring(0, count) + new string(' ', probel));
                    count++;
                    probel--;
                    if (i == longN - 1)
                    {
                        count--;
                        probel++;
                        for (int j = 0; j < longN; j++)
                        {
                            Console.WriteLine(new string(' ', probel) + Name.Substring(0, count) + Name.Substring(0, count) + new string(' ', probel));
                            count--;
                            probel++;
                        };
                    }
                }


            }
            return;
        }
        public void RombInvers(string Name)
        {
            int count = 1;
            int probel;
            int longN = Name.Length;
            {
                probel = 1;
                count = longN-1;
                for (int i = 1; i <= longN; i++)
                {
                    Console.WriteLine(Name.Substring(0, count) + new string(' ', probel*2) + Name.Substring(0, count));
                    count--;

                    probel++;
                    if (i == longN - 1)
                    {
                        
                        for (int j = 0; j < longN; j++)
                        {
                            Console.WriteLine(Name.Substring(0, count) + new string(' ', probel*2) + Name.Substring(0, count));
                            count++;
                            probel--;
                        };
                    }
                }
                return;
            }
            


        }
        public void Elochka(string Name)
        {
           
            int count = 2;
            int elovha = 3;
            int probel;
            int longN = Name.Length;
            {
                probel = longN;

                for (int i = 0; i < longN; i++)
                {
                    for (int e = elovha -3; e<i; e++)
                               Console.WriteLine( Name.Substring(0, e) + Name.Substring(0, e) + new string(' ', probel) + Name.Substring(0, e) + Name.Substring(0, e) + new string(' ', probel));
                    count++;
                    probel--;
   

                }
            }
            Console.ReadKey();
            return;
        }
    }
}
