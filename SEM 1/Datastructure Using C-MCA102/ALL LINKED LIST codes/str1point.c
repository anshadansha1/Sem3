/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <stdio.h>
#include <malloc.h>
struct stud 
{
    int no;
    char name[20];
};
int main()
{
    struct stud *s;
    s = (struct stud*)malloc(sizeof(struct stud));
    printf("Enter the no and name");
    scanf("%d%s",&s->no,&s->name);
    printf("No %d Name %s",s->no,s->name);
    free(s);
    return 0;
}
