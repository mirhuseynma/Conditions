//1 - den 100 - e qeder olan ededlerin  cemini tapan algoritm
using System;
using System.Threading.Channels;
int a = 0;
int b = 100;
int sum = 0;
for (int i = a; i <= b; i++)
{
    sum += i;
}
Console.WriteLine(sum);


//1 - den 100 - e qeder olan ededlerin cemini tapan algoritm
int c = 0;
int d = 100;
int total = 0;
while (c <= d)
{
    total += c;
    c++;
}
Console.WriteLine(total);

//1 - den 100 - e qeder olan ededlerin cemini tapan alqoritm
int g = 0;
int h = 100;
int tot = 0;
do
{
    tot += g;
    g++;
} while (g <= h);
Console.WriteLine(tot);

// ededin sade ve ya murekkeb olmagini yoxlamag
int number = 2;
if ((number % 2 == 0 | number % 3 == 0) & number > 3)
{
    Console.WriteLine("Daxil etdiyiniz " + "'" + number + "'" + " ededi murekkebdir!");
}
else
{
    Console.WriteLine("Daxil etdiyiniz " + "'" + number + "'" + " ededi sadedir!");
}


// verilmis ededin mertebelerini ekrana cap etdirmek
int value = 4545454;
int count = 0;
int cloneval = value;
while(value > 0)
{
    value /= 10;
    count++;
}
Console.WriteLine("Daxil etdiyiniz " + "'" + cloneval + "'"  + " ededi " + count  + " mertebeden ibaretdir");