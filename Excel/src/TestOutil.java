import javax.swing.JFrame;
import javax.swing.JLabel;

public class TestOutil  
{
    public static void main(String[] args) throws Exception 
    {
        Tableau tab = new Tableau("Excel\\test.xlsx", "sheet1");
        Object corps[][] = tab.getBody();
        Person[] persons=new Person[corps.length];
        for (int i = 0; i < corps.length; i++) {
        	persons[i]=new Person(corps[i],i);
        	
        	//check
        	//jkj
		}
        JFrame f=new JFrame();
        JLabel l1=new JLabel();
        l1.setText(persons[0].toString());
        JLabel l2=new JLabel();
        l1.setText(persons[1].toString());
       // JLabel l3=new JLabel();
       // l1.setText(persons[2].toString());
        f.add(l1);
        f.add(l2);
      //  f.add(l3);
        f.setVisible(true);
        f.setSize(500, 500);
        
        //System.out.println(corps[0][0]);
     /*   corps[1][0] = 5000;
        Object corps2[][] = tab.getBody();
        System.out.println(corps2[1][0]);
        tab.save();*/
    }
}