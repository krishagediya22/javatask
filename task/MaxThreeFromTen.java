//10.. Write a program to find out max1, max2, max3 among 10 values. 
import java.util.Scanner;

public class MaxThreeFromTen {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int max1 = Integer.MIN_VALUE;
        int max2 = Integer.MIN_VALUE;
        int max3 = Integer.MIN_VALUE;

        System.out.println("Enter 10 numbers:");

        for (int i = 1; i <= 10; i++) {
            int num = sc.nextInt();

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

        System.out.println("Max1 (Largest)  = " + max1);
        System.out.println("Max2 (2nd Largest) = " + max2);
        System.out
