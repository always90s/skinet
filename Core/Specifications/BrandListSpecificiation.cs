using System;
using Core.Entities;

namespace Core.Specifications;

public class BrandListSpecificiation : BaseSpecification<Product, string>
{
    public BrandListSpecificiation()
    {
        AddSelect(x=>x.Brand);
        ApplyDistinct();
    }
}
