﻿using System;
using System.Linq;
using System.Text;

public class Person
{
    protected string name;
    protected int age;

   

    public virtual string Name
    {
        get
        {
            return this.name;
        }
       private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Name’s length should not be less than 3 symbols!");
            }
            this.name = value;
        }
    }

    public virtual int Age
    {
        get { return this.age; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }

            this.age = value;
        }

    }

    public override string ToString()
    {
        return $"Name: {this.name}, Age: {this.age}";
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}