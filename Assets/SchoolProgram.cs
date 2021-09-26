using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolProgram : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        // this creates a reference to a calc object that is null, the reference is named calcObject
        Calculator calcObject = new Calculator();
        // calcObject.HelloWorld();

        Debug.Log(calcObject.Multiply(15, 12));
        Debug.Log(calcObject.Add(15, 12));

        ///////////////////////////////

        Student joe = new Student("Joe");
        Student kim = new Student("Kim");
        Student tim = new Student();

        joe.SayName();
        kim.SayName();
        tim.SayName();



    }


}

public class Calculator
{
    // public int because this method returns an int and not a void, and number1 and number2 are the parameters
    // and they are what this function needs to do his job
    public int Multiply(int number1, int number2)
    {
        return (number1 * number2);

    }

    public int Add(int number1, int number2)
    {
        return number1 + number2;
    }


}

public class Student
{
    private string name;


    // Constructor that requires a string _name to be given, and it sets our name to that string

    public Student(string _name)
    {
        name = _name;
    }

    // Constructor that requires no extra data, and initializes all fields to defaults.
    public Student()
    {
        name = "";
    }

    public void SayName()
    {
        Debug.Log(name);
    }

}

