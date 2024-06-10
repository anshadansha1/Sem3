#include<stdio.h>
#include<malloc.h>
typedef struct node link;
struct node{
	int data;
	link *next;
};
link *head=NULL;
void insert(int e){
	link *t;
	if(head==NULL)
	{
		head=(link *)malloc(sizeof(link));
		head->data=e;
		head->next=NULL;
	}
	else{
		t=head;
		while(t->next!=NULL){
			t=t->next;
		}
		t->next=(link *)malloc(sizeof(link));
		t->next->data=e;
		t->next->next=NULL;
	}
}

void display()
{
	link *t;
	if(head==NULL){
		printf("linked list is empty\n");
	}
	else{
		t=head;
		while(t!=NULL){
			printf("%d\t",t->data);
			t=t->next;	
		}
	}
}
int main(){
	insert(10);
	insert(20);
	insert(30);
	display();
	return 0;
}
