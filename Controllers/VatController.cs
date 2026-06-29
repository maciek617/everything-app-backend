using EverythingAppBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace EverythingAppBackend.Controllers;

[ApiController]
[Route("api/tools/vat")]

public class VatController : ControllerBase
{
    [HttpPost]
    public ActionResult<VatResponse> Calculate(VatRequest request)
    {
        if (request.VatRate <= 0 || request.NetAmount <= 0)
            return BadRequest("Height must be greater than 0");

        decimal net, vat, gross;

        if (request.IsNet)
        {
            net = request.NetAmount;
            vat = net * request.VatRate;
            gross = net + vat;
        }
        else
        {
            gross = request.NetAmount;
            net = gross / (1 + request.VatRate);
            vat = gross - net;
        }

        return Ok(new VatResponse
        {
            Net = Math.Round(net, 2),
            Gross = Math.Round(gross, 2),
            Vat = Math.Round(vat, 2),
        });
    }

    [HttpGet]
    public IActionResult Test()
    {
        return Ok("BMI API działa");
    }
}

