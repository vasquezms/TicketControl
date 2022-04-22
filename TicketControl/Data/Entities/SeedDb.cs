namespace TicketControl.Data.Entities
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context) 
        
        {
            _context = context;
        }

    }
}
