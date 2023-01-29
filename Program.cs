using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone ios = new Iphone("62 9 82606375","Iphone 8 Plus","8762468576521357",64);
Nokia nokia = new Nokia("62 9 82606375","Windows Phone","1135486524961321",32);

nokia.InstalarAplicativo("Watsapp");
nokia.Ligar();
nokia.ReceberLigacao();

ios.InstalarAplicativo("Watsapp");
ios.Ligar();
ios.ReceberLigacao();