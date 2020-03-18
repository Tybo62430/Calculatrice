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
        
        // 1 Attribut pour sstocker l'injection
        private UtilisateurService utilisateurService;

        // 2 je creer un constructeur et je demande en params le service
        public OperationCalculatriceService(/*je demande ici>*/UtilisateurService service)
        {
            this.utilisateurService = service;
        }
        public OperationDTO AjouterUneOperation(OperationDTO op)
        {
            op.Id = operations.Count();
            op.Auteur = utilisateurService.TrouverUnUtilisateur(op.Auteur.Id);
            operations.Add(op);
            return op;
        }

        public OperationDTO Modifier(int id, OperationDTO op)
        {
            op.Id = id;
            op.Auteur = utilisateurService.TrouverUnUtilisateur(op.Auteur.Id);
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
