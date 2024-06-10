//prg to display array elements in the same order using recursive func
#include<stdio.h>
#include<conio.h>
int dispArr(int a[10],int size,int i){
	if(i==size)
	{
		return 0;
	}
	else{
		printf("%d",a[i]);
		i++;
		return dispArr(a,size,i);
	}
}

void main(){

	int size,i,a[10];
	clrscr();
	printf("Enter the size: ");
	scanf("%d",&size);
	for(i=0;i<size;i++){
		printf("Enter element %d: ",i+1);
		scanf("%d",&a[i]);
	}
	printf("Array: ");
	dispArr(a,size,0);
	getch();
}