#include <stdio.h>
#define MAX_TERMS 20
// Function to add two polynomials and store the result in a new array
void addPolynomials(int poly1[][2], int num_terms1, int poly2[][2], int num_terms2, int result[][2]) {
    int i, j, k;
    i = j = k = 0;

    // Traverse both polynomials until we reach the end of either
    while (i < num_terms1 && j < num_terms2) {
        if (poly1[i][0] > poly2[j][0]) {
            // If the degree of the term in the first polynomial is greater, copy it to the result
            result[k][0] = poly1[i][0];
            result[k][1] = poly1[i][1];
            i++;
        } else if (poly1[i][0] < poly2[j][0]) {
            // If the degree of the term in the second polynomial is greater, copy it to the result
            result[k][0] = poly2[j][0];
            result[k][1] = poly2[j][1];
            j++;
        } else {
            // If the degrees are equal, add the coefficients and store the result in the result array
            result[k][0] = poly1[i][0];
            result[k][1] = poly1[i][1] + poly2[j][1];
            i++;
            j++;
        }
        k++;
    }

    // Copy any remaining terms from the first polynomial, if any
    while (i < num_terms1) {
        result[k][0] = poly1[i][0];
        result[k][1] = poly1[i][1];
        i++;
        k++;
    }

    // Copy any remaining terms from the second polynomial, if any
    while (j < num_terms2) {
        result[k][0] = poly2[j][0];
        result[k][1] = poly2[j][1];
        j++;
        k++;
    }
}

// Function to display the polynomial
void displayPolynomial(int polynomial[][2], int num_terms) {
    printf("Polynomial: ");
    for (int i = 0; i < num_terms; i++) {
        printf("%dx^%d", polynomial[i][1], polynomial[i][0]);
        if (i < num_terms - 1) {
            printf(" + ");
        }
    }
    printf("\n");
}

int main() {
    int poly1[MAX_TERMS][2], poly2[MAX_TERMS][2], result[MAX_TERMS * 2][2];
    int num_terms1, num_terms2;

    // Read the first polynomial
    printf("Enter the number of terms in the first polynomial: ");
    scanf("%d", &num_terms1);
    for (int i = 0; i < num_terms1; i++) {
        printf("Enter the degree for term %d: ", i + 1);
        scanf("%d", &poly1[i][0]);
        printf("Enter the coefficient for term %d: ", i + 1);
        scanf("%d", &poly1[i][1]);
    }

    // Read the second polynomial
    printf("Enter the number of terms in the second polynomial: ");
    scanf("%d", &num_terms2);
    for (int i = 0; i < num_terms2; i++) {
        printf("Enter the degree for term %d: ", i + 1);
        scanf("%d", &poly2[i][0]);
        printf("Enter the coefficient for term %d: ", i + 1);
        scanf("%d", &poly2[i][1]);
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

