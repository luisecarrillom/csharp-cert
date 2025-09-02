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