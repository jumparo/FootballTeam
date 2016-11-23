using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FootballProject.Models
{
    public class MyPlayersDbContext :DbContext
    {
       
            public MyPlayersDbContext() : base("Players")
            {

            }
            [Key]
            public DbSet<FootballTeam> FootballTeam { get; set; }

        public System.Data.Entity.DbSet<FootballProject.Models.Players> Players { get; set; }
    }
}