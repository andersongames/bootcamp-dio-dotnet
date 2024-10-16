using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

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

// TUPLE
(int Id, string None, string Sobrenome, decimal Altura) tuple1 = (1, "Anderson", "Games", 1.7M);
ValueTuple<int, string, string, decimal> tuple2 = (1, "Anderson", "Games", 1.7M);
var tuple3 = Tuple.Create(1, "Anderson", "Games", 1.7M);
Console.WriteLine($"Id: {tuple1.Id}");
Console.WriteLine($"Nome: {tuple1.Item2}");
Console.WriteLine($"Sobrenome: {tuple2.Item3}");
Console.WriteLine($"Altura: {tuple3.Item4}");

LeituraArquivo file = new LeituraArquivo();
var (Success, Lines, _) = file.ReadFile("Files/readFile.txt");
if (Success)
{
  // Console.WriteLine($"Quantidade de linhas no arquivo: {Qtd}");
  foreach (string line in Lines)
  {
    Console.WriteLine(line);
  }
}
else
{
  Console.WriteLine("Não foi possiveel ler o arquivo.");
}

// DECONSTRUCT
Pessoa p3 = new Pessoa("Anderson", "Games");
(string nome, string sobrenome) = p3;
Console.WriteLine($"{nome} {sobrenome}");

// TERNARY
int number = 21;

bool ehPar = number % 2 == 0;
Console.WriteLine($"O número {number} é " + (ehPar ? "Par" : "Ímpar"));

// SERIALIZE
DateTime currentDate = DateTime.Now;
Venda v1 = new Venda(1, "Material de escritório", 25.00M, currentDate);
Venda v2 = new Venda(2, "Licença de software", 110.00M, currentDate);
List<Venda> listVendas = new List<Venda>();
listVendas.Add(v1);
listVendas.Add(v2); 
string vendaSerialized = JsonConvert.SerializeObject(v1, Formatting.Indented);
string listVendasSerialized = JsonConvert.SerializeObject(listVendas, Formatting.Indented);
Console.WriteLine(listVendasSerialized);
File.WriteAllText("Files/venda.json", vendaSerialized);
File.WriteAllText("Files/vendas.json", listVendasSerialized);

// DESERIALIZE
string fileContent = File.ReadAllText("Files/vendas.json");
List<Venda> listVendaFile = JsonConvert.DeserializeObject<List<Venda>>(fileContent);

foreach (Venda venda in listVendaFile)
{
  Console.WriteLine($"Id: {venda.Id}, Prouto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd-MM-yyyy HH:mm")}");
}

// ATRIBUTES - [JsonProperty("Nome_Produto")]
string fileContent2 = File.ReadAllText("Files/vendas2.json");
List<Venda> listVendaFile2 = JsonConvert.DeserializeObject<List<Venda>>(fileContent2);

foreach (Venda venda in listVendaFile2)
{
  Console.WriteLine(
    $"Id: {venda.Id}, Prouto: {venda.Produto}, " +
    $" Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd-MM-yyyy HH:mm")}" +
    $"{(venda.Desconto.HasValue ? $", Desconto: {venda.Desconto}" : "")}"
  );
}

// NULLABLE
bool? recieveEmail = null;

if (recieveEmail.HasValue && recieveEmail.Value)
{
  Console.WriteLine("O usuário optou por receber e-mail.");
}
else
{
  Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");
}

// ANONYMOUS TYPES
var anonymousType = new { Nome = "Anderson", Sobrenome = "Games", Altura = 1.80 };
Console.WriteLine("Nome: " + anonymousType.Nome);
Console.WriteLine("Sobrenome: " + anonymousType.Sobrenome);
Console.WriteLine("Altura: " + anonymousType.Altura);

var anonymousList = listVendaFile2.Select(x => new { x.Produto, x.Preco });

foreach (var venda in anonymousList)
{
  Console.WriteLine($"Produto: {venda.Produto}, Preco: {venda.Preco}");
}

// DYNAMIC VARIABLES
dynamic dynamicVariable = 4;
Console.WriteLine($"Tipo da variável: {dynamicVariable.GetType()}, Valor: {dynamicVariable}");

dynamicVariable = "text";
Console.WriteLine($"Tipo da variável: {dynamicVariable.GetType()}, Valor: {dynamicVariable}");

dynamicVariable = true;
Console.WriteLine($"Tipo da variável: {dynamicVariable.GetType()}, Valor: {dynamicVariable}");

// GENERIC CLASS
MeuArray<int> arrayInt = new MeuArray<int>();
arrayInt.AddElementArray(30);
Console.WriteLine(arrayInt[0]);

MeuArray<string> arrayString = new MeuArray<string>();
arrayString.AddElementArray("test");
Console.WriteLine(arrayString[0]);

// EXTENSSION METHODS
int number2 = 20;

bool ehPar2 = number2.ehPar();
Console.WriteLine($"O número {number2} é " + (ehPar2 ? "Par" : "Ímpar"));
