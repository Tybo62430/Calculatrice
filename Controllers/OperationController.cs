using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatriceAPI.Controllers
{
    using Calculatrice.DTO;
    

    [Route("api/operations")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private static List<Operation> operations = new List<Operation>();

        [HttpGet]
        [Route("")]
        public List<Operation> findAll()
        {
            List<Operation> result = new List<Operation>();
            foreach (Operation operation in operations)
            {
                if (operation != null)
                {
                    result.Add(operation);
                }
            }
            return result;
        }

        [HttpPost]
        [Route("")]
        public Operation save([FromBody] Operation data)
        {
            data.Id = operations.Count;
            operations.Add(data);
            return data;
        }

        [HttpGet]
        [Route("{id}")]
        public Operation findById(int id)
        {
            return operations[id];
        }

        [HttpDelete]
        [Route("{id}")]
        public void delete(int id)
        {
            operations[id] = null;
        }

        [HttpPut]
        [Route("{id}")]
        public Operation update(int id, [FromBody] Operation data)
        {
            data.Id = id;
            operations[id] = data;
            return data;
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public List<Operation> findByNom(string nom)
        {
            return operations.Where(operation => operation.Nom == nom).ToList();
        }

        [HttpGet]
        [Route("valeur/{valeur}")]
        public List<Operation> findByValeur(string valeur)
        {
            List<Operation> result = new List<Operation>();
            foreach (Operation operation in operations)
            {
                if (operation.Valeur == valeur)
                {
                    result.Add(operation);
                }
            }
            return result;
        }
    }
}



