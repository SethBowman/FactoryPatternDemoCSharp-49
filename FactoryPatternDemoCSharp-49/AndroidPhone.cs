namespace FactoryPatternDemoCSharp_49;

public class AndroidPhone : IMobilePhone
{
    public void Call()
    {
        Console.WriteLine("Calling with an Android phone..");
    }

    public void Text()
    {
        Console.WriteLine("Texting with an Android phone..");
    }
}