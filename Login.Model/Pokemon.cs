using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string UrlImage { get; set; }
        public int PreviousEvolution { get; set; }
        public int NextEvolution { get; set; }
    }
}
