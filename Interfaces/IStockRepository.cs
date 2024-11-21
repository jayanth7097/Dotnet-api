using System.Collections.Generic;
using System.Threading.Tasks;
using api1.Dtos.Stock;
using api1.Helpers;
using api1.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace api1.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject query);
        Task<Stock> GetByIdAsync(int id);
        Task<Stock> CreateAsync(Stock stockModel);
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(int id);
        Task<bool> StockExists(int id);

    }
}
