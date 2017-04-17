using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison
{
    public class Authentification
    {
        public string key;
        public string id;
        public Authentification(string auth_key,string id)
        {
            this.key = auth_key;
            this.id = id;
        }


    }
}
