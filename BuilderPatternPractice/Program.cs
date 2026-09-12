using BuilderPatternPractice;
using System;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }
    public decimal Wallet { get; set; }

    private Student(StudentBuilder builder)
    {
        Name = builder.Name;
        Age = builder.Age;
        Address = builder.Address;
        Wallet = builder.Wallet;
    }

    public class StudentBuilder
    {
        internal string Name { get; }
        internal int Age { get; private set; }
        internal string? Address { get; private set; }  
        internal decimal Wallet { get; private set; }

        public StudentBuilder(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }

            Name = name;
        }

        //Optional Values

        public StudentBuilder SetAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "Age cannot be negative.");
            }
            Age = age;
            return this;
        }

        public StudentBuilder SetAddress(string address)
        {
            Address = address;
            return this;
        }

        public StudentBuilder SetWallet(decimal wallet)
        {
            Wallet = wallet;
            return this;
        }

        public Student Build()
        {
            return new Student(this);
        }   
    }

}

class Program
{
    static void Main(string[] args)
    {
        var student = new Student.StudentBuilder("John Doe")
            .SetAge(20)
            .SetAddress("123 Main St")
            .SetWallet(100.50m)
            .Build();
        Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Address: {student.Address}, Wallet: {student.Wallet}");

        var notificationRequest = new InspectionNotificationRequest.Builder("Inspection Alert", "Your inspection is scheduled for tomorrow.", Guid.NewGuid())
                .SetTopic("Safety Inspection")
                .SetCardNumber("1234-5678-9012-3456")
                .SetIsImportant(true)
                .Build();
        Console.WriteLine($"Title: {notificationRequest.Title}");
        Console.WriteLine($"Message: {notificationRequest.Message}");
        Console.WriteLine($"Inspector ID: {notificationRequest.InspectorId}");
        Console.WriteLine($"Topic: {notificationRequest.Topic}");
        Console.WriteLine($"Card Number: {notificationRequest.CardNumber}");
        Console.WriteLine($"Is Important: {notificationRequest.IsImpotant}");
    }
}

