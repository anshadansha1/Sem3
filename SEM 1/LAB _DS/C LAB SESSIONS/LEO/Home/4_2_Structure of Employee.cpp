#include <stdio.h>
#include <string.h>
#define MAX_EMPLOYEES 100
// Structure for employees
struct Employee
{
    int eno;
    char ename[50];
    float esal;
    int dno;
};
// Function to search an employee by eno
struct Employee* searchEmployeeByEno(struct Employee employees[], int n, int eno)
{
    for (int i = 0; i < n; i++)
	{
        if (employees[i].eno == eno)
		{
            return &employees[i];
        }
    }
    return NULL; // Employee with given eno not found
}
// Function to sort employees by name
void sortEmployeesByName(struct Employee employees[], int n)
{
    struct Employee temp;
    for (int i = 0; i < n - 1; i++)
	{
        for (int j = i + 1; j < n; j++)
		{
            if (strcmp(employees[i].ename, employees[j].ename) > 0)
			{
                temp = employees[i];
                employees[i] = employees[j];
                employees[j] = temp;
            }
        }
    }
}
// Function to sort employees by salary
void sortEmployeesBySalary(struct Employee employees[], int n)
{
    struct Employee temp;
    for (int i = 0; i < n - 1; i++)
	{
        for (int j = i + 1; j < n; j++)
		{
            if (employees[i].esal > employees[j].esal)
		{
                temp = employees[i];
                employees[i] = employees[j];
                employees[j] = temp;
            }
        }
    }
}
// Function to delete an employee by eno
void deleteEmployeeByEno(struct Employee employees[], int *n, int eno)
{
    int found = 0;
    for (int i = 0; i < *n; i++)
	{
        if (employees[i].eno == eno)
		{
            found = 1;
            for (int j = i; j < *n - 1; j++)
			{
                employees[j] = employees[j + 1];
            }
            (*n)--;
            printf("Employee with Employee Number %d deleted successfully!\n", eno);
            break;
        }
    }
    if (!found)
	{
        printf("Employee with Employee Number %d not found!\n", eno);
    }
}

// Function to display an employee
void displayEmployee(struct Employee employee) {
    printf("Employee Number: %d\n", employee.eno);
    printf("Employee Name: %s\n", employee.ename);
    printf("Employee Salary: %.2f\n", employee.esal);
    printf("Department Number: %d\n", employee.dno);
    printf("----------------------\n");
}

int main()
{
    struct Employee employees[MAX_EMPLOYEES];
    int n;

    printf("Enter the number of employees: ");
    scanf("%d", &n);

    // Read employee information
    for (int i = 0; i < n; i++) {
        printf("\nEnter details for Employee %d:\n", i + 1);
        printf("Employee Number: ");
        scanf("%d", &employees[i].eno);

        printf("Employee Name: ");
        scanf(" %[^\n]", employees[i].ename);

        printf("Employee Salary: ");
        scanf("%f", &employees[i].esal);

        printf("Department Number: ");
        scanf("%d", &employees[i].dno);
    }

    int option;
    do
	{
        printf("\n1. Search Employee by Employee Number");
        printf("\n2. Sort Employees by Name");
        printf("\n3. Sort Employees by Salary");
        printf("\n4. Delete Employee by Employee Number");
        printf("\n5. Display All Employees");
        printf("\n6. Exit");
        printf("\nEnter your choice: ");
        scanf("%d", &option);

        switch (option)
		{
            case 1:
                int eno;
                printf("\nEnter the Employee Number to search: ");
                scanf("%d", &eno);
                struct Employee *result = searchEmployeeByEno(employees, n, eno);
                if (result != NULL)
				{
                    printf("\nEmployee Found!\n");
                    displayEmployee(*result);
                }
				else
				{
                    printf("\nEmployee with Employee Number %d not found!\n", eno);
                }
                break;

            case 2:
                sortEmployeesByName(employees, n);
                printf("\nEmployees sorted by Name!\n");
                break;

            case 3:
                sortEmployeesBySalary(employees, n);
                printf("\nEmployees sorted by Salary!\n");
                break;

            case 4:
                printf("\nEnter the Employee Number to delete: ");
                scanf("%d", &eno);
                deleteEmployeeByEno(employees, &n, eno);
                break;

            case 5:
                printf("\nAll Employees:\n");
                for (int i = 0; i < n; i++) {
                    displayEmployee(employees[i]);
                }
                break;

            case 6:
                printf("\nExiting...\n");
                break;

            default:
                printf("\nInvalid option! Try again.\n");
                break;
        }
    } while (option != 6);

    return 0;
}
