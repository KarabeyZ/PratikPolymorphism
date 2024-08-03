using PratikPolymorphism;

Kare kare = new Kare(5,5);
Console.WriteLine("Karenin alanı: " + kare.AlanHesapla());

Dikdörtgen dikdörtgen = new Dikdörtgen(8, 6);
Console.WriteLine("Dikdörtgenin alanı: " + dikdörtgen.AlanHesapla());

DikUcgen dikucgen = new DikUcgen(8, 4);
Console.WriteLine("Diküçgenin alanı: "+ dikucgen.AlanHesapla());