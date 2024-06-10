/*all matrix operations based on choice
  a.add
  b.subtract
  c.multiplication
  d.exit
*/
#include<conio.h>
#include<stdio.h>
int a[10][10],b[10][10],n,i,m,k,j,p,q,ch,add[10][10],sub[10][10],prdt[10][10];
void addd(int a[][10],int b[][10],int m,int n)
{
	for(i=0;i<m;i++)
	{ for(j=0;j<n;j++)
		{
		  add[i][j]=a[i][j]+b[i][j];
		}
	}
	printf("\nAfter adding matrix 1 and 2:\n");
	for(i=0;i<m;i++)
	{ for(j=0;j<n;j++)
		{ printf("%d\t",add[i][j]);
		}printf("\n");
	}
}

void subb(int a[][10],int b[][10],int m,int n)
{
	 for(i=0;i<m;i++)
	      { for(j=0;j<n;j++)
		{ sub[i][j]=a[i][j]-b[i][j];
		}printf("\n");
	      }
	      printf("\nAfter subtracting matrix 1 and 2:\n");
	      for(i=0;i<m;i++)
	      { for(j=0;j<n;j++)
		{ printf("%d\t",sub[i][j]);
		}printf("\n");
	      }
}

void mult(int a[][10],int b[][10],int m,int n)
{
	 for(i=0;i<m;i++)
	      { for(j=0;j<q;j++)
		{ prdt[i][j]=0;
		  for(k=0;k<n;k++)
		  { prdt[i][j]=prdt[i][j]+a[i][k]*b[k][j];
		  }
		}
	      }
	      printf("\nAfter multiplying matrix 1 and 2:\n");
	      for(i=0;i<m;i++)
	      { for(j=0;j<q;j++)
		{ printf("%d\t",prdt[i][j]);
		} printf("\n");
	      }
}
void process()
{
	printf("Enter the number of rows and columns for matrix 1 : ");
	scanf("%d%d",&m,&n);
	printf("Enter the number of rows and columns for matrix 2: ");
	scanf("%d%d",&p,&q);
	if(m==p&&n==q)
	{
		printf("\nEnter the elements  for matrix 1: ");
		for(i=0;i<m;i++)
		{
			for(j=0;j<n;j++)
			{
				scanf("%d",&a[i][j]);
			}
		}
	printf("\nEnter the elements for matrix 2: ");
	for(i=0;i<p;i++)
	{
		for(j=0;j<q;j++)
		{ scanf("%d",&b[i][j]); }
	}
	printf("\nMatrix 1:\n");
	for(i=0;i<m;i++)
	{ for(j=0;j<n;j++)
		{ printf("%d\t",a[i][j]); }
	printf("\n");
	}
	printf("\nMatrix 2:\n");
	for(i=0;i<p;i++)
	{ for(j=0;j<q;j++)
		{ printf("%d\t",b[i][j]);
		}
		printf("\n");
	}
}
}


void main()
{

 clrscr();
 process();
  do
   { printf("\n\n\t\tENTER CHOICE\n\n");
     printf("\n1.Addition");
     printf("\n2.Subtraction");
     printf("\n3.Multiplication");
     printf("\n4.Exit  ");
     scanf("%d",&ch);

     switch(ch)
     { case 1:addd(a,b,m,n);
	      break;
      case 2: subb(a,b,m,n);
	      break;
      case 3: mult(a,b,m,n);
	      break;
      case 4: exit(0);
     }

  }while(ch<4);

 getch();
 }