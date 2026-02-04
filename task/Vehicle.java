/*(34) Write a program to create interface Vehicle with start() method. Classes Car and Bike 
implement Vehicle with their own start() definitions.*/

interface Vehicle {

    void start();   // Abstract method
}

class Car implements Vehicle {

    public void start() {
        System.out.println("Car starts with key");
    }
}

class Bike implements Vehicle {

    public void start() {
        System.out.println("Bike starts with self start or kick");
    }

    public static void main(String args[]) {

        Vehicle v;

        v = new Car();
        v.start();   // Car's start()

        v = new Bike();
        v.start();   // Bike's start()
    }
}
