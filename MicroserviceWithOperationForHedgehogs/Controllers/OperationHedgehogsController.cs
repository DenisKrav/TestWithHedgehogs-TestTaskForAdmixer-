using MicroserviceWithOperationForHedgehogs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceWithOperationForHedgehogs.Controllers
{
    [ApiController]
    public class OperationHedgehogsController : ControllerBase
    {
        [Route("colors")]
        public IResult GetNumberHedgehogsTheirColor(int[] data)
        {
            Dictionary<int, string> result = new Dictionary<int, string>();

            for (int i = 0; i < data.Length; i++)
            {
                result.Add(data[i], ColorHedgehogs.GetLolor(i));
            }

            return Results.Json(result);
        }
    }
}