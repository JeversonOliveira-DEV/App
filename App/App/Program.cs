/*string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Beth";
Console.WriteLine(firstName);
firstName = "Conrad";
Console.WriteLine(firstName);
firstName = "Grant";
Console.WriteLine(firstName);
Console.ReadLine();*/

/*string firstName = "Hello, Bob!";
int f = 3;
decimal v = 34,4;
Console.Write("  ");
Console.Write("You have");
Console.Write(" ");
Console.Write(f);Console.Write(" ");
Console.Write("messages in your inbox.");
Console.Write(" ");
Console.Write("The temperature is ");
Console.Write(" ");
Console.Write(v);
Console.Write(" ");
Console.Write("celsius.");
Console.ReadLine();*/

using System;
using System.Security.Cryptography;
using System.Xml.Linq;

/*Console.WriteLine("Hello\nWord!");
Console.WriteLine("Hello\tWord!");
Console.ReadLine();*/

/*Console.WriteLine("Hello \"Word!\" ");
Console.ReadLine();*/

/*Console.WriteLine("C:\\source\\repos");
Console.ReadLine();*/

/*Console.WriteLine("Fatura: 1021\t\tComplete!");
Console.WriteLine("Fatura: 1022\t\tComplete!");
Console.WriteLine("\nDiretório de saída:\t");
//Console.ReadLine();

//Console.WriteLine(@"   c:\source\repos   
//     (""é aqui que vai o seu código"")");
Console.Write(@"c:\invoices");
//Console.ReadLine();


//Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
//Para gerar faturas japonesas:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");
Console.ReadLine();*/

/*string firstName = "Bob";
string greeting = "hello";
Console.WriteLine ($"{greeting} {firstName}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Date");
Console.ReadLine();*/

/*string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English output:
     C:\Exercise\{projectName}\data.text");

Console.WriteLine($@"{russianMessage}
     C:\Exercise\{projectName}\data.text");*/

/*string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");*/

/*int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);*/

/*decimal decimalQuotient = 7 / 5.0m;
//decimal decimalQuotient = 7.0m / 5.0m;
Console.WriteLine("Decimal quotient: " + decimalQuotient);*/

/*int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);*/

/*Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
Console.WriteLine("Modulus of 7 / 5 : " + (7 % 5));*/

/*int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);*/

/*int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);*/

/*int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine("Second: " + value++);
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));*/

//Converter Fahrenheit para Celsius. 
/*int fahrenheit = 94;
decimal Celsius = ((decimal)fahrenheit - 32) * 5 / 9;
Console.WriteLine($"The temperature is {Celsius} Celsius.");*/

// Outra solução.
/*int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");*/

//Console.WriteLine(5m / 10m);//Solução tem como resultado zero porque ao ta declarado como decimal.
//Console.WriteLine(5m / 10m);//Manueira correta de usar asolução.

//Chamar métodos da Biblioteca de Classes do .NET usando C#
/*
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);//Math.Max é o metodo da classe Math. 


Console.WriteLine(largerValue);
*/

/*
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
 Console.WriteLine("What does the fox say?");
}
*/

//Random dice = new();
/*
int roll1 = 6;//dice.Next(1, 7);
int roll2 = 6;//dice.Next(1, 7);
int roll3 = 6;//.Next(1, 7);

int total = roll1 + roll2 + roll3;
    
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))//Etapa 3
    {
        Console.WriteLine("Você rolou duplas! +2 de bônus no total!");
        total += 2;
    }
    else
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
}

if (total >= 16)
{
    Console.WriteLine("Você ganhau um carro novo!");
}
else if (total >= 10)
{
    Console.WriteLine("Você ganhau um nootbook novo!");
}
else if (total == 7)
{
    Console.WriteLine("Você ganha uma viagem a dois!");
}
else
{
    Console.WriteLine("Você ganha um gatinho!");
}
*/

/*Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Sua assinatura expirou.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Sua assinatura expira em um dia!\nRenove agora e economize 20 % !");
}
else if (daysUntilExpiration <= 5) 
{
    Console.WriteLine($"Sua assinatura expira {daysUntilExpiration} em  dias.\nRenove agora e economize 10%!");
}
else if  (daysUntilExpiration <= 10)
{
    Console.WriteLine("Sua assinatura expirará em breve.\nRenovar agora!");
}
*/
// \n para pular de linha.
// \t para dar espaço.
// $ para chamar variavel para impresão.

//Armazenar e iterar em sequências de dados usando Matrizes e a instrução foreach em C#
/*string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000"; 
// Teste para ver o erro. Não è posssivel abrir uma variavel fora da matriz [3].

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/


//Executar um loop em uma matriz usando o foreach

/*string[] names = { "Bob", "Conrad", "Grant" };
foreach (string name in names)
{
    Console.WriteLine(name);
}*/

/*int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");*/


string[] pedidos = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string falsos in pedidos)
{
    if (falsos.StartsWith("B"))
    {
        Console.WriteLine(falsos);
    }
}
    Console.ReadLine();
