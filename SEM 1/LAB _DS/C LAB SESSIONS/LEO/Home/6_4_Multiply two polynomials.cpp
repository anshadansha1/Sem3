#include <stdio.h>

#define MAX_TERMS 20

// Structure to represent each term of the polynomial
struct Term {
    int coef;
    int exp;
};

typedef struct Term poly;

// Function to multiply two polynomials and store the result in a new array
void multiplyPolynomials(poly poly1[], int num_terms1, poly poly2[], int num_terms2, poly result[]) {
    int i, j, k;
    k = 0;

    for (i = 0; i < num_terms1; i++) {
        for (j = 0; j < num_terms2; j++) {
            result[k].coef = poly1[i].coef * poly2[j].coef;
            result[k].exp = poly1[i].exp + poly2[j].exp;
            k++;
        }
    }
}

// Function to display the polynomial
void displayPolynomial(poly polynomial[], int num_terms) {
    printf("Polynomial: ");
    for (int i = 0; i < num_terms; i++) {
        printf("%dx^%d", polynomial[i].coef, polynomial[i].exp);

        if (i < num_terms - 1) {
            printf(" + ");
        }
    }
    printf("\n");
}

int main() {
    poly poly1[MAX_TERMS], poly2[MAX_TERMS], result[MAX_TERMS * MAX_TERMS];
    int num_terms1, num_terms2;

    // Read the first polynomial
    printf("Enter the number of terms in the first polynomial: ");
    scanf("%d", &num_terms1);
    for (int i = 0; i < num_terms1; i++) {
        printf("Enter the coefficient for term %d: ", i + 1);
        scanf("%d", &poly1[i].coef);
        printf("Enter the exponent for term %d: ", i + 1);
        scanf("%d", &poly1[i].exp);
    }

    // Read the second polynomial
    printf("Enter the number of terms in the second polynomial: ");
    scanf("%d", &num_terms2);
    for (int i = 0; i < num_terms2; i++) {
        printf("Enter the coefficient for term %d: ", i + 1);
        scanf("%d", &poly2[i].coef);
        printf("Enter the exponent for term %d: ", i + 1);
        scanf("%d", &poly2[i].exp);
    }

    // Multiply the two polynomials
    multiplyPolynomials(poly1, num_terms1, poly2, num_terms2, result);

    // Display the first polynomial
    printf("\nFirst ");
    displayPolynomial(poly1, num_terms1);

    // Display the second polynomial
    printf("Second ");
    displayPolynomial(poly2, num_terms2);

    // Display the resultant polynomial after multiplication
    printf("Resultant ");
    displayPolynomial(result, num_terms1 * num_terms2);

    return 0;
}

