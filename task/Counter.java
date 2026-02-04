/*(23) Write a program to create a class Counter with a static variable count and a non-static 
variable number. Increment count in constructor and display both number and count. */
class Counter {
    static int count = 0;   // Static variable (shared)
    int number;            // Non-static variable (separate)

    // Constructor
    Counter(int number) {
        this.number = number;
        count++;   // Increment static variable
    }

    // Method to display values
    void display() {
        System.out.println("Number = " + number);
        System.out.println("Count  = " + count);
    }

    public static void main(String args[]) {

        Counter c1 = new Counter(10);
        c1.display();

        Counter c2 = new Counter(20);
        c2.display();

        Counter c3 = new Counter(30);
        c3.display();
    }
}
