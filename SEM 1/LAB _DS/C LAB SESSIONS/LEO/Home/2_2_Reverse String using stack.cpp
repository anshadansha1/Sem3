#include <stdio.h>
#include <string.h>
#define max 100
int top, stack[max];
/* push function */
void push(char x)
{
    if (top == max - 1)
	{
        printf("stack overflow");
    }
	else
	{
        stack[++top] = x;
    }
}
/* pop function */
void pop()
{
    printf("%c", stack[top--]);
}

int main()
{
    char str[] = "hello world";
    /* Reading the string to len */
    int len = strlen(str);
    int i; // Add a semicolon here

    for (i = 0; i < len; i++)
        push(str[i]);

    for (i = 0; i < len; i++)
        pop();

    return 0;
}

