using System;
using System.Collections.Generic;
using System.Text;
using Ballerz.Forums.Models;
using Ballerz.KnowledgeBase.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace Ballerz.Data.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Managers> Managers { get; set; } 
        public DbSet<Leagues> Leagues { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Stadiums> Stadiums { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Seasons> Seasons { get; set; }
        public DbSet<ClubHistory> ClubHistories { get; set; }
        public DbSet<PlayerHistory> PlayerHistories { get; set; }
        public DbSet<ManagerHistory> ManagerHistories { get; set; }
        public DbSet<Players> Players { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReply> PostReplies { get; set; }
        public DbSet<Profile> Profile { get; set ;}




     
         protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

      
    }
    }
}
