namespace _2M_13_SrodkiTransportu
{
    abstract class SrodekTransportu
    {
        public abstract string nazwa { get; protected set; }
    }
    interface IJedz
    {
        void jedz();
    }
    interface IPlyn
    {
        void plyn();
    }
    interface ILec
    {
        void lec();
    }
    abstract class Ladowe : SrodekTransportu, IJedz
    {
        public abstract void jedz();
    }
    abstract class Wodne : SrodekTransportu, IPlyn
    {
        public abstract void plyn();
    }
    abstract class Powietrzne : SrodekTransportu, ILec
    {
        public abstract void lec();
    }
    class Auto : Ladowe
    {
        public override string nazwa { get; protected set; }
        public Auto(string nazwa) => this.nazwa = nazwa;
        public override void jedz()
        {
            Console.WriteLine($"{nazwa} jedzie!");
        }
    }


    class Kajak : Wodne
    {
        public override string nazwa { get; protected set; }
        public Kajak(string nazwa) => this.nazwa = nazwa;
        public override void plyn()
        {
            Console.WriteLine($"{nazwa} plynie!");
        }
    }
    class Samolot : Powietrzne
    {
        public override string nazwa { get; protected set; }
        public Samolot(string nazwa) => this.nazwa = nazwa;
        public override void lec()
        {
            Console.WriteLine($"{nazwa} leci!");
        }
    }
    class Amfibia : Ladowe, IPlyn
    {
        public override string nazwa { get; protected set; }
        public Amfibia(string nazwa) => this.nazwa = nazwa;
        public override void jedz()
        {
            Console.WriteLine($"{nazwa} jedzie!");
        }
        public void plyn()
        {
            Console.WriteLine($"{nazwa} plynie!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kajak k1 = new("Kajak");
            k1.plyn();

        }
    }
}
