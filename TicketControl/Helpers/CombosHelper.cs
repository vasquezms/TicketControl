using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketControl.Data;

namespace TicketControl.Helpers
{
 
public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _context;

        public CombosHelper(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetComboEntranceAsync()
        {
            List<SelectListItem> list = await _context.Entrances.Select(E => new SelectListItem
            {
                Text = E.Description,
                Value = E.Id.ToString()
            })
                .OrderBy(c => c.Text)
                .ToListAsync();

            list.Insert(0, new SelectListItem { Text = "[Ingrese el codigo de la Entrada...", Value = "0" });
            return list;
        }

    }
}
