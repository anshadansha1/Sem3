#include<stdio.h>
#include<conio.h>
struct book{
	char author_name[20];
	char book_name[20];
};

void read(int n,struct book s[])
{
	int i;
	for(i=0;i<n;i++)
	{
		printf("Enter author name and book name: ");
		scanf("%s%s",s[i].author_name,s[i].book_name);		
	}
	display(n,s);
	
}

void display(int n,struct book s[])
{
	int i;
	for(i=0;i<n;i++)
	{
		printf("\nbook %d details\n",i+1);
		printf("author:%s\tbook:%s\n\n",s[i].author_name,s[i].book_name);
	}
}

int main()
{
	struct book *s;
	int n,i;
	printf("Enter limit: ");
	scanf("%d",&n);
	s=(struct book*)malloc(sizeof(struct book)*n);
	read(n,s);
	return 0;
}

