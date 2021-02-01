using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SalesWeb.Data;
using SalesWeb.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SalesWeb.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebContext Database;
        public SalesRecordService(SalesWebContext database)
        {
            Database = database;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in Database.SalesRecord select obj;

            if(minDate.HasValue)
                result = result.Where(x => x.Date >= minDate.Value);

            if(maxDate.HasValue)
                result = result.Where(x => x.Date <= maxDate.Value);

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }


        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in Database.SalesRecord select obj;

            if(minDate.HasValue)
                result = result.Where(x => x.Date >= minDate.Value);

            if(maxDate.HasValue)
                result = result.Where(x => x.Date <= maxDate.Value);

            var sales = await result.Include(x => x.Seller).Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date).ToListAsync();

            return sales.GroupBy(s => s.Seller.Department).ToList();
        }
    }
}