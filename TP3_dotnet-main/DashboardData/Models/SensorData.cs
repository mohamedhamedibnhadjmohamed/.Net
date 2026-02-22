using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardData.Models;

public class SensorData
{
    [Key] // Clé Primaire (PK)
    public int Id { get; set; }

    [Required] [StringLength(50)]
    public string Name { get; set; }

    public string Type { get; set; } = "Temperature";

    public double Value { get; set; }

    public DateTime LastUpdate { get; set; } = DateTime.Now;

    // ===== RELATIONS =====

    // FK vers Location (1-to-N) : chaque capteur est dans UN emplacement
    public int LocationId { get; set; }
    public Location Location { get; set; }

    // Navigation N-to-N : un capteur peut avoir PLUSIEURS tags
    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
}