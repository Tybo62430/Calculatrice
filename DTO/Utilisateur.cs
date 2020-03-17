using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculatrice.DTO
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Metier { get; set; }
    }
}
