// 03...Write a program to convert the amount from US$ to Indian Rupee.

import java.util.Scanner;

public class USDToINR {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        // Conversion rate (example)
        double rate = 83.0;  // 1 USD = 83 INR

        System.out.print("Enter amount in US Dollars: ");
        double usd = sc.nextDouble();

        double inr = usd * rate;

        System.out.println("Amount in Indian Rupees: ₹" + inr);

        sc.close();
    }
}
