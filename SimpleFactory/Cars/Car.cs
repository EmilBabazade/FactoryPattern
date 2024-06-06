namespace SimpleFactory.Cars;
public abstract class Car(string model)
{
    protected string _model = model;
    public string Model { get => _model; }
    public void Shine() => Console.WriteLine("Shininh " + _model);
    public void TestTires() => Console.WriteLine("Testing tires of " + _model);
    public void TestSteering() => Console.WriteLine("Testing steering of " + _model);
    public void SignDocuments() => Console.WriteLine("Signing the documents of " + _model);
}
