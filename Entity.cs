using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inteferente_ECO
{
    class Entity
    {
        public string Name { get; set; }
        public int Action { get; set; }

        public int X, Y;

        public Entity()
        {
            Action = 0;
        }

    }
}
