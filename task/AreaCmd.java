//(19) Write a program to find the area of circle and rectangle using command line argument. 
class AreaCmd {
    public static void main(String args[]) {

        // Command line inputs
        double radius = Double.parseDouble(args[0]);
        double length = Double.parseDouble(args[1]);
        double width  = Double.parseDouble(args[2]);

        // Area calculations
        double areaCircle = 3.14 * radius * radius;
        double areaRect   = length * width;

        // Output
        System.out.println("Radius = " + radius);
        System.out.println("Area of Circle = " + areaCircle);

        System.out.println("Length = " + length);
        System.out.println("Width = " + width);
        System.out.println("Area of Rectangle = " + areaRect);
    }
}
