using CodeFirstVenueBooking.Models;
using System.Collections.Generic;

namespace CodeFirstVenueBooking.Repositories
{
    public interface IDecorationRepo
    {
        List<Decoration> GetAllDecorations();
        void AddNewDecoration(Decoration decoration);
        void UpdateDecoration(Decoration decoration);
        Decoration GetDecorationById(int id);
        void DeleteDecoration(int id);
        

    }
}
