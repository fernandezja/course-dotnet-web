using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Entities
{
    public class StarwarsConfig
    {
        public string StarwarsConnectionString { get; set; }

        public string Timestamp { get; set; }

        public StarwarsConfig() {
            Timestamp = DateTime.Now.ToString();
        }
    }
}
