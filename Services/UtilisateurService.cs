using Calculatrice.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculatrice.Services
{
    public interface UtilisateurService
    {
        public IEnumerable<UtilisateurDTO> TrouverTout();
        public UtilisateurDTO TrouverUnUtilisateur(int id);
        public UtilisateurDTO AjouterUnUtilisateur(UtilisateurDTO utilisateur);
        public void SupprimerUtilisateur(int id);
        public UtilisateurDTO Modifier(int id, UtilisateurDTO nouveau);
        public IEnumerable<UtilisateurDTO> TrouverParNom(string nom);
        public IEnumerable<UtilisateurDTO> TrouverParPrenom(string prenom);
        public IEnumerable<UtilisateurDTO> TrouverParAge(int age);
        public IEnumerable<UtilisateurDTO> TrouverParAge(int min, int max);
        public IEnumerable<UtilisateurDTO> TrouverParMetier(string metier);
    }
}
