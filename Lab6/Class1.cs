using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Class1
    {
        [DisplayName("номер"), Category("Параметры метода")]
        public double Number { get; set; }
        [DisplayName("Название"), Category("Параметры метода2")]
        public string Name { get; set; }
    }
}
