namespace Inheritance;

public class Hayvanlar:Canlılar
{
    protected void Adaptasyon()
    {
        Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
    }

    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();
        Console.WriteLine("Hayvanlar temasa tepki verir.");
    }
}

//Inheritance; ":" kalıtım kurma şeklidir. ":" önceki sınıfa kalıtım verilen, sonraki sınıf ise üst sınıftır(miras alınan)
public class Sürüngenler:Hayvanlar
{
    public Sürüngenler()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }
    public void SurunerekHareketEtmek()
    {
        Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
    }
}

public class Kuşlar:Hayvanlar
{
    public Kuşlar()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
        base.UyaranlaraTepki();
    }
    public void Ucmak()
    {
        Console.WriteLine("Kuşlar uçarlar.");
    }
}
