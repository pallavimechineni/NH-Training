using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phylibrary
{
    public class Physics
    {
        public int Velocity(int u, int a, int t)
        {
            return u + a * t;
        }

    }
}
