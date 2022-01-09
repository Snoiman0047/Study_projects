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
public class HardwareProduct extends Product
{

    private int WarrantyPeriod;
    
    /*  Constructors  */

    public HardwareProduct() { }

    public HardwareProduct(int WarrantyPeriod, long ID, String Name, String Description, float PricePerUnit)
    {
        super(ID, Name, Description, PricePerUnit);
        this.WarrantyPeriod = WarrantyPeriod;
    }
    
    /*  Properties  */

    public int getWarrantyPeriod() { return WarrantyPeriod; }
    public void setWarrantyPeriod(int WarrantyPeriod) { this.WarrantyPeriod = WarrantyPeriod; }  
    
    /*  Functions  */
        
    @Override
    public float getPrice()
    { return this.getWarrantyPeriod() + this.getPricePerUnit(); }
    
}
