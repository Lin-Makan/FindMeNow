using System;
using System.Collections.Generic;
using System.Text;
using FindMeNow.Models;
using System.Threading.Tasks;

namespace FindMeNow.Repositories
{
    public interface ILocationRepository
    {
        Task Save(Location location);
    }
}
