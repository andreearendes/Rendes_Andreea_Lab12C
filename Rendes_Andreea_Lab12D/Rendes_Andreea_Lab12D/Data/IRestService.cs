using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Rendes_Andreea_Lab12D.Models;

namespace Rendes_Andreea_Lab12D.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
