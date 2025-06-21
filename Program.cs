using System;
using System.Reflection;
using reflection_study.Models;
    
var person = new Person("Alice", 30);

Type personType = typeof(Person);

// List all public properties
Console.WriteLine("Public Properties:");
foreach (var prop in personType.GetProperties())
{
    Console.WriteLine($"- {prop.Name} ({prop.PropertyType.Name})");
}

// List all methods (public and non-public)
Console.WriteLine("\nAll Methods:");
foreach (var method in personType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
{
    Console.WriteLine($"- {method.Name}");
}

// Get and set a private property using reflection
var ageProp = personType.GetProperty("Age", BindingFlags.NonPublic | BindingFlags.Instance);
if (ageProp != null)
{
    Console.WriteLine($"\nOriginal Age (via reflection): {ageProp.GetValue(person)}");
    ageProp.SetValue(person, 35);
    Console.WriteLine($"Updated Age (via reflection): {ageProp.GetValue(person)}");
}

// Invoke a public method
var sayHelloMethod = personType.GetMethod("SayHello");
sayHelloMethod?.Invoke(person, null);
// Invoke a private method
var showAgeMethod = personType.GetMethod("ShowAge", BindingFlags.NonPublic | BindingFlags.Instance);
showAgeMethod?.Invoke(person, null);       
