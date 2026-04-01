using System.ComponentModel.DataAnnotations;

namespace DashboardData.Models
{
    public class SensorData    {

        [Key]
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage="Le nom doit faire entre 3 et 50 caractères.")]
        public string Name { get; set; }

        public string Type { get; set; } = "Temperature";
        [Range(-50.0, 150.0)]
        public double Value { get; set; }

        public DateTime LastUpdate { get; set; } = DateTime.Now;


        //====== Entity Framework Core relationships ======

        // Foreign key to Location (1-to-N): 1 sensor belongs to 1 location
        [Range(1, int.MaxValue, ErrorMessage = "Veuillez sélectionner un lieu valide.")]
        public int LocationId { get; set; }  
        public Location Location { get; set; }

        // Many-to-Many relationship with Tag: 1 sensor can have multiple tags, and 1 tag can be associated with multiple sensors
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();  

        // One-to-Many relationship with SensorValueHistor: 1 sensor can have multiple historical values
        public ICollection<SensorValueHistor> SensorValueHistories { get; set; } = new List<SensorValueHistor>();
    }
}
