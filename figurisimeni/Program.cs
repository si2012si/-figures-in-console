using System;

namespace figurisimeni
{
    class Program
    {
        static void Main(string[] args)
        {   string Name;
            int countsimv; // колличество символов
            Sortirovka sortirovka = new Sortirovka(); // объявляю класс
            Console.WriteLine("Введите что-нибудь");
           Name = Console.ReadLine();
           
            Console.WriteLine("Сколько символов нужно?");
            Console.WriteLine("Если вы хотите превратить в рисунок слово впишите 1");
           countsimv =Convert.ToInt32(Console.ReadLine());
          
           
            int chois;
            Console.WriteLine("Какой Узор предпочитаете?");
            Console.WriteLine("1. Полупирамида");
            Console.WriteLine("2. Пирамида");
            Console.WriteLine("3. Ромб");
            Console.WriteLine("4. Ромб Инверсия");
            Console.WriteLine("5. ");
            Console.WriteLine("6. ");
            chois =Convert.ToInt32(Console.ReadLine()); 
            Console.Clear();
            
            
            
            switch (chois)
            
            {
                case 1:
                    if (countsimv ==1)
                        sortirovka.LeftPiramid(Name);
                    else
                        sortirovka.LeftPiramid(new string(Convert.ToChar(Name), countsimv));

                    Console.ReadLine();
                break;

                case 2:
                    if (countsimv == 1)
                        sortirovka.Piramid(Name);
                    else
                        sortirovka.Piramid(new string(Convert.ToChar(Name), countsimv));
                    Console.ReadLine();
                    break;
                case 3:
                    if (countsimv == 1)
                        sortirovka.Romb(Name);
                    else
                        sortirovka.Romb(new string(Convert.ToChar(Name), countsimv));
                    break;
                case 4:
                    if (countsimv == 1)
                        sortirovka.RombInvers(Name);
                    else
                        sortirovka.RombInvers(new string(Convert.ToChar(Name), countsimv));
                        break;
                default:
                    sortirovka.LeftPiramid(Name);
                    Console.ReadLine();
                    break;
            }
            sortirovka.LeftPiramid(Name);
        }
    }
}
