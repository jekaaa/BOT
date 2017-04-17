using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison
{
    class Boss
    {
        public string name;
        public string hp;
        public string id;
        public Boss(string name, int hp, int id)
        {
            this.name = name;
            this.hp = hp.ToString();
            this.id = id.ToString();
        }

    }
}
