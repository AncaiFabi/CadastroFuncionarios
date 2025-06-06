using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class FuncionariosController : ControllerBase
{
    private readonly AppDbContext _context;

    public FuncionariosController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/funcionarios
    [HttpGet]
    public async Task<IActionResult> GetTodos()
    {
        var funcionarios = await _context.Funcionarios.ToListAsync();
        return Ok(funcionarios);
    }

    // GET: api/funcionarios/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetPorId(int id)
    {
        var funcionario = await _context.Funcionarios.FindAsync(id);
        if (funcionario == null)
            return NotFound();

        return Ok(funcionario);
    }

    // GET: api/funcionarios/ativos
    [HttpGet("ativos")]
    public async Task<IActionResult> GetAtivos()
    {
        var ativos = await _context.Funcionarios
            .Where(f => f.DataDesligamento == null)
            .ToListAsync();

        return Ok(ativos);
    }

    // GET: api/funcionarios/desligados
    [HttpGet("desligados")]
    public async Task<IActionResult> GetDesligados()
    {
        var desligados = await _context.Funcionarios
            .Where(f => f.DataDesligamento != null)
            .ToListAsync();

        return Ok(desligados);
    }
}