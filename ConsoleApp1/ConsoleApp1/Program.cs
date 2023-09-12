using System;

class MyClass
{
    // Static property
    public static int StaticProperty { get; set; }

    // Static constructor
    static MyClass()
    {
        Console.WriteLine("Static constructor called.");
        StaticProperty = 42;
    }
    // Static function
    public static void StaticFunction()
    {
        Console.WriteLine("Static function called.");
    }
}

class Program
{
    static void Main()
    {
        // Access the static property
        Console.WriteLine("StaticProperty: " + MyClass.StaticProperty);

        // Call the static function
        MyClass.StaticFunction();
        Console.Read();
    }
}
