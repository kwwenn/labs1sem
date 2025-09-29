#include <stdio.h>
#include <math.h>
#include <locale.h>
// ЗАДАНИЕ:
// 1.Даны два круга с общим центром и радиусами ( R_1 ) и ( R_2 ) (( R_1 > R_2 )).
// Найти площадь ( S ) кольца, внешний радиус которого равен ( R_1 ), а внутренний радиус равен ( R_2 ).
// 2. Дана масса ( M ) в килограммах. Перевести её в фунты.
// 3. Дано трёхзначное число. Найти сумму его цифр.
// 4. Найти значения двух заданных функций в заданной точке ( x ).
int task1()
{
    int r1, r2;
    double s1, s2, s3;
    printf("input first radius: ");
    scanf("%d", &r1);
    printf("input second radius: ");
    scanf("%d", &r2);
    s1 = 3.14 * r1 * r1;
    s2 = 3.14 * r2 * r2;
    s3 = s1 - s2;
    printf("ring area: %lf\n", s3);
}

int task2()
{
        int mass;
        double funt;
        printf("input mass: ");
        scanf("%d", &mass);
        funt = mass * 2.205;
        printf("funts: %lf\n", funt);
}

int task3() 
{

        int a, ff, sf, tf, sum;
        printf("input three digit number: ");
        scanf("%d", &a);
        ff = a / 100;
        sf = (a / 10) % 10;
        tf = a % 10;
        sum = ff + sf + tf;
        printf("sum: %d\n", sum);
}

int task4() 
{
        double x, f1, f2;
        printf("input x: ");
        scanf("%lf", &x);
        f1 = 0.25*log((1+x)/(1-x))+0.5*atan(x);
        f2 = (1+x)*exp(-x);
        printf("f1: %lf\n", f1);
        printf("f2: %lf\n", f2);
    }

    int main() 
    {
        printf("1:\n");
        task1();
        printf("2:\n ");
        task2();
        printf("3:\n ");
        task3();
        printf("4: ");
        task4();
        _getch();
        return 0;
    }


