using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class MockCakeRepository : IRepository
    {
        private List<Cake> _cakes;

        public MockCakeRepository()
        {
            if (_cakes == null)
                InitializeCakes();
        }

        private void InitializeCakes()
        {
            _cakes = new List<Cake>()
            {
                new Cake { Id = 1, Name = "Apple Cake", Price = 12.95M, ShortDescription = "Our famous apple Cakes!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Cake chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Cake muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Cake cake danish lemon drops. Brownie cupcake dragée gummies.", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", IsCakeOfTheWeek = true, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg" },
                new Cake { Id = 2, Name = "Blueberry Cheese Cake", Price = 18.95M, ShortDescription = "You'll love it!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Cake chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Cake muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Cake cake danish lemon drops. Brownie cupcake dragée gummies.", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", IsCakeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg" },
                new Cake { Id = 3, Name = "Cheese Cake", Price = 18.95M, ShortDescription = "Plain cheese cake. Plain pleasure.", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Cake chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Cake muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Cake cake danish lemon drops. Brownie cupcake dragée gummies.", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", IsCakeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg" },
                new Cake { Id = 4, Name = "Cherry Cake", Price = 15.95M, ShortDescription = "A summer classic!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Cake chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Cake muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Cake cake danish lemon drops. Brownie cupcake dragée gummies.", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", IsCakeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg" }
            };
        }

        public IEnumerable<Cake> GetAllCakes()
        {
            return _cakes;
        }

        public Cake GetCakeById(int id)
        {
            return _cakes.FirstOrDefault(c => c.Id == id);
        }
    }
}
