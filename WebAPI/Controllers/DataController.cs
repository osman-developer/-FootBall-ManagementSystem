using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLC;
using DALC;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using static Entities.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private IConfiguration MyConfig;
        public DataController(IConfiguration config)
        {

            this.MyConfig = config;
        }
        [HttpGet]
        [Route("GetCourts")]
        public List<Court> GetAllCourts()
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            return oBLC.GetAllCourts();
        }


        [HttpPost]
        [Route("DeleteCourt")]
        public void Delete_Court(Params_Delete_Court i_Params_Delete_Court)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Delete_Court(i_Params_Delete_Court);
        }


        [HttpPost]
        [Route("EditCourt")]
        public void Edit_Court(Court i_Court)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Edit_Court(i_Court);
        }

        //-------------------------------------------------
        [HttpPost]
        [Route("EditCustomer")]
        public void Edit_Customer(Customer i_Customer)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Edit_Customer(i_Customer);
        }


        [HttpGet]
        [Route("GetCustomers")]
        public List<Customer> GetAllCustomers()
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            return oBLC.GetAllCustomers();
        }


        [HttpPost]
        [Route("DeleteCustomer")]
        public void Delete_Customer(Params_Delete_Customer i_Params_Delete_Customer)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Delete_Customer(i_Params_Delete_Customer);
        }

        //-------------------------------------------------
        [HttpPost]
        [Route("AddBook")]
        public void Add_Book(Booking i_Booking)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Add_Book(i_Booking);
        }


        [HttpPost]
        [Route("EditBook")]
        public void Edit_Book(Booking i_Booking)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Edit_Book(i_Booking);
        }


        [HttpPost]
        [Route("DeleteBook")]
        public void Delete_Book(Params_Delete_Booking i_Params_Delete_Booking)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Delete_Book(i_Params_Delete_Booking);
        }


        [HttpGet]
        [Route("GetBooks")]
        public List<Booking> GetAllBooks()
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            return oBLC.GetAllBooks();
        }

        //-------------------------------------------------

        [HttpGet]
        [Route("GetCurrency")]
        public List<Currency> GetAllCurrencies()
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            return oBLC.GetAllCurrencies();
        }


    }

}