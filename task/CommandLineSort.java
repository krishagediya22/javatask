/*(17) Write a program to accept an array of strings in the command line and arrange them in 
alphabetical order.*/
import java.util.Arrays;

public class CommandLineSort {
    public static void main(String[] args) {

        if (args.length == 0) {
            System.out.println("Please provide some strings as command line arguments.");
            return;
        }

        // args already contains the strings entered in command line
        System.out.println("Original order:");
        for (String str : args) {
            System.out.print(str + " ");
        }
        System.out.println();

        // Sort the strings in alphabetical order
        Arrays.sort(args);

        System.out.println("Alphabetical order:");
        for (String str : args) {
            System.out.print(str + " ");
        }
        System.out.println();
    }
}
 
