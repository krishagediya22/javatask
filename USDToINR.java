//3
import java.util.Scanner;

public class USDToINR {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        // Example exchange rate
        double exchangeRate = 83.0; // 1 USD = 83 INR

        System.out.print("Enter amount in US Dollars: ");
        double usd = sc.nextDouble();

        double inr = usd * exchangeRate;

        System.out.println("Amount in Indian Rupees: ₹" + inr);

        sc.close();
    }
}