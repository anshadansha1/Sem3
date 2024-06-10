#include<stdio.h>
#include<malloc.h>
typedef struct node link;
enum op{
	INSERTBEG=1,INSERTSPEC,INSERTEND,DISPLAY
};
struct node{
	int data;
	link *next;
};
link *head=NULL;
void insertEnd(int e){
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
void insertBeg(int e)
{
	link *t;
	t=(link *)malloc(sizeof(link)); //alocate new node
	t->data=e;		//insert data to new node
	t->next=head;		//make the next of new node have head's address
	head=t;		//head has address of new node
}

void insertSpec(int e)
{
	link *t,*newnode;
	t=head;
	int pos,i;
	printf("\nlinked list\n");
	display();
	printf("\nEnter the position where you want to insert: ");
	scanf("%d",&pos);
	if(pos==1)
	{
		insertBeg(e);
	}
	
	else{
		for(i=2;i<pos;i++)
		{
			t=t->next;	
		}
		newnode=(link *)malloc(sizeof(link));
		newnode->data=e;
		newnode->next=t->next;
		t->next=newnode;
	}
	if(pos>i){
		printf("illegal position");
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

int menu(){
	int ch;
	printf("\n\n1. INSERT BEGINING\n2. INSERT AT SPECIFIED POSITION\n3. INSERT LAST\n4.DISPLAY\n5.EXIT\nENTER CHOICE: ");
	scanf("%d",&ch);
	return ch;
}

void process(){
	int ch,e;
	for(ch=menu();ch!=5;ch=menu()){
		switch(ch){
			case INSERTBEG: printf("Enter the data to be inserted: ");
							scanf("%d",&e);
							insertBeg(e);
							break;
			case INSERTEND: printf("Enter the data to be inserted: ");
							scanf("%d",&e);
							insertEnd(e);
							break;
			case INSERTSPEC: printf("Enter the data to be inserted: ");
							scanf("%d",&e);
							insertSpec(e);
							break;
			case DISPLAY: display();
						  break;	
		}
	}
}
int main(){
	process();
	return 0;
}
