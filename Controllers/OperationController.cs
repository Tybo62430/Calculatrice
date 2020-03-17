using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculatrice.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculatrice.Controllers
{
    [Route("api/operations")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private static List<Operation> operations = new List<Operation>();

        [HttpGet]
        public string Get()
        {
            return "ca marche?";
        }

        [HttpGet]
        [Route("save")]
        public Operation Save([FromBody]Operation data)
        {
            data.Id = operations.Count;
            operations.Add(data);
            return data;
        }

        [HttpGet]
        [Route("findall")]
        public List<Operation> FindAll()
        {
            return operations;            
        }

        [HttpGet]
        [Route("findid/{id}")]
        public Operation FindId(int id)
        {
            return operations[id];
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public void Delete(int id)
        {
            operations.RemoveAt(id);
        }

        [HttpPut]
        [Route("update/{id}")]
        public Operation update(int id,[FromBody] Operation data)
        {
             data.Id = id;
             operations[id] = data;
             return data;            
        }



    }
}