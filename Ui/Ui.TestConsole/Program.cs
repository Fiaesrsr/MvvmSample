using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ui.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPropertyChanged();
            Console.ReadKey();
        }
        private static void TestPropertyChanged()
        {
            var test = new TestClass();
            test.PropertyChanged += (s, e) =>
            {
                Console.WriteLine($"Property {e.PropertyName} has changed.");
            };
            test.SomeProperty = "Hello World"; // expect to fire the event
            test.SomeProperty = "Hello World"; // should not fired cause property wasn't changed
            test.SomeProperty = "Hallo Welt"; // should fired again
            test.SomeProperty = "Funktioniert!"; // should fired again

            test.SomeSectretProperty = true;
            test.SomeSectretProperty = false;
        }
    }
}
