using System.Threading.Tasks;

namespace Taxi.Common.Services
{
    public interface IGeolocatorService
    {
        double Latitude { get; set; }

        double Longitude { get; set; }

        //Metodo para cargar la  Latitude y Longitud 
        Task GetLocationAsync();
    }
}
