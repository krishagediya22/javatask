/*(35) Write a program to create interface Shape with area() method. Classes Circle and 
Rectangle implement Shape with their own area() calculations.*/

interface Shapee {

    void area();   // Abstract method
}

class Circle implements Shapee {
    double radius = 7;

    public void area() {
        double a = 3.14 * radius * radius;
        System.out.println("Area of Circle = " + a);
    }
}

class Rectangle implements Shape {
    double length = 10;
    double breadth = 5;

    public void area() {
        double a = length * breadth;
        System.out.println("Area of Rectangle = " + a);
    }

    public static void main(String args[]) {

        Shapee s;

        s = new Circle();
        s.area();

        s = new Rectangle();
        s.area();
    }
}
