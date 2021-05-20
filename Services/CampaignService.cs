using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMM.Data;
using DMM.Models.Entities;
using DMM.Services.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DMM.Services
{
    public class CampaignService : Service<Campaign>
    {
        private IDbContextFactory<ApplicationDbContext> dbContextFactory;
        private readonly ILogger<CampaignService> logger;
        public CampaignService(IDbContextFactory<ApplicationDbContext> dbContextFactory) : base(dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public async Task<List<Campaign>> GetItems()
        {
            await using var context = dbContextFactory.CreateDbContext();
            var AllItems = await context.Campaigns.ToListAsync();

            return AllItems.ToList();
        }

        public async Task UpdateItems(Campaign p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Campaigns.SingleOrDefault(x => x.Id == p.Id);
            q1.Name = p.Name;
            q1.Description = p.Description;
            context.Update(q1);
            context.SaveChanges();
        }
        public async Task DeleteItems(Campaign p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Campaigns.SingleOrDefault(x => x.Id == p.Id);
            context.Remove(q1);
            context.SaveChanges();
        }
        public async Task InsertItems(Campaign p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            context.Add(p);
            context.SaveChanges();
        }

    }
}
