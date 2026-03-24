import java.util.Random; 


public class Randomtest1
 { 
    public static void main(String[] args) {
        Random random = new Random();
        
        System.out.println(random.nextInt(10));
        System.out.println(random.nextBoolean());
        System.out.println(random.nextDouble());
        System.out.println(random.nextFloat());
    }   
}