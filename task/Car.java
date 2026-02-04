/*(21) Write a program to define a Car class with three attributes: brand (String), model 
(String), and year (int). Include a constructor, setter methods, and a method to display 
complete information.*/
class Car {
    String brand;
    String model;
    int year;

    // Constructor
    Car(String brand, String model, int year) {
        this.brand = brand;
        this.model = model;
        this.year = year;
    }

    // Setter methods
    void setBrand(String brand) {
        this.brand = brand;
    }

    void setModel(String model) {
        this.model = model;
    }

    void setYear(int year) {
        this.year = year;
    }

    // Method to display complete information
    void display() {
        System.out.println("Brand : " + brand);
        System.out.println("Model : " + model);
        System.out.println("Year  : " + year);
    }

    public static void main(String args[]) {
        // Create Car object
        Car c1 = new Car("Honda", "City", 2022);

        // Using setter methods
        c1.setBrand("Toyota");
        c1.setModel("Innova");
        c1.setYear(2023);

        // Display details
        c1.display();
    }
}
