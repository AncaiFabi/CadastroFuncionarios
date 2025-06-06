async function carregarFuncionarios() {
    const tabela = document.getElementById("tabela-funcionarios");
    tabela.innerHTML = "<tr><td colspan='3'>Carregando...</td></tr>";
  
    try {
      const resposta = await fetch("http://localhost:5109/api/funcionarios");
      if (!resposta.ok) throw new Error("Erro na requisição");
  
      const funcionarios = await resposta.json();
  
      if (funcionarios.length === 0) {
        tabela.innerHTML = "<tr><td colspan='3'>Nenhum funcionário encontrado.</td></tr>";
        return;
      }
  
      tabela.innerHTML = "";
      funcionarios.forEach(f => {
        const linha = document.createElement("tr");
        linha.innerHTML = `
          <td>${f.id}</td>
          <td>${f.nome}</td>
          <td>${f.setor}</td>
        `;
        tabela.appendChild(linha);
      });
    } catch (erro) {
      tabela.innerHTML = `<tr><td colspan="3">Erro ao carregar funcionários 😢</td></tr>`;
      console.error(erro);
    }
  }
  
  window.onload = carregarFuncionarios;
  