using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1234", modelo: "1", imei: "34124512", memoria: 12312);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "4567", modelo: "2", imei: "56645765", memoria: 234646);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");