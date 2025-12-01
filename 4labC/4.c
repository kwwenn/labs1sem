#include <stdio.h>
#include <math.h>

int F(int n) {
    if (n < 2) {
        return 1;
    }
    else if (n % 2 == 0) {
        return F(n/2) + 1;
    }
    else {
        return F(n - 3) + 3;
    }
}

int task11() {
    int count = 0;
    for (int n = 1; n <= 100000; n++) {
        if (F(n) == 16) {
            count++;
        }
    }
    return count;
}

int task12(int x) {
    int f = F(x);
    int max_even = -1;
    while (f > 0) {
        int digit = f % 10;
        if (digit % 2 == 0 && digit > max_even) {
            max_even = digit;
        }
        f = f / 10;
    }
    return max_even;
}

double series_recursive(int N, double x) {
    if (N < 1) return 0;

    double a_n = 1.5 * x * x; 
    double sum = a_n;
    
    for (int n = 2; n <= N; n++) {
        
        double numerator = (2.0 * n + 1.0);
        double denominator = (2.0 * n - 1.0) * (2.0 * n);
        
        a_n = a_n * x * x * (numerator / denominator);
        sum += a_n;
    }
    return sum;
}

double series_direct(int N, double x) {
    if (N < 1) return 0;
    
    double sum = 0.0;
    for (int n = 1; n <= N; n++) {
        double double_fact_num = 1.0;
        for (int i = 1; i <= 2 * n + 1; i += 2) {
            double_fact_num *= i;
        }
        
        double factorial_denom = 1.0;
        for (int i = 1; i <= 2 * n; i++) {
            factorial_denom *= i;
        }
        
        sum += double_fact_num * pow(x, 2 * n) / factorial_denom;
    }
    return sum;
}

int main() {
    printf("task1\n");
    int d = task11();
    printf("task1.1 result: %d\n", d);
    
    int x;
    printf("Enter x for F(x): ");
    scanf("%d", &x);
    int c = task12(x);
    if (c == -1) {
        printf("No even digits\n");
    } else {
        printf("task1.2 result: %d\n", c);
    }
    printf("task2\n");
    int N;
    double y;
    printf("Enter N: ");
    scanf("%d", &N);
    printf("Enter x: ");
    scanf("%lf", &y);
    
    double result_recursive = series_recursive(N, y);
    double result_direct = series_direct(N, y);
    
    printf("Recursive sum: %.10f\n", result_recursive);
    printf("Direct sum: %.10f\n", result_direct);
    printf("Difference: %.10f\n", fabs(result_recursive - result_direct));
    
    return 0;
}