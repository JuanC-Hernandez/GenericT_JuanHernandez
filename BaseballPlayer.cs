using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericT_JuanHernandez
{
    internal class BaseballPlayer : Player
    {
        private string atBat;

        public string AtBat { get => atBat; set => atBat = value; }
    }
}
