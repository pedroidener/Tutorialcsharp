// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("You wrote your first lines of code.");
Console.WriteLine("Congratulations!");
Console.Write("You wrote your first lines of code.");

Console.WriteLine("");

Console.WriteLine('b');
Console.WriteLine(2);
Console.WriteLine(3.4F);
Console.WriteLine(3.4);
Console.WriteLine(2.512314m);
Console.WriteLine(false);

string firstName = "Bob";
int messages = 3;
float temperature = 34.4f;

Console.WriteLine("");

Console.WriteLine("Hello, " + firstName + "! You have " + messages + " messages in your inbox. The temperature is " + temperature + " celsius.");


Console.WriteLine("");

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

string path_en = $@"c:\Exercise\{projectName}\data.txt";
string path_ru = $@"c:\Exercise\{projectName}\ru-RU\data.txt";

Console.WriteLine($"View English output:\n\t{path_en}\n\n");

Console.WriteLine($"{russianMessage}:\n\t{path_ru}\n\n");

Console.WriteLine("");

int fahrenheit = 94;

decimal celsius = (fahrenheit - 32m) * 5m / 9m;

Console.WriteLine($"The temperature is {celsius} Celsius.");
