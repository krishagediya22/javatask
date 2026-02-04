/*27) Write a program to create a class Demo demonstrating Instance Initialization Block 
(IIB) execution before constructor.*/

class Demo {

    // Instance Initialization Block (IIB)
    {
        System.out.println("Instance Initialization Block executed");
    }

    // Constructor
    Demo() {
        System.out.println("Constructor executed");
    }

    public static void main(String args[]) {
        System.out.println("Main method started");

        Demo d1 = new Demo();

        System.out.println("Main method ended");
    }
}
