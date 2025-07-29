using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public string Numero { get; set; }
        private string _modelo;
        private string _imei;
        private int _memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)

        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;

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