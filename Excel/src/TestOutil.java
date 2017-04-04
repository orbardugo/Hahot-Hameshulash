import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;

import javax.swing.JButton;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;

public class TestOutil  
{
    public static void main(String[] args) throws Exception 
    {
    	JFrame f=new JFrame();
    	f.setVisible(true);
    	JButton openFile=new JButton("choose file");
    	openFile.setSize(20, 20);
    	f.add(openFile);
    	f.setSize(100, 100);
    	openFile.addActionListener(new ActionListener()
    	{
    		  public void actionPerformed(ActionEvent e)
    		  {
    			  	JFileChooser fileChooser = new JFileChooser();
    		    	fileChooser.setCurrentDirectory(new File(System.getProperty("user.home")));
    		    	int result = fileChooser.showOpenDialog(f);
    		    	File selectedFile=null;
    		    	if (result == JFileChooser.APPROVE_OPTION) {
    		    	    selectedFile = fileChooser.getSelectedFile();
    		    	}
    		    	Table tab = new Table(selectedFile.getAbsolutePath(), "sheet1");
    		    	 Object corps[][] = tab.getBody();
    		         Person[] persons=new Person[corps.length];
    		         for (int i = 0; i < corps.length; i++) {
    		         	persons[i]=new Person(corps[i],i);
    		 		}
    		         JLabel l1=new JLabel();
    		         l1.setSize(100,500);
    		         l1.setText(persons[0].toString());
    		         JLabel l2=new JLabel();
    		         l2.setText(persons[1].toString());
    		         l2.setSize(100,500);
    		         f.add(l1);
    		         f.add(l2);
    		         f.setVisible(true);
    		         
    		  }
    		});
    	
    	
        //Tableau tab = new Tableau("Excel\\test.xlsx", "sheet1");
       
       
        
        
        
        //System.out.println(corps[0][0]);
     /*   corps[1][0] = 5000;
        Object corps2[][] = tab.getBody();
        System.out.println(corps2[1][0]);
        tab.save();*/
    }
}