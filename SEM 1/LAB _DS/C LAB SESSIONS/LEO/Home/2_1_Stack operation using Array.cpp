#include <stdio.h>
#include <stdlib.h> // For the exit() function

#define SIZE 5
int top = -1, element, stack[SIZE];

/* push function */
void push(int element)
{
    if (top == SIZE - 1)
	{
        printf("\n stack overflow");
    }
	else
	{
        top++;
        stack[top] = element;
    }
}

/* pop function */
void pop()
{
    if (top == -1)
	{
        printf("\n stack underflow");
    } else
	{
        printf("\n deleted item is %d", stack[top]);
        top--;
    }
}

/* display function */
void display()
{
    int i;
    if (top == -1)
	{
        printf("\n stack underflow");
    } else
	{
        for (i = top; i >= 0; i--)
		{
            printf("%d\t", stack[i]);
        }
    }
}

int main()
{
    int ch;
    /* menu driven */
    do
	{
        printf("\n 1.insertion\n 2.deletion\n 3.display \n 4.exit");
        printf("\n enter your choice: ");
        scanf("%d", &ch);
        switch (ch)
		{
        case 1:
            printf("\n enter the element: ");
            scanf("%d", &element);
            push(element);
            break;
        case 2:
            pop();
            break;
        case 3:
            display();
            break; // Add a semicolon here
        case 4:
            exit(0);
        default:
            printf("\n wrong choice");
        }
    }
	while (1); // Change 'ch' to '1' to create an infinite loop
    return 0;
}


