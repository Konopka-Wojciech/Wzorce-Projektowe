namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
           IPizzaBuilder MargharitaBuilder = new MargharitaBuilder();
            IPizzaBuilder SalamiBuilder = new SalamiBuilder();

            Director MargharitaDirector = new Director(MargharitaBuilder);
            Director SalamiDirector = new Director(SalamiBuilder);
            MargharitaDirector.ConstructPizza();
            SalamiDirector.ConstructPizza();
            Pizza margharita = MargharitaBuilder.GetPizza();
            Pizza salami = SalamiBuilder.GetPizza();
            margharita.EatPizza();
            salami.EatPizza();







        }
    }
}
