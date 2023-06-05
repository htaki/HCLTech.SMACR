using System;
using Volo.Abp.Domain.Entities;

namespace HCLTech.SMACR.EmissionFactors;

public class EmissionFactor : Entity<Guid>
{
    public EmissionFactor(Guid id, int year, string country, decimal actualEmissionFactor)
        :base(id)
    {
        Year = year;
        Country = country;
        ActualEmissionFactor = actualEmissionFactor;
    }
    public int Year { get; private set; }
    public string Country { get; private set; }
    public decimal ActualEmissionFactor { get; private set; }
}
