/*(33) Write a program to create parent class Shape with area() method. Child classes Circle 
and Rectangle override area() to calculate and display actual area. */

class Shape {

    void area() {
        System.out.println("Area of Shape is not defined");
    }
}

class Circle extends Shape {
    double radius = 7;

    void area() {
        double a = 3.14 * radius * radius;
        System.out.println("Area of Circle = " + a);
    }
}

class Rectangle extends Shape {
    double length = 10;
    double breadth = 5;

    void area() {
        double a = length * breadth;
        System.out.println("Area of Rectangle = " + a);
    }

    public static void main(String args[]) {

        Shape s;

        s = new Circle();
        s.area();   // Calls Circle's area()

        s = new Rectangle();
        s.area();   // Calls Rectangle's area()
    }
}
