import java.util.Scanner;

public class PositiveAverage {
	
	static int MAX_NUMBERS = 100;
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int inputNumber; // = in.nextInt();
		
		System.out.println("Input positive integers:");
		int[] intArray = new int[MAX_NUMBERS];
		
		for (int i=0; i<MAX_NUMBERS; i++) {
			inputNumber = in.nextInt();
			if (inputNumber < 0) {
				break;
			} else {
				intArray[i] = inputNumber;
			}
		}
		printArray(intArray);
	}
	
	
	private static void printArray(int[] arr) {
		for (int i=0; i<4; i++) {
			System.out.println(arr.toString());
		}
	}
}