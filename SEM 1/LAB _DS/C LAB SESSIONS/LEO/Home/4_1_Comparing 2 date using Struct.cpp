#include <stdio.h>
// Structure for dates
struct Date
{
    int day;
    int month;
    int year;
};
// Function to read a date from the user
void readDate(struct Date *date)
{
    printf("Enter the day (dd): ");
    scanf("%d", &date->day);

    printf("Enter the month (mm): ");
    scanf("%d", &date->month);

    printf("Enter the year (yyyy): ");
    scanf("%d", &date->year);
}

// Function to display a date
void displayDate(struct Date date)
{
    printf("%02d/%02d/%04d", date.day, date.month, date.year);
}

// Function to compare two dates and check if they are equal
int isEqual(struct Date date1, struct Date date2)
{
    if (date1.day == date2.day && date1.month == date2.month && date1.year == date2.year)
	{
        return 1; // Dates are equal
    }
	else
	{
        return 0; // Dates are not equal
    }
}

int main()
{
    struct Date date1, date2;

    // Read two dates from the user
    printf("Enter the first date:\n");
    readDate(&date1);

    printf("Enter the second date:\n");
    readDate(&date2);

    // Display the two dates
    printf("First date: ");
    displayDate(date1);
    printf("\n");

    printf("Second date: ");
    displayDate(date2);
    printf("\n");

    // Compare the two dates
    if (isEqual(date1, date2))
	{
        printf("The two dates are equal.\n");
    }
	else
	{
        printf("The two dates are not equal.\n");
    }

    return 0;
}

