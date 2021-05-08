using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Data.Interfaces;
using WebAPI.Data.Models;

namespace WebAPI.Data.Mocks
{
    public class MockCars: IAllCars
    {
        private readonly ICarsCategory categoryCars = new MockCategory();

        public IEnumerable<Car> GetCars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        Name = "Tesla Model S",
                        ShortDesc = "Быстрый авто",
                        LongDesc = "Красивый, быстрый и тихий авто от компании Tesla",
                        Img = "https://www.google.com/url?sa=i&url=https%3A%2F%2F3dnews.ru%2F1021277&psig=AOvVaw2JgG2puejU9N64R_MZeZQi&ust=1620566002428000&source=images&cd=vfe&ved=2ahUKEwjjlcb4lLrwAhWTyCoKHSxuDz4QjRx6BAgAEAc",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = categoryCars.AllCategories.First()
                 },
                    new Car {
                        Name = "Ford Fiesta",
                        ShortDesc = "Тихий авто",
                        LongDesc = "Удобный авто для городской жизни",
                        Img = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.drive.ru%2Fnews%2Fford%2F5edf7d15ec05c4ff2d000022.html&psig=AOvVaw0PKtDfoNeLlJnjM5kfPzeG&ust=1620566167546000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCICUhsiVuvACFQAAAAAdAAAAABAD",
                        Price = 11000,
                        IsFavourite = false,
                        Available = true,
                        Category = categoryCars.AllCategories.Last()
                 },
                    new Car {
                        Name = "BMV M3",
                        ShortDesc = "Дерзкий и стильный",
                        LongDesc = "Удобный авто для городской жизни",
                        Img = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.kolesa.ru%2Fnews%2Fbmw-m3-sleduyushchego-pokoleniya-g80-novye-izobrazheniya&psig=AOvVaw3pe2uFJXr7wkIcVwXhvsIm&ust=1620566367129000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNi15KiWuvACFQAAAAAdAAAAABAD",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = categoryCars.AllCategories.Last()
                 },
                    new Car {
                        Name = "BMV M3",
                        ShortDesc = "Дерзкий и стильный",
                        LongDesc = "Удобный авто для городской жизни",
                        Img = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.kolesa.ru%2Fnews%2Fbmw-m3-sleduyushchego-pokoleniya-g80-novye-izobrazheniya&psig=AOvVaw3pe2uFJXr7wkIcVwXhvsIm&ust=1620566367129000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNi15KiWuvACFQAAAAAdAAAAABAD",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = categoryCars.AllCategories.Last()
                 },
                    new Car {
                        Name = "Mercedes C class",
                        ShortDesc = "Уютный и большой",
                        LongDesc = "Удобный авто для городской жизни",
                        Img = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.motor1.com%2Fimages%2Fmgl%2Fk3pee%2Fs1%2Fmercedes-c-klasse-limousine-2021.jpg&imgrefurl=https%3A%2F%2Fru.motor1.com%2Fnews%2F498532%2Fmerc-c-rus-price%2F&tbnid=ccaKzyWVv2dg-M&vet=12ahUKEwjfm8iQl7rwAhUuiYsKHRKCCFcQMygAegUIARC2AQ..i&docid=5c5OU96-NE9AbM&w=1920&h=1080&q=mercedes%20c%20class&safe=strict&ved=2ahUKEwjfm8iQl7rwAhUuiYsKHRKCCFcQMygAegUIARC2AQ",
                        Price = 40000,
                        IsFavourite = false,
                        Available = false,
                        Category = categoryCars.AllCategories.Last()
                 },
                    new Car {
                        Name = "Nissan Leaf",
                        ShortDesc = "Бесшумный и экономный",
                        LongDesc = "Удобный авто для городской жизни",
                        Img = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fru.wikipedia.org%2Fwiki%2FNissan_LEAF&psig=AOvVaw1iaUIOYmHcXH1-EGwROtSq&ust=1620566694979000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCOiapMaXuvACFQAAAAAdAAAAABAD",
                        Price = 14000,
                        IsFavourite = true,
                        Available = true,
                        Category = categoryCars.AllCategories.First()
                 }
            };
        }
    }
        public IEnumerable<Car> GetFavCars { get ; set ; }

        public Car GetCar(int CarId)
        {
            throw new NotImplementedException();
        }
    }
}
