//5
public class PatternPrint {
    public static void main(String[] args) {
        int rows = 4;

        for (int i = 1; i <= rows; i++) {
            if (i == 1) {
                System.out.println("1");
            } else {
                System.out.print("1");
                for (int j = 1; j <= i - 2; j++) {
                    System.out.print("0");
                }
                System.out.println("1");
            }
        }
    }
}