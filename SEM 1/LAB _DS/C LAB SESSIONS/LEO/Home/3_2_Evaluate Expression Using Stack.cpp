#include <stdio.h>
#include <conio.h>
#include <ctype.h>
char post[100];
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
    if (x == '(')
        return 0;
    if (x == '+' || x == '-')
        return 1;
    if (x == '*' || x == '/')
        return 2;
    return 0;
}
/* infix to postfix */
char* infixtopost()
{
    char exp[100];
    char *e, *p, x;
    int i = 0;
    printf("\n Enter the expression: ");
    scanf("%s", exp);
    e = exp;
    p = post;
    while (*e != '\0')
	{
        if (isalnum(*e))
		{
            post[i] = *e;
            i++;
        }
		else if (*e == '(')
		{
            push(*e);
        }
		else if (*e == ')')
		{
            while ((x = pop()) != '(')
			{
                post[i] = x;
                i++;
            }
        }
		else
		{
            while (priority(stack[top]) >= priority(*e))
			{
                post[i] = pop();
                i++;
            }
            push(*e);
        }
        e++;
    }
    while (top != -1)
	{
        post[i] = pop();
        i++;
    }
    post[i] = '\0';
    p = post;
    return post;
}

/* evaluating expression */
void EvalPostfix(char postfix[])
{
    int i;
    char ch;
    int val;
    int a, b;
    for (i = 0; postfix[i] != '\0'; i++)
	{
        ch = postfix[i];
        if (isdigit(ch)) {
            push(ch - '0'); // Convert character digit to integer digit
        }
		else if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
		{
            a = pop();
            b = pop();
            switch (ch) {
                case '*':
                    val = b * a;
                    break;
                case '/':
                    val = b / a;
                    break;
                case '+':
                    val = b + a;
                    break;
                case '-':
                    val = b - a;
                    break;
            }
            push(val);
        }
    }
    printf("\n Result of the expression evaluation: %d", pop());
}

int main()
{
    char *postfix, *cursor;
    postfix = infixtopost();
    cursor = postfix;
    while (*cursor != '\0')
	{
        printf("%c", *cursor);
        cursor++;
    }
    printf("\n");
    EvalPostfix(postfix);
    getch();
    return 0;
}

