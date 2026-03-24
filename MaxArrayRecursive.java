//14
public class MaxArrayRecursive {

    // Recursive method to find the maximum in the array
    public static int findMax(int[] arr, int n) {
        // Base case: if there's only one element
        if (n == 1) {
            return arr[0];
        }

        // Recursive call: get the maximum of the first n-1 elements
        int maxOfRest = findMax(arr, n - 1);

        // Return the maximum between last element and max of rest
        return Math.max(arr[n - 1], maxOfRest);
    }

    public static void main(String[] args) {
        int[] arr = {4, 7, 1, 9, 3, 8}; // Sample array
        int n = arr.length;

        int max = findMax(arr, n);
        System.out.println("Maximum element in the array is: " + max);
    }
}