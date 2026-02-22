using DashboardData.Models;

namespace DashboardData.Services;

public interface ISensorService 
{
    Task<List<SensorData>> GetSensorsAsync();
    void AddSensor(SensorData sensor);
}