//reverse of string using stack
#include<stdio.h>
#include<conio.h>
#include<string.h>
int stack[20],top=-1;
char a[20];
void push(char a[20]){
	int i;
	for(i=0;i<strlen(a);i++){
		top++;
		stack[top]=a[i];
	}
	pop();
}

void pop(){
	printf("\nReversed string : ");
	for(;top>=-1;top--){
		printf("%c",stack[top]);
	}
}

void main(){
	clrscr();
	printf("\nenter the string: ");
	gets(a);
	push(a);
	getch();
}
