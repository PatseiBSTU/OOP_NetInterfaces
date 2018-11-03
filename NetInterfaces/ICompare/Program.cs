using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICompare
{
    class Card : IComparable<Card>
    {
        public string Name { get; set; }
        public int Sum { get; set; }
        public int CompareTo(Card p)
        {
            return this.Name.CompareTo(p.Name);
        }
    }

    class SumComparer : IComparer<Card>
    {
        public int Compare(Card x, Card y)

        {
            if (x.Sum > y.Sum)
                return 1;
            else if (x.Sum < y.Sum)
                return -1;
            else
                return 0;
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                Card visa = new Card { Name = "VISA", Sum = 12 };
                Card mastercard = new Card { Name = "Mastercard", Sum = 230 };

                Card[] allMy = new Card[] { visa, mastercard };
                Console.WriteLine("Sort by Name: ");
                Array.Sort(allMy);

                foreach (Card p in allMy)
                {
                    Console.WriteLine($"{p.Name}---{p.Sum}");
                }
                 Console.WriteLine("Sort by Sum: ");
                 Array.Sort(allMy, new SumComparer());

                foreach (Card p in allMy)
                {
                    Console.WriteLine($"{p.Name}---{p.Sum}");
                }

            }
        }
    } 
