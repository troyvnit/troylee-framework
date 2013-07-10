
namespace TroyLeeFramework.Mappers
{
    using AutoMapper;

    using TroyLeeFramework.Domain.Entities;
    using TroyLeeFramework.ViewModels;

    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
        }
    }
}