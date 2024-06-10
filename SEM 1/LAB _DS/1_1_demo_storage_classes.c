#include <stdio.h>
int a,b=3;//golbal variable
void displ()
{
	static int i,k=4,j=2; //static variable
	register int g=2;
	printf("value of i = %d\n",i);
	printf("\nregister = %d\n",g);
}
void Auto_function() {
    auto int x = 10; //auto
    printf("Inside Auto_function : x = %d\n", x);
}
int main()
{
	displ();
	Auto_function();
	int b;
	{
		int z=20;//local variable
		int i=10;
		register int *m = &i; //register variable
		printf("%d\n%d\n",a,b);		
		printf("\nlocal = %d",z);
		printf("\nValue of pointer : %d\n",*m);
		
		//extern storage class Fist file :
		//*************************************************
		//#include <stdio.h>
        //int count ;
        //extern void write_extern();
 
        //main() {
        //count = 5;
        //write_extern();
        //}
        //*************************************************
        //extern second file :
        //#include <stdio.h>
 
        //extern int count;
 
        //void write_extern(void) {
        //printf("count is %d\n", count);
        //}
	    //***********************************************
		return 0;
	}
}
