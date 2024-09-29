using ComarchBootcamp1.App.Cars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchBootcamp1.App.Cars.Repositories;

/// <summary>
/// CRUD
/// </summary>
internal class VehicleRepository
{
    private static List<Vehicle> data;

    public List<Vehicle> GetAll()
    {
        return data;
    }

    public Vehicle GetVehicle(int id)
    {
        return data.FirstOrDefault(x => x.Id == id);
    }

    public void Add(Vehicle vehicle)
    {
        int id = data.OrderByDescending(x => x.Id).First().Id;
        vehicle.Id = id + 1;
        data.Add(vehicle);
    }

    public void Remove(int id)
    {
        Vehicle vehicle = GetVehicle(id);
        data.Remove(vehicle);
    }
}
