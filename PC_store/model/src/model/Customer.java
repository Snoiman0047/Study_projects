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
public class Customer 
{
 
    private long Id;
    private String Name;
    private String Address;
    
    /*  Constructors  */

    public Customer() {}

    public Customer(long Id, String Name, String Address)
    {
        this.Id = Id;
        this.Name = Name;
        this.Address = Address;
    }
    
    /*  Properties  */

    public long getId() { return Id; }
    public void setId(long Id) { this.Id = Id; }

    public String getName() { return Name; }
    public void setName(String Name) { this.Name = Name; }    

    public String getAddress() { return Address; }
    public void setAddress(String Address) { this.Address = Address; }
    
    /*  Functions  */

    @Override
    public String toString() 
    { return "Customer ( " + "Id: " + this.Id + ", Name: " + this.Name + ", Address: " + this.Address; }    

    @Override
    public boolean equals(Object o) 
    {
        if (this == o)
            return true;
        if (o == null)
            return false;
        if (getClass() != o.getClass())
            return false;
        final Customer other = (Customer)o;
        if (this.Id != other.Id)
            return false;
        return true;
    }

    @Override
    public int hashCode() 
    {
       int hash = 3;
       hash = 17 * hash + (int) (this.Id ^ (this.Id >>> 32));
       return hash;
    }
    
}
