#region (1 - den 100 - e qeder olan ededlerin  cemini tapan algoritm)

//int a = 0;
//int b = 100;
//int sum = 0;
//for (int i = a; i <= b; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);
#endregion

#region (1 - den 100 - e qeder olan ededlerin cemini tapan algoritm)
//int c = 0;
//int d = 100;
//int total = 0;
//while (c <= d)
//{
//    total += c;
//    c++;
//}
//Console.WriteLine(total);
#endregion

#region (1 - den 100 - e qeder olan ededlerin cemini tapan alqoritm)
//int g = 0;
//int h = 100;
//int tot = 0;
//do
//{
//    tot += g;
//    g++;
//} while (g <= h);
//Console.WriteLine(tot);
#endregion

#region (ededin sade ve ya murekkeb olmagini yoxlamag)
//int number = 2;
//if ((number % 2 == 0 | number % 3 == 0) & number > 3)
//{
//    Console.WriteLine("Daxil etdiyiniz " + "'" + number + "'" + " ededi murekkebdir!");
//}
//else
//{
//    Console.WriteLine("Daxil etdiyiniz " + "'" + number + "'" + " ededi sadedir!");
//}
#endregion

#region (verilmis ededin mertebelerini ekrana cap etdirmek)
//int value = -458;
//int count = 0;
//int cloneval = value;
//while (value > 0)
//{

//    value /= 10;
//    count++;

//}
//Console.WriteLine("Daxil etdiyiniz " + "'" + cloneval + "'" + " ededi " + count + " mertebeden ibaretdir");
#endregion

#region (verilmis ededin mertebelerini ekrana yazdir)
//int value = -13;
//int count = 0;
//int cloneval = value;

//if (value > 0)
//{
//    while (value > 0)
//    {
//        value /= 10;
//        count++;
//    }
//    Console.WriteLine("Daxil etdiyiniz " + "'" + cloneval + "'" + " ededi " + count + " mertebeden ibaretdir");
//}
//else
//    Console.WriteLine("Sizin daxil etdiyiniz eded: " + "'" + cloneval + "'" + " Tekrar 0 dan boyuk eded daxil edin!");
#endregion


// "Salam Dünya" və Ad çapı Tapşırıq: Ekrana "Salam" və istifadəçinin daxil etdiyi adı yazdırın.
string helloWorld = "Salam Dunya! ";
string userName = "Mirhuseyn";
Console.WriteLine(helloWorld + userName);

// İki ədədin cəmi Tapşırıq: İstifadəçidən iki ədəd alıb cəmini tapın.
int a = 100;
int b = 200;
int sum = a + b;
Console.WriteLine("iki ededinin cemi " + sum);

// Ədədin kvadratı Tapşırıq: Daxil edilən ədədin kvadratını hesablayın.
int c = 2;
int squareNum = c * c;
Console.WriteLine(c + " ededinin kvadrati " +squareNum);

// Düzbucaqlının sahəsi və perimetri. Tapşırıq: Eni və uzunluğu verilən düzbucaqlının sahəsini və perimetrini tapın.
int sideOne = 6;
int sideSecond = 10;
int area = sideOne * sideSecond;
int perimetr = 2 * (sideOne + sideSecond);
Console.WriteLine("duzbucaqlinin sahesi " + area + ", perimetri ise " + perimetr);

// Qalıqlı bölmə Tapşırıq: İki ədədin bölünməsindən alınan qalığı tapın.
int numOne = 5;
int numSecond = 3;
int resudue = numOne % numSecond;
Console.WriteLine("Neticeden qalan qaliq " +resudue);

//// Orta yaş hesablama Tapşırıq: tələbəlerin yaşını alıb ortalamasını tapın.
////int ages = Convert.ToInt32(Console.ReadLine());
//int students = 5;
//int numOfStudents = 0;
//for (int i = students; i >= numOfStudents; i++)
//{

//    numOfStudents += i;
//}
//Console.WriteLine(numOfStudents);

// Selsi dəyərini Fahrenheit-ə çevirin
float celci = 12f;
float faranheyt = celci * 1.8f + 32;
Console.WriteLine(faranheyt);

// Ədədin son rəqəmi Tapşırıq: Daxil edilən ədədin son rəqəmini ekrana çıxarın.
int oneNum = 230;
int endNum = oneNum % 10;
Console.WriteLine("Verilmis ededin son reqemi: " + endNum);

// Artırma əməliyyatı Tapşırıq: Bir ədədi daxil edin və onu 1 vahid artırıb ekrana yazın (Post-increment).
int value = 14;
int incrementValue = ++value;
Console.WriteLine("ededin bir ustu: " + incrementValue);

// Tək yoxsa Cüt? Tapşırıq: Ədədin tək və ya cüt olmasını yoxlayın.
int number = 5;
if(number % 2 == 0)
{
    Console.WriteLine(number + " ededi cutdur");
}else
    Console.WriteLine(number + " ededi tekdir");

// Mənfi, Müsbət, Sıfır Tapşırıq: Ədədin işarəsini təyin edin.
int numberU = -5;
if(numberU > 0)
{
    Console.WriteLine(numberU + " ededi musbetdir: +");
}else if(numberU == 0)
{
    Console.WriteLine(" eded 0 a beraberdir");
}else
    Console.WriteLine(numberU + " ededi menfidir; -");

// Böyük olanı tap Tapşırıq: İki ədəd arasında ən böyüyünü tapın.
int one = 20;
int second = 5;
int third = 10;
if (one > second)
{
    Console.WriteLine(one + " verilmis ededlerden en boyuyudur");
}else
    Console.WriteLine(second + " ededi en boyukdur");

// 3 ədəd arasında maksimum Tapşırıq: Üç ədəd daxil edilir, ən böyüyünü tapın.
if (one > second && one > third)
{
    Console.WriteLine(one + " ededi en boyukdur");
}else if (one < second && second > third)
{
    Console.WriteLine(second + " ededi en boyukdur");
}else
    Console.WriteLine(third + " ededi en boyukdur");

// İmtahan nəticəsi Tapşırıq: Bal 50-dən yuxarıdırsa "Keçdi", aşağıdırsa "Kəsildi".
int examResult = 40;
if(examResult > 50)
{
    Console.WriteLine("imtahandan kecdiniz");
}else
    Console.WriteLine("imtahandan kesildiniz");

// Həftənin günləri (Switch) Tapşırıq: 1-7 arası rəqəm daxil edilir, günün adını yazın.
int dayOfWeek = 1;
switch (dayOfWeek )
{
    case 1:
        Console.WriteLine("heftenin birinci gunu");
        break;
    case 2:
        Console.WriteLine("heftenin ikinci gunu");
        break;
    case 3:
        Console.WriteLine("heftenin ucuncu gunu");
        break;
    case 4:
        Console.WriteLine("heftenin dorduncu gunu");
        break;
    case 5:
        Console.WriteLine("heftenin besinci gunu");
        break;
    case 6:
        Console.WriteLine("heftenin altinci gunu");
        break;
    case 7:
        Console.WriteLine("heftenin yeddinci gunu");
        break;
}


int fizz = 15;
if (fizz % 3 == 0 | fizz % 5 == 0)
{
    Console.WriteLine( "FizzBuzz");
}else if (fizz % 3 == 0)
{
    Console.WriteLine("Fizz");
}else if (fizz % 5 == 0)
{
    Console.WriteLine("Buzz");
}else
    Console.WriteLine("hec birine bolunmur");


