/*(18) Write a program to accept an integer using command line and print whether a given 
number is prime or not.*/
class PrimeCmd {
    public static void main(String args[]) {

        // Accept number from command line
        int num = Integer.parseInt(args[0]);

        int count = 0;

        for (int i = 1; i <= num; i++) {
            if (num % i == 0) {
                count++;
            }
        }

        if (count == 2) {
            System.out.println(num + " is a Prime Number");
        } else {
            System.out.println(num + " is Not a Prime Number");
        }
    }
}
