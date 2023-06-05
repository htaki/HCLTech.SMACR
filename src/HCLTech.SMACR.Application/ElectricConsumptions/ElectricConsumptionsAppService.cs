using HCLTech.SMACR.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace HCLTech.SMACR.ElectricConsumptions;

public class ElectricConsumptionsAppService : SMACRAppService, IElectricConsumptionsAppService
{
    private readonly IUserProfileRepository _userProfileRepository;
    private readonly IElectricConsumptionRepository _electricConsumptionRepository;

    public ElectricConsumptionsAppService(IUserProfileRepository userProfileRepository, IElectricConsumptionRepository electricConsumptionRepository )
    {
        this._userProfileRepository = userProfileRepository;
        this._electricConsumptionRepository = electricConsumptionRepository;
    }

    public async Task DeleteElectricConsumption()
    {
        var userProfile = await _userProfileRepository.GetProfileWithConsumption();

        if (userProfile == null)
        {
            throw new EntityNotFoundException();
        }

        userProfile.ClearConsumption();
    }

    public async Task<IEnumerable<ElectricConsumptionDto>> GetElectricConsumption()
    {
        var userProfile = await _userProfileRepository.GetProfileWithConsumption();

        if (userProfile == null)
        {
            throw new EntityNotFoundException();
        }

        return ObjectMapper.Map<IEnumerable<ElectricConsumption>, IEnumerable<ElectricConsumptionDto>>(userProfile.ElectricConsumptions);
    }

    public async Task InsertElectricConsumption(ElectricConsumptionDto[] electricConsumptionDtos)
    {
        var userProfile = await _userProfileRepository.GetProfileWithConsumption();

        if (userProfile == null)
        {
            throw new EntityNotFoundException();
        }

        var consumptions = new List<ElectricConsumption>();
        foreach (var electricConsumptionDto in electricConsumptionDtos)
        {
            consumptions
                .Add(new ElectricConsumption(Guid.NewGuid(), userProfile.Id, electricConsumptionDto.StartDate, electricConsumptionDto.EndDate, electricConsumptionDto.EnergyConsumedInKwh));
        }

       await _electricConsumptionRepository.InsertManyAsync(consumptions);
    }

 
}
