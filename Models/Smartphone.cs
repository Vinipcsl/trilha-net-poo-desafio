namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
      
        private string Modelo;
        public string modelo {
    get { return Modelo; }
    set { Modelo = value; }
        }
        private string IMEI;
        public string imei { 
            get{ return IMEI;} 
            set{IMEI = value; }
        }
        private int Memoria;
        public int memoria{
    get { return Memoria; }
    set { Memoria = value; }
        }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
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
