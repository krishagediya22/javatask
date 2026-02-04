/*(31) Write a program to create parent class Animal, child classes Dog and Cat. Demonstrate 
hierarchical inheritance with methods eat(), bark(), and meow().*/

class Animall {

    void eat() {
        System.out.println("Animal is eating");
    }
}

class Dog extends Animall {

    void bark() {
        System.out.println("Dog is barking");
    }
}

class Cat extends Animall {

    void meow() {
        System.out.println("Cat is meowing");
    }

    public static void main(String args[]) {

        Dog d = new Dog();
        Cat c = new Cat();

        d.eat();    // From Animal
        d.bark();   // From Dog

        c.eat();    // From Animal
        c.meow();   // From Cat
    }
}
