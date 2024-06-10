#include <stdio.h>
void Disp(int arr[], int index , int size)
{
    if (index >= size)
	{
        return;
    }
	else
	{
        printf("%d\t", arr[index]);
        Disp(arr, index + 1, size);
    }
}

int main()
{
    int size, i, arr[10], index = 0;
    /* Reading the size of the array */
    printf("Enter the size of the array:\n");
    scanf("%d", &size);
    /* Reading the elements */
    for (i = 0; i < size; i++)
	{
        printf("Enter a[%d]: ", i);
        scanf("%d", &arr[i]);
    }
    printf("Elements are following:\n");
    Disp(arr, index, size);
    return 0;
}


