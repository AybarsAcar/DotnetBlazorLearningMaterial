using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data
{
  /**
   * Hotel model class
   * represents the table
   */
  public class HotelRoom
  {
    [Key] // we dont need Key since the name is Id
    public int Id { get; set; }

    [Required] public string Name { get; set; }

    [Required] public int Occupancy { get; set; }

    [Required] public double RegularRate { get; set; }

    public string Details { get; set; }
    public string SqFt { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string UpdatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<HotelRoomImage> HotelRoomImages { get; set; }
  }
}