using EverythingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EverythingApp.Api.Controllers;

[ApiController]
[Route("api/tools/bmi")]
public class BmiController : ControllerBase
{
    [HttpPost]
    public ActionResult<BmiResponse> Calculate(BmiRequest request)
    {
        if (request.Height <= 0)
            return BadRequest("Height must be greater than 0");

        var bmi = request.Weight / (request.Height * request.Height);

        var category = bmi switch
        {
            < 18.5 => "Underweight",
            < 25 => "Normal",
            < 30 => "Overweight",
            _ => "Obese"
        };

        return Ok(new BmiResponse
        {
            Bmi = Math.Round(bmi, 2),
            Category = category
        });
    }

    [HttpGet]
    public IActionResult Test()
    {
        return Ok("BMI API działa");
    }
}