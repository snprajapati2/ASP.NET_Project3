using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BucketList_Assignment3.Models;

namespace BucketList_Assignment3.Data
{
    public class BucketList_Assignment3Context : DbContext
    {
        public BucketList_Assignment3Context (DbContextOptions<BucketList_Assignment3Context> options)
            : base(options)
        {
        }

        public DbSet<BucketList_Assignment3.Models.List> List { get; set; } = default!;
    }
}
