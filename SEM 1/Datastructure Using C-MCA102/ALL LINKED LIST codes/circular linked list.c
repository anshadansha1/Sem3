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
        head->next = head; //
    }
    else {
        t = head;
        while(t->next != head)  {
            t = t->next;
        }
    t->next = (struct node *)malloc(sizeof(struct node));
        t->next->data = e;
        t->next->next = head;/////
    }
}
void disp() {
    struct node *t;
    if(head == NULL) {
        printf("\nCircular Linked List is Empty");
    }
    else {
        t = head;
        printf("\n");
        while(t->next != head) {
            printf("%d\t",t->data);
            t = t->next;
        }
        printf("%d",t->data);
    }
}
void disp_2() {
    struct node *t;
    if(head == NULL) {
        printf("\nCircular Linked List is Empty");
    }
    else {
        t = head;
        printf("\n");
        do {
            printf("%d\t",t->data);
            t = t->next;
        }while(t != head);
    }
}
void delete(int e) {
    struct node *t;
    if(head == NULL) {   //case 1 when the list is empty
        printf("\nEmpty Circular Linked List");
    }
    else if(head->data == e && head->next == head) { 
        head = NULL;   //first element with one element  
    }
    else if(head->data == e)
    {           //first element with several element
        t = head;
        while(t->next != head) { //finding the last node
            t = t->next;
        }    //changing the last node next address
        t->next = head->next; 
        head = head->next; //changing the head address
    }
    else  {
        t = head; //searching for the element 
        while(t->next != head && t->next->data != e) {
            t = t->next;
        }
        if(t->next == head) {
            printf("\nElement Not Found");
        }
        else { //deleting the intermediate or last element
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
    disp_2();
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
