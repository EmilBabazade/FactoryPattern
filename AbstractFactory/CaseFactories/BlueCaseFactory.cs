// Factory using composition
using AbstractFactory.Cases;

public class BlueCaseFactory : ICaseFactory
{
    public Case MakeCase() => new BlueCase();
}
