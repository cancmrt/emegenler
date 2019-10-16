using Guard.Emegenler.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmegenlerTests.FakeContext
{
    public class FakeContextGenerator
    {
        public  EmegenlerDbContext GetContext()
        {
            
            DbContextOptions<EmegenlerDbContext> options;
            var builder = new DbContextOptionsBuilder<EmegenlerDbContext>();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            options = builder.Options;
            EmegenlerDbContext context = new EmegenlerDbContext(options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            return context;
        }

    }

}
