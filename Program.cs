using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("9999 9999", "Iphone", "IMEI123", "120gb");
Iphone iphone = new Iphone("88888 88888", "nokia", "IMEI123", "120gb");


// Testando as classes
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("YouTube");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Sportzy");


