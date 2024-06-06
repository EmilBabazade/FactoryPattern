// Factory using composition
namespace AbstractFactory.Cases;
public abstract class Case(string color)
{
    protected string _color = color;
    public string Color { get => _color; }
}
