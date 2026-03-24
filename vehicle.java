class vehicle
{
	void run()
	{
		System.out.println("vehicle is running");
	}
}
class Bike extends vehicle
{
	void run()
	{
		System.out.println("Bike is running safely");
	}
}
class main
{
	public static void main(String args[] )
	{
		vehicle v=new vehicle();
		v.run();
		Bike obj=new Bike();
		obj.run();
	}
}
