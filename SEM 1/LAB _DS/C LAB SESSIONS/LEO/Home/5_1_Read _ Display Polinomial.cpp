#include <stdio.h>
#define MAX_TERMS 2
int main()
{
    int polynomial[MAX_TERMS][2]; // 2D array to store degree and coefficient for each term
    int num_terms, i;

    // Read the number of terms in the polynomial
    printf("Enter the number of terms in the polynomial: ");
    scanf("%d", &num_terms);

    // Read the degree and coefficient for each term
    for (i = 0; i < num_terms; i++)
	{
        printf("Enter the degree for term %d: ", i + 1);
        scanf("%d", &polynomial[i][0]);

        printf("Enter the coefficient for term %d: ", i + 1);
        scanf("%d", &polynomial[i][1]);
    }

    // Display the polynomial
    printf("\nPolynomial: ");
    for (i = 0; i < num_terms; i++)
	{
        printf("%dx^%d", polynomial[i][1], polynomial[i][0]);

        if (i < num_terms - 1)
		{
            printf(" + ");
        }
    }
    printf("\n");

    return 0;
}

