/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <stdio.h>
#include <malloc.h>
struct node {
    int data;
    struct node *next;
};
struct node *head = NULL;
void insert(int e)  {
    struct node *t;
    if(head == NULL) {
        head = (struct node *)malloc(sizeof(struct node));
        head->data = e;
        head->next = NULL;
    }
    else {
        t = head;
        while(t->next != NULL)  {
            t = t->next;
        }
        t->next = (struct node *)malloc(sizeof(struct node));
        t->next->data = e;
        t->next->next = NULL;
    }
}
void disp() {
    struct node *t;
    if(head == NULL) {
        printf("\nLinked List is Empty");
    }
    else {
        t = head;
        printf("\n");
        while(t != NULL) {
            printf("%d\t",t->data);
            t = t->next;
        }
    }
}
void delete(int e) {
    struct node *t;
    if(head == NULL) {   //case 1 when the list is empty
        printf("\nEmpty Linked List");
    }
    else if(head->data == e) { //case 2 a) first element with one element
        //case 2 b) first element with several element
        head = head->next;      //t = head; head = head->next; free(t);
    }
    else  {
        t = head;
        while(t->next != NULL && t->next->data != e) {
            t = t->next;
        }
        if(t->next == NULL) {
            printf("\nElement Not Found");
        }
        else {
            t->next = t->next->next;
        }
    }
}
int main()
{
    insert(10);
    insert(20);
    insert(30);
    disp();
    delete(20);
    disp();
    delete(100);
    disp();
    delete(10);
    disp();
    delete(30);
    disp();

    return 0;
}
