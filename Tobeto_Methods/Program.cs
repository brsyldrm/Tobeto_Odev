using Tobeto_Methods;

Product urun1 = new Product();
urun1.Name = "Elma";
urun1.Description = "Amasya elması";
urun1.Price = 15;
Product urun2 = new Product();
urun2.Name = "Karpuz";
urun2.Description = "Diyarbakır Karpuzu";
urun2.Price = 80;


Product[] products = new Product[] {urun1, urun2};

foreach (Product product in products)
{
    Console.WriteLine(urun2.Name);
    Console.WriteLine(urun2.Description);
    Console.WriteLine(urun2.Price);
    Console.WriteLine("----------");
}

Console.WriteLine("------------Merhodlar--------------");

//Encapsulation
SepetManager sepetManager = new SepetManager();
sepetManager.Add(urun1);


sepetManager.Add2("Armut","Yeşil Armut",12,10);
sepetManager.Add2("Elma","Yeşil Elma",12,9);
sepetManager.Add2("Karpuz","Diyarbakır Karpuzu",12,8);