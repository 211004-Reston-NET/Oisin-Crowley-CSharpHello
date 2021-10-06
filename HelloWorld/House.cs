namespace HouseFuction
{
    public class House
    {
        private string owner;
        private string ghost;
        private int roomCount;
    

        public House()
        {
            owner = "Oisin";
            ghost = "Casper";
            roomCount = 2;
        }
         public string Owner 
        { 
            get
            {
                return owner;
            } 
            
            set
            {
                owner = value + " Owner";
            } 
        }
        public string MiceName { get; set; }
    }

}
      
        
