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
        private List<Operation> operations = new List<Operation>();

        [HttpGet]
        public string Get()
        {
            return "ca marche?";
        }

        [HttpGet]
        [Route("save")]
        public Operation Save([FromBody]Operation data)
        {            
            this.operations.Add(data);
            return data;
        }

        [HttpGet]
        [Route("findall")]
        public List<Operation> FindAll()
        {
            return this.operations;            
        }

        [HttpGet]
        [Route("findid")]
        public Operation FindId(int id)
        {
            return this.operations[id];
        }

        [HttpDelete]
        [Route("delete")]
        public void Delete(int id)
        {
            this.operations.RemoveAt(id);
        }



    }
}