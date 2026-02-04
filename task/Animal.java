/*(30) Write a program to create a multilevel inheritance hierarchy: Animal → Mammal → 
Dog. Demonstrate method calls from all levels.*/

class Animal {

    void eat() {
        System.out.println("Animal is eating");
    }
}

class Mammal extends Animal {

    void walk() {
        System.out.println("Mammal is walking");
    }
}

class Dog extends Mammal {

    void bark() {
        System.out.println("Dog is barking");
    }

    public static void main(String args[]) {

        Dog d = new Dog();

        d.eat();    // From Animal
        d.walk();   // From Mammal
        d.bark();   // From Dog
    }
}
