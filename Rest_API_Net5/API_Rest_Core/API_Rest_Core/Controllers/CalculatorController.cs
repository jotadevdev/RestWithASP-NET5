using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Rest_Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNum}/{secondNum}")]
        public IActionResult Get(string firstNum, string secondNum)
        {
            if(IsNumeric(firstNum) && IsNumeric(secondNum))
            {
                var sum = Convert.ToDecimal(firstNum) + Convert.ToDecimal(secondNum);

                return Ok(sum);

            }

            return BadRequest();
        }

        private bool IsNumeric(string strNum)
        {
            decimal num;

            bool result = decimal.TryParse(
                          strNum,
                          System.Globalization.NumberStyles.Any,
                          System.Globalization.NumberFormatInfo.CurrentInfo,
                          out num);

            return result;

        }
    }
}
