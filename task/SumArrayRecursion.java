//(15) Write a program to find the sum of an array using recursion. 
import java.util.Scanner;

public class SumArrayRecursion {

    // Recursive function to find sum
    public static int sumArray(int[] arr, int index) {
        if (index < 0) {
            return 0; // base case
        }
        return arr[index] + sumArray(arr, index - 1);
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int[] arr = new int[5]; // example array size
        System.out.println("Enter 5 numbers:");
        for (int i = 0; i < 5; i++) {
            arr[i] = sc.nextInt();
        }

        int sum = sumArray(arr, arr.length - 1);
        System.out.println("Sum of array elements is: " + sum);

        sc.close();
    }
}
