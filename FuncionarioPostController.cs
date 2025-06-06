using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class FuncionariosPostController : ControllerBase
{
    private readonly AppDbContext _context;

    public FuncionariosPostController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Cadastrar([FromBody] Funcionario novoFuncionario)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        _context.Funcionarios.Add(novoFuncionario);
        await _context.SaveChangesAsync();

        return CreatedAtAction(null, new { id = novoFuncionario.Id }, novoFuncionario); // GetPorId pode estar em outro controller
    }
}
