#include <iostream>

using namespace std;

void printArray(int arr[], int size);
void mergeSort(int unsortedArray[], int arraySize);
void splitThenMerge(int unsortedArray[], int startIndex, int endIndex, int workingArray[]);
void mergeHalves(int unsortedArray[], int startIndex, int middleIndex, int endIndex, int workingArray[]);
void updateArray(int unsortedArray[], int startIndex, int endIndex, int workingArray[]);

const int MAX_NUMBERS = 20;

int main(int argc, const char* argv[]) {
    // IMPORTANT NOTE: This main() could be implemented better (most likely with a liked list). Due to time
    // restraints and the need to get the program working, an array of 20 is made, but the input can
    // take less than MAX_NUMBERS numbers.
    // ALSO: This program only sorts arrays of positive numbers.
    // ALSO: There is no exception handling for inputs.

    int arr[MAX_NUMBERS];
    int inputtedNumber;
    int count = 0;
    cout << "Input a list containing 1 to " << MAX_NUMBERS << " positive numbers, then a negative number when finished:\n";
    while (count < MAX_NUMBERS) {
        cin >> inputtedNumber;
        if (inputtedNumber < 0){
            break;
        } else {
            arr[count] = inputtedNumber;
            count++;
        }
    }

    cout << "\n\nInputted/Non-sorted array:\n";
    printArray(arr, count);

    cout << "\nSorted array:\n";
    mergeSort(arr, count);
    printArray(arr, count);

    return 0;
}

void printArray(int arr[], int size) {
    for (int i=0; i<size; i++) {
        cout << arr[i] << " ";
    }
    cout << endl << endl;
}

/*
unsortedArray: Inputted unsorted array that needs to be sorted
 workingArray: Temporary array used for work
    arraySize: Size of the unsortedArray
*/
void mergeSort(int unsortedArray[], int arraySize) {
    int workingArray[arraySize];
    splitThenMerge(unsortedArray, 0, arraySize, workingArray);
}

/*
unsortedArray: Inputted unsorted array that needs to be sorted
   startIndex: Beginning index (inclusive)
     endIndex: Last index (exclusive), so NOT a valid index in the array
 workingArray: Temporary array used for work
*/
void splitThenMerge(int unsortedArray[], int startIndex, int endIndex, int workingArray[]) {
    if (endIndex - startIndex == 1) {
        return;
    }

    int middleIndex = (startIndex + endIndex) / 2; //Average b/c startIndex and endIndex not always the same
    splitThenMerge(unsortedArray, startIndex, middleIndex, workingArray);
    splitThenMerge(unsortedArray, middleIndex, endIndex, workingArray);
    mergeHalves(unsortedArray, startIndex, middleIndex, endIndex, workingArray);
    updateArray(unsortedArray, startIndex, endIndex, workingArray);
}

/*
unsortedArray: Inputted unsorted array that needs to be sorted
   startIndex: Beginning index (inclusive)
  middleIndex: Middle index (will be used both as inclusive and exclusive)
     endIndex: Last index (exclusive), so NOT a valid index in the array
 workingArray: Temporary array used for work
*/
void mergeHalves(int unsortedArray[], int startIndex, int middleIndex, int endIndex, int workingArray[]) {
    int firstHalfIndex = startIndex, secondHalfIndex = middleIndex;

    //Compare values of firstHalfIndex and secondHalfIndex. Place smaller value in workingArray.
    //Increment index of lower value.
    for (int i=startIndex; i<endIndex; i++) {
        // First check if firstHalfIndex is out of its boundary. If so, then just need to print
        // the rest of the second half. Otherwise, first check if secondHalfIndex is out of its
        // boundary. Act accordingly.
        if (firstHalfIndex < middleIndex && (secondHalfIndex >= endIndex || unsortedArray[firstHalfIndex] < unsortedArray[secondHalfIndex])) {
            workingArray[i] = unsortedArray[firstHalfIndex];
            firstHalfIndex++;
        } else {
            workingArray[i] = unsortedArray[secondHalfIndex];
            secondHalfIndex++;
        }
    }
    printArray(unsortedArray, endIndex);
}

/*
unsortedArray: Inputted unsorted array that needs to be sorted
   startIndex: Beginning index (inclusive)
     endIndex: Last index (exclusive), so NOT a valid index in the array
 workingArray: Temporary array used for work
*/
void updateArray(int unsortedArray[], int startIndex, int endIndex, int workingArray[]) {
    for (int i=startIndex; i<endIndex; i++) {
        unsortedArray[i] = workingArray[i];
    }
}