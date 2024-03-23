namespace Builder
{
    internal class SalamiBuilder: IPizzaBuilder
    {
        private Pizza salami;

        public SalamiBuilder()
        {
            salami = new Pizza();
        }

        public void BuildDough()
        {
            salami.Dough = "Thin";
        }

        public void BuildSauce()
        {
            salami.Sauce = "red";

        }
        public void BuildCheese()
        {
            salami.Cheese.Add("mozarella");
        }
        public void BuildMeat()
        {
            salami.Meat.Add("salami picante");
        }

        public Pizza GetPizza()
        {
            return salami;
        }


    }
}
