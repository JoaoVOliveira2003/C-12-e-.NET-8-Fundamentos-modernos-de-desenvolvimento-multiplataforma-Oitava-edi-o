
string horizontalLine = new('-', 74);
Console.WriteLine(horizontalLine);

int a = 1;
int b = 2;

int mult = a * b;
int soma = a + b;

Console.WriteLine(soma);
Console.WriteLine(horizontalLine);

int x = 5;
int postfixIncrement = x++;
int prefixIncrement = ++x;

Console.WriteLine(prefixIncrement);

/*
Simplesmente tem algo que tem um 
var result = boolean_expression ? value_if_true : value_if_false;

Simplesmente se a expressão booleana for verdadeira, executa a primeira;
se for falso, você tem como resultado o segundo valor.
*/

string resultado = x > 3 ? "Maior que 3" : "Menor ou igual a 3";
// que é idêntico a:
string result;
if (x > 3)
{
    result = "Maior que 3";
}
else
{
    result = "Menor ou igual a 3";
}
Console.WriteLine(result);

// Explorando operadores unários
int c = 3;
int d = ++c; // Prefixo significa incremento de c antes de atribuí-lo.
Console.WriteLine($"c é {c}, d é {d}");

Console.WriteLine(prefixIncrement);

int e = 11;
int f = 3;
Console.WriteLine($"e é {e}, f é {f}");
Console.WriteLine($"e + f = {e + f}");
Console.WriteLine($"e - f = {e - f}");
Console.WriteLine($"e * f = {e * f}");
Console.WriteLine($"e / f = {e / f}");
Console.WriteLine($"e % f = {e % f}");

double g = 11.0;
Console.WriteLine($"g é {g:N1}, f é {f}");
Console.WriteLine($"g / f = {g / f}");

int p = 6;
p += 3; // Equivalente a: p = p + 3;
p -= 3; // Equivalente a: p = p - 3;
p *= 3; // Equivalente a: p = p * 3;
p /= 3; // Equivalente a: p = p / 3;

Console.WriteLine(p);

// Aplicação dos operadores lógicos AND, OR e XOR (OR exclusivo)
bool pBool = true;
bool qBool = false;
Console.WriteLine("AND  | p     | q    ");
Console.WriteLine($"p    | {pBool & pBool,-5} | {pBool & qBool,-5} ");
Console.WriteLine($"q    | {qBool & pBool,-5} | {qBool & qBool,-5} ");
Console.WriteLine();
Console.WriteLine("OR   | p     | q    ");
Console.WriteLine($"p    | {pBool | pBool,-5} | {pBool | qBool,-5} ");
Console.WriteLine($"q    | {qBool | pBool,-5} | {qBool | qBool,-5} ");
Console.WriteLine();
Console.WriteLine("XOR  | p     | q    ");
Console.WriteLine($"p    | {pBool ^ pBool,-5} | {pBool ^ qBool,-5} ");
Console.WriteLine($"q    | {qBool ^ pBool,-5} | {qBool ^ qBool,-5} ");

Console.WriteLine();
int xBitwise = 10;
int yBitwise = 6;
Console.WriteLine("Expression | Decimal |   Binary");
Console.WriteLine("-------------------------------");
Console.WriteLine($"x          | {xBitwise,7} | {Convert.ToString(xBitwise, 2).PadLeft(8, '0')}");
Console.WriteLine($"y          | {yBitwise,7} | {Convert.ToString(yBitwise, 2).PadLeft(8, '0')}");
Console.WriteLine($"x & y      | {xBitwise & yBitwise,7} | {Convert.ToString(xBitwise & yBitwise, 2).PadLeft(8, '0')}");
Console.WriteLine($"x | y      | {xBitwise | yBitwise,7} | {Convert.ToString(xBitwise | yBitwise, 2).PadLeft(8, '0')}");
Console.WriteLine($"x ^ y      | {xBitwise ^ yBitwise,7} | {Convert.ToString(xBitwise ^ yBitwise, 2).PadLeft(8, '0')}");

int age = 50;
Console.WriteLine($"A variável {nameof(age)} utiliza {sizeof(int)} bytes de memória.");

// Compreendendo as declarações de seleção
Console.WriteLine("Aqui é basicamente a mesma coisa do C, siga em frente.");

string password = "examplePassword";
if (password.Length < 8)
{
    Console.WriteLine("Sua senha é muito curta. Use pelo menos 8 caracteres.");
}
else
{
    Console.WriteLine("Sua senha é forte.");
}

/*
Adicione instruções para que, se o valor armazenado na variável chamada o for um int, então o valor seja atribuído à variável local chamada i, que pode ser usada dentro da instrução if. Isso é mais seguro do que usar a variável chamada o porque sabemos com certeza que i é uma variável do tipo int e não outra coisa, conforme mostrado no código a seguir:
*/

object o = 42; // Exemplo de algum valor

if (o is int i)
{
    // Agora você pode usar a variável 'i' com segurança dentro deste bloco.
    Console.WriteLine($"O valor de i é {i}");
}
else
{
    Console.WriteLine("A variável 'o' não é um int.");
}

// Ramificação com a instrução switch

// Limite inferior inclusivo, mas limite superior exclusivo.
int number = Random.Shared.Next(minValue: 1, maxValue: 7);
Console.WriteLine($"Meu número aleatório é {number}");
switch (number)
{
    case 1:
        Console.WriteLine("Um");
        break; // Salta para o final da instrução switch.
    case 2:
        Console.WriteLine("Dois");
        goto case 1;
    case 3: // Seção de casos múltiplos.
    case 4:
        Console.WriteLine("Três ou quatro");
        goto case 1;
    case 5:
        goto A_label;
    default:
        Console.WriteLine("Padrão");
        break;
} // Fim da instrução switch.
Console.WriteLine("Após o fim do switch");
A_label:
Console.WriteLine($"Após A_label");


class Animal // Este é o tipo base para todos os animais.
{
  public string? Name;
  public DateTime Born;
  public byte Legs;
}
class Cat : Animal // Este é um subtipo de animal.
{
  public bool IsDomestic;
}
class Spider : Animal // Este é outro subtipo de animal.
{
  public bool IsPoisonous;
}


var animals = new Animal?[]
{
  new Cat { Name = "Karen", Born = new(year: 2022, month: 8,
    day: 23), Legs = 4, IsDomestic = true },
  null,
  new Cat { Name = "Mufasa", Born = new(year: 1994, month: 6,
    day: 12) },
  new Spider { Name = "Sid Vicious", Born = DateTime.Today, 
    IsPoisonous = true},
  new Spider { Name = "Captain Furry", Born = DateTime.Today }
};
foreach (Animal? animal in animals)
{
  string message;
  switch (animal)
  {
    case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
      message = $"O gato chamado {fourLeggedCat.Name} tem quatro pernas.";
      break;
    case Cat wildCat when wildCat.IsDomestic == false:
      message = $"O gato não doméstico se chama {wildCat.Name}.";
      break;
    case Cat cat:
      message = $"O gato se chama {cat.Name}.";
      break;
    default: // default é sempre avaliado por último.
      message = $"{animal.Name} é um {animal.GetType().Name}.";
      break;
    case Spider spider when spider.IsPoisonous:
      message = $"A aranha {spider.Name} é venenosa. Corra!";
      break;
    case null:
      message = "O animal é nulo.";
      break;
  }
  WriteLine($"declaração switch: {message}");
}

message = animal switch
{
  Cat fourLeggedCat when fourLeggedCat.Legs == 4
    => $"O gato chamado {fourLeggedCat.Name} tem quatro pernas.",
  Cat wildCat when wildCat.IsDomestic == false
    => $"O gato não doméstico se chama {wildCat.Name}.",
  Cat cat
    => $"O gato se chama {cat.Name}.",
  Spider spider when spider.IsPoisonous
    => $"A aranha {spider.Name} é venenosa. Corra!",
  null
    => "O animal é nulo.",
  _
    => $"{animal.Name} é um {animal.GetType().Name}."
};
WriteLine($"expressão switch: {message}");

/*
declaração switch: O gato chamado Karen tem quatro pernas.
expressão switch: O gato chamado Karen tem quatro pernas.
declaração switch: O animal é nulo.
expressão switch: O animal é nulo.
declaração switch: O gato não doméstico se chama Mufasa.
expressão switch: O gato não doméstico se chama Mufasa.
declaração switch: A aranha Sid Vicious é venenosa. Corra!
expressão switch: A aranha Sid Vicious é venenosa. Corra!
declaração switch: Captain Furry é uma Aranha.
expressão switch: Captain Furry é uma Aranha.

*/

int x = 0;
while (x < 10)
{
  WriteLine(x);
  x++;
}

//Do while

string? actualPassword = "Pa$$w0rd";
string? password;
do
{
  Write("Digite sua senha: "); 
  password = ReadLine();
}
while (password != actualPassword);
WriteLine("Correto!");

for (int y = 1; y <= 10; y++)
{
  WriteLine(y);
}

string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
  WriteLine($"{name} tem {name.Length} caracteres.");
}

IEnumerator e = names.GetEnumerator();
while (e.MoveNext())
{
  string name = (string)e.Current; // Current é somente leitura!
  WriteLine($"{name} tem {name.Length} caracteres.");
}
//Armazenando múltiplos valores em um array

string[] names; // Isso pode referenciar qualquer array de strings de qualquer tamanho.
// Alocar memória para quatro strings em um array.
names = new string[4];
// Armazenar itens nessas posições de índice.
names[0] = "Kate";
names[1] = "Jack"; 
names[2] = "Rebecca"; 
names[3] = "Tom";
// ou pode ser.
string[] names2 = { "Kate", "Jack", "Rebecca", "Tom" };

// Percorrer os nomes.
for (int i = 0; i < names.Length; i++)
{
  // Exibir o item na posição do índice i.
  WriteLine($"{names[i]} está na posição {i}.");
}

//Trabalhando com arrays multidimensionais
string[,] grid1 = // Array bidimensional.
{
  { "Alpha", "Beta", "Gamma", "Delta" },
  { "Anne", "Ben", "Charlie", "Doug" },
  { "Aardvark", "Bear", "Cat", "Dog" }
};

WriteLine($"1ª dimensão, limite inferior: {grid1.GetLowerBound(0)}");
WriteLine($"1ª dimensão, limite superior: {grid1.GetUpperBound(0)}");
WriteLine($"2ª dimensão, limite inferior: {grid1.GetLowerBound(1)}");
WriteLine($"2ª dimensão, limite superior: {grid1.GetUpperBound(1)}");
/*SAÍDA
1ª dimensão, limite inferior: 0
1ª dimensão, limite superior: 2
2ª dimensão, limite inferior: 0
2ª dimensão, limite superior: 3
*/

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
  for (int col = 0; col <= grid1.GetUpperBound(1); col++)
  {
    WriteLine($"Linha {row}, Coluna {col}: {grid1[row, col]}");
  }
}
/*SAÍDA
Linha 0, Coluna 0: Alpha
Linha 0, Coluna 1: Beta
Linha 0, Coluna 2: Gamma
Linha 0, Coluna 3: Delta
Linha 1, Coluna 0: Anne
Linha 1, Coluna 1: Ben
Linha 1, Coluna 2: Charlie
Linha 1, Coluna 3: Doug
Linha 2, Coluna 0: Aardvark
Linha 2, Coluna 1: Bear
Linha 2, Coluna 2: Cat
Linha 2, Coluna 3: Dog
*/

// Sintaxe alternativa para declarar e alocar memória
// para uma matriz multidimensional.
string[,] grade2 = new string[3, 4]; // Alocar memória.
grade2[0, 0] = "Alfa"; // Atribuir valores.
grade2[0, 1] = "Beta";
// E assim por diante.
grade2[2, 3] = "Cachorro";


int[] sequentialNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] oneTwoNumbers = { 1, 2 };
int[] oneTwoTenNumbers = { 1, 2, 10 };
int[] oneTwoThreeTenNumbers = { 1, 2, 3, 10 };
int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
int[] emptyNumbers = { }; // Or use Array.Empty<int>()
int[] threeNumbers = { 9, 7, 5 };
int[] sixNumbers = { 9, 7, 5, 4, 2, 10 };
WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");
static string CheckSwitch(int[] values) => values switch
{
  [] => "Empty array",
  [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
  [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
  [1, 2] => "Contains 1 then 2.",
  [int item1, int item2, int item3] => 
    $"Contains {item1} then {item2} then {item3}.",
  [0, _] => "Starts with 0, then one other number.",
  [0, ..] => "Starts with 0, then any range of numbers.",
  [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
  [..] => "Any items in any order.",
};
