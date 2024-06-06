// Factory using composition
using AbstractFactory.Cases;

public class NoCaseFactory : ICaseFactory
{
    public Case MakeCase() => new NoCase();
}