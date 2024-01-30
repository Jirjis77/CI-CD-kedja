using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class EncryptController : ControllerBase
{
    [HttpPost]
    public ActionResult<string> Post([FromBody] string input)
    {
        // Här kan du lägga till din krypteringslogik.
        // Returnera den krypterade strängen.
        return Ok(EncryptString(input));
    }

    private string EncryptString(string input)
    {
        // Enkel Caesar-chiffer-logik som exempel.
        // Du kan implementera din egen logik här.
        return string.Concat(input.Select(c => (char)(c + 1)));
    }
}
