/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <stdio.h>
int insert(int a[],int pos,int e) //for insertion and return the position
{
    if(pos + 1 == 5) //checking the array is full or not
    {
        printf("Error : Array is full");
    }
    else 
    {
        a[++pos] = e;  //increment the position by 1 then inserrt
    }
    return pos;
}
int delete(int a[],int pos) 
{
    if(pos == -1)
    {
        printf("Error : Array is empty");
    }
    else
    {
        printf("Deleted Element : %d",a[pos--]);
    }
    return pos;
}
int menu() 
{
    int ch;
    printf("Insert  - 1\nDelete - 2\nExit - 3\nUr Choice");
    scanf("%d",&ch);
    return ch;
}
void process()
{
    int ch;
    int a[5],pos=-1;
    for(ch = menu();ch != 3;ch = menu())
    {
        switch(ch) 
        {
            case 1:
                printf("\nEnter the element");
                scanf("%d",&ch);
                pos = insert(a,pos,ch);
                break;
            case 2:
                pos = delete(a,pos);
                break;
            default:
                printf("\nError : Wrong Choice");
                break;
        }
    }
}
int main()
{
    process();
    return 0;
}
