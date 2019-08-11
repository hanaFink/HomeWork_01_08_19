using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_01_08_19
{
    class Link<T>
    {

        public ListItem<T> First { get; protected set; }
        public ListItem<T> Last { get; protected set; }
        public int counter = 0;

        public Link()
        {
            First = null;
            Last = null;
        }
        public void Add(T num)
        {
            ListItem<T> Item = new ListItem<T>();
            Item.Data = num;
            counter++;

            if (Last == null)
            {



                Item.Previous = null;
                Item.Next = null;
                Console.Write("counter is " + counter);
                Console.WriteLine("data is " + Item.Data);
                First = Item;
                Last = Item;
            }
            else
            {
                Item.Previous = Last;
                Last.Next = Item;
                Last = Item;
                Console.Write("counter is " + counter);
                Console.WriteLine("data is " + Item.Data);

            }
        }

        public void GetList()
        {
            ListItem<T> _current = First;


            Console.WriteLine("data is " + _current.Data);


            for (int i = 0; i < counter - 1; i++)
            {
                _current = _current.Next;
                Console.WriteLine("place " + (i + 1) + "date " + _current.Data);


            }
        }
        public void InsertNode(int index, T num)
        {

            ListItem<T> Item = new ListItem<T>();
            ListItem<T> _current = First;
            Item.Data = num;
            counter++;

            if (index == 0)
            {

                Item.Previous = null;
                _current.Next = First;
                First = Item;
                _current.Next.Previous = Item;

            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    _current = _current.Next;
                }
                Item.Previous = _current.Previous;
                Item.Next = _current.Next;
                _current.Previous.Next = Item;
                _current.Next.Previous = Item;


            }
            ListItem<T> _current1 = First;
            for (int i = 0; i < counter - 1; i++)
            {
                _current1 = _current1.Next;
                Console.WriteLine("place " + (i + 1) + "date " + _current1.Data);

            }
        }

        public void RemoveNode(int index)
        {

            ListItem<T> _current = First;

            for (int i = 0; i < index - 1; i++)
            {
                _current = _current.Next;
            }
            _current.Next.Previous = _current.Previous;
            _current.Previous.Next = _current.Next;
            counter--;
            
            Console.WriteLine("place " + index + "date " + _current.Data);

            ListItem<T> _current1 = First;
            for (int i = 0; i < counter - 1; i++)
            {
                _current1 = _current1.Next;
                Console.WriteLine("place " + (i + 1) + "date " + _current1.Data);


            }



        }
    }
}
