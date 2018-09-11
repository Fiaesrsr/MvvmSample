using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ui.TestConsole
{
    class TestClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public string SomeProperty { get; set; }

        [DependsOn(nameof(SomeProperty))]
        public int LengthOfSomeProperty => SomeProperty.Length;

        //[DoNotNotify]
        public bool SomeSectretProperty { get; set; }


    }
    
}
