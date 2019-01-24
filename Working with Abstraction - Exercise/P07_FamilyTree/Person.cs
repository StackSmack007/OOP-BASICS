using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private string birthday;
    private List<Person> parents;
    private List<Person> children;

    public Person()
    {
        this.Children = new List<Person>();
        this.Parents = new List<Person>();
    }
    public Person(string name) : this()
    {
        this.Name = name;
    }
    public Person(string name, string birthDate) : this(name)
    {
        this.Birthday = birthDate;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Birthday
    {
        get { return birthday; }
        set { birthday = value; }
    }

    public List<Person> Parents
    {
        get { return this.parents; }
        set { parents = value; }
    }

    public List<Person> Children
    {
        get { return this.children; }
        set { children = value; }
    }

    public override string ToString()
    {
        return $"{ this.Name} { this.Birthday}";
    }

    public void PrintData()
    {
        Console.WriteLine(this);
        Console.WriteLine("Parents:");
        PrintList(Parents);
        Console.WriteLine("Children:");
        PrintList(Children);
    }
    public void PrintList(List<Person> persons)
    {
        foreach (var person in persons)
        {
            Console.WriteLine(person);
        }
    }
}