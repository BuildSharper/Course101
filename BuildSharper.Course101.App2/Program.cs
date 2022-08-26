bool enrolled = true;
string firstName = "John";
string lastName = "Smith";
char sex = 'M';
int age = 21;
double gpa = 3.7;
DateTime birthday = DateTime.Parse("3/11/2001");

Console.WriteLine($"Student: {lastName}, {firstName}");
Console.WriteLine($"Enrolled: {enrolled}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Sex: {sex}");
Console.WriteLine($"DOB: {birthday}");
Console.WriteLine($"GPA: {gpa}");

Console.WriteLine("Press any key to continue.");
Console.ReadLine();