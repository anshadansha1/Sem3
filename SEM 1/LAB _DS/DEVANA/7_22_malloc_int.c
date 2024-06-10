#include<stdio.h>
#include<malloc.h>
#include<conio.h>
void m(int n)
{
	int *a,i;
	float sum=0,mean=0;
	a=(int *)malloc(sizeof(int)*n);
	for(i=0;i<n;i++)
	{
		printf("enter %d 'th value: ",i);
	    scanf("%d",&a[i]);	
	}
	printf("Elements are: ");
	for(i=0;i<n;i++)
	{
		printf(" %d",a[i]);	
	}
	for(i=0;i<n;i++)
	{
		sum=sum+a[i];
	}
	mean=sum/n;
	printf("\nmean= %f",mean);
	free(a);
}

int main()
{
	int n;
	printf("Enter number of elements: ");
	scanf("%d",&n);
	m(n);
}
