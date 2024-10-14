using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Anderson", "Games");
// p1.Nome = "Anderson";
// p1.Sobrenome = "Games";

Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Queiroz");
// p2.Nome = "Eduardo";
// p2.Sobrenome = "Queiroz";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();