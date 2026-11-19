List<Contact> contacts = new();

var c = new Contact("Felipe");

contacts.Add(c);

c = new Contact("Cyber Pestana");

contacts.Add(c);

foreach (var item in contacts)
{
    Console.WriteLine(item);
}