﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NavigatingMelbourne.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PointsOfInterestEntities : DbContext
    {
        public PointsOfInterestEntities()
            : base("name=PointsOfInterestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<POI> POIs { get; set; }
        public virtual DbSet<Supermarket> Supermarkets { get; set; }
        public virtual DbSet<ArtGalleryMuseum> ArtGalleryMuseums { get; set; }
        public virtual DbSet<ChineseRestaurant> ChineseRestaurants { get; set; }
        public virtual DbSet<PlacesOfWorship> PlacesOfWorships { get; set; }
    }
}
