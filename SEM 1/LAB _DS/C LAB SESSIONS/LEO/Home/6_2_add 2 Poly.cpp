#include <stdio.h>

#define MAX_TERMS 20

// Structure to represent each term of the polynomial
struct Term {
    int coef;
    int exp;
};

typedef struct Term poly;

// Function to add two polynomials and store the result in a new array
void addPolynomials(poly poly1[], int num_terms1, poly poly2[], int num_terms2, poly result[]) {
    int i, j, k;
    i = j = k = 0;

    while (i < num_terms1 && j < num_terms2) {
        if (poly1[i].exp > poly2[j].exp) {
            result[k].coef = poly1[i].coef;
            result[k].exp = poly1[i].exp;
            i++;
        } else if (poly1[i].exp < poly2[j].exp) {
            result[k].coef = poly2[j].coef;
            result[k].exp = poly2[j].exp;
            j++;
        } else {
            result[k].coef = poly1[i].coef + poly2[j].coef;
            result[k].exp = poly1[i].exp;
            i++;
            j++;
        }
        k++;
    }

    while (i < num_terms1) {
        result[k].coef = poly1[i].coef;
        result[k].exp = poly1[i].exp;
        i++;
        k++;
    }

    while (j < num_terms2) {
        result[k].coef = poly2[j].coef;
        result[k].exp = poly2[j].exp;
        j++;
        k++;
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
    poly poly1[MAX_TERMS], poly2[MAX_TERMS], result[MAX_TERMS * 2];
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

    // Add the two polynomials
    addPolynomials(poly1, num_terms1, poly2, num_terms2, result);

    // Display the first polynomial
    printf("\nFirst ");
    displayPolynomial(poly1, num_terms1);

    // Display the second polynomial
    printf("Second ");
    displayPolynomial(poly2, num_terms2);

    // Display the resultant polynomial after addition
    printf("Resultant ");
    displayPolynomial(result, num_terms1 + num_terms2);

    return 0;
}

