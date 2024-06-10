//program to demonstrate the use of storage classes in c
#include<stdio.h>
int a=10;
void classwithglobal()
{
	printf("Global variable= %d\n",a);
}

void classwithlocal()
{
	int b=8,c=101;
	printf("Local variables are %d %d\n",b,c);
}

void classwithstatic()
{
	static int b=2;
	printf("b=%d without using static, b=%d using static\n",b,++b);
}

void classwithregister()
{
	int b=2,c=8;
	register int d;
	d=b+c;
	d=d+20;
	printf("using register variable, c=%d,b=%d,d=%d\n",c,b,d);
}

void main()
{
	classwithglobal();
	classwithlocal();
	classwithstatic();
	classwithregister();
	getch();
}
