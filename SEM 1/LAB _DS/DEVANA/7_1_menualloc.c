#include<stdio.h>
#include<malloc.h>
#include<conio.h>
void m()
{
	int *a;
	a=(int *)malloc(sizeof(int));
	printf("enter a value: ");
	scanf("%d",a);
	printf("using malloc, *a=%d",*a);
	free(a);
}

void c()
{
	int *a;
	a=(int *)calloc(1,sizeof(int));
	printf("enter a value: ");
	scanf("%d",a);
	printf("using calloc, *a=%d",*a);
	free(a);
}

int main()
{
	int ch;
	do{
		printf("\n1.malloc\n2.calloc\n3.exit\nENTER Choice");
		scanf("%d",&ch);
		switch(ch){
			case 1: m();
					break;
			case 2: c();
					break;
		}
	}while(ch<3);
	
	return 0;
}
