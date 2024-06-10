#include<stdio.h>
int insert(int a[],int n,int i)
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

void search(int a[],int n)
{

	int k,i,count=0;
	printf("\nenter the element to be searched: ");
	scanf("%d",&k);
	for(i=0;i<n;i++)
	{
		if(a[i]==k)
		{
			count++;
			
		}
	
	}
	if(count==0)
		{
			printf("Element not found");
		}
	else
	{
		printf("occuence of %d is %d",k,count);
	}
}

int menu()
{
	int ch;
	printf("\n\n1.insert\n2.display\n3.search\n4.exit\nenter choice: ");
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
			case 1:i=insert(a,n,i);
					break;
			case 2: display(a,i);
					break;
			case 3: search(a,i);
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
