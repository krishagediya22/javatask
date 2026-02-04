/*(24) Write a program to create a class Calculator demonstrating method overloading with 
different add methods (two ints, three ints, two doubles).*/
class Calculator {

    // Add two integers
    int add(int a, int b) {
        return a + b;
    }

    // Add three integers
    int add(int a, int b, int c) {
        return a + b + c;
    }

    // Add two double values
    double add(double a, double b) {
        return a + b;
    }

    public static void main(String args[]) {
        Calculator calc = new Calculator();

        System.out.println("Add two ints: " + calc.add(10, 20));
        System.out.println("Add three ints: " + calc.add(5, 10, 15));
        System.out.println("Add two doubles: " + calc.add(2.5, 3.5));
    }
}
