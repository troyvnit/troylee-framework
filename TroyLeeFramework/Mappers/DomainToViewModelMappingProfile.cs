
namespace TroyLeeFramework.Mappers
{
    using AutoMapper;

    using TroyLeeFramework.Domain.Entities;
    using TroyLeeFramework.ViewModels;

    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
        }
    }
}