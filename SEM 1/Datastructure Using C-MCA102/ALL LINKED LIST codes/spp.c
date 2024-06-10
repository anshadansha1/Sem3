/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/
#include <stdio.h>
#include <malloc.h>
struct one {
    int a;
    struct one *b;
};
int main()  {
    struct one *s;
    s = (struct one *)malloc(sizeof(struct one));
    s->a = 10;
    s->b = (struct one *)malloc(sizeof(struct one));
    s->b->a = 20;
    s->b->b = (struct one *)malloc(sizeof(struct one));
    s->b->b->a = 30;
    printf("%d  %d   %d",s->a,s->b->a,s->b->b->a);
    free(s->b->b); free(s->b);  free(s);
    return 0;
}
