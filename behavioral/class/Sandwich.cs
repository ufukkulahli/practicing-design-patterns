namespace PracticingDesignPatterns.Behavioral.Class.Template
{
    public abstract class Sandwich
    {
        protected Sandwich LayBread()
        {
            Console.WriteLine("Laying down the bread");
            return this;
        }

        protected Sandwich AddLettuce()
        {
            Console.WriteLine("Adding some lettuce");
            return this;
        }

        protected Sandwich AddSauces()
        {
            Console.WriteLine("Adding some sauces");
            return this;
        }

        protected abstract Sandwich AddMainIngredient();

        public Sandwich Make()
        {
            Console.WriteLine("Making sandwich is in progress...");
            return this
                    .LayBread()
                    .AddLettuce()
                    .AddMainIngredient()
                    .AddSauces();
        }
    }
}