using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myClassType = typeof(MyClass);

            // Имя класса
            Console.WriteLine($"Имя класса: {myClassType.Name}");

            // Конструкторы
            ConstructorInfo[] constructors = myClassType.GetConstructors();
            Console.WriteLine("\nКонструкторы:");
            foreach (var constructor in constructors)
            {
                Console.WriteLine($"Модификатор доступа: {constructor.Attributes}");
                Console.WriteLine($"Параметры: {string.Join(", ", constructor.GetParameters().Select(p => $"{p.ParameterType} {p.Name}"))}");
            }

            // Поля и свойства
            Console.WriteLine("\nПоля и свойства:");
            foreach (var property in myClassType.GetProperties())
            {
                Console.WriteLine($"Модификатор доступа: {property.GetAccessors().First().Attributes}");
                Console.WriteLine($"Тип: {property.PropertyType.Name}");
                Console.WriteLine($"Имя: {property.Name}");
            }

            // Методы
            Console.WriteLine("\nМетоды:");
            foreach (var method in myClassType.GetMethods())
            {
                Console.WriteLine($"Модификатор доступа: {method.Attributes}");
                Console.WriteLine($"Тип возвращаемого значения: {method.ReturnType.Name}");
                Console.WriteLine($"Имя: {method.Name}");
            }
            Console.ReadKey();
        }
    }
}
