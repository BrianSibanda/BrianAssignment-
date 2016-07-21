import java.util.Scanner;

public class HelloWorld
    {
        public static void main (String [] args)
            {
                Scanner scan = new Scanner(System.in);
        
                String userName;
        
                System.out.println("Please enter user name");
                userName = scan.next();
        
                System.out.println("Hello, " + userName + "," + " welcome back!");        
            }
   }
