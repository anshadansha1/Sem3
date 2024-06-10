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
    struct node *prev; 
};
struct node *head = NULL;
void insert(int e)  {
    struct node *t;
    if(head == NULL) {
        head = (struct node *)malloc(sizeof(struct node));
        head->data = e;
        head->next = NULL;
        head->prev = NULL;
    }
    else {
        t = head;
        while(t->next != NULL)  {
            t = t->next;
        }
        t->next = (struct node *)malloc(sizeof(struct node));
        t->next->data = e;
        t->next->next = NULL;
        t->next->prev = t;
    }
}
void disp() {
    struct node *t;
    if(head == NULL) {
        printf("\nDoubly Linked List is Empty");
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
        printf("\nEmpty Doubly Linked List");
    }
    else if(head->data == e && head->next == NULL) { 
        // first element with one element
        head = NULL;      
    }
    else if(head->data == e) // first element but several
    {
        head = head->next;   // moving head to second element
        head->prev = NULL;   // making the pev as NULL
    }
    else  {
        t = head->next; //traversing the list to find 
        while(t != NULL && t->data != e) {
            t = t->next;
        }
        if(t== NULL)  // element not found
        {
            printf("Element Not Found");
        }
        else if(t->next == NULL) { //deleting the last node
            t->prev->next = NULL;
        }
        else {  //deleting the intermediate node
            t->prev->next = t->next;
            t->next->prev = t->prev;
        }
    }
}
int main()    {
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
