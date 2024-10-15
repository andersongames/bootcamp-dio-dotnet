using ExemploExplorando.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

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

// CONCAT
string n1 = "10";
int n2 = 20;
string res = n1 + n2;
Console.WriteLine(res);

decimal valorMonetario = 1582.40M;
Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine($"{valorMonetario:C8}");
Console.WriteLine($"{valorMonetario:N}");

double percent = .3421;
Console.WriteLine(percent.ToString("P"));

int n3 = 123456;
Console.WriteLine(n3.ToString("##-##-##"));

// DATETIME
DateTime date = DateTime.Now;
Console.WriteLine(date);
Console.WriteLine(date.ToString("dd-MM-yyyy HH:mm"));
Console.WriteLine(date.ToShortDateString());
Console.WriteLine(date.ToShortTimeString());

string dateString = "2022-04-17 18:00";
DateTime convertTime1 = DateTime.Parse(dateString);
Console.WriteLine(convertTime1);

string invalidDateString = "2022-13-17 18:00";
bool dateTryParseRes = DateTime.TryParseExact(
  invalidDateString,
  "yyyy-M-dd HH:mm",
  CultureInfo.InvariantCulture,
  DateTimeStyles.None,
  out DateTime parsedDate
);

if (dateTryParseRes)
{
  Console.WriteLine($"Convertido com sucesso! Data: {parsedDate}");
}
else
{
  Console.WriteLine($"{invalidDateString} Não é uma data válida.");
}

// EXCEPTIONS
try
{
  string[] lines = File.ReadAllLines("Files/read_File.txt");

  foreach (string line in lines)
  {
    Console.WriteLine(line);
  }
}
catch (FileNotFoundException ex)
{
  Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
  Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado. {ex.Message}");
}
catch (Exception ex)
{
  Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
finally
{
  Console.WriteLine("Program flow not interrupted!!");
}

// STACK TRACK
new ExemploExcecao().Metodo1();

// QUEUE
Queue<int> queue = new Queue<int>();
queue.Enqueue(2);
queue.Enqueue(4);
queue.Enqueue(6);
queue.Enqueue(8);

foreach (int item in queue)
{
  Console.WriteLine(item);
}

Console.WriteLine($"Removido o item: {queue.Dequeue()}");

// STACK
Stack<int> stack = new Stack<int>();
stack.Push(4);
stack.Push(6);
stack.Push(8);
stack.Push(10);

foreach (int item in stack)
{
  Console.WriteLine(item);
}

Console.WriteLine($"Removido o item do topo: {stack.Pop()}");

// DICTIONARY
Dictionary<string, string> states = new Dictionary<string, string>();
states.Add("SP", "São Paulo");
states.Add("BA", "Bahia");
states.Add("MG", "Minas Gerais");
// states.Add("BA", "Bahia"); // key must be unique

states.Remove("BA");
states["SP"] = "São Paulo - Locomotiva do Brasil";

foreach (var item in states)
{
  Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string keySearch = "BA";
Console.WriteLine($"Verificando se a chave '{keySearch}' existe");

if (states.ContainsKey(keySearch))
{
  Console.WriteLine($"Chave '{keySearch}' já existe");
}
else
{
  Console.WriteLine($"Chave '{keySearch}' não existe");
}

states.Add("BA", "Bahia");
Console.WriteLine(states["BA"]);
