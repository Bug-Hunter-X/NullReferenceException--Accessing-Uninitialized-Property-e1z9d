public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize MyProperty

    public void MyMethod()
    {
        int value = this.MyProperty; // Now safe to access
    }
}