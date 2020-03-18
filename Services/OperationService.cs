using Calculatrice.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculatrice.Services
{
    interface OperationService
    {
        public IEnumerable<OperationDTO> TrouverTout();       
        public OperationDTO AjouterUneOperation(OperationDTO operation);
        public IEnumerable<OperationDTO> TrouverUneOperation(int id);
        public IEnumerable<OperationDTO> TrouverParNom(string nom);
        public IEnumerable<OperationDTO> TrouverParValeur(string valeur);
        public OperationDTO Modifier(int id, OperationDTO nouveau);
        public void SupprimerOperation(int id);



    }
}
