﻿using System;
using System.Collections.Generic;


namespace FirstSolution.Domain
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Update(Product product);
        void Remove(Product product);
        Product GetById(Guid productId);
        Product GetByName(string name);
        ICollection<Product> GetByCategory(string category);

    }
}
