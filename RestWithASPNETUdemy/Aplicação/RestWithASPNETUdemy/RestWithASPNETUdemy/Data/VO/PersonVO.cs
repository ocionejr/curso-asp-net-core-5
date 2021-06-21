namespace RestWithASPNETUdemy.Data.VO
{
    public class PersonVO
    {
        public long id { get; set; } 
        
        public string firstName { get; set; }
        
        public string LastName { get; set; }

        public string address { get; set; }

        public string gender { get; set; }

        public bool enabled { get; set; }
    }
}
