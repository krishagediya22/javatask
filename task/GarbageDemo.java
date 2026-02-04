/*(22) Define a class GarbageDemo that overrides the finalize() method to perform cleanup 
activities before object destruction. Demonstrate calling finalize().*/
class GarbageDemo {

    // Override finalize() method
    protected void finalize() {
        System.out.println("finalize() method called - Cleaning up resources");
    }

    public static void main(String args[]) {

        // Create objects
        GarbageDemo obj1 = new GarbageDemo();
        GarbageDemo obj2 = new GarbageDemo();

        // Make objects eligible for garbage collection
        obj1 = null;
        obj2 = null;

        // Request Garbage Collector
        System.gc();

        System.out.println("Garbage Collection Requested");
    }
}
