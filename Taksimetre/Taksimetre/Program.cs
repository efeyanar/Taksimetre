Console.WriteLine("---Taksimetre Hesaplama Programı---");

double acilis, kmbasi, indibindi, toplamUcret, yol;
acilis = 24.55;
kmbasi = 17.61;
indibindi = 90;

tepe:
Console.Write("KM cinsinden mesafeyi yazınız : ");
yol = Convert.ToDouble(Console.ReadLine());

toplamUcret = acilis + (kmbasi * yol);

if (yol > 0)
{
    if (toplamUcret <= 90)
    {
        Console.WriteLine("Toplam ücret : " + indibindi + "TL.");
    }
    else if (toplamUcret > 90)
    {
        Console.WriteLine("Toplam Ücret : " + toplamUcret + "TL.");
    }
}
else if (yol <= 0)
{
    Console.WriteLine();
    Console.WriteLine("Lütfen geçerli bir değer giriniz.");
    Console.WriteLine();
    goto tepe;
}



Console.ReadLine();


