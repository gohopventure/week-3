using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Domain.Models;

namespace PizzaStore.Storing.Factories
{
    public interface IMenuFactory : IFactory<MenuModel>
    {
        
    }
}