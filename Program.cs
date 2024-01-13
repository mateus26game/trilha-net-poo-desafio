using System;
using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone


class Program
{
    static void Main()
    {
        // Cria instâncias de Nokia
        Console.WriteLine("Smartphone Nokia:");
        Nokia nokia = new Nokia(numero: "99599443", modelo: "Nokia x", imei: "1357924680", memoria: 256);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");


        Console.WriteLine("\n");
        // Cria instâncias do Iphone
        
        Console.WriteLine("Smartphone Iphone:");
        Iphone iphone = new Iphone(numero: "992622006", modelo: "Iphone U", imei: "9753108642", memoria: 512);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");


        // Aguarda a entrada do usuário antes de encerrar o programa
        Console.ReadLine();
        
    }
}