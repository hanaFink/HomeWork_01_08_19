using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_01_08_19
{
    class Link <T>
    {
        
        public ListItem <T> First {get; protected set;}
        public ListItem<T> Last { get; protected set; }
        public int counter { get; protected set; }
          
        public  Link()
        {
            First = null;
            Last = null;
        }
        public void Add (T num)
        {

            
            if (Last==null)
            {
                ListItem<T> Item = new ListItem<T>();
                Item.Data = num;
                Last =Item ;
                First = Item;
                counter++;
                Item.Previous = num;
                Item.Next = num;
            }
            else
            {
                
                ListItem<T> Item = new ListItem<T>();
                Item.Data = num;
                Item.Previous = num;
                Last = Item;
                counter++;
            }
            

            
                }
    }
}
