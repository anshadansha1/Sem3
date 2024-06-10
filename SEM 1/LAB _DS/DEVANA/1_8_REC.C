//prg to display array elements in the reverse order using recursive func
#include<stdio.h>
#include<conio.h>
int dispArrRev(int a[10],int size){
	if(size==0)
	{
		return 0;
	}
	else{
		size=size-1;
		printf("%d ",a[size]);
		return dispArrRev(a,size);
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
	dispArrRev(a,size);
	getch();
}