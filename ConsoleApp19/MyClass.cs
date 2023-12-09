using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class MyClass
    {
        // Публичное свойство
        public int PublicProperty { get; set; }

        // Приватное свойство
        private string PrivateProperty { get; set; }

        // Конструктор без параметров
        public MyClass()
        {
        }

        // Конструктор с параметрами
        private MyClass(int value)
        {
            PublicProperty = value;
        }

        // Публичный метод
        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod");
        }

        // Приватный метод
        private void PrivateMethod()
        {
            Console.WriteLine("PrivateMethod");
        }
    }
}
