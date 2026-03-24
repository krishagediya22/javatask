//20
class Room {
    double length;
    double breadth;
    double area;

    // Constructor
    Room(double length, double breadth) {
        this.length = length;
        this.breadth = breadth;
        this.area = length * breadth;
    }

    // Method to display room details
    void displayDetails() {
        System.out.println("Length  : " + length);
        System.out.println("Breadth : " + breadth);
        System.out.println("Area    : " + area);
    }

    // Main method to test the class
    public static void main(String[] args) {
        Room room = new Room(10.5, 8.0);
        room.displayDetails();
    }
}