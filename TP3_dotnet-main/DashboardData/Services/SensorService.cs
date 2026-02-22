using DashboardData.Models;

namespace DashboardData.Services;

public class SensorService : ISensorService
{
    private List<SensorData> _sensors = new ()
    {
        new SensorData { Name= "Temp_Salon", Value=22.5},
        new SensorData { Name= "Hum_Cuisine", Value=45.0},
        new SensorData { Name= "CO2_Bureau", Value=800},
        new SensorData { Name= "Temp_Bureau", Value=24.0},
        new SensorData { Name= "Temp_Ext", Value=12.0}   
    };
    

    public async Task<List<SensorData>> GetSensorsAsync()
    {
        await Task.Delay(2000);
        return _sensors;
    }

    public void AddSensor(SensorData sensor)
    {
        _sensors.Add(sensor);
    }


}