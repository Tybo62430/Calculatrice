using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculatrice.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculatrice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private static List<Utilisateur> utilisateurs = new List<Utilisateur>();

        [HttpPost]
        [Route("")]
        public Utilisateur save([FromBody] Utilisateur data)
        {
            data.Id = utilisateurs.Count;
            utilisateurs.Add(data);
            return data;
        }

        [HttpGet]
        [Route("")]
        public List<Utilisateur> findAll()
        {
            List<Utilisateur> result = new List<Utilisateur>();
            foreach (Utilisateur utilisateur in utilisateurs)
            {
                if (utilisateur != null)
                {
                    result.Add(utilisateur);
                }
            }
            return result;
        }

        [HttpGet]
        [Route("{id}")]
        public Utilisateur findById(int id)
        {
            return utilisateurs[id];
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public List<Utilisateur> findByNom(string nom)
        {
            return utilisateurs.Where(utilisateur => utilisateur.Nom == nom).ToList();
        }

        [Route("prenom/{prenom}")]
        public List<Utilisateur> findByPrenom(string prenom)
        {
            return utilisateurs.Where(utilisateur => utilisateur.Prenom == prenom).ToList();
        }

        [Route("age/{age}")]
        public List<Utilisateur> findByAge(int age)
        {
            return utilisateurs.Where(utilisateur => utilisateur.Age == age).ToList();
        }

        [Route("metier/{metier}")]
        public List<Utilisateur> findByMetier(string metier)
        {
            return utilisateurs.Where(utilisateur => utilisateur.Metier == metier).ToList();
        }

        [Route("between/{min}/{max}")]
        public List<Utilisateur> between(int min, int max)
        {
            return utilisateurs.Where(utilisateur => utilisateur.Age >= min && utilisateur.Age <= max).ToList();
        }

        [HttpPut]
        [Route("{id}")]
        public Utilisateur update(int id, [FromBody] Utilisateur data)
        {
            data.Id = id;
            utilisateurs[id] = data;
            return data;
        }

        [HttpDelete]
        [Route("{id}")]
        public void delete(int id)
        {
            utilisateurs[id] = null;
        }
    }
}