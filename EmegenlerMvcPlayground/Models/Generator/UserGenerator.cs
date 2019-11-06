using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmegenlerMvcPlayground.Models.Generator
{
    public class UserGenerator
    {
        public UserGenerator()
        {
            /*var testOrders = new Faker<User>()
            //Ensure all properties have rules. By default, StrictMode is false
            //Set a global policy by using Faker.DefaultStrictMode
            .StrictMode(true)
            //OrderId is deterministic
            .RuleFor(o => o.OrderId, f => orderIds++)
            //Pick some fruit from a basket
            .RuleFor(o => o.Item, f => f.PickRandom(fruit))
            //A random quantity from 1 to 10
            .RuleFor(o => o.Quantity, f => f.Random.Number(1, 10))
            //A nullable int? with 80% probability of being null.
            //The .OrNull extension is in the Bogus.Extensions namespace.
            .RuleFor(o => o.LotNumber, f => f.Random.Int(0, 100).OrNull(f, .8f));*/
        }
    }
}
