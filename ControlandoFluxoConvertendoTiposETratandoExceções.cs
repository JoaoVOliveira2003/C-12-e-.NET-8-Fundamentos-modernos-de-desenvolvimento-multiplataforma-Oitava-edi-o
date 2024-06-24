/*
Para se executar um código em C#:
No terminal é necessário utilizar o `dotnet run`.
*/
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
