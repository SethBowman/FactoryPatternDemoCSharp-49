namespace FactoryPatternDemoCSharp_49;

public class GooglePhone : IMobilePhone
{
    public void Call()
    {
        Console.WriteLine("Calling with a Google phone..");
    }

    public void Text()
    {
        Console.WriteLine("Texting with a Google phone..");
    }
}