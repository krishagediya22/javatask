//(12) Write a program to check whether a given string is palindrome or not. 

import java.util.Scanner;

public class PalindromeCheck {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Enter a string: ");
        String str = sc.nextLine();

        // Remove spaces and convert to lowercase for uniformity
        String cleanStr = str.replaceAll("\\s+", "").toLowerCase();

        String reversed = "";
        for (int i = cleanStr.length() - 1; i >= 0; i--) {
            reversed += cleanStr.charAt(i);
        }

        if (cleanStr.equals(reversed)) {
            System.out.println("\"" + str + "\" is a Palindrome");
        } else {
            System.out.println("\"" + str + "\" is NOT a Palindrome");
        }

        sc.close();
    }
}
