namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        { 

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instanlando o app {nomeApp} no Nokia!");
        }
    }
}