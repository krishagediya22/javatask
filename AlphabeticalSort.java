//17
import java.util.Arrays;

public class AlphabeticalSort {
    public static void main(String[] args) {

        // Check if any arguments are passed
        if (args.length == 0) {
            System.out.println("Please provide some strings as command-line arguments.");
            return;
        }

        // Sort the array of strings alphabetically
        Arrays.sort(args);

        // Display the sorted strings
        System.out.println("Strings in alphabetical order:");
        for (String str : args) {
            System.out.println(str);
        }
    }
}