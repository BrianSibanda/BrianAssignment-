import javax.swing.JOptionPane;

    public class HelloUserName
        {
            public static void main (String [] args)
                {
                    String userName;                
                    userName = JOptionPane.showInputDialog("Please enter user name");
                
                    JOptionPane.showMessageDialog(null, "Hello, " + userName + "," + " welcome back!");
                    
                    System.exit(0);
                }
        }

 