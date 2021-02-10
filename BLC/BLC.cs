using DALC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static Entities.Entities;

namespace BLC
{
    public class BLC
    {
        public string connStr = "";
        public List<Court> GetAllCourts()
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            List<Court> oList = oDALC.GetAllCourts();
            oList= oList.OrderBy(x => x.NAME).ToList();
            oList.RemoveAll(x => x.ADDRESS == "Tripoli");
            return oList;
        }


        public void Delete_Court(Params_Delete_Court i_Params_Delete_Court)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Delete_Court(i_Params_Delete_Court);
        }


    
        public void Edit_Court(Court i_Court)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Edit_Court(i_Court);
        }

        //-------------------------------------------------
    
        public void Edit_Customer(Customer i_Customer)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Edit_Customer(i_Customer);
        }


    
        public List<Customer> GetAllCustomers()
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            return oDALC.GetAllCustomers();
        }


    
        public void Delete_Customer(Params_Delete_Customer i_Params_Delete_Customer)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Delete_Customer(i_Params_Delete_Customer);
        }

        //-------------------------------------------------
       
        public void Add_Book(Booking i_Booking)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Add_Book(i_Booking);
        }


    
        public void Edit_Book(Booking i_Booking)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Edit_Book(i_Booking);
        }


        public void Delete_Book(Params_Delete_Booking i_Params_Delete_Booking)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Delete_Book(i_Params_Delete_Booking);
        }


     
        public List<Booking> GetAllBooks()
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            return oDALC.GetAllBooks();
        }

        //-------------------------------------------------

      
        public List<Currency> GetAllCurrencies()
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            return oDALC.GetAllCurrencies();
        }

    }
  
}
