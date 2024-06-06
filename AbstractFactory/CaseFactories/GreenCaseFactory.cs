// Factory using composition
using AbstractFactory.Cases;

public class GreenCaseFactory : ICaseFactory
{
    public Case MakeCase() => new GreenCase();
}
