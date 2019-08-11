using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HomeWork_01_08_19
{
    class ListItem <T>
    {
        public T Data { get;set;}
        public ListItem<T> Next { get; set; }
        public ListItem<T> Previous { get;set;}

       
    }
}
