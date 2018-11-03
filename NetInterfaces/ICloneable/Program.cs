
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableI
{
    class Card : ICloneable
    { 
        public string Name { get; set; }
        public int Sum { get; set; }

        public object Clone()
        {
            return new Card
            {
                Name = this.Name,
                Sum = this.Sum
            };

        }

        public override string ToString() => $"Card : {Name}  {Sum}";
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Card belCard = new Card{ Name = "BelCard", Sum = 100 };
            Console.WriteLine(belCard);
            Card bankCard = (Card)belCard.Clone();
            Console.WriteLine(bankCard);


        }
    }
}
