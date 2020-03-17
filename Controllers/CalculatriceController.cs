using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Calculatrice.DTO;

namespace CalculatriceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatriceController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "ca marche?";
        }

        [HttpGet]
        [Route("add/{a}/{b}")]
        public string Addition(int a, int b)
        {
            return (a + b).ToString();
        }


        [HttpGet]
        [Route("sous/{a}/{b}")]
        public string Soustraction(int a, int b)
        {
            return (a - b).ToString();
        }

        [HttpGet]
        [Route("multi/{a}/{b}")]
        public string Multiplication(int a, int b)
        {
            return (a * b).ToString();
        }

        [HttpGet]
        [Route("div/{a}/{b}")]
        public string Division(int a, int b)
        {
            return (a / b).ToString();
        }

        [HttpPost]
        public string Post([FromBody] Data content)
        {
            string result = "";

            switch (content.operation)
            {
                case "AND":
                    result = (content.a + content.b).ToString();
                    break;
                case "SUB":
                    result = (content.a - content.b).ToString();
                    break;
                case "DIV":
                    result = (content.a / content.b).ToString();
                    break;
                case "MUL":
                    result = (content.a * content.b).ToString();
                    break;
                default:
                    result = "non definie";
                    break;
            }
            return result;
        }

        [HttpGet]
        [Route("params")]
        public string Params(int a, int b, string o)
        {
            string result = "";

            switch (o)
            {
                case "AND":
                    result = (a + b).ToString();
                    break;
                case "SUB":
                    result = (a - b).ToString();
                    break;
                case "DIV":
                    result = (a / b).ToString();
                    break;
                case "MUL":
                    result = (a * b).ToString();
                    break;
                default:
                    result = "non definie";
                    break;
            }
            return result;
        }
        //utilisation dans postman https://localhost:44361/api/calculatrice/params?a=12&b=28&o=AND        
    }
}