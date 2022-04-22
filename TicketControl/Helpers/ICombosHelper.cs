using Microsoft.AspNetCore.Mvc.Rendering;

namespace TicketControl.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboEntranceAsync();
    }
}
