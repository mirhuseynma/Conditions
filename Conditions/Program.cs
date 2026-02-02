//Home Tasks 1-10
#region (1 - den 100 - e qeder olan ededlerin  cemini tapan algoritm)

int a = 0;
int b = 100;
int sum = 0;
for (int i = 1; i <= b; i++)
{
    sum += i;
}
Console.WriteLine(sum);
#endregion

#region (1 - den 100 - e qeder olan ededlerin cemini tapan algoritm)


int c = 110;
int d = 150;
int total = 0;
while (c <= d)
{
    total += c;
    c++;
}
Console.WriteLine(total);
#endregion

#region (1 den n e qeder olan  murekkeb ededleri yoxlamag)
int number = 1;
for(int i = number; i < 100; i++)
    if ((i % 2 == 0 | i % 3 == 0) & i > 3)
    {
        Console.WriteLine(i);
        
    }


#endregion

#region (verilmis ededin sade ve ya murekkeb oldugunu yoxlamag)
int numbera = 7;
if ((numbera % 2 == 0 | numbera % 3 == 0) & numbera > 3)
{
    Console.WriteLine(numbera + " ededi murekkeb ededdir");
}else
    Console.WriteLine(numbera + " ededi sade ededdir");

#endregion

#region (verilmis ededin mertebelerini ekrana cap etdirmek)
int value = 78;
int count = 0;
int cloneval = value;
while (value > 0)
{

    value /= 10;
    count++;
    

}
Console.WriteLine("Daxil etdiyiniz " + "'" + cloneval + "'" + " ededi " + count + " mertebeden ibaretdir");
#endregion

#region (verilmis ededin 2 nin quvveti olub olmamasi)
int num = 16;
int quvvet = 1;
int esas = 2;

while (quvvet < num)
{
    quvvet *= esas;
}
if (quvvet == num)
{
    Console.WriteLine(num + " ededi " + esas + " ededinin quvvetidir");

}
else if (quvvet != num)
    Console.WriteLine(num + " ededi " + esas + " ededinin quvveti deyil");
#endregion

#region (1-dən M-ədək ədədlər içərisində 3-ə bölünən ədədlərin sayını tapan alqoritm)
int m = 19;
int mcount = 0;
for (int i = 1; i <= m; i++)
{
    if (i % 3 == 0)
        mcount++;
}
Console.WriteLine(mcount);

#endregion

#region (Verilmiş n ədədinin bölənlərini tapın.  meselen 6 (1,2,3,6))
int n = 18;
for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        Console.WriteLine(i);
    }
    
}
#endregion

#region (Sizə x və y tam ədədləri verilir. Siz 0 ilə x arasında yerləşən və y-ə tam bölünən ən böyük ədədi tapmalısınız. Əgər belə bir ədəd yoxdursa, ekranda -1 çap olunmalıdır.)
int x = 65;
int y = 30;
int z = 0;

while (x > 0)
{
    
    z = x; 
    if(z%y == 0)
    {
        Console.WriteLine(z);
        break;
    }
    x --;
}
if (z % y != 0)
{
    Console.WriteLine("-1");
}

#endregion

#region (Verilmiş 3 rəqəmli ədədin rəqəmlərinin hasilini tapan alqoritm. Misalçün alqoritmə 231 ədədini daxil etdikdə 2*3*1 in nəticəsini verməlidir.)
int numer = 432;

int hasil = 1;
while (numer > 0)
{

    int arg = numer % 10;
    hasil *= arg;
    numer /= 10;
}
Console.WriteLine(hasil);
#endregion

#region (upermarketdə belə bir aksiya keçirilir: 3 məhsul aldıqda ən ucuz məhsul pulsuz olur.Misalçün 40 , 50 və 20 manatlıq mıəhsullar alsam ümumilikdə 40+50 manat ödənilir.3 Mıhsulun qiyməti verildikdə müştərinin nə qədər ödəməli olduğunu tapan alqoritm)
int firstProduct = 50;
int secondProduct = 40;
int thirdProduct = 100;
if (firstProduct > thirdProduct && secondProduct > thirdProduct)
{
    Console.WriteLine(thirdProduct + " AZN meblegindeki mehsulumuzu pulsuz elde etdiniz. Odemeli olacaginiz mebleg: " + (firstProduct + secondProduct) + " AZN ");
}
else if (secondProduct > firstProduct && thirdProduct > firstProduct)
{
    Console.WriteLine(firstProduct + " AZN meblegindeki mehsulumuzu pulsuz elde etdiniz. Odemeli olacaginiz mebleg: " + (thirdProduct + secondProduct) + " AZN ");
}
else if (thirdProduct > secondProduct && firstProduct > secondProduct)
{
    Console.WriteLine(secondProduct + " AZN meblegindeki mehsulumuzu pulsuz elde etdiniz. Odemeli olacaginiz mebleg: " + (thirdProduct + firstProduct) + " AZN ");
}
#endregion

#region (X, Y, Z  ədədləri verilib. Bu ədədlərin ən kiçiyini tapan alqoritm qurun)
int xOne = 1000;
int yOne = 1500;
int zOne = 999;
if(xOne <= yOne && xOne <= zOne)
{
    Console.WriteLine(xOne + " en kicik ededdir.");
}else if (yOne <= xOne && yOne <= zOne)
{
    Console.WriteLine(yOne + " en kicik ededdir.");
}else if (zOne <= yOne && zOne <= xOne)
{
    Console.WriteLine(zOne + " en kicik ededdir.");
}

#endregion


    
