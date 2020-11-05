using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Delete
    {
        public int TestValue { get; set; } = 5;

        public void DisplayValue()
        {
            Console.WriteLine(TestValue);
        }

        public static void DisplayValueStatic()
        {
            Delete delete = new Delete();
            Console.WriteLine(delete.TestValue);

            int i = Int32.Parse(Console.ReadLine());
        }
    }
}
