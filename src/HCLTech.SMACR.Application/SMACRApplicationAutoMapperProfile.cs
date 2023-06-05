using AutoMapper;
using HCLTech.SMACR.EnergyReductionPlans;

namespace HCLTech.SMACR;

public class SMACRApplicationAutoMapperProfile : Profile
{
    public SMACRApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<EnergyReductionPlan, EnergyReductionPlanReadDto>();
    }
}
