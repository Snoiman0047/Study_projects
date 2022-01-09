/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

/**
 *
 * @author snoim
 */
public class SoftwareProduct extends Product
{
    
    private int NumberOfUsers;
    
    /*  Constructors  */

    public SoftwareProduct() { }

    public SoftwareProduct(int NumberOfUsers, long ID, String Name, String Description, float PricePerUnit) 
    {
        super(ID, Name, Description, PricePerUnit);
        this.NumberOfUsers = NumberOfUsers;
    } 
    
    /*  Properties  */

    public int getNumberOfUsers() { return NumberOfUsers; }
    public void setNumberOfUsers(int NumberOfUsers) { this.NumberOfUsers = NumberOfUsers; }  
    
    /*  Functions  */
        
    @Override
    public float getPrice()
    { return this.getNumberOfUsers()+ this.getPricePerUnit(); }
     
}