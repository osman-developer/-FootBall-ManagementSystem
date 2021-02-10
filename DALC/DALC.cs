    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using static Entities.Entities;

namespace DALC
{
    public class DALC
    {         // 1. Define Your Connection String
       public string connStr ;
        public List<Court> GetAllCourts()
        {
            List<Court> oList = new List<Court>();

   

            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_GET_COURT"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    // 7. Execute the Command (ExecuteReader)
                    // 8. The Reader is a kind of Hand/Cursor pointing to data retrieved by the Command
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Court oCourt = new Court();
                                oCourt.COURT_ID = Convert.ToInt32(reader["COURT_ID"]);
                                oCourt.NAME = Convert.ToString(reader["NAME"]);
                                oCourt.ADDRESS = Convert.ToString(reader["ADDRESS"]);

                                oList.Add(oCourt);
                            }
                        }
                    }
                }
            }

            

            return oList;
        }


        public void Delete_Court(Params_Delete_Court i_Params_Delete_Court)
        {
            // You should Always create a complex type (Class) which has properties matching parameters

            // 1. Define Your Connection String
           

            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_DELETE_COURT"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "COURT_ID", Value = i_Params_Delete_Court.COURT_ID });

                    command.ExecuteNonQuery();
                }
            }
        }



        public void Edit_Court(Court i_Court)
        {
            // You should Always create a complex type (Class) which has properties matching parameters

            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_EDIT_COURT"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "COURT_ID", Value = i_Court.COURT_ID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "NAME", Value = i_Court.NAME });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "ADDRESS", Value = i_Court.ADDRESS });

                    command.ExecuteNonQuery();
                }
            }
        }

        //-------------------------------------------------

        public void Edit_Customer(Customer i_Customer)
        {
            // You should Always create a complex type (Class) which has properties matching parameters

          

            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_CREATE_CUSTOMER"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "CUSTOMER_ID", Value = i_Customer.CUSTOMER_ID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "FIRST_NAME", Value = i_Customer.FIRST_NAME });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "LAST_NAME", Value = i_Customer.LAST_NAME });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "MOBILE", Value = i_Customer.MOBILE });

                    command.ExecuteNonQuery();
                }
            }
        }



        public List<Customer> GetAllCustomers()
        {
            List<Customer> oList = new List<Customer>();

         

            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_GET_CUSTOMERS"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    // 7. Execute the Command (ExecuteReader)
                    // 8. The Reader is a kind of Hand/Cursor pointing to data retrieved by the Command
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Customer oCustomer = new Customer();
                                oCustomer.CUSTOMER_ID = Convert.ToInt32(reader["CUSTOMER_ID"]);
                                oCustomer.FIRST_NAME = Convert.ToString(reader["FIRST_NAME"]);
                                oCustomer.LAST_NAME = Convert.ToString(reader["LAST_NAME"]);
                                oCustomer.MOBILE = Convert.ToString(reader["MOBILE"]);
                                oList.Add(oCustomer);
                            }
                        }
                    }
                }
            }

            oList = oList.OrderBy(x => x.FIRST_NAME).ToList();

            return oList;
        }



        public void Delete_Customer(Params_Delete_Customer i_Params_Delete_Customer)
        {
            // You should Always create a complex type (Class) which has properties matching parameters

         

            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_DELETE_CUSTOMER"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "CUSTOMER_ID", Value = i_Params_Delete_Customer.CUSTOMER_ID });

                    command.ExecuteNonQuery();
                }
            }
        }

        //-------------------------------------------------

        public void Add_Book(Booking i_Booking)
        {
            // You should Always create a complex type (Class) which has properties matching parameters


            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_ADD_BOOK"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "CUSTOMER_ID", Value = i_Booking.CUSTOMER_ID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "COURT_ID", Value = i_Booking.COURT_ID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "DATE", Value = i_Booking.DATE });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "HOUR", Value = i_Booking.HOUR });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "DURATION", Value = i_Booking.DURATION });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "DESCRIPTION", Value = i_Booking.DESCRIPTION });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "IS_DONE", Value = i_Booking.IS_DONE });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "IS_PAID", Value = i_Booking.IS_PAID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "AMOUNT", Value = i_Booking.AMOUNT });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "CURRENCY_ID", Value = i_Booking.CURRENCY_ID });


                    command.ExecuteNonQuery();
                }
            }
        }



        public void Edit_Book(Booking i_Booking)
        {
            // You should Always create a complex type (Class) which has properties matching parameters


            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_EDIT_BOOK"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "BOOKING_ID", Value = i_Booking.BOOKING_ID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "CUSTOMER_ID", Value = i_Booking.CUSTOMER_ID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "COURT_ID", Value = i_Booking.COURT_ID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "DATE", Value = i_Booking.DATE });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "HOUR", Value = i_Booking.HOUR });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "DURATION", Value = i_Booking.DURATION });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "DESCRIPTION", Value = i_Booking.DESCRIPTION });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "IS_DONE", Value = i_Booking.IS_DONE });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "IS_PAID", Value = i_Booking.IS_PAID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "AMOUNT", Value = i_Booking.AMOUNT });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "CURRENCY_ID", Value = i_Booking.CURRENCY_ID });


                    command.ExecuteNonQuery();
                }
            }
        }


        public void Delete_Book(Params_Delete_Booking i_Params_Delete_Booking)
        {
            // You should Always create a complex type (Class) which has properties matching parameters

         

            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_DELETE_BOOK"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "BOOKING_ID", Value = i_Params_Delete_Booking.BOOKING_ID });

                    command.ExecuteNonQuery();
                }
            }
        }



        public List<Booking> GetAllBooks()
        {
            List<Booking> oList = new List<Booking>();

         

            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_GET_BOOKS"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    // 7. Execute the Command (ExecuteReader)
                    // 8. The Reader is a kind of Hand/Cursor pointing to data retrieved by the Command
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Booking oBooking = new Booking();
                                oBooking.BOOKING_ID = Convert.ToInt32(reader["BOOKING_ID"]);
                                oBooking.CUSTOMER_ID = Convert.ToInt32(reader["CUSTOMER_ID"]);
                                oBooking.COURT_ID = Convert.ToInt32(reader["COURT_ID"]);
                                oBooking.DATE = Convert.ToDateTime(reader["DATE"]);
                                oBooking.HOUR = Convert.ToInt32(reader["HOUR"]);
                                oBooking.DURATION = Convert.ToInt32(reader["DURATION"]);
                                oBooking.DESCRIPTION = Convert.ToString(reader["DESCRIPTION"]);
                                oBooking.IS_DONE = Convert.ToBoolean(reader["IS_DONE"]);
                                oBooking.IS_PAID = Convert.ToBoolean(reader["IS_PAID"]);
                                oBooking.AMOUNT = Convert.ToDecimal(reader["AMOUNT"]);
                                oBooking.CURRENCY_ID = Convert.ToInt32(reader["CURRENCY_ID"]);

                                oList.Add(oBooking);
                            }
                        }
                    }
                }
            }


            return oList;
        }

        //-------------------------------------------------


        public List<Currency> GetAllCurrencies()
        {
            List<Currency> oList = new List<Currency>();

          

            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_GET_CURRENCY"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    // 7. Execute the Command (ExecuteReader)
                    // 8. The Reader is a kind of Hand/Cursor pointing to data retrieved by the Command
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Currency oCurrency = new Currency();
                                oCurrency.CURRENCY_ID = Convert.ToInt32(reader["CURRENCY_ID"]);
                                oCurrency.NAME = Convert.ToString(reader["NAME"]);
                                oCurrency.SYMBOL = Convert.ToString(reader["SYMBOL"]);

                                oList.Add(oCurrency);
                            }
                        }
                    }
                }
            }



            return oList;
        }
    }

}
