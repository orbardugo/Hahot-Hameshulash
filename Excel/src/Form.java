import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.*;
import java.awt.Component;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.GridLayout;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;

import javax.swing.BorderFactory;
import javax.swing.JButton;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JPanel;
import javax.swing.JScrollBar;
import javax.swing.JScrollPane;
import javax.swing.JTextField;
import javax.swing.ListSelectionModel;
import javax.swing.SwingConstants;
import javax.swing.border.Border;

import com.sun.glass.ui.Window;
import com.sun.javafx.geom.transform.GeneralTransform3D;

import javafx.scene.layout.BorderWidths;



public class Form {
	JFrame mainScreen;
	JPanel main;
	JButton submit;
	JLabel showForm,queryTitle;
	JTextField amountTxtField;
	JPanel queryPanel,resultPanel;
	JList list,list2;
	
	public Form(String[] headers){
		mainScreen= new JFrame();
		Dimension DimMax = Toolkit.getDefaultToolkit().getScreenSize();
		mainScreen.setMaximumSize(DimMax);
		mainScreen.setExtendedState(JFrame.MAXIMIZED_BOTH);
		main = new JPanel();
//		Border blackline = BorderFactory.createLineBorder(Color.black);
//		main.setBorder(blackline);
		//this.main.setLayout(new GridLayout(1,5));
		queryPanel = new JPanel();
		queryPanel.setLayout(new GridBagLayout());
		queryPanel.setPreferredSize(new Dimension((int)(DimMax.width*0.25), (int)(DimMax.height)));
		GridBagConstraints c = new GridBagConstraints();
		
		
		resultPanel = new JPanel();
		//this.queryPanel.setMaximumSize(new Dimension(200, 200));
	
		
		
		
		queryTitle = new JLabel("הפקת דוחות",SwingConstants.CENTER);
		queryTitle.setFont(new Font("Serif", Font.BOLD, 20));
		
		c.fill = GridBagConstraints.HORIZONTAL;
		c.weightx = 0.5;
		c.gridx = 0;
		c.gridy = 0;
		
		queryPanel.add(queryTitle , c);
		
		//Colomns Choose
		//String[] colomns={"a","b","c","d","e","f","g","h"};
		list = new JList<String>(headers);
		list.setSelectionMode(ListSelectionModel.MULTIPLE_INTERVAL_SELECTION);
		list.setVisibleRowCount(5);
		JScrollPane scrollPane_1 = new JScrollPane(list, JScrollPane.VERTICAL_SCROLLBAR_AS_NEEDED,
                JScrollPane.HORIZONTAL_SCROLLBAR_NEVER);
		JScrollBar bar = scrollPane_1.getVerticalScrollBar();
		bar.setPreferredSize(new Dimension(15, 0));
		
		//Options from Colomns choose
		String[] options={"1","2","3","4","5","6","7"};
		list2 = new JList<Object>(options);
		list2.setSelectionMode(ListSelectionModel.MULTIPLE_INTERVAL_SELECTION);
		list2.setVisibleRowCount(5);
		JScrollPane scrollPane_2 = new JScrollPane(list2, JScrollPane.VERTICAL_SCROLLBAR_AS_NEEDED,
                JScrollPane.HORIZONTAL_SCROLLBAR_NEVER);
		
		
		scrollPane_1.setPreferredSize(new Dimension(150, 300));
		scrollPane_2.setPreferredSize(new Dimension(150, 300));
		scrollPane_1.setBorder(BorderFactory.createEmptyBorder(10, 10, 0, 10));
		scrollPane_2.setBorder(BorderFactory.createEmptyBorder(10, 10,0, 10));
		
		
		JPanel twoLists = new JPanel(new GridLayout(1, 2));
		twoLists.add(scrollPane_1);
		twoLists.add(scrollPane_2);
		
		c.fill = GridBagConstraints.HORIZONTAL;
		c.gridx = 0;
		c.gridy = 1;
		
		queryPanel.add(twoLists,c);
		
		JPanel empty=new JPanel();
		
		empty.setPreferredSize(new Dimension((int)(DimMax.width*0.25), (int)(DimMax.height*0.2)));
		c.fill = GridBagConstraints.HORIZONTAL;
		c.gridx = 0;
		c.gridy = 2;
		
		queryPanel.add(empty,c);
		
		JLabel btnSubmit = new JLabel("הצג",SwingConstants.CENTER);
		btnSubmit.setFont(new Font("Serif", Font.BOLD, 20));
		btnSubmit.setBorder(BorderFactory.createLineBorder(Color.black));
		
		resultPanel.setPreferredSize(new Dimension((int)(DimMax.width*0.7), (int)(DimMax.height)));
		resultPanel.setBorder(BorderFactory.createLineBorder(Color.black));
		resultPanel.setBackground(Color.WHITE);
		
		main.add(resultPanel);
		main.add(queryPanel);
		
		
		c.fill = GridBagConstraints.HORIZONTAL;
		c.gridx = 0;
		c.gridy = 3;
		
		queryPanel.add(btnSubmit,c);
		
		
		mainScreen.add(main);
		mainScreen.setVisible(true);
	}
}

