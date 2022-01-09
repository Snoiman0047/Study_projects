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
public abstract class Product
{
 
    private long ID;
    private String Name;
    private String Description;
    private float PricePerUnit;
    public enum type {HardwareProduct, SoftwareProduct}

    /*  Constructors  */

    public Product() {}

    public Product(long ID, String Name, String Description, float PricePerUnit) 
    {
        this.ID = ID;
        this.Name = Name;
        this.Description = Description;
        this.PricePerUnit = PricePerUnit;
    }
    
    /*  Properties  */

    public long getID() { return ID; }
    public void setID(long ID) { this.ID = ID; }

    public String getName() { return Name; }
    public void setName(String Name) { this.Name = Name; }

    public String getDescription() { return Description; }
    public void setDescription(String Description) { this.Description = Description; }    

    public float getPricePerUnit() { return PricePerUnit; }
    public void setPricePerUnit(float PricePerUnit) { this.PricePerUnit = PricePerUnit; }
    
    /*  Function  */

    @Override
    public String toString() 
    { return "Product ( " + "Id: " + this.ID + ", Name: " + this.Name + ", Description: " + this.Description + ", PricePerUnit: " + this.PricePerUnit + " )"; }
    
    public abstract float getPrice();
}
