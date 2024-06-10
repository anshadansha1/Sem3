#include<stdio.h>
int read(int a[],int n,int i)
{

	if(n==i)
	{
		printf("array is full");
		return i;
	}
	printf("enter element:");
	scanf("%d",&a[i]);
	printf("%d",i);
	return ++i;
}

void display(int a[],int index)
{
	int i;
	for(i=0;i<index;i++)
	{
		printf("%d ",a[i]);
	}
}

void sort(int a[],int n)
{
	int i,j,t;
	for(i=0;i<n;i++)
	{
		for(j=0;j<n-i-1;j++)
		{
			if(a[j]>a[j+1])
			{
				t=a[j];
				a[j]=a[j+1];
				a[j+1]=t;
			}
		}
	}
}

int menu()
{
	int ch;
	printf("\n\n1.read\n2.display\n3.sort\n4.exit\nenter choice: ");
	scanf("%d",&ch);
	return ch;
}


void process(int n)
{
	int ch,b,k,i=0;
	int a[6];
	for(ch=menu();ch!=4;ch=menu())
	{
		switch(ch)
		{
			case 1:i=read(a,n,i);
					break;
			case 2: display(a,i);
					break;
			case 3: sort(a,n);
					break;
			default: printf("bye");
		}
	}
}

int main()
{
	int n;
	printf("Enter array limit: ");
	scanf("%d",&n);
	process(n);
	return 0;
}

