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
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private static UtilisateurService service = new UtilisateurCalculatriceService();

        [HttpPost]
        [Route("")]
        public UtilisateurDTO AjouterUnUtilisateur([FromBody] UtilisateurDTO value)
        {
            return service.AjouterUnUtilisateur(value);
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<UtilisateurDTO> TrouverTout()
        {
            return service.TrouverTout();
        }

        [HttpGet]
        [Route("{id}")]
        public UtilisateurDTO TrouverUnUtilisateur(int id)
        {
            return service.TrouverUnUtilisateur(id);
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public IEnumerable<UtilisateurDTO> TrouverParNom(string nom)
        {
            return service.TrouverParNom(nom);
        }

        [Route("prenom/{prenom}")]
        public IEnumerable<UtilisateurDTO> TrouverParPrenom(string prenom)
        {
            return service.TrouverParPrenom(prenom);
        }

        [Route("age/{age}")]
        public IEnumerable<UtilisateurDTO> TrouverParAge(int age)
        {
            return service.TrouverParAge(age);
        }

        [Route("metier/{metier}")]
        public IEnumerable<UtilisateurDTO> TrouverParMetier(string metier)
        {
            return service.TrouverParMetier(metier);
        }

        [Route("age")]
        public IEnumerable<UtilisateurDTO> TrouverParAge(int min, int max = 1000)
        {
            return service.TrouverParAge(min, max);
        }

        [HttpPut]
        [Route("{id}")]
        public UtilisateurDTO Modifier(int id, [FromBody] UtilisateurDTO value)
        {
            return service.Modifier(id, value);
        }

        [HttpDelete]
        [Route("{id}")]
        public void SupprimerUtilisateur(int id)
        {
            service.SupprimerUtilisateur(id);
        }
    }
}