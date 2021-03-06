﻿using Calculatrice.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculatrice.Services.Impl
{
    public class UtilisateurCalculatriceService : UtilisateurService
    {
        private static List<UtilisateurDTO> utilisateurs = new List<UtilisateurDTO>();

        public UtilisateurDTO AjouterUnUtilisateur(UtilisateurDTO user)
        {
            user.Id = utilisateurs.Count();
            utilisateurs.Add(user);
            return user;
        }

        public UtilisateurDTO Modifier(int id, UtilisateurDTO user)
        {
            user.Id = id;
            utilisateurs[id] = user;
            return user;
        }

        public void SupprimerUtilisateur(int id)
        {
            utilisateurs[id] = null;
        }

        public IEnumerable<UtilisateurDTO> TrouverParAge(int age)
        {
            return utilisateurs.Where(u => u.Age == age);
        }

        public IEnumerable<UtilisateurDTO> TrouverParAge(int min, int max)
        {
            return utilisateurs.Where(u => u.Age < max && u.Age > min);
        }

        public IEnumerable<UtilisateurDTO> TrouverParMetier(string metier)
        {
            return utilisateurs.Where(u => u.Metier == metier);
        }

        public IEnumerable<UtilisateurDTO> TrouverParNom(string nom)
        {
            return utilisateurs.Where(u => u.Nom == nom);
        }

        public IEnumerable<UtilisateurDTO> TrouverParPrenom(string prenom)
        {
            return utilisateurs.Where(u => u.Prenom == prenom);
        }

        public IEnumerable<UtilisateurDTO> TrouverTout()
        {
            return utilisateurs.Where(u => u != null);
        }

        public UtilisateurDTO TrouverUnUtilisateur(int id)
        {
            return utilisateurs[id];
        }
    }
}
