using Calculatrice.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculatrice.Services.Impl
{
    public class OperationCalculatriceService : OperationService
    {
        private static List<OperationDTO> operations = new List<OperationDTO>();
        private static UtilisateurService utilisateurService = new UtilisateurCalculatriceService();
        public OperationDTO AjouterUneOperation(OperationDTO op)
        {
            op.Id = operations.Count();
            op.Auteur = utilisateurService.TrouverUnUtilisateur(op.AuteurId);
            operations.Add(op);
            return op;
        }

        public OperationDTO Modifier(int id, OperationDTO op)
        {
            op.Id = id;
            op.Auteur = utilisateurService.TrouverUnUtilisateur(op.AuteurId);
            operations[id] = op;
            return op;
        }

        public void SupprimerOperation(int id)
        {
            operations[id] = null;
        }

        public IEnumerable<OperationDTO> TrouverParNom(string nom)
        {
            return operations.Where(u => u.Nom == nom);
        }

        public IEnumerable<OperationDTO> TrouverParValeur(string valeur)
        {
            return operations.Where(u => u.Valeur == valeur);
        }

        public IEnumerable<OperationDTO> TrouverTout()
        {
            return operations.Where(u => u != null);
        }

        public IEnumerable<OperationDTO> TrouverUneOperation(int id)
        {
            return operations.Where(u => u.Id == id);
        }
    }
}
