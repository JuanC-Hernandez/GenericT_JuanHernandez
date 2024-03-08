using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericT_JuanHernandez
{
    internal class FootballPlayer : Player
    {
        private string interceptions;

        public string Interceptions { get => interceptions; set => interceptions = value; }
    }
}
