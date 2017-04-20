import java.awt.Dimension;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.io.File;

import javax.imageio.ImageIO;
import javax.swing.BorderFactory;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridBagConstraints;
import java.awt.GridLayout;
import java.awt.Insets;

import javax.swing.SwingUtilities;
import javax.swing.border.EmptyBorder;

public class TestOutil  
{
	public static void main(String[] args) throws Exception 
	{

		JFrame frame=new JFrame();
		JPanel panel = new JPanel(new GridLayout(3,0));
		//panel.setLayout(new FlowLayout());
		JButton openFileButton = new JButton();
		JLabel title = new JLabel();
		title.setText("מערכת הפקת דוחות");
		GridBagConstraints c = new GridBagConstraints();
		
		openFileButton.setText("בחר קובץ");
		BufferedImage image;
		image = ImageIO.read(new File("External/HmLogo.png"));
		JLabel picLabel = new JLabel(new ImageIcon(image));
		openFileButton.setBackground(new Color(246,151,32));
		openFileButton.setForeground(new Color(81,43,32));
		openFileButton.setFocusPainted(false);
		openFileButton.setFont(new Font("Tahoma", Font.BOLD, 20));
		title.setFont(new Font("Tahoma", Font.BOLD, 30));
		title.setForeground(new Color(81,43,32));
		title.setHorizontalAlignment(JLabel.CENTER);
		panel.add(picLabel);
		panel.add(title);
		openFileButton.setBorder(BorderFactory.createCompoundBorder(
				BorderFactory.createLineBorder(Color.WHITE, 40), null));
		panel.add(openFileButton);
		
		//panel.add(openFileButton);
		
		frame.add(panel);
		frame.setSize(700, 500);
		frame.setLocationRelativeTo(null);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setVisible(true);

		openFileButton.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent e) {
				JFileChooser fileChooser = new JFileChooser();
				fileChooser.setCurrentDirectory(new File(System.getProperty("user.home")));
				int result = fileChooser.showOpenDialog(frame);
				File selectedFile=null;
				if (result == JFileChooser.APPROVE_OPTION) {
					selectedFile = fileChooser.getSelectedFile();
				}

				Table tab = new Table(selectedFile.getAbsolutePath(), "sheet1");
				Object corps[][] = tab.getBody();
				Person[] persons=new Person[corps.length];
				for (int i = 0; i < corps.length; i++) {
					persons[i]=new Person(corps[i],i);
					System.out.println(persons[i].toString());
				}
				String[] header = tab.getHeader();
				Form a=new Form(header);
			}          
		});

		/*
        JLabel l1=new JLabel();
        l1.setSize(100,500);
        l1.setText(persons[0].toString());
        JLabel l2=new JLabel();
        l2.setText(persons[1].toString());
        l2.setSize(100,500);
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