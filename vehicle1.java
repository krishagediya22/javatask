class Vehicle {
    protected int speed;   
}

class Bike extends Vehicle {	
    public void setSpeed(int s) {
        speed = s; 
    }

    public int getSpeed() {
        return speed;
    }

    public static void main(String[] args) {
        Bike b = new Bike();
        b.setSpeed(100);
        System.out.println("Bike speed: " + b.getSpeed());

        
        Vehicle v = new Vehicle();
        
        System.out.println("Vehicle speed: " + v.speed); 
    }
}