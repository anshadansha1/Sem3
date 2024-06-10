#include<stdio.h>
#define MAX_SIZE 100

//GLobal variables
int arr[MAX_SIZE];
int size=0;

//Function prototypes
void menu();
void insertEl();
void searchEl();
void deleteEl();
void sortArr();
void displayArr();

int main(){
    int choice;
    do {
        menu();
        printf("\nEnter your choice : ");
        scanf("%d",&choice);

        switch(choice){
            case 1:
                insertEl();
                break;
            case 2:
                searchEl();
                break;
            case 3:
                deleteEl();
                break;
            case 4:
                sortArr();
                break;
            case 5:
                displayArr();
                break;
            case 6:
                printf("\nExiting program....\n");
                break;
            default:
                printf("\nInvalid choice.Try agan.\n");
        }
        
    }while(choice != 6);

    return 0;
}

void menu(){
    printf("\n----MENU----\n");
    printf("1.Insert. \n2.Search.\n3.Delete.\n4.Sort.\n5.Display.\n6.Exit.\n");

}

void insertEl(){
    int i,trv;
    printf("\nEnter the number ")
}





