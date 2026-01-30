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

#region (1 - den 100 - e qeder olan ededlerin cemini tapan alqoritm)
int g = 0;
int h = 100;
int tot = 0;
do
{
    tot += g;
    g++;
} while (g <= h);
Console.WriteLine(tot);
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
int value = -13;
int count = 0;
int cloneval = value;

if (value > 0)
{
    while (value > 0)
    {
        value /= 10;
        count++;
    }
    Console.WriteLine("Daxil etdiyiniz " + "'" + cloneval + "'" + " ededi " + count + " mertebeden ibaretdir");
}
else
    Console.WriteLine("Sizin daxil etdiyiniz eded: " + "'" + cloneval + "'" + " Tekrar 0 dan boyuk eded daxil edin!");
#endregion