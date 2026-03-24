//19
class AreaCalculation {
    public static void main(String[] args) {

        // Convert command line arguments to double
        double radius = Double.parseDouble(args[0]);
        double length = Double.parseDouble(args[1]);
        double breadth = Double.parseDouble(args[2]);

        // Calculate areas
        double circleArea = Math.PI * radius * radius;
        double rectangleArea = length * breadth;

        // Display results
        System.out.println("Area of Circle = " + circleArea);
        System.out.println("Area of Rectangle = " + rectangleArea);
    }
}