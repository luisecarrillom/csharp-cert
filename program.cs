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

// Exercise: Addition with implicit type conversion

// Add two integers
int firstNumber = 12;
int secondNumber = 7;
// The + operator here is interpreted as numeric addition
Console.WriteLine(firstNumber + secondNumber);  // Output: 19

// Reuse the 'firstName' variable you declared earlier (no redeclaration here)
firstName = "Bob";       // <-- Asignamos la variable ya declarada arriba
int widgetsSold = 7;

// The + operator is interpreted as string concatenation
// C# automatically converts widgetsSold (int) into a string
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");  
// Output: Bob sold 7 widgets.

// Mixing int variable with a literal int inside concatenation
// Notice how the compiler treats everything as a string
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");  
// Output: Bob sold 77 widgets. (7 concatenated with "7" instead of adding)

// Use parentheses to clarify order of operations
// Parentheses force numeric addition before concatenation
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
// Output: Bob sold 14 widgets.

//Basic math operations
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// Declare a variable for temperature in Fahrenheit
int fahrenheit = 94;

// Convert Fahrenheit to Celsius
// Step 1: Subtract 32
// Step 2: Multiply by 5
// Step 3: Divide by 9
double celsius = (fahrenheit - 32) * 5.0 / 9.0;

// Print the result with all decimals
Console.WriteLine("The temperature is " + celsius + " Celsius.");

// Print the result formatted to one decimal place
// Use string interpolation and format specifier F1
Console.WriteLine($"The temperature is {celsius:F1} Celsius.");

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

// Calculate averages
decimal sophiaAvg = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / (decimal)currentAssignments;
decimal nicolasAvg = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / (decimal)currentAssignments;
decimal zahirahAvg = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / (decimal)currentAssignments;
decimal jeongAvg = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / (decimal)currentAssignments;

// Function to determine the letter grade
string GetLetterGrade(decimal average)
{
    if (average >= 90)
        return "A";
    else if (average >= 80)
        return "B";
    else if (average >= 70)
        return "C";
    else if (average >= 60)
        return "D";
    else
        return "F";
}

// Header
Console.WriteLine("Student\t\tGrade");

// Results
Console.WriteLine($"Sophia\t\t{sophiaAvg:F1}\t{GetLetterGrade(sophiaAvg)}");
Console.WriteLine($"Nicolas\t\t{nicolasAvg:F1}\t{GetLetterGrade(nicolasAvg)}");
Console.WriteLine($"Zahirah\t\t{zahirahAvg:F1}\t{GetLetterGrade(zahirahAvg)}");
Console.WriteLine($"Jeong\t\t{jeongAvg:F1}\t{GetLetterGrade(jeongAvg)}");

// ============================================================================
// Store numeric grade values for each course (GPA prep)
// ============================================================================

// Base data for the student and courses
// NOTE: If you already declared these in a previous section, remove or comment
// the lines below to avoid redeclaration errors.
string studentName = "Sophia Johnson";

// Course names and credit hours (credits are integers in this example)
string course1Name = "English 101";        int course1Credit = 3;
string course2Name = "Algebra 101";        int course2Credit = 3;
string course3Name = "Biology 101";        int course3Credit = 4;
string course4Name = "Computer Science I"; int course4Credit = 4;
string course5Name = "Psychology 101";     int course5Credit = 3;

// ---------------------------------------------------------------------------
// Create variables to store numeric equivalents for letter grades
// A = 4 grade points, B = 3 grade points
// (C, D, F omitted for now because they aren't used in this exercise)
// ---------------------------------------------------------------------------
int gradeA = 4;
int gradeB = 3;

// ---------------------------------------------------------------------------
// Map the student's letter grades for each course to their numeric equivalents
// ---------------------------------------------------------------------------
int course1Grade = gradeA; // English 101  -> A
int course2Grade = gradeB; // Algebra 101  -> B
int course3Grade = gradeB; // Biology 101  -> B
int course4Grade = gradeB; // CS I         -> B
int course5Grade = gradeA; // Psychology   -> A

// ---------------------------------------------------------------------------
// Print course name with numeric grade (first pass - without credits)
// Expected output:
//   English 101 4
//   Algebra 101 3
//   Biology 101 3
//   Computer Science I 3
//   Psychology 101 4
// ---------------------------------------------------------------------------
Console.WriteLine($"{course1Name} {course1Grade}");
Console.WriteLine($"{course2Name} {course2Grade}");
Console.WriteLine($"{course3Name} {course3Grade}");
Console.WriteLine($"{course4Name} {course4Grade}");
Console.WriteLine($"{course5Name} {course5Grade}");

// ---------------------------------------------------------------------------
// Print course name, numeric grade, and credit hours (final target format)
// Expected output:
//   English 101 4 3
//   Algebra 101 3 3
//   Biology 101 3 4
//   Computer Science I 3 4
//   Psychology 101 4 3
// ---------------------------------------------------------------------------
Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

// ---------------------------------------------------------------------------
// ---  nested decision  ---
var rnd2 = new Random();
int a = rnd2.Next(1,7), b = rnd2.Next(1,7), c = rnd2.Next(1,7);
int t = a + b + c;
Console.WriteLine($"Dice roll: {a} + {b} + {c} = {t}");

// one bonus only (triples else doubles)
if (a==b || b==c || a==c)
{
    if (a==b && b==c) { Console.WriteLine("Triples! +6"); t += 6; }
    else { Console.WriteLine("Doubles! +2"); t += 2; }
    Console.WriteLine($"Total w/ bonus: {t}");
}

// single prize outcome
if (t >= 16) Console.WriteLine("You win a new car!");
else if (t >= 10) Console.WriteLine("You win a new laptop!");
else if (t == 7) Console.WriteLine("You win a trip for two!");
else Console.WriteLine("You win a kitten!");

// ---------------------------------------------------------------------------
// Array example (declare, read, reassign, count)
// Store three fraudulent order IDs
string[] fraudIds = { "A123", "B456", "C789" };

// Read one element
Console.WriteLine($"First: {fraudIds[0]}");

// Reassign one element
fraudIds[0] = "F000";

// How many items are in the array
Console.WriteLine($"Count: {fraudIds.Length}");

// ---------------------------------------------------------------------------
// --- Inventory with foreach  ---
int[] inventory = { 200, 450, 700, 175, 250 }; // items per warehouse bin
int total = 0, bin = 0;                        // running total and bin counter

foreach (int items in inventory)
{
    total += items;                             // accumulate current bin 
    Console.WriteLine($"Bin {++bin}: {items} (running total: {total})"); // print and advance bin # 
}

Console.WriteLine($"We have {total} items in inventory."); // final total comments

//student names string
string[] studentNamess = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

foreach (string name in studentNamess)
{
    Console.WriteLine($"{name}");

} 

// ===========================================================================
// Updated Student Grading
// ===========================================================================

string[] stuNames = { "Sophia", "Andrew", "Emma", "Logan" };
decimal[] examAvgs = { 92.2m, 89.6m, 85.6m, 91.2m };
int[] extraShown = { 92, 89, 89, 96 };
decimal[] extraSums = { 184m, 89m, 267m, 96m };

Console.WriteLine("\nStudent\t\tExam Score\tOverall Grade\tExtra Credit\n");

for (int i = 0; i < stuNames.Length; i++)
{
    decimal extraPts = (0.1m * extraSums[i]) / 5;
    decimal overall = examAvgs[i] + extraPts;
    string letter = overall >= 93 ? "A" : "A-";

    Console.WriteLine($"{stuNames[i],-15}{examAvgs[i],5:F1}\t\t{overall,5:F2}\t{letter,-2}\t{extraShown[i]} ({extraPts:F2} pts)");
}

// ===========================================================================
// Evaluate Boolean Expressions to Make Decisions
// ===========================================================================
Console.WriteLine("a" == "a");  // true
Console.WriteLine("a" == "A"); // false
Console.WriteLine(1 == 2);  // false

string myValue = "a";
Console.WriteLine(myValue == "a"); // true

// ===========================================================================
// Evaluate Boolean Expressions to Make Decisions 2
// ===========================================================================

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

// =========================================================================
// Using variable scope and logic using Code Blocks in C#
// =========================================================================

bool flag = true;
if (flag)
{
    int value = 10; 
    Console.WriteLine($"Inside the code block: {value}");
}

int employeeLevel = 200;
string employeeName = "John Smith";

string title = ""; 

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}
 
Console.WriteLine($"{employeeName}, {title}");

//for 0 to 3

for (int ii = 0; ii < 4; ii++)
{
    Console.WriteLine(ii);
} 

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);


Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Convert a string to int value

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

// Convert decimal to int

int value3 = (int)1.5m; // casting truncates
Console.WriteLine(value3);

int value4 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value4);