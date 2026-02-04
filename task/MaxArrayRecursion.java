//(14) Write a program to find the maximum of an array using recursion. 
import java.util.Scanner;

public class MaxArrayRecursion {
    
    // Recursive function to find max
    public static int findMax(int[] arr, int index) {
        if (index == 0) {
            return arr[0]; // base case
        }
        int max = findMax(arr, index - 1);
        return (arr[index] > max) ? arr[index] : max;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int[] arr = new int[5]; // example: array of 5 numbers

        System.out.println("Enter 5 numbers:");
        for (int i = 0; i < 5; i++) {
            arr[i] = sc.nextInt();
        }

        System.out.println("Maximum number is: " + findMax(arr, arr.length - 1));
        sc.close();
    }
}
