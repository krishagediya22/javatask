//10
import java.util.Scanner;

public class MaxThreeValues {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int[] numbers = new int[10];

        // Input 10 numbers
        System.out.println("Enter 10 numbers:");
        for (int i = 0; i < 10; i++) {
            numbers[i] = sc.nextInt();
        }

        // Initialize max1, max2, max3
        int max1 = Integer.MIN_VALUE;
        int max2 = Integer.MIN_VALUE;
        int max3 = Integer.MIN_VALUE;

        // Find max1, max2, max3
        for (int num : numbers) {
            if (num > max1) {
                max3 = max2;
                max2 = max1;
                max1 = num;
            } else if (num > max2) {
                max3 = max2;
                max2 = num;
            } else if (num > max3) {
                max3 = num;
            }
        }

        // Output the results
        System.out.println("The largest three numbers are:");
        System.out.println("Max1: " + max1);
        System.out.println("Max2: " + max2);
        System.out.println("Max3: " + max3);

        sc.close();
    }
}