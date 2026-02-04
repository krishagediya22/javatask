/*(29) Write a program to create parent class Animal with method eat(), child class Dog with 
method bark(), demonstrating single inheritance. */

class Animal {

    void eat() {
        System.out.println("Animal is eating");
    }
}

class Dog extends Animal {

    void bark() {
        System.out.println("Dog is barking");
    }

    public static void main(String args[]) {

        Dog d = new Dog();

        d.eat();    // Inherited method
        d.bark();   // Child class method
    }
}


