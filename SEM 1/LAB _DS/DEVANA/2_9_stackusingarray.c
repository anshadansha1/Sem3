#include<stdio.h>
#include<conio.h>
int a[5],top=-1;
void push(int e)
{
	if(top+1==5)
	{
		printf("Stack is full");
	}
	else
	{
		a[++top]=e;
	}
}

void pop()
{
	if(top==-1)
	{
		printf("stack underflow");
	}
	else
	{
		printf("deleted element %d",a[top--]);
	}
}

void peak()
{
	printf("elemenmt at top is %d",a[top]);
}

int menu()
{
	int ch;
	printf("\n1 Insert\n2.delete\n3.peak\n4.exit\nenter choice: ");
	scanf("%d",&ch);
	return ch;
}

void process()
{
	int ch;
	for(ch=menu();ch!=4;ch=menu())
	{
		switch(ch)
		{
			case 1: printf("enter the element: ");
					scanf("%d",&ch);
					push(ch);
					break;
			case 2: pop();
					break;
			case 3: peak();
					break;
			default: printf("\nwrong choice");
		}
	}
}
int main()
{
	process();
	return 0;
}
