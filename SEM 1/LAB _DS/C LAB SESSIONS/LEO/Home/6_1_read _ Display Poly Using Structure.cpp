#include <stdio.h>

/* defining structure term */
struct term
{
    int coef;
    int exp;
};
typedef struct term poly;

int main()
{
    poly p[50];
    int i, n;

    /* Reading the terms of polynomial */
    printf("\n Enter the number of terms: ");
    scanf("%d", &n);

    /* Reading the coefficient and exponent */
    for (i = 0; i < n; i++)
    {
        printf("\n Enter a coefficient and exponent: ");
        scanf("%d%d", &p[i].coef, &p[i].exp);
    }

    /* Printing the polynomial */
    for (i = 0; i < n - 1; i++)
    {
        printf("%dx^%d", p[i].coef, p[i].exp);
        printf("%s", p[i + 1].coef >= 0 ? "+" : " ");
    }

    /* Handling the last term separately to avoid the trailing "+" */
    if (p[i].exp == 0)
    {
        printf("%d", p[i].coef);
    }
    else
    {
        printf("%dx^%d", p[i].coef, p[i].exp);
    }

    return 0;
}

