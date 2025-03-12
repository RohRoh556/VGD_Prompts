string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
// I learned how to string values together 
