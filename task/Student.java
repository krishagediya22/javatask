/*(25) Write a program to create a class Student demonstrating constructor overloading (no 
args, name only, name + age). */
class Student {
    String name;
    int age;

    // No-argument constructor
    Student() {
        name = "Not Set";
        age = 0;
    }

    // Constructor with name only
    Student(String name) {
        this.name = name;
        this.age = 0;
    }

    // Constructor with name and age
    Student(String name, int age) {
        this.name = name;
        this.age = age;
    }

    // Method to display details
    void display() {
        System.out.println("Name = " + name);
        System.out.println("Age  = " + age);
        System.out.println("----------------");
    }

    public static void main(String args[]) {

        Student s1 = new Student();
        Student s2 = new Student("Janvi");
        Student s3 = new Student("Rahul", 21);

        s1.display();
        s2.display();
        s3.display();
    }
}
