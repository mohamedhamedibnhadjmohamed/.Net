using DashboardData.Data;
using DashboardData.Models;
using Microsoft.EntityFrameworkCore;
#nullable enable
namespace DashboardData.Services
{
    public class SensorService : ISensorService
    {
        private readonly AppDbContext _dbContext;
        public SensorService(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<SensorData>> GetSensorsAsync()
        {
            // EF Core traduit Include par un JOIN SQL vers la table Location
            return await _dbContext.Sensors
                .Include(s => s.Location)
                .ToListAsync();
        }

        public async Task<List<Location>> GetLocationsAsync()
        {
            return await _dbContext.Locations.ToListAsync();
        }

        public async Task<SensorData?> GetSensorByIdAsync(int id)
        {
            // FindAsync cherche directement par la Clé Primaire (Id)
            return await _dbContext.Sensors.FindAsync(id);
        }

        public async Task AddSensorAsync(SensorData sensor)
        {
            sensor.LastUpdate = DateTime.Now;
            
            // Historisation de la valeur initiale (TP5)
            sensor.SensorValueHistories.Add(new SensorValueHistor {
                MeasuredValue = sensor.Value,
                Timestamp = DateTime.Now
            });

            _dbContext.Sensors.Add(sensor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateSensorAsync(SensorData sensor)
        {
            sensor.LastUpdate = DateTime.Now; // Mise à jour de la date
            
            // Ajout à l'historique lors d'une modification (TP5)
            sensor.SensorValueHistories.Add(new SensorValueHistor {
                MeasuredValue = sensor.Value,
                Timestamp = DateTime.Now
            });

            _dbContext.Sensors.Update(sensor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteSensorAsync(int id)
        {
            var sensor = await _dbContext.Sensors.FindAsync(id);
            if (sensor != null)
            {
                _dbContext.Sensors.Remove(sensor);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<SensorData>> GetCriticalSensorsAsync(double threshold)
        {
            return await _dbContext.Sensors
                .Include(s => s.Location)
                .Where(s => s.Value > threshold) 
                .OrderByDescending(s => s.Value) 
                .ToListAsync();                  
        }

        public async Task<double> GetAverageValueAsync()
        {
            if (!await _dbContext.Sensors.AnyAsync()) return 0;

            return await _dbContext.Sensors.AverageAsync(s => s.Value);
        }

        public async Task<double> GetMaxValueAsync()
        {
            if (!await _dbContext.Sensors.AnyAsync()) return 0;
            return await _dbContext.Sensors.MaxAsync(s => s.Value);
        }

        public async Task<int> GetTotalCountAsync()
        {
            return await _dbContext.Sensors.CountAsync();
        }
    }
}
