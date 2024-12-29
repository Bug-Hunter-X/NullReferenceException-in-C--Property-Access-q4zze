public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Assigning a default value to MyProperty
        MyProperty = 0; 
        Console.WriteLine(MyProperty);
    }
    public ExampleClass() { //constructor to assign initial value
        MyProperty = 0;
    }
} 