using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    public class PokemonByUser
    {
        public int IdPokemon { get; set; }
        public string UserName { get; set; }
        public int CpPokemon { get; set; }
        public int HpPokemon { get; set; }
        public int AtkPokemon { get; set; }
        public int DefPokemon { get; set; }
        public int StaPokemon { get; set; }
        public Int64 DustPrice { get; set; }
        public bool PoweredUp { get; set; }
        public int NroPokemon { get; set; }

    }
}
