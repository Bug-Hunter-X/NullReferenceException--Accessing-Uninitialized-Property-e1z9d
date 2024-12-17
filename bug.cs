public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized yet.
        int value = this.MyProperty; // Bug: Potential NullReferenceException
    }
}