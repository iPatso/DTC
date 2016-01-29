import java.util.Scanner;

public class PositiveAverage {
	
	static int MAX_NUMBERS = 100;
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int inputNumber; // = in.nextInt();
		
		System.out.println("Input positive integers:");
		int[] intArray = new int[MAX_NUMBERS];
		int count = 0;
		
		for (int i=0; i<MAX_NUMBERS; i++) {
			inputNumber = in.nextInt();
			if (inputNumber < 0) {
				break;
			} else {
				intArray[i] = inputNumber;
				count += 1;
			}
		}

		System.out.println("\nInputted numbers:");
		printArray(intArray, count);

		System.out.printf("Average: %s\n", formatDoubleIfInt(average(intArray, count)));

	}
	
	//If double is a whole number, then print as digit/int
	public static String formatDoubleIfInt(double dubble) {
		if (dubble % 1.0 != 0)
			return String.format("%s", dubble);
		else
			return String.format("%.0f", dubble);

	}
	
	public static void printArray(int[] arr, int size) {
		for (int i=0; i<size; i++) {
			System.out.printf("%d ", arr[i]);
		}
		System.out.println();
	}

	public static double average(int[] arr, int size) {
		int sum = 0;
		for (int i=0; i<size; i++) {
			sum += arr[i];
		}

		return (double)sum/size;
	}
}