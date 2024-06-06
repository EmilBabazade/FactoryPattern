// Factory using composition
using AbstractFactory.Cases;

public class RedCaseFactory : ICaseFactory
{
    public Case MakeCase() => new RedCase();
}
