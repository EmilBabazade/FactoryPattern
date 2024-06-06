// Factory using composition

var bluePhone = new Phone(new BlueCaseFactory());
var redPhone = new Phone(new RedCaseFactory());
var greenPhone = new Phone(new GreenCaseFactory());
var phone = new Phone(new NoCaseFactory());

public abstract class Case(string color)
{
    protected string _color = color;
    public string Color { get => _color; }
}

public class BlueCase : Case
{
    public BlueCase() : base("blue")
    {
    }
}

public class RedCase : Case
{
    public RedCase() : base("red")
    {
    }
}

public class GreenCase : Case
{
    public GreenCase() : base("green")
    {
    }
}

public class NoCase : Case
{
    public NoCase() : base(string.Empty) 
    { 
    }
}

public class Phone
{
    private ICaseFactory _caseFactory;

    public Phone(ICaseFactory caseFactory)
    {
        _caseFactory = caseFactory;
        var phoneCase = _caseFactory.MakeCase();
        if(phoneCase.Color != string.Empty)
        {
            Console.WriteLine($"I am a phone disguised as a {phoneCase.Color} phone");
        } else
        {
            Console.WriteLine($"I am a phone and I don't disguise because I am a real manly phone");
        }
        //build other stuff....
    }
}
public interface ICaseFactory
{
    public Case MakeCase();
}

public class RedCaseFactory : ICaseFactory
{
    public Case MakeCase() => new RedCase();
}

public class BlueCaseFactory : ICaseFactory
{
    public Case MakeCase() => new BlueCase();
}

public class GreenCaseFactory : ICaseFactory
{
    public Case MakeCase() => new GreenCase();
}

public class NoCaseFactory : ICaseFactory
{
    public Case MakeCase() => new NoCase();
}