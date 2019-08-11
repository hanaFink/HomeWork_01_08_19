using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_01_08_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Link <int> num = new Link<int>() ;
            for (int i = 0; i < 10; i++)
            {
                num.Add(i);

            }
            num.GetList();
            //num.InsertNode(5, 34567);
            num.RemoveNode(5);
        }
    }
}