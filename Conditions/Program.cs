#region (1 - den 100 - e qeder olan ededlerin  cemini tapan algoritm)

int a = 0;
int b = 100;
int sum = 0;
for (int i = a; i <= b; i++)
{
    sum += i;
}
Console.WriteLine(sum);
#endregion

#region (1 - den 100 - e qeder olan ededlerin cemini tapan algoritm)


int c = 110;
int d = 100;
int total = 0;
while (c <= d)
{
    total += c;
    c++;
}
Console.WriteLine(total);
#endregion

#region (ededin sade ve ya murekkeb olmagini yoxlamag)
int number = 2;
if ((number % 2 == 0 | number % 3 == 0) & number > 3)
{
    Console.WriteLine("Daxil etdiyiniz " + "'" + number + "'" + " ededi murekkebdir!");
}
else
{
    Console.WriteLine("Daxil etdiyiniz " + "'" + number + "'" + " ededi sadedir!");
}
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
int num = 81;
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
int x = 29;
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





//#region ("Salam Dünya" və Ad çapı Tapşırıq: Ekrana "Salam" və istifadəçinin daxil etdiyi adı yazdırın.)
//string helloWorld = "Salam Dunya! ";
//string userName = "Mirhuseyn";
//Console.WriteLine(helloWorld + userName);
//#endregion

//#region (İki ədədin cəmi Tapşırıq: İstifadəçidən iki ədəd alıb cəmini tapın.)
//int ab = 100;
//int ba = 200;
//Console.WriteLine("iki ededinin cemi " + ab + ba);
//#endregion

//#region (Ədədin kvadratı Tapşırıq: Daxil edilən ədədin kvadratını hesablayın.)
//int q = 2;
//int squareNum = q * q;
//Console.WriteLine(q + " ededinin kvadrati " + squareNum);
//#endregion

//#region (Düzbucaqlının sahəsi və perimetri. Tapşırıq: Eni və uzunluğu verilən düzbucaqlının sahəsini və perimetrini tapın.)
//int sideOne = 6;
//int sideSecond = 10;
//int area = sideOne * sideSecond;
//int perimetr = 2 * (sideOne + sideSecond);
//Console.WriteLine("duzbucaqlinin sahesi " + area + ", perimetri ise " + perimetr);
//#endregion

//#region (Qalıqlı bölmə Tapşırıq: İki ədədin bölünməsindən alınan qalığı tapın.)
//int numOne = 5;
//int numSecond = 3;
//int resudue = numOne % numSecond;
//Console.WriteLine("Neticeden qalan qaliq " + resudue);
//#endregion



//#region (Selsi dəyərini Fahrenheit-ə çevirin)
//float celci = 12f;
//float faranheyt = celci * 1.8f + 32;
//Console.WriteLine(faranheyt);
//#endregion

//#region (Ədədin son rəqəmi Tapşırıq: Daxil edilən ədədin son rəqəmini ekrana çıxarın.)
//int oneNum = 230;
//int endNum = oneNum % 10;
//Console.WriteLine("Verilmis ededin son reqemi: " + endNum);
//#endregion

//#region (Artırma əməliyyatı Tapşırıq: Bir ədədi daxil edin və onu 1 vahid artırıb ekrana yazın (Post-increment).)
//int value1 = 14;
//int incrementValue = ++value1;
//Console.WriteLine("ededin bir ustu: " + incrementValue);
//#endregion

//#region (Tək yoxsa Cüt? Tapşırıq: Ədədin tək və ya cüt olmasını yoxlayın.)
//int number = 5;
//if (number % 2 == 0)
//{
//    Console.WriteLine(number + " ededi cutdur");
//}
//else
//    Console.WriteLine(number + " ededi tekdir");
//#endregion

//#region (Mənfi, Müsbət, Sıfır Tapşırıq: Ədədin işarəsini təyin edin.)
//int numberU = -5;
//if (numberU > 0)
//{
//    Console.WriteLine(numberU + " ededi musbetdir: +");
//}
//else if (numberU == 0)
//{
//    Console.WriteLine(" eded 0 a beraberdir");
//}
//else
//    Console.WriteLine(numberU + " ededi menfidir; -");
//#endregion

//#region (Böyük olanı tap Tapşırıq: İki ədəd arasında ən böyüyünü tapın.)
//int one = 20;
//int second = 5;
//int third = 10;
//if (one > second)
//{
//    Console.WriteLine(one + " verilmis ededlerden en boyuyudur");
//}
//else
//    Console.WriteLine(second + " ededi en boyukdur");
//#endregion

//#region (3 ədəd arasında maksimum Tapşırıq: Üç ədəd daxil edilir, ən böyüyünü tapın.)
//if (one > second && one > third)
//{
//    Console.WriteLine(one + " ededi en boyukdur");
//}
//else if (one < second && second > third)
//{
//    Console.WriteLine(second + " ededi en boyukdur");
//}
//else
//    Console.WriteLine(third + " ededi en boyukdur");
//#endregion

//#region (İmtahan nəticəsi Tapşırıq: Bal 50-dən yuxarıdırsa "Keçdi", aşağıdırsa "Kəsildi".)
//int examResult = 40;
//if (examResult > 50)
//{
//    Console.WriteLine("imtahandan kecdiniz");
//}
//else
//    Console.WriteLine("imtahandan kesildiniz");
//#endregion

//#region (Həftənin günləri (Switch) Tapşırıq: 1-7 arası rəqəm daxil edilir, günün adını yazın.)
//int dayOfWeek = 1;
//switch (dayOfWeek)
//{
//    case 1:
//        Console.WriteLine("heftenin birinci gunu");
//        break;
//    case 2:
//        Console.WriteLine("heftenin ikinci gunu");
//        break;
//    case 3:
//        Console.WriteLine("heftenin ucuncu gunu");
//        break;
//    case 4:
//        Console.WriteLine("heftenin dorduncu gunu");
//        break;
//    case 5:
//        Console.WriteLine("heftenin besinci gunu");
//        break;
//    case 6:
//        Console.WriteLine("heftenin altinci gunu");
//        break;
//    case 7:
//        Console.WriteLine("heftenin yeddinci gunu");
//        break;
//}
//#endregion

//#region
//int fizz = 15;
//if (fizz % 3 == 0 | fizz % 5 == 0)
//{
//    Console.WriteLine("FizzBuzz");
//}
//else if (fizz % 3 == 0)
//{
//    Console.WriteLine("Fizz");
//}
//else if (fizz % 5 == 0)
//{
//    Console.WriteLine("Buzz");
//}
//else
//    Console.WriteLine("hec birine bolunmur");


//#endregion






