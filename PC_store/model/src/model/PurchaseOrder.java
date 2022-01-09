/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

import java.time.LocalDate;
import java.util.ArrayList;

/**
 *
 * @author snoim
 */
public class PurchaseOrder 
{
 
    private Customer OrderingCustomer;
    private ArrayList<Product> ProudactList;
    private LocalDate OrderDate;
    
    /*  Constructors  */

    public PurchaseOrder() 
    {
        this.OrderDate = LocalDate.now();
        this.ProudactList = new ArrayList<>();
    }

    public PurchaseOrder(Customer OrderingCustomer, ArrayList<Product> ProudactList, LocalDate OrderDate) 
    {
        this.OrderingCustomer = OrderingCustomer;
        this.ProudactList = ProudactList;
        this.OrderDate = OrderDate;
    }
    
    /*  Properties  */

    public Customer getOrderingCustomer() { return OrderingCustomer; }
    public void setOrderingCustomer(Customer OrderingCustomer) { this.OrderingCustomer = OrderingCustomer; }

    public ArrayList<Product> getProudactList() { return ProudactList; }
    public void setProudactList(ArrayList<Product> ProudactList) { this.ProudactList = ProudactList; }    
    
    public LocalDate getOrderDate() { return OrderDate; }
    public void setOrderDate(LocalDate OrderDate) { this.OrderDate = OrderDate; }
    
    /*  Functions  */

    @Override
    public String toString()
    { return "PurchaseOrder ( " + "OrderDate: " + this.OrderDate + "OrderingCustomer: " + this.OrderingCustomer + ", ProudactList: " + this.ProudactList; }

}