using CodeFirstVenueBooking.Models;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirstVenueBooking.Repositories
{
    public class DecorationRepo : IDecorationRepo
    {
        MyDbContext context;
        public DecorationRepo(MyDbContext Decorationcontext)
        {
            context = Decorationcontext;
        }
        public void AddNewDecoration(Decoration decoration)
        {
            context.Decorations.Add(decoration);
            context.SaveChanges();
        }



        public void DeleteDecoration(int id)
        {
            Decoration decoration = context.Decorations.FirstOrDefault(Decoration => Decoration.Id == id);
            if (decoration != null)
            {
                context.Decorations.Remove(decoration);
                context.SaveChanges();
            }

        }
        public List<Decoration> GetAllDecorations()
        {
            return context.Decorations.ToList();

        }
        public Decoration GetDecorationById(int id)
        {
            Decoration decoration = context.Decorations.Find(id);
                
                return decoration;
        }
            public void UpdateDecoration(Decoration newdecoration)
        {
            Decoration decoration = context.Decorations.FirstOrDefault(Decoration => Decoration.Id == newdecoration.Id);
            if (decoration != null)
            {
                
                decoration.EventName = newdecoration.EventName;
                decoration.Price = newdecoration.Price;
                context.SaveChanges();
            }
       
            
              
            


        }
    }
}
