#include<stdio.h>
#include<malloc.h>
struct node{
	int data;
	struct node *next;
};
struct node *head=NULL;

void insert_at_start(int e)
{
	struct node *t;
	t=(struct node *)malloc(sizeof(struct node));
	t->data=e;
	t->next=head;
	head = t;	
}

void insert_at_end(int e)
{
	struct node *t;
	if(head == NULL)
	{
		head = (struct node *)malloc(sizeof(struct node));
		head -> data = e;
		head -> next = NULL;
    }
    else
    {
    	t=head;
    	while(t->next!=NULL)
    	{
    		t=t->next;
		}
		t->next=(struct node *)malloc(sizeof(struct node));
		t->next->data=e;
		t->next->next=NULL;
	}	
}

void insert_after_element(int e)
{
	struct node *t,*t2;
	int num;
	if (head==NULL)
		printf("Linked list is empty!!\n\n");
    else
    {
    	printf("Enter the the element after which %d should be inserted : ",e);
    	scanf("%d",&num);
    	t=head;
    	while(t!=NULL &&t->data!=num)
    	{
    		t=t->next;
		}
		if(t==NULL)
			printf("%d not found\n",num);
		else
		{
			t2=t->next;
			t->next=(struct node *)malloc(sizeof(struct node));
			t->next->data=e;
			t->next->next=t2;
		}
		
	}	
}

void disp()
{
	struct node *t;
	if (head==NULL)
		printf("Linked list is empty!!\n\n");
	else
	{
		t=head;
		printf("\n");
		while(t!=NULL)
		{
			printf("%d\t",t->data);
			t=t->next;
		}
		printf("\n");
	}		
}

int menu()
{
	int ch;
	printf("Insert at the beginnig- 1\nInsert at the end - 2\nInsert after a specified element - 3\nDisplay - 4\nEXIT - 5\n");
	printf("Enter your choice : ");
	scanf("%d",&ch);
	return ch;
}
void main()
{
	int ch;
	for(ch = menu();ch != 5;ch = menu())
    {
        switch(ch)
        {
            case 1 : printf("Enter the element to insert : ");
					 scanf("%d",&ch);
					 insert_at_start(ch);
                     break;
            case 2 : printf("Enter the element to insert : ");
					 scanf("%d",&ch);
					 insert_at_end(ch);
                     break;
            case 3 : printf("Enter the element to insert : ");
					 scanf("%d",&ch);         
                     insert_after_element(ch);
                     break;
			case 4 : disp();
                     break;
            default : printf("Wrong Choice!!!\n");
                      break;
        };
        printf("\n");
    }
}
