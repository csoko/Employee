
using System;

// Define the IQuittable interface with a void method called Quit().
public interface IQuittable
{
    void Quit();
}

// Employee class that inherits from the IQuittable interface.
public class Employee : IQuittable
{
    // Implement the Quit() method from the IQuittable interface.
    public void Quit()
    {
        Console.WriteLine("Employee quitting...");
        // Add custom logic here for an employee quitting, such as saving data or performing cleanup tasks.
    }
}

class Program
{
    static void Main()
    {
        // Create an object of type IQuittable using polymorphism.
        IQuittable quittableEmployee = new Employee();

        // Call the Quit() method on the IQuittable object.
        quittableEmployee.Quit();
    }
}
