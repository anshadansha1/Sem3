#include <stdio.h>
#include <ctype.h>
char stack[100];
int top = -1;
/* push function */
void push(char x)
{
    stack[++top] = x;
}

/* pop function */
char pop()
{
    if (top == -1)
        return -1;
    else
        return stack[top--];
}

/* priority function */
int priority(char x)
{
    if (x == ')')
        return 0;
    if (x == '+' || x == '-')
        return 1;
    if (x == '*' || x == '/')
        return 2;
    return -1; // Return a default value for unknown characters
}

int main()
{
    char exp[20];
    char *e, x;
    /* Reading the expression */
    printf("Enter the expression: ");
    scanf("%s", exp);
    e = exp;
    /* infix to postfix */
    printf("Postfix expression: ");
    while (*e != '\0')
	{
        if (isalnum(*e))
            printf("%c", *e);
        else if (*e == '(')
            push(*e);
        else if (*e == ')')
		{
            while ((x = pop()) != '(')
                printf("%c", x);
        }
		else
		{
            while (top != -1 && priority(stack[top]) >= priority(*e))
                printf("%c", pop());
            push(*e);
        }
        e++;
    }
    while (top != -1) {
        printf("%c", pop());
    }
    return 0;
}


