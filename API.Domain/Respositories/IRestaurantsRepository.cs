using API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Respositories
{
    public interface IRestaurantsRepository
    {
        Task<IEnumerable<Restaurants>> GetAllAsync();
        Task<Restaurants> GetOneAsync(int id);
        Task<int> Create(Restaurants entity);
    }
}
