namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
         //Implementa as propriedades faltantes de acordo com o diagrama
        private string Numero { get; set; }
        private string Modelo { get; set;}
        private string Imei { get; set; }
        private string Memoria { get; set; }

       
        //Passa os parâmetros do construtor para as propriedades
        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}