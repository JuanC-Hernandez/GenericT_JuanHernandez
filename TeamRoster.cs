using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericT_JuanHernandez
{
    internal class TeamRoster<T> where T : Player
    {
        public List<T> _roster = new List<T> ();
    }
}
