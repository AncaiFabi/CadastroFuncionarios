public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public DateTime DataAdmissao { get; set; }
    public DateTime? DataDesligamento { get; set; }

    public bool Ativo => DataDesligamento == null;
}
