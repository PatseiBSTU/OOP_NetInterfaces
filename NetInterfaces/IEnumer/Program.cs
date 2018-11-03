using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumer
{
    public class Shop : IEnumerable
    {     // опущены элементы  
        private string[] _items = new string[0];
        public int ItemsCount         {             get => _items.Length;  }

        public void AddItem(string item)
        {
            Array.Resize(ref _items, ItemsCount + 1);
            _items[ItemsCount - 1] = item;
        }

        public string GetItem(int index) => _items[index];
        
    
    private class ShopEnumerator : IEnumerator
        {
           
        private readonly string[] _data; // локальная копия данных  
            private int _position = -1;      // текущая позиция в наборе 

            public ShopEnumerator(string[] values)
            {
                _data = new string[values.Length];
                Array.Copy(values, _data, values.Length);
            }

            public object Current { get { return _data[_position]; } }
            public bool MoveNext()
            {
                if (_position < _data.Length - 1)
                {
                    _position++; return true;
                }
                return false;
            }
            public void Reset() { _position = -1; }
        }
        public IEnumerator GetEnumerator()
        {
            return new ShopEnumerator(_items);
        }
    }

    class Program
    {
    static void Main(string[] args)
    {

        var shop = new Shop();
        shop.AddItem("computer");
        shop.AddItem("monitor");
        shop.AddItem("mouse");

        foreach (string s in shop)
            Console.WriteLine(s);

    }

}
}
