/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import java.sql.Array;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.Customer;
import model.HardwareProduct;
import model.Product;
import static model.Product.type.SoftwareProduct;
import model.PurchaseOrder;
import model.SoftwareProduct;
import sun.util.calendar.LocalGregorianCalendar.Date;


/**
 *
 * @author snoim
 */
public class Backend_DAO_db implements Backend
{
   
    private static Backend_DAO_db Backend_dao_db;
    Connection connect = null;
    
    private static Backend_DAO_db bdb_singleton;
    
     /*  Constructors  */

    private Backend_DAO_db() {
       try{ connect = DriverManager.getConnection("jdbc:derby://localhost:1527/Pcstore_db", "Sara", "Sara"); }
       catch(SQLException ex) {Logger.getLogger(Backend_DAO_db.class.getName()).log(Level.SEVERE, null, ex); }
    }
    
    public static Backend_DAO_db Get_db() {
        if (Backend_dao_db == null)
        { Backend_dao_db = new Backend_DAO_db(); }
        return Backend_dao_db;
    }
    
    public static Backend_DAO_db Get_singleton() {
        if (bdb_singleton == null)
        { bdb_singleton = new Backend_DAO_db(); }
        return bdb_singleton;
    }
    
    /*  Functions  */
    
    @Override
    public void AddCustomer(Customer c) throws Exception {
        PreparedStatement Statement = connect.prepareStatement("insert into Customer values (?,?,?)");
        Statement.setString(1, String.valueOf(c.getId()));
        Statement.setString(2, c.getName());
        Statement.setString(3, c.getAddress());
        Statement.execute();
        Statement.close();
    }

    @Override
    public void AddProduct(Product p) {
        try {
            PreparedStatement Statement = connect.prepareStatement("insert into Product (Name, Description, P_type, Warranty_period, Number_of_users, Price) values (?, ?, ?, ?, ?, ?)");
//            Statement.setInt(1, Integer.parseInt(String.valueOf(p.getID())));
            Statement.setString(1, p.getName());
            Statement.setString(2, p.getDescription());
            Statement.setDouble(6, p.getPrice());
            Statement.setString(3, p.getClass().getSimpleName());
            System.out.println(p.getClass().getSimpleName());
            if (p.getClass().getSimpleName().equals("SoftwareProduct")) {
                 Statement.setInt(4, 0); Statement.setInt(5, ((SoftwareProduct) p).getNumberOfUsers());
            } else {
                 Statement.setInt(4, ((HardwareProduct) p).getWarrantyPeriod()); Statement.setInt(5, 0); 
            }
            Statement.execute();
        } catch (SQLException ex) {
            Logger.getLogger(Backend_DAO_db.class.getName()).log(Level.SEVERE, null, ex);
        }
    }


    @Override
    public HashMap<Long, Customer> getAllCustomers() throws Exception {
        HashMap<Long, Customer> map = new HashMap();
        Statement statement = connect.createStatement();
        ResultSet rs = statement.executeQuery("select * from Customer");
        while (rs.next()) {
            Customer c = new Customer();
            c.setId(rs.getLong(1));
            c.setName(rs.getString(2));
            c.setAddress(rs.getString(3));
            map.put(c.getId(), c);
        }
        return map;
    }

    @Override
    public HashSet<Product> getAllProducts() throws Exception {
        HashSet<Product> set=new HashSet<>();
        Statement statement = connect.createStatement();
        ResultSet rs = statement.executeQuery("select * from Product");
        while(rs.next())
        {
           Product p ;
           if(rs.getString(5).equals("SoftwareProduct"))
               p = new SoftwareProduct(rs.getInt(6), (Long.parseLong(rs.getString(1))), rs.getString(2), rs.getString(3), rs.getFloat(7));
           else
               p = new HardwareProduct(rs.getInt(5), (Long.parseLong(rs.getString(1))), rs.getString(2), rs.getString(3), rs.getFloat(7));
           set.add(p);
        }
        return set;
    }

    @Override
    public void PlaceOrder(PurchaseOrder po) {
        try ( PreparedStatement ps = connect.prepareStatement("insert into Orders (Cust_tz, Order_date) values(?, ?)") )
        {
            ps.setString(1, String.valueOf(po.getOrderingCustomer().getId()));
            ps.setDate(2, java.sql.Date.valueOf(po.getOrderDate()));
            ps.execute();
            
            Statement statement = connect.createStatement();
            ResultSet rs = statement.executeQuery("select max(Id) from Orders");
            
            PreparedStatement sp;
            ResultSet sd;         
            for (Product p : po.getProudactList()) {   
                sd = statement.executeQuery("select * from Product where Name = 'p.getName()'");
                sp = connect.prepareStatement("insert into SARA.\"Order_products\" (Order_id, Product_id) values(?, ?)");
                sp.setInt(1, rs.getInt(1));   
                sp.setInt(2, sd.getInt(1));
            }
            ps.execute();
        } catch (SQLException ex) {
            Logger.getLogger(Backend_DAO_db.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    @Override
    public void RemoveProduct(Product p) throws Exception {
        PreparedStatement ps = connect.prepareStatement("DELETE FROM PRODUCT WHERE ID = (?)");
        ps.setString(1, String.valueOf(p.getID()));
        ps.execute();
    }

    @Override
    public ArrayList<Product> getCustomersOrders(Customer c) throws Exception {
        ArrayList<Product> set=new ArrayList<>();
        Statement statement = connect.createStatement();
        ResultSet rs = statement.executeQuery("select * from SARA.\"PurchaseOrder\"  where cust_id = " + String.valueOf(c.getId()));
        
        while(rs.next())
        {
          ResultSet sr = statement.executeQuery("select * from SARA.\"Order_products\" where Order_code = " + rs.getInt(1));
          while(sr.next())
         {
             ResultSet P = statement.executeQuery("select * fROM PRODUCT where ID = " + sr.getInt(1));
            Product p ;
           if(P.getString(5).equals("SoftwareProduct"))
               p = new SoftwareProduct(rs.getInt(1), rs.getLong(2), rs.getString(3), rs.getString(4), rs.getFloat(6));
           else
               p = new HardwareProduct(rs.getInt(1), rs.getLong(2), rs.getString(3), rs.getString(4), rs.getFloat(6));
           set.add(p);
         }
        }
        return set;
    }

    @Override
    public Float CalcProductsTotalCost(Product[] products) throws Exception {
        float sum = 0;
        for (Product p : products) 
        { sum += p.getPrice(); }
        return sum;
    }
  
    public void CloseConnection() {
        try { connect.close(); }
        catch (SQLException ex) { Logger.getLogger(Backend_DAO_db.class.getName()).log(Level.SEVERE, null, ex); }
    }
    
}