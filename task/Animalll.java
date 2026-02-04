/*(32) Write a program to create parent class Animal with method sound(), child class Dog 
overriding sound(). Demonstrate method overriding.*/

class Animalll {

    void sound() {
        System.out.println("Animal makes a sound");
    }
}

class Dog extends Animalll {

    // Overriding method
    void sound() {
        System.out.println("Dog barks");
    }

    public static void main(String args[]) {

        Animalll a;   // Parent class reference

        a = new Dog();   // Child class object (Upcasting)

        a.sound();   // Calls Dog's overridden method
    }
}
