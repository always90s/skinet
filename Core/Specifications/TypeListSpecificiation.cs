using System;
using Core.Entities;

namespace Core.Specifications;

public class TypeListSpecificiation : BaseSpecification<Product, string>
{
    public TypeListSpecificiation()
    {
        AddSelect(x => x.Type);
        ApplyDistinct();
    }
}
