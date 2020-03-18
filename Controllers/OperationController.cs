using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatriceAPI.Controllers
{
    using Calculatrice.DTO;
    using Calculatrice.Services;
    using Calculatrice.Services.Impl;

    [Route("api/operations")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private static OperationService service = new OperationCalculatriceService();

        [HttpGet]
        [Route("")]
        public IEnumerable<OperationDTO> TrouverTout()
        {
            return service.TrouverTout();
        }

        [HttpPost]
        [Route("")]
        public OperationDTO AjouterUneOperation([FromBody] OperationDTO value)
        {
            return service.AjouterUneOperation(value);
        }

        [HttpGet]
        [Route("{id}")]
        public IEnumerable<OperationDTO> TrouverUneOperation(int id)
        {
            return service.TrouverUneOperation(id);
        }

        [HttpDelete]
        [Route("{id}")]
        public void SupprimerOperation(int id)
        {
            service.SupprimerOperation(id);
        }

        [HttpPut]
        [Route("{id}")]
        public OperationDTO Modifier(int id, [FromBody] OperationDTO value)
        {
            return service.Modifier(id, value);
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public IEnumerable<OperationDTO> TrouverParNom(string nom)
        {
            return service.TrouverParNom(nom);
        }

        [HttpGet]
        [Route("valeur/{valeur}")]
        public IEnumerable<OperationDTO> TrouverParValeur(string valeur)
        {
            return service.TrouverParValeur(valeur);
        }
    }    
}



