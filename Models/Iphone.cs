namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) // Chamada ao construtor da classe base
        {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando Aplicativo " + nomeApp + " no Nokia");
        }
    }
}