using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class DecryptController : ControllerBase
{
    [HttpPost]
    public ActionResult<string> Post([FromBody] string input)
    {
        // Här kan du lägga till din avkrypteringslogik.
        // Returnera den avkrypterade strängen.
        return Ok(DecryptString(input));
    }

    private string DecryptString(string input)
    {
        // Enkel logik för att reversera Caesar-chiffer som exempel.
        // Du kan implementera din egen logik här.
        return string.Concat(input.Select(c => (char)(c - 1)));
    }
}
