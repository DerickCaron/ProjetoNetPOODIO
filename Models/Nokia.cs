namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) // Chamada ao construtor da classe base
        {
            // Nenhuma outra inicialização necessária aqui, pois já foi feita pela classe base
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando Aplicativo " + nomeApp + " no Nokia");
        }
    }
}