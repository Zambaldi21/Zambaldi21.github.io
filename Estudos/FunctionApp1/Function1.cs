using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ConsoleApp1.Estudos;

namespace FunctionApp1
{
    // Web Api
    public class Function1
    {
        [FunctionName("PercentualCusto")]
        public async Task<IActionResult> PercentualCusto([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req)
        {
            return new OkObjectResult("0,30");
        }

        [FunctionName("PercentualImpostos")]
        public async Task<IActionResult> PercentualImpostos([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req)
        {
            Calculadora.Processar();
            return new OkObjectResult("0,50");
        }
    }
}
