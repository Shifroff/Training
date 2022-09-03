// Salutation
Console.Write("Enter Username:");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
  Console.Write("Hooray, it's Masha!");  
}
else
{
    Console.Write("Hello,");
    Console.WriteLine(username);
}
