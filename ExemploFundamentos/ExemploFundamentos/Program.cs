// See https://aka.ms/new-console-template for more information

// CLASS INSTANCE
using ExemploFundamentos.Commom.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Anderson";
pessoa1.Idade = 29;
pessoa1.Apresentar();

// DATA TYPES
string apresentacao = "Olá seja bem vindo";
int quantidade = 1;
quantidade = 10;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;
DateTime dataAtual = DateTime.Now.AddDays(5);

Console.WriteLine("Valor da variável apresentacao: " + apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);
Console.WriteLine("Valor da variável dataAtual: " + dataAtual.ToString("dd/MM/yyyy HH:mm"));

// OPERATORS
int a = 10;
int b = 20;

int c = a +  b;

// c = c + 5; // 30 + 5
c += 5;

// c + c + 5;
c *= 5;

Console.WriteLine(c);

double d = 4 / (2 + 2);

Console.WriteLine(d);


// CONVERT TYPES - CAST
int d1 = Convert.ToInt32("5");
int e = int.Parse("5");
Console.WriteLine(d1);
Console.WriteLine(e);

int d2 = Convert.ToInt32(null);
// int e1 = int.Parse(null);
Console.WriteLine(d2);
// Console.WriteLine(e1);

int inteiro = 5;
string a1 = inteiro.ToString();
Console.WriteLine(a1);

int a2 = int.MaxValue;
double b2 = a2;
long c2 = a2;
Console.WriteLine(b2);

string a3 = "15-";
int b3 = 0;
int.TryParse(a3, out b3);
Console.WriteLine(b3);


// CODITIONS
int quantidade2 = 10;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidade2 >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidade2}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
  Console.WriteLine("Venda inválida.");
}
else if (possivelVenda)
{
  Console.WriteLine("Venda realizada.");
}
else
{
  Console.WriteLine("Falta estoque.");
}

// SWITCH CASE
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
  case "a":
  case "e":
  case "i":
  case "o":
  case "u":
    Console.WriteLine("É uma vogal");
    break;
  default:
    Console.WriteLine("Não é uma vogal");
    break;
}

// LOGICAL OPERATORS
bool maior = false;
bool possuiAutoriazacao = false;

if (maior || possuiAutoriazacao)
{
  Console.WriteLine("Entrada liberada");
}
else
{
  Console.WriteLine("Entrada não liberada");
}

bool presencaMinima = true;
double media = 7.5;

if (presencaMinima && media >= 7)
{
  Console.WriteLine("Aprovado");
}
else
{
  Console.WriteLine("Reprovado");
}

bool choveu = true;
bool estaTarde = true;

if (!choveu && !estaTarde)
{
  Console.WriteLine("Vou pedalar");
}
else
{
  Console.WriteLine("Vou pedalar outro dia");
}

// ARITHMETIC OPERATORS
Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 30);
calc.Multiplicar(10, 30);
calc.Dividir(2, 2);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);

int numero = 10;
Console.WriteLine(numero);
Console.WriteLine("incrementando o numero");
// numero += numero + 1;
numero++;
Console.WriteLine(numero);

Console.WriteLine("decrementando o numero");
// numero -= numero - 1;
numero--;
Console.WriteLine(numero);


// LOOPS
int numero2 = 2;

for (int i = 0; i <= 10; i++)
{
  Console.WriteLine($"{numero2} x {i} = {numero2 * i}");
}

int count = 0;
while (count <= 10)
{
  Console.WriteLine($"{numero2} x {count} = {numero2 * count}");
  count++;

  if (count == 6)
  {
    break;
  }
}

int soma = 0, num = 0;
do
{
  Console.WriteLine("Digite um numero (0 para parar)");
  num = Convert.ToInt32(Console.ReadLine());

  soma += num;
} while (num != 0);

Console.WriteLine($"Soma dos números digitados é {soma}");

string option;
bool showMenu = true;

while(showMenu)
{
  Console.Clear();
  Console.WriteLine("Digite a opção desejada:");
  Console.WriteLine("1 - Cadastrar cliente");
  Console.WriteLine("2 - Buscar cliente");
  Console.WriteLine("3 - Apagar cliente");
  Console.WriteLine("4 - Encerrar");

  option = Console.ReadLine();

  switch(option)
  {
    case "1":
      Console.WriteLine("Cadastro de cliente");
      break;

      case "2":
        Console.WriteLine("Busca de cliente");
        break;

      case "3":
        Console.WriteLine("apagar cliente");
        break;

      case "4":
        Console.WriteLine("Encerrar");
        // Environment.Exit(0);
        showMenu = false;
        break;

      default:
        Console.WriteLine("Opção inválida");
        break;
  }
}

Console.WriteLine("O programa encerrou");

// ARRAY
int[] arrayInteiros = new int[4];
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

int[] arrayInteirosB = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosB, arrayInteiros.Length);

Console.WriteLine("Percorrendo array com FOR");
for (int i = 0; i < arrayInteiros.Length; i++)
{
  Console.WriteLine($"Posição {i} -> {arrayInteiros[i]}");
}

Console.WriteLine("Percorrendo array com FOREACH");
int contadorForeach = 0;
foreach(int valor in arrayInteiros)
{
  Console.WriteLine($"Posição {contadorForeach} -> {valor}");
  contadorForeach++;
}

// LISTS
List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine("Percorrendo lista com FOR");
for (int i = 0; i < listaString.Count; i++)
{
  Console.WriteLine($"Posição {i} -> {listaString[i]}");
}

Console.WriteLine("Percorrendo lista com FOREACH");
int contadorForeachLista = 0;
foreach(string item in listaString)
{
  Console.WriteLine($"Posição {contadorForeachLista} -> {item}");
  contadorForeachLista++;
}

Console.WriteLine($"Itens na lista: {listaString.Count} - Ccapacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na lista: {listaString.Count} - Ccapacidade: {listaString.Capacity}");

listaString.Remove("RJ");

Console.WriteLine($"Itens na lista: {listaString.Count} - Ccapacidade: {listaString.Capacity}");

// COMMENTS
// Instace Pessoa class
Pessoa p2 = new Pessoa();

/*
  Set Nome and Idade
*/
p2.Nome = "Anderson";
p2.Idade = 29;

// Call Apresentar method
p2.Apresentar();

// Register to XYZ Clients ERP
p2.CadastrarNoERPDaEmpresa();