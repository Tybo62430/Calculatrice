using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculatrice.DTO;
using Calculatrice.Services;
using Calculatrice.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculatrice.Controllers
{
    [Route("api/utilisateur")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        //private static UtilisateurService service = new UtilisateurCalculatriceService();
        private UtilisateurService service;

        public UtilisateurController(UtilisateurService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("")]
        public UtilisateurDTO AjouterUnUtilisateur([FromBody] UtilisateurDTO value)
        {
            return this.service.AjouterUnUtilisateur(value);
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<UtilisateurDTO> TrouverTout()
        {
            return this.service.TrouverTout();
        }

        [HttpGet]
        [Route("{id}")]
        public UtilisateurDTO TrouverUnUtilisateur(int id)
        {
            return this.service.TrouverUnUtilisateur(id);
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public IEnumerable<UtilisateurDTO> TrouverParNom(string nom)
        {
            return this.service.TrouverParNom(nom);
        }

        [Route("prenom/{prenom}")]
        public IEnumerable<UtilisateurDTO> TrouverParPrenom(string prenom)
        {
            return this.service.TrouverParPrenom(prenom);
        }

        [Route("age/{age}")]
        public IEnumerable<UtilisateurDTO> TrouverParAge(int age)
        {
            return this.service.TrouverParAge(age);
        }

        [Route("metier/{metier}")]
        public IEnumerable<UtilisateurDTO> TrouverParMetier(string metier)
        {
            return this.service.TrouverParMetier(metier);
        }

        [Route("age")]
        public IEnumerable<UtilisateurDTO> TrouverParAge(int min, int max = 1000)
        {
            return this.service.TrouverParAge(min, max);
        }

        [HttpPut]
        [Route("{id}")]
        public UtilisateurDTO Modifier(int id, [FromBody] UtilisateurDTO value)
        {
            return this.service.Modifier(id, value);
        }

        [HttpDelete]
        [Route("{id}")]
        public void SupprimerUtilisateur(int id)
        {
            this.service.SupprimerUtilisateur(id);
        }
    }
}