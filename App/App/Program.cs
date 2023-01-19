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

Console.WriteLine(1 && 5);
Console.ReadLine();