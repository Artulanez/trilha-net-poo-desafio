using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia!");

Smartphone nokia = new Nokia("123456789", "Modelo 1", "11111111xxxx", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone!");
Smartphone iphone = new Iphone("987654321", "Modelo 2", "2222222yyyy", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegran");
