// See https://aka.ms/new-console-template for more information

// #1 Sting Methods
// String fullName = "Vakho Cloud";
// String phoneNumber = "598-00-00-00";
// String forTrime = "                Vakho Cloud                  ";

// fullName = fullName.ToUpper();
// fullName = fullName.ToLower();
// Console.WriteLine(fullName);
// phoneNumber = phoneNumber.Replace("-","");

// String username = fullName.Insert(0, "Mr");
// Console.WriteLine(username);

// forTrime = forTrime.Trim();
// Console.WriteLine(phoneNumber + " " + forTrime + " " + username);

// Console.WriteLine(fullName.Length);

// String firstName = fullName.Substring(0, 5);
// String lastName = fullName.Substring(6, 5);

// Console.WriteLine("First name : " + firstName);
// Console.WriteLine("Last name : " + lastName);


// #2 if Statement

Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if(age > 18) 
{
    Console.WriteLine("You are signed up!");
}
else if(age < 0)
{
    Console.WriteLine("You haven't been born yeat");
}
else    
{ 
    Console.WriteLine("You are " + age);
}
