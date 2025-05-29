# 📋 Cadastro de Funcionários - API RESTful

Este projeto é uma API REST desenvolvida em C# com Entity Framework Core e SQLite, com o objetivo de realizar o cadastro e o controle de funcionários ativos e desligados.

---

## 🎯 Objetivo

O sistema busca resolver o problema da **falta de controle entre funcionários ativos e desligados**. Para isso, a API permite:

- Cadastro de funcionários com datas de admissão e desligamento.
- Identificação automática de funcionários ativos.
- Filtragem por funcionários ativos ou desligados.

---

## 🛠️ Tecnologias Utilizadas

- ASP.NET Core 7.0.0
- Entity Framework Core 7.0.0
- SQLite
- Swagger (Swashbuckle)

---

## 📦 Funcionalidades Implementadas

- `GET /api/funcionarios`  
  Lista todos os funcionários (ativos e desligados).

- `GET /api/funcionarios/{id}`  
  Busca um funcionário pelo ID.

- `GET /api/funcionarios/ativos`  
  Lista apenas os funcionários **ativos**.

- `GET /api/funcionarios/desligados`  
  Lista apenas os funcionários **desligados**.

- `POST /api/funcionarios`  
  (Em desenvolvimento)

- `DELETE /api/funcionarios/{id}`  
  (Em desenvolvimento)

---

## 📂 Como Rodar o Projeto

1. Clone o repositório:
```bash
git clone https://github.com/seu-usuario/seu-repo.git
cd seu-repo
```

2.Configure o ambiente:
```bash
dotnet new tool-manifest
```

3.Instale o Entity Framework CLI:
```bash
dotnet tool install dotnet-ef --version 7.0.10
```

4.Instale os pacotes necessários:
```bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 7.0.10
dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.10
dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10
dotnet add package Swashbuckle.AspNetCore --version 6.4.0
```

5.Crie o banco de dados e a migration:
```bash
dotnet tool run dotnet-ef migrations add Inicial
dotnet tool run dotnet-ef database update
```

6.Rode a aplicação:
```bash
dotnet build
```

7.Rode a aplicação:
```bash
dotnet run
```

8. Acesse a interface Swagger:
Abra o navegador em:
```bash
http://localhost:5109/swagger
```



