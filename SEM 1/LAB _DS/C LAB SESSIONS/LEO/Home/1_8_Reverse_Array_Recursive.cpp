#include <stdio.h>
/* Reverse function */
void display_array_reverse(int arr[], int index, int size)
{
    if (index >= size)
	{
        return;
    }
	else
	{
        display_array_reverse(arr, index + 1, size);
        printf("%d\t", arr[index]);
    }
}

int main()
{
    int i, arr[20], size, index = 0;
    /* Reading the size */
    printf("Enter the size of the array:\n");
    scanf("%d", &size);
    /* Reading the elements */
    printf("Enter %d elements:\n", size);
    for (i = 0; i < size; i++)
	{
        scanf("%d", &arr[i]);
    }
    printf("Elements in reverse order:\n");
    display_array_reverse(arr, index, size);
    return 0;
}


