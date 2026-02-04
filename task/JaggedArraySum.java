//(16) Write a program to calculate the sum of all elements in a jagged array of integers. 
public class JaggedArraySum {
    public static void main(String[] args) {

        // Example jagged array
        int[][] jaggedArray = {
            {1, 2, 3},
            {4, 5},
            {6, 7, 8, 9}
        };

        int sum = 0;

        // Loop through each row
        for (int i = 0; i < jaggedArray.length; i++) {
            // Loop through each element in the row
            for (int j = 0; j < jaggedArray[i].length; j++) {
                sum += jaggedArray[i][j];
            }
        }

        System.out.println("Sum of all elements in jagged array: " + sum);
    }
}
