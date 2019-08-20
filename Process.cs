using System;
using System.Collections.Generic;
using System.Data;
using LinqQuery.Models;
using System.Linq;

namespace LinqQuery
{
    public static class Process
    {
        public static IList<BusinessLine> ProcessBusinessLineLinq(DataSet dataSet, Func<DataSet, IList<BusinessLine>> mapper){
            return mapper(dataSet);
        }

        public static Func<DataSet, IList<BusinessLine>> GetMapper(){
            return ds =>
            {
                return (from row in ds.Tables[0].AsEnumerable()
                                     .GroupBy(bl => bl["BusinessLineId"].ToString())
                                     .Select(bl => bl.FirstOrDefault())
                        select new BusinessLine
                        {
                            Id = Convert.ToInt32(row["BusinessLineId"].ToString()),
                            Name = row["Description"].ToString(),
                            Tiers = ds.Tables[0].AsEnumerable()
                                .Where(t => t["BusinessLineId"].ToString() == row["BusinessLineId"].ToString())
                                .GroupBy(t => t["TierId"].ToString())
                                .Select(t => t.FirstOrDefault())
                                .Select(tier => new Tier
                                {
                                    Id = Convert.ToInt32(tier?["TierId"].ToString()),
                                    Name = tier?["TierName"].ToString(),
                                    Signals = ds.Tables[0].AsEnumerable()
                                        .Where(s => s["TierId"].ToString() == tier?["TierId"].ToString() &&
                                                    s["BusinessLineId"].ToString() == row["BusinessLineId"].ToString())
                                        .GroupBy(s => s["ProductId"].ToString())
                                        .Select(s => s.FirstOrDefault())
                                        .Select(signal => new Signal
                                        {
                                            Id = Convert.ToInt32(signal?["ProductId"].ToString()),
                                            Name = signal?["ProductName"].ToString(),
                                            Checked = true
                                        }).ToList()
                                }).ToList()
                        }).ToList();
            };
        }
    }
}