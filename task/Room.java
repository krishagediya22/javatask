/*(20) Define a Room class with attributes length, breadth and area. Define a suitable 
constructor and method to display the details of Room.*/
class Room {
    double length;
    double breadth;
    double area;

    // Constructor
    Room(double l, double b) {
        length = l;
        breadth = b;
        area = length * breadth;
    }

    // Method to display room details
    void display() {
        System.out.println("Length = " + length);
        System.out.println("Breadth = " + breadth);
        System.out.println("Area = " + area);
    }

    public static void main(String args[]) {
        // Create Room object
        Room r1 = new Room(10, 5);

        // Display details
        r1.display();
    }
}
