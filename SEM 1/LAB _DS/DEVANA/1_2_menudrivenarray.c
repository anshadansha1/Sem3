#include<stdio.h>
int a[20];
int insert(int n,int i)
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

void display(int index)
{
	int i;
	for(i=0;i<index;i++)
	{
		printf("%d ",a[i]);
	}
}

void search(int n)
{

	int k,i;
	printf("\nenter the element to be searched: ");
	scanf("%d",&k);
	for(i=0;i<n;i++)
	{
		if(a[i]==k)
		{
			printf("%d found at position %d",k,i);
			return ;
		}
	
	}
	if(i==n)
		{
			printf("Element not found");
		}
}

void sort(int n)
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
	printf("\n\n1.insert\n2.display\n3.search\n4.sort\n5.exit\nenter choice: ");
	scanf("%d",&ch);
	return ch;
}


void process(int n)
{
	int ch,b,k,i=0;
	for(ch=menu();ch!=5;ch=menu())
	{
		switch(ch)
		{
			case 1:i=insert(n,i);
					break;
			case 2: display(i);
					break;
			case 3: search(i);
					break;
			case 4: sort(n);
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
