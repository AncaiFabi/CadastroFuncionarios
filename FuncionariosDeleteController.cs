using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class FuncionariosDeleteController : ControllerBase{
    private readonly AppDbContext _context;

    public FuncionariosDeleteController(AppDbContext context)
    {
        _context = context;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Deletar(int id)
    {
        var funcionario = await _context.Funcionarios.FindAsync(id);
        if (funcionario == null)
            return NotFound();

        _context.Funcionarios.Remove(funcionario);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
