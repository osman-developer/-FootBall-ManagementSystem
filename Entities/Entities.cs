using System;

namespace Entities
{
    public class Entities
    {
        public class Params_Delete_Customer
        {
            public int CUSTOMER_ID { get; set; }
        }

        public class Params_Delete_Booking
        {
            public int BOOKING_ID { get; set; }
        }

        public class Params_Delete_Court
        {
            public int COURT_ID { get; set; }
        }
        public class Currency
        {
            public int CURRENCY_ID { get; set; }
            public string NAME { get; set; }
            public string SYMBOL { get; set; }
        }
        public class Booking
        {
            public int BOOKING_ID { get; set; }
            public int CUSTOMER_ID { get; set; }
            public int COURT_ID { get; set; }
            public DateTime DATE { get; set; }
            public int HOUR { get; set; }
            public int DURATION { get; set; }
            public string DESCRIPTION { get; set; }
            public Boolean IS_DONE { get; set; }
            public Boolean IS_PAID { get; set; }
            public decimal AMOUNT { get; set; }
            public int CURRENCY_ID { get; set; }

        }
        public class Customer
        {
            public int CUSTOMER_ID { get; set; }
            public string FIRST_NAME { get; set; }

            public string LAST_NAME { get; set; }
            public string MOBILE { get; set; }
        }
        public class Court
        {
            public int COURT_ID { get; set; }
            public string NAME { get; set; }

            public string ADDRESS { get; set; }
        }
    }
}
