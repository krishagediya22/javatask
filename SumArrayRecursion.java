//15
import java.util.Scanner;

public class SumArrayRecursion {

    // Recursive method to find sum of array
    public static int sumArray(int[] arr, int n) {
        if (n <= 0) { // Base case: no elements left
            return 0;
        } else {
            return sumArray(arr, n - 1) + arr[n - 1]; // Sum of first n-1 elements + last element
        }
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter the size of the array: ");
        int size = sc.nextInt();

        int[] arr = new int[size];

        System.out.println("Enter the elements of the array:");
        for (int i = 0; i < size; i++) {
            arr[i] = sc.nextInt();
        }

        int sum = sumArray(arr, size);
        System.out.println("The sum of the array elements is: " + sum);

        sc.close();
    }
}