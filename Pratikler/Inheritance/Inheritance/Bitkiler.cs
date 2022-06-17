namespace Inheritance;

public class Bitkiler:Canlılar
{
    protected void FotosentezYapmak()
    {
        Console.WriteLine("Bitkiler fotosentez yaparlar.");
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
