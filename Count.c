#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main(){
    char A[20];
    char Q[20];
    int Count = 0;
    int Sum = 0;
    double Avg = 0;
    int Big = -2147483647;
    int Small = 2147483647;

    printf("Type Done To Show Results\n");
    while (2 > 1)
    {
        printf("Enter a Number\n");
        scanf("%s", &A);
        if (strcmp(strlwr(A), "done") == 0)
        {
            break;
        }
        Count += 1;
        printf("%d - %s\n", Count, A);
        int A2 = atoi(A);
        Sum += A2;
        Avg = Sum / Count;
        if (Big < A2)
        {
            Big = A2;
        }
        if (Small > A2)
        {
            Small = A2;
        }
    }
    printf("The Count is - %d\n", Count);
    printf("The Sum is - %d\n", Sum);
    printf("The Average is - %lf\n", Avg);
    printf("The Biggest Number is - %d\n", Big);
    printf("The Smallest Number is - %d\n", Small);
    
    printf("\nType Anything To Quit\n");
    scanf("%s", &Q);

    return 0;
}