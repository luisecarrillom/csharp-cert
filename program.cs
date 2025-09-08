// Print "Hello World!" and move to a new line
Console.WriteLine("Hello World!");
// Print a second message and move to a new line
Console.WriteLine("This is the second line");
// Print a third message and move to a new line
Console.WriteLine("This is the Third Line");
// Print "Congratulations!" but stay on the same line
Console.Write("Congratulations!");
// Print a space without moving to a new line
Console.Write(" ");
// Print another message on the same line as "Congratulations!"
Console.Write("You wrote your first lines of code.");

// Exercise: Print literal values

// Print a single char literal
Console.WriteLine('b');

// This would fail: too many characters in a char literal
// Console.WriteLine('Hello World!');

// Print an int literal (whole number)
Console.WriteLine(123);

// Print a float literal (use suffix F)
Console.WriteLine(0.25F);

// Print a double literal (default for decimals)
Console.WriteLine(2.625);

// Print a decimal literal (use suffix m)
Console.WriteLine(12.39816m);

// Print bool literals
Console.WriteLine(true);
Console.WriteLine(false);

// Compare strings vs other types (same output, different types)
// Print "123" as a string
Console.WriteLine("123");
// Print 123 as an int
Console.WriteLine(123);
// Print "true" as a string
Console.WriteLine("true");
// Print true as a bool
Console.WriteLine(true);

// Declare variables 

// A variable for a name (text) 
string firstName;

// A variable for one character (like A, B, or C) 
char userOption;

// A variable for a game score (whole number) 
int gameScore;

// A variable for a precise number
decimal particlesPerMillion;

// A variable for true/false values
bool processedCustomer;

// Show a message
Console.WriteLine("Variables were declared correctly.");

// Implicitly typed local variables

// The compiler infers the type based on the initial value
var message = "Hello world!";
var temperature = 36.6;    // double
var isActive = true;       // bool
var score = 150;           // int

// Print values to confirm types
Console.WriteLine(message);
Console.WriteLine(temperature);
Console.WriteLine(isActive);
Console.WriteLine(score);

// Exercise: String combination using escape sequences

// Print a message with a quoted customer name and a new line at the end
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");

// Print invoice numbers with tabs for alignment
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");

// Print a blank line, then show output directory label
Console.WriteLine("\nOutput Directory:\t");

// Print the path using escaped backslashes
Console.Write(@"c:\invoices");

// Exercise: Using Unicode escape characters

// Print instructions in Japanese using Unicode escapes
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");

// Print the user command using a verbatim string literal (@)
Console.WriteLine(@"c:\invoices\app.exe -j");

// Exercise: String interpolation

// Combine a string literal and a variable using interpolation
// Use different variable names to avoid conflicts with previous code
string firstName2 = "Bob";
string interpMessage = $"Hello {firstName2}!";
Console.WriteLine(interpMessage);

// Use string interpolation with more variables
int version = 11;
string updateText = "Update to Windows";
string updateMessage = $"{updateText} {version}";
Console.WriteLine(updateMessage);

// Avoid intermediate variables by writing directly in Console.WriteLine
Console.WriteLine($"{updateText} {version}!");

// Combine verbatim string literal (@) with interpolation ($)
// Verbatim keeps backslashes; interpolation inserts variable values
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");