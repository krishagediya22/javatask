class Mathsum 
{
    public static void main(String[] args) {
        int i = 7;
        int j = -9;
        double x = 72.3;
        double y = 0.34;

        System.out.println("i is " + i);
        System.out.println("j is " + j);
        
        
        System.out.println("|" + i + "| is " + Math.abs(i));
        System.out.println("|" + j + "| is " + Math.abs(j));

        
        System.out.println(x + " round=== " + Math.round(x));
        System.out.println(y + " round=== " + Math.round(y));

        
        System.out.println("min(" + i + "," + j + ") is " + Math.min(i,j));
		System.out.println("min(" + x + "," + y + ") is " + Math.min(x,y));
        System.out.println("max(" + x + "," + y + ") is " + Math.max(i,j));
		System.out.println("max(" + x + "," + y + ") is " + Math.max(x,y));

       
        System.out.println("pow(2, 2) is " + Math.pow(2, 2));
		System.out.println("pow(10.0,3)is"+Math.pow(10.0,3));
        System.out.println("pow(-3, 2) is " + Math.pow(-3, 2));

     
        for (int i = 0; i < 10; i++)
			{
            System.out.println("The square root of " + i + " is " + Math.sqrt(i));
        }
    }
}