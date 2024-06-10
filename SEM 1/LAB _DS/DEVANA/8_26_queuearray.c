#include<stdio.h>
int q[5],f=-1,r=-1;
void enqueue(){
	if(r+1==5)
	{
		printf("Error: queue is full");
	}
	else{
		if(f==-1)
		{
			f=0;
		}
		printf("enter value: ");
		scanf("%d",&q[++r]);
	}
}

void dequeue()
{
	int i;
	if(f==-1)
	{
		printf("Error: queue is empty");
	}
	else{
		printf("dequeued item %d",q[f]);
		if(f==r)
		{ f=r=-1; }
		else
		{
			for(i=0;i<r;i++)
			{
				q[i]=q[i+1];
			}
			r--;
		}
		}
	}

void display()
{
    int i;
    if (f == - 1)
        printf("Queue is empty \n");
    else
    {
        printf("Queue is : \n");
        for (i = f; i <= r; i++)
            printf("%d ", q[i]);
        printf("\n");
    }
} 
int main()
{
	int ch;
	do{
		printf("\n1.enqueue\n2.dequeue\n3.display\n4.exit\nenter choice: ");
		scanf("%d",&ch);
		switch(ch)
		{
			case 1: enqueue();
					break;
			case 2:dequeue();
					break;
			case 3:display();
					break;
		}		
	}while(ch<4);
	return 0;
}
