namespace MethodFactory.Phones;
public abstract class Phone
{
    protected abstract ICase BuildCase();

    protected Phone()
    {
        var phoneCase = BuildCase();
        Console.WriteLine($"A phone with a {phoneCase.Color} case");
    }
}

public class BluePhone : Phone
{
    protected override ICase BuildCase()
    {
        return new BlueCase();
    }
}

public class RedPhone : Phone
{
    protected override ICase BuildCase()
    {
        return new RedCase();
    }
}
