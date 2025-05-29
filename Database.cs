using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Funcionario> Funcionarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Funcionario>().HasData(
            new Funcionario { Id = 1, Nome = "Ana Souza", Cargo = "Analista", DataAdmissao = new DateTime(2020, 1, 15) },
            new Funcionario { Id = 2, Nome = "Carlos Lima", Cargo = "Gerente", DataAdmissao = new DateTime(2019, 5, 10) },
            new Funcionario { Id = 3, Nome = "Fernanda Dias", Cargo = "Assistente", DataAdmissao = new DateTime(2021, 3, 12), DataDesligamento = new DateTime(2023, 6, 1) },
            new Funcionario { Id = 4, Nome = "João Pedro", Cargo = "Analista", DataAdmissao = new DateTime(2022, 9, 25) },
            new Funcionario { Id = 5, Nome = "Luciana Braga", Cargo = "Coordenadora", DataAdmissao = new DateTime(2018, 4, 20), DataDesligamento = new DateTime(2022, 1, 15) },
            new Funcionario { Id = 6, Nome = "Marcos Silva", Cargo = "Analista", DataAdmissao = new DateTime(2021, 7, 30) },
            new Funcionario { Id = 7, Nome = "Juliana Rocha", Cargo = "Gerente", DataAdmissao = new DateTime(2017, 2, 2) },
            new Funcionario { Id = 8, Nome = "Rafael Costa", Cargo = "Assistente", DataAdmissao = new DateTime(2023, 1, 18) },
            new Funcionario { Id = 9, Nome = "Beatriz Martins", Cargo = "Analista", DataAdmissao = new DateTime(2020, 10, 5) },
            new Funcionario { Id = 10, Nome = "Eduardo Nunes", Cargo = "Técnico", DataAdmissao = new DateTime(2016, 6, 11), DataDesligamento = new DateTime(2020, 12, 31) }
        );
    }
}