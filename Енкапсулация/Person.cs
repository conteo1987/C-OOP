using System;

public class Person

{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }



    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException($"{nameof(this.FirstName)} cannot be less than 3 symbols");
            }
            this.firstName = value;
        }

    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException($"{nameof(this.LastName)} cannot be less than 3 symbols");
            }
            this.lastName = value;
        }

    }


    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException($"{nameof(this.Age)} must not be zero or negative");
            }
            this.age = value;
        }
    }

    public double Salary
    {
        get { return this.salary; }
        set
        {
            if (value < 460)
            {
                throw new ArgumentException($"{nameof(this.Salary)} cannot be less than 460 leva");
            }
            this.salary = value;
        }
    }
    public void IncreaseSalary(double bonus)
    {
        if (this.Age < 30)
        {
            this.salary += this.salary * bonus / 200;
        }
        else
        {
            this.salary += this.salary * bonus / 100;
        }
    }
    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
    }
}