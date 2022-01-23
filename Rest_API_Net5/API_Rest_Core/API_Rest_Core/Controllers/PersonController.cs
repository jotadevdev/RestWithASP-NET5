using API_Rest_Core.Model;
using API_Rest_Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace API_Rest_Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;


        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(_personService.FindAll());
        }

        [HttpGet("{Id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.FindById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            
            return Ok(_personService.Create(person));
        }

        [HttpPut]


        public IActionResult Put([FromBody] Person person)
        {
            if (person == null) return BadRequest();

            return Ok(_personService.Update(person));

        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            return NoContent();
        }

        //------------------------------------------------------------Calculadora
        //[HttpGet("sum/{firstNum}/{secondNum}")]
        //public IActionResult Sum(string firstNum, string secondNum)
        //{
        //    if(IsNumeric(firstNum) && IsNumeric(secondNum))
        //    {
        //        var sum = Convert.ToDecimal(firstNum) + Convert.ToDecimal(secondNum);

        //        return Ok(sum.ToString());

        //    }

        //    return BadRequest();
        //}

        //[HttpGet("subtraction/{firstNum}/{secondNum}")]
        //public IActionResult Subtraction(string firstNum, string secondNum)
        //{
        //    if (IsNumeric(firstNum) && IsNumeric(secondNum))
        //    {
        //        var sum = Convert.ToDecimal(firstNum) - Convert.ToDecimal(secondNum);

        //        return Ok(sum.ToString());

        //    }

        //    return BadRequest();
        //}

        //private bool IsNumeric(string strNum)
        //{
        //    decimal num;

        //    bool result = decimal.TryParse(
        //                  strNum,
        //                  System.Globalization.NumberStyles.Any,
        //                  System.Globalization.NumberFormatInfo.CurrentInfo,
        //                  out num);

        //    return result;

        //}
    }
}
