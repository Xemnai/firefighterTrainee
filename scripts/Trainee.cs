using Godot;
using System;

public class Trainee : Node
{
    private string _lastName;
    private string _firstName;

    public Trainee(string first, string last)
    {
        lastName = last;
        firstName = first;
    }
    public string lastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    public string firstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
}

