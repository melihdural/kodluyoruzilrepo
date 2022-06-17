namespace Inheritance;

public class Bitkiler:Canlılar
{
    protected void FotosentezYapmak()
    {
        Console.WriteLine("Bitkiler fotosentez yaparlar.");
    }

   //UyaranalaraTepki metodunu canlılardan bir kere çek ve çalıştır.
    public override void UyaranlaraTepki()
    {
        //base.UyaranlaraTepki();
        // Bu kod açılmazsa Canlılar içindeki UyaranlaraTepki() metodu çalışmaz.
        Console.WriteLine("Bitkiler güneşe tepki verir.");
    }
}

public class TohumluBitkiler:Bitkiler
{
    public TohumluBitkiler()
    {
        base.FotosentezYapmak();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
        base.UyaranlaraTepki();
    }
    public void TohumlaCogalma()
    {
        Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }
}
