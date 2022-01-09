/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package storemanagerguiview;

import controller.Backend_DAO_db;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.HeadlessException;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.WindowConstants;
import model.Customer;

/**
 *
 * @author snoim
 */
public class AddNewCustomerForm extends JFrame
{
    
    private JButton jButtonOK; 
    private JLabel jLabelID; 
    private JLabel jLabelName; 
    private JLabel jLabelAddress; 
    private JTextField jTextFieldID; 
    private JTextField jTextFieldName; 
    private JTextField jTextFieldAddress;

    public AddNewCustomerForm() throws HeadlessException 
    {
      
        jButtonOK = new JButton("OK"); 
        jLabelID = new JLabel("Tz:"); 
        jLabelName = new JLabel("Name:"); 
        jLabelAddress = new JLabel("Address:"); 
        jTextFieldID = new JTextField(); 
        jTextFieldName = new JTextField(); 
        jTextFieldAddress = new JTextField();
      
        
        this.getContentPane().add(jLabelID); 
        this.getContentPane().add(jTextFieldID);
        this.getContentPane().add(jLabelName); 
        this.getContentPane().add(jTextFieldName);
        this.getContentPane().add(jLabelAddress); 
        this.getContentPane().add(jTextFieldAddress);
        this.add(jButtonOK);
   
        
        jButtonOK.setBackground(new java.awt.Color(22, 147, 145));
        jButtonOK.setFont(new java.awt.Font("Gabriola", 0, 18)); 
        jButtonOK.setForeground(new java.awt.Color(51, 51, 51));
        jButtonOK.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(0, 153, 153), 0, true));
        
        jLabelID.setFont(new java.awt.Font("Bahnschrift", 0, 18));
        jLabelName.setFont(new java.awt.Font("Bahnschrift", 0, 18));
        jLabelAddress.setFont(new java.awt.Font("Bahnschrift", 0, 18));
        
        jTextFieldID.addKeyListener(new KeyAdapter() 
        {
            @Override
            public void keyTyped(KeyEvent ke)
            {
                if(!Character.isDigit(ke.getKeyChar()) || jTextFieldID.getText().length() >= 9)
                    ke.consume();
            }
        });
       
        jButtonOK.addActionListener(new ActionListener() 
        {
            public void actionPerformed(ActionEvent ae)
            {
                try
                {
                     if (jTextFieldID.getText().isEmpty())
                        throw new Exception("The Tz field is required");
                     if (jTextFieldID.getText().length() < 9)
                        throw new Exception("ID is not valid");
                    if (jTextFieldName.getText().isEmpty())
                        throw new Exception("The name field is required");
                    Customer c = new Customer();
                    c.setId(Long.parseLong(jTextFieldID.getText()));
                    c.setName(jTextFieldName.getText());
                    c.setAddress(jTextFieldAddress.getText());
                    Backend_DAO_db.Get_singleton().AddCustomer(c);
                    JOptionPane.showMessageDialog(AddNewCustomerForm.this, "Customer was successfully added");
                }
                catch (Exception ex)
                { JOptionPane.showMessageDialog(AddNewCustomerForm.this, ex.getMessage()); }
            }
        });
        
        this.setTitle("Add customer");
        this.setPreferredSize(new Dimension(400, 200)); 
        this.getContentPane().setLayout(new GridLayout(0,2,10,10)); 

        this.setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE); 
        this.pack();  
    }
    
    

    
}
