// 1 - den 100 - e qeder olan ededlerin  cemini tapan algoritm
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


// 1 - den 100 - e qeder olan ededlerin cemini tapan algoritm
int c = 0;
int d = 100;
int total = 0;
while (c <= d)
{
    total += c;
    c++;
}
Console.WriteLine(total);

// 1 - den 100 - e qeder olan ededlerin cemini tapan alqoritm
int g = 0;
int h = 100;
int tot = 0;
do { 
    tot += g;
    g++;
} while (g <= h);
Console.WriteLine(tot);