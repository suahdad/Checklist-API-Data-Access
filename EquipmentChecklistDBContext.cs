﻿using EquipmentChecklistDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace EquipmentChecklistDataAccess
{
    public class EquipmentChecklistDBContext: DbContext
    {
        public EquipmentChecklistDBContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Checklist> Checklists { get; set; }
        public DbSet<Checklist_Item> Checklist_Items { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Question> Questions { get; set; }  
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Checklist_Item>()
                .HasKey(c => new { c.ChecklistID, c.EquipmentID, c.ComponentID, c.ConditionID });

            modelBuilder.Entity<Question>()
                .HasKey(c => new { c.EquipmentID, c.ComponentID });
        }

    }
}
