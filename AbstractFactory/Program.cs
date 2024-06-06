// Factory using composition
var bluePhone = new Phone(new BlueCaseFactory());
var redPhone = new Phone(new RedCaseFactory());
var greenPhone = new Phone(new GreenCaseFactory());
var phone = new Phone(new NoCaseFactory());

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