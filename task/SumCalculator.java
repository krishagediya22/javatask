/*(26) Write a program to create a class SumCalculator demonstrating variable-length 
arguments (varargs) to calculate sum. */
class SumCalculator {

    // Varargs method
    int sum(int... numbers) {
        int total = 0;

        for (int n : numbers) {
            total = total + n;
        }

        return total;
    }

    public static void main(String args[]) {
        SumCalculator sc = new SumCalculator();

        System.out.println("Sum of 2 numbers = " + sc.sum(10, 20));
        System.out.println("Sum of 3 numbers = " + sc.sum(5, 10, 15));
        System.out.println("Sum of 5 numbers = " + sc.sum(1, 2, 3, 4, 5));
    }
}
