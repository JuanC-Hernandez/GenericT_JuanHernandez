using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericT_JuanHernandez
{
    internal abstract class Player
    {
        string _name;
        string _number;

        public override string ToString()
        {
            return $"{_name} - {_number}";
        }
    }
}
