// See https://aka.ms/new-console-template for more information

// #1 Sting Methods
// String fullName = "Bro Code";
// String phoneNumber = "598-91-10-07";
// String forTrime = "                Bro Code                  ";

// fullName = fullName.ToUpper();
// fullName = fullName.ToLower();
// Console.WriteLine(fullName);
// phoneNumber = phoneNumber.Replace("-","");

// String username = fullName.Insert(0, "Mr");
// Console.WriteLine(username);

// forTrime = forTrime.Trim();
// Console.WriteLine(phoneNumber + " " + forTrime + " " + username);

// Console.WriteLine(fullName.Length);

// String firstName = fullName.Substring(0, 3);
// String lastName = fullName.Substring(4, 4);

// Console.WriteLine("First name : " + firstName);
// Console.WriteLine("Last name : " + lastName);


// #2 if Statement

Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if(age > 18) {
    Console.WriteLine("You are signed up!");
}else { 
    Console.WriteLine("You are " + age);
}
