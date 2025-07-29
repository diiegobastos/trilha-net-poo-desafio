using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone

        Console.WriteLine("Smartphone Nokia");
        Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine("\nSmartphone Iphone");
        Smartphone iphone = new Iphone("987654321", "Iphone 16", "98765432109876", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}