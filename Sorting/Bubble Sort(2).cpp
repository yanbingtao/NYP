// Define Header Files
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

// Define Constant
#define MAX_ITEMS 30	// Maximum number of elements in the array

// Define Function Prototypes
void introPage();
void menuPage();
void endPage();
void displayArray(int [],int);
void bubble();
void bubbleSort(int [], int);

// The Starting Function
void main()
{
    introPage();	 
    menuPage();
    endPage();   
}

// Introduce the project and team members
void introPage()
{
    // Display Introduction Page
    printf("	***********************************************************\n");
    printf("	*                     Introduction Page                   *\n");
    printf("	***********************************************************\n");
	
    //  Wait for 3 seconds before clearing the screen
    _sleep(3000);
    system("cls");
}

// Display Thank you message at the end of program
void endPage()
{
    // Clear the screen before displaying Ending Page
    system("cls");
    printf("	***********************************************************\n");
    printf("	*                     Thank you!                                        *\n");
    printf("	***********************************************************\n\n\n");
}

// Display menu to take user input and execute the function
void menuPage()
{  
    int choice;	// user selection
    
    do
    {
        // Clear the screen before displaying Main Menu
        system("cls");
        printf("			*******************************	\n");
        printf("			*  Main Operation             *	\n");
        printf("			*******************************	\n");
        printf("			1. Bubble Sort				\n");
        printf("			2. Selection Sort			\n");
        printf("			3. Insertion Sort				\n");
        printf("			4. Shell Sort					\n");
        printf("			5. Quick Sort					\n");
        printf("			6. Exit.								\n\n");

        // Get user selection
        printf("			Please input your choice: ");
        scanf("%d",&choice);
     
        // Clear the screen before calling sort function
        system("cls");

        switch (choice)
        {
		case 1 :	bubble();
						break;
		case 6 :	break;
		default :	printf("\n\n		Your choice is invalid !\n");
						_sleep(3000);
        }
    }
    while(choice != 6);
}

// Display array elements 
void displayArray(int arrayToSort[],int sizeOfArray)
{
    for (int i=0; i<sizeOfArray; i++)
    {
        printf("%d ",arrayToSort[i]);
    }    
    printf("\n");
}

// Bubble sort function
void bubble()
{   
    // You should change these two lines :

    int arrayToSort[MAX_ITEMS]={18,17,45,17,22,7,62,31,15,5};             // Array to be sorted
    int sizeOfArray=10;					// Number of elements in the array

    //  to:
    //
    //	int arrayToSort[MAX_ITEMS];
    //	int sizeOfArray;
    //
    // and write a loop to prompt user to enter array elements and then count the number 
    // of elements entered (sizeOfArray).   

    printf("*************************************************************************\n");
    printf("*				Bubble Sort			        *\n");  
    printf("*************************************************************************\n\n");; 

    printf("Bubble Sort works by repeatedly stepping through the list to be sorted,	    \n");
    printf("comparing each pair of adjacent items and swapping them if they are in	\n");
    printf("the wrong order.	\n\n");

    // Print unsorted array
    printf("\t\t\t  Unsorted Array:     ");
    displayArray(arrayToSort, sizeOfArray);
        
    // Call bubble-sort algorithm
    bubbleSort(arrayToSort, sizeOfArray);
    
    // Print sorted array
    printf("\n\n \t\t\t     Sorted Array:    ");
    displayArray(arrayToSort, sizeOfArray);

    printf("\nPress any key to continue......");
    getch();    
}

// The bubble-sort algorithm makes several passes through the array. On each pass, 
// successive neighbouring pairs are compared. 
// If a pair is in decreasing order, its values are swapped; otherwise, the values remain unchanged. 
// The technique is called a bubble sort or sinking sort because the smaller values gradually 
// “bubble” their way to the top and the larger values “sink” to the bottom. 
void bubbleSort(int arrayToSort[], int sizeOfArray)
{
    // Make several passes through the array
    for ( int i=1 ; i<=sizeOfArray-1 ; i++ )         
    {
		int  j ;

		printf("\nPass %d",i);
		printf("\n======\n");

		// Loop over elements in the array 
		for ( j = 0 ; j<sizeOfArray-i ; j++)		 
		{
			printf("Comparing %2d and %2d, ",arrayToSort[j], arrayToSort[j+1]);

			// Comparing adjacent elements 
			if ( arrayToSort[j] > arrayToSort[j+1] )	// If there are in decreasing order,	 
			{
				printf("%2d > %2d, ",arrayToSort[j], arrayToSort[j+1]);
				printf(" Swap --------> ");

				// Swap elements
				int temp=arrayToSort[j];		 
				arrayToSort[j]=arrayToSort[j+1];
				arrayToSort[j+1]=temp;

				// Print array
				displayArray(arrayToSort, sizeOfArray);		
			}
			else 	// otherwise (increasing order),
			{
				// No change

				printf("%2d <= %2d, ",arrayToSort[j], arrayToSort[j+1]);
				printf("No change ---> ");

				// Print array
				displayArray(arrayToSort, sizeOfArray);		
			}
		}
    }
}
