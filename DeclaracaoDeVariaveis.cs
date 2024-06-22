/*
Para se executar um código em C#:
No terminal é necessário utilizar o `dotnet run`.
*/

// Declarando um double e colocando na tela
double alturaMetros = 1.86;
string nome = "João";


Console.WriteLine($"A altura de {nome} é {alturaMetros}");

// Simplesmente faz uma linha de 74 '-' na saída
string horizontalLine = new('-', count: 74);
Console.WriteLine(horizontalLine);

// Habilita a saída UTF-8 para suportar emojis
Console.OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
Console.WriteLine(grinningEmoji);

Console.WriteLine(horizontalLine);

var person = new { FirstName = "Alice", Age = 56 };
string json = $$@"
              {{
                ""first_name"": ""{{person.FirstName}}"",
                ""age"": {{person.Age}},
                ""calculation"": ""{{{{ 1 + 2 }}}}""
              }}";
Console.WriteLine(json);
Console.WriteLine(horizontalLine);

/*
uint (0 e positivos).
int (positivos ou negativos).
float armazena números de ponto flutuante com precisão de aproximadamente 7 dígitos.
double armazena números de ponto flutuante com precisão de aproximadamente 15-16 dígitos.
*/

// Exemplo de uso:
uint numeroPositivo = 4;
int numeroInteiro = -16;
float numeroFloat = 2.2f; // Note o 'f' no final
double numeroDouble = 2.22222222222222;

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000; 
int hexadecimalNotation = 0x_001E_8480;

// Verifica se as três variáveis têm o mesmo valor
Console.WriteLine(decimalNotation == binaryNotation); 
Console.WriteLine(decimalNotation == hexadecimalNotation);

// Exibe os valores das variáveis em decimal
Console.WriteLine(decimalNotation.ToString("N0"));
Console.WriteLine(binaryNotation.ToString("N0"));
Console.WriteLine(hexadecimalNotation.ToString("N0"));

// Exibe os valores das variáveis em hexadecimal
Console.WriteLine(decimalNotation.ToString("X"));
Console.WriteLine(binaryNotation.ToString("X"));
Console.WriteLine(hexadecimalNotation.ToString("X"));

Console.WriteLine(horizontalLine);

Console.WriteLine($"int usa {sizeof(int)} bytes e pode armazenar números no intervalo de {int.MinValue:N0} a {int.MaxValue:N0}."); 
Console.WriteLine($"double usa {sizeof(double)} bytes e pode armazenar números no intervalo de {double.MinValue:N0} a {double.MaxValue:N0}."); 
Console.WriteLine($"decimal usa {sizeof(decimal)} bytes e pode armazenar números no intervalo de {decimal.MinValue:N0} a {decimal.MaxValue:N0}.");

Console.WriteLine(horizontalLine);

bool happy = true; 
bool sad = false;

Console.WriteLine($"Se Você Quer Sorrir é com o Patata {sad}, se você quiser brincar é com o Patata {happy}");

Console.WriteLine(horizontalLine);

/*
Existe um tipo especial chamado object que pode armazenar qualquer tipo de dados, mas sua flexibilidade tem o custo de um código mais confuso e possivelmente de um desempenho ruim.
*/
object height = 1.88; // Armazenando um double em um object.
object name = "Amir"; // Armazenando uma string em um object.
Console.WriteLine($"{name} tem {height} metros de altura.");
//int length1 = name.Length; // Isto dá um erro de compilação!
int length2 = ((string)name).Length; // Converte name para string.
Console.WriteLine($"{name} tem {length2} caracteres.");

Console.WriteLine(horizontalLine);

Person kim = new Person { BirthDate = new DateTime(1967, 12, 26) };

List<Person> people = new() // Ao invés de: new List<Person>()
{
  new Person { FirstName = "Alice" }, // Ao invés de: new Person() { ... }
  new Person { FirstName = "Bob" },
  new Person { FirstName = "Charlie" }
};

Console.WriteLine(horizontalLine);

int number = 13;
Console.WriteLine($"Número definido para: {number}");
number = default;
Console.WriteLine($"Número redefinido para seu padrão: {number}");

Console.WriteLine(horizontalLine);

int numberOfApples = 12; 
decimal pricePerApple = 0.35M;
Console.WriteLine(
  format: "{0} maçãs custam {1:C}", 
  arg0: numberOfApples,
  arg1: pricePerApple * numberOfApples);
string formatted = string.Format(
  format: "{0} maçãs custam {1:C}",
  arg0: numberOfApples,
  arg1: pricePerApple * numberOfApples);
// WriteToFile(formatted); // Escreve a string em um arquivo.
Console.WriteLine(horizontalLine);
// Três valores de parâmetro podem usar argumentos nomeados.
Console.WriteLine("{0} {1} morava em {2}.", 
  arg0: "Roger", arg1: "Cevung", arg2: "Estocolmo");
// Quatro ou mais valores de parâmetro não podem usar argumentos nomeados.
Console.WriteLine(
  "{0} {1} morava em {2} e trabalhava na equipe de {3} na {4}.", 
  "Roger", "Cevung", "Estocolmo", "Educação", "Optimizely");

Console.WriteLine(horizontalLine);

// Constantes não podem usar interpolação de string
const string firstname = "Omar";
const string lastname = "Rudberg";
const string fullname = firstname + " " + lastname;

Console.WriteLine(fullname);

Console.WriteLine(horizontalLine);

string applesText = "Maçãs"; 
int applesCount = 1234;
string bananasText = "Bananas"; 
int bananasCount = 56789;
Console.WriteLine();
Console.WriteLine(format: "{0,-10} {1,6}",
  arg0: "Nome", arg1: "Quantidade");
Console.WriteLine(format: "{0,-10} {1,6:N0}",
  arg0: applesText, arg1: applesCount);
Console.WriteLine(format: "{0,-10} {1,6:N0}",
  arg0: bananasText, arg1: bananasCount);

public class Person
{
  public DateTime BirthDate { get; set; }
  public string FirstName { get; set; }
}

/*
Perguntas 

- Que declaração você pode digitar em um arquivo C# para descobrir o compilador e a versão da linguagem?
   #error version

- Quais são os dois tipos de comentários em C#?
   // Comentário de linha única
   /* Comentário de bloco 

- Qual é a diferença entre uma string literal e uma string interpolada?
   "Texto literal"
   $"Texto interpolado com {variavel}"
   String literal é um texto fixo; string interpolada permite incluir expressões dentro de {}.

- Por que você deve ter cuidado ao usar valores float e double?
   float x = 0.1f;
   double y = 0.1;
   Valores float e double podem causar problemas de precisão em cálculos.

- Como você pode determinar quantos bytes um tipo como double usa na memória?
   Use sizeof(double).
   Console.WriteLine(sizeof(double));

- Quando você deve usar a palavra-chave var?
   var numero = 10;
   var texto = "Olá";
   Use var quando o tipo exato é óbvio a partir do contexto.

- Qual é a sintaxe mais recente para criar uma instância de uma classe como XmlDocument?
   XmlDocument xmlDoc = new();

- Por que você deve ter cuidado ao usar o tipo dynamic?
   dynamic obj = "texto";
   O tipo dynamic pode causar erros de tempo de execução devido à falta de verificação em tempo de compilação.

- Como você alinha à direita uma string de formato?
   string.Format("{0,10}", "texto");
   Use a especificação de alinhamento como {0, -10} em strings formatadas.

- Qual caractere separa os argumentos de um aplicativo de console?
   args[0] = "primeiroArgumento";
   args[1] = "segundoArgumento";
   Espaço ( ) é o separador de argumentos de um aplicativo de console.
*/

/* O número de telefone de uma pessoa */
string numeroTelefone = "1234-5678";

/* A altura de uma pessoa */
double alturaEmMetros = 1.75;

/* A idade de uma pessoa */
int idade = 30;

/* O salário de uma pessoa */
decimal salario = 3500.50M;

/* ISBN de um livro */
string isbn = "978-3-16-148410-0";

/* O preço de um livro */
decimal precoLivro = 29.99M;

/* O peso de envio de um livro */
double pesoLivroKg = 0.85;

/* A população de um país */
long populacaoPais = 1268000000;

/* O número de estrelas no universo */
long numeroEstrelasUniverso = 1000000000000;

/* O número de funcionários em cada uma das pequenas ou médias empresas no Reino Unido */
int numeroFuncionariosReinoUnido = 50000;
