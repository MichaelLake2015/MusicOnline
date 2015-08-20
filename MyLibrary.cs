using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    public class MyClass
    {
        public void In()
        {
            Console.WriteLine("namespace A");
        }
    }

    namespace A1
    {
         public class MyMath
         {
            public void In()
             {
            Console.WriteLine("namespace A1");
             }
         }
    }
}
namespace B
{
    public class MyClass
    {
        public void In()
        {
            Console.WriteLine("namespace B");
        }
    }
}
