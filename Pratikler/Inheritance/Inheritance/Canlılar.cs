namespace Inheritance;

public class Canlılar
{
    protected void Beslenme()
    {
        Console.WriteLine("Canlılar beslenir.");
    }

    protected void Solunum()
    {
        Console.WriteLine("Canlılar ssolunum yapar.");
    }

    public void Bosaltim()
    {
        Console.WriteLine("Canlılar boşaltım yapar.");
    }

    public virtual void UyaranlaraTepki()
    {
        Console.WriteLine("Canlılar uyaranlara tepki verir.");
    }
}
