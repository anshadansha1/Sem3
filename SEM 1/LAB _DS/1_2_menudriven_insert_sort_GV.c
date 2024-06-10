#include <stdio.h>

#define MAX_SIZE 100

// Global variables
int arr[MAX_SIZE];
int size = 0;

// Function prototypes
void displayMenu();
void insertElement();
void searchElement();
void deleteElement();
void sortArray();
void displayArray();

int main() {
    int choice;

    do {
        displayMenu();
        printf("Enter your choice: ");
        scanf("%d", &choice);

        switch (choice) {
            case 1:
                insertElement();
                break;
            case 2:
                searchElement();
                break;
            case 3:
                deleteElement();
                break;
            case 4:
                sortArray();
                break;
            case 5:
                displayArray();
                break;
            case 6:
                printf("Exiting the program.\n");
                break;
            default:
                printf("Invalid choice. Please try again.\n");
        }
    } while (choice != 6);

    return 0;
}

void displayMenu() {
    printf("\nMenu:\n");
    printf("1. Insert an element\n");
    printf("2. Search an element\n");
    printf("3. Delete an element\n");
    printf("4. Sort the array\n");
    printf("5. Display the array\n");
    printf("6. Exit\n");
}

void insertElement() {
    if (size >= MAX_SIZE) {
        printf("Array is full. Cannot insert more elements.\n");
        return;
    }

    printf("Enter the element to insert: ");
    scanf("%d", &arr[size]);
    size++;

    printf("Element inserted successfully.\n");
}

void searchElement() {
    int searchValue, found = 0;

    if (size == 0) {
        printf("Array is empty. Cannot perform search.\n");
        return;
    }

    printf("Enter the element to search: ");
    scanf("%d", &searchValue);

    for (int i = 0; i < size; i++) {
        if (arr[i] == searchValue) {
            printf("Element %d found at index %d.\n", searchValue, i);
            found = 1;
            //break;
        }
    }

    if (!found) {
        printf("Element not found in the array.\n");
    }
}

void deleteElement() {
    int deleteValue, found = 0, i;

    if (size == 0) {
        printf("Array is empty. Cannot perform deletion.\n");
        return;
    }

    printf("Enter the element to delete: ");
    scanf("%d", &deleteValue);

    for (i = 0; i < size; i++) {
        if (arr[i] == deleteValue) {
            found = 1;
            break;
        }
    }

    if (found) {
        // Move elements after the element to delete one position back
        for (int j = i; j < size - 1; j++) {
            arr[j] = arr[j + 1];
        }
        size--;
        printf("Element %d deleted successfully.\n", deleteValue);
    } else {
        printf("Element not found in the array. Deletion failed.\n");
    }
}

void sortArray() {
    int temp;

    for (int i = 0; i < size - 1; i++) {
        for (int j = i + 1; j < size; j++) {
            if (arr[i] > arr[j]) {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    printf("Array sorted in ascending order.\n");
}

void displayArray() {
    if (size == 0) {
        printf("Array is empty.\n");
        return;
    }

    printf("Array elements: ");
    for (int i = 0; i < size; i++) {
        printf("%d ", arr[i]);
    }
    printf("\n");
}