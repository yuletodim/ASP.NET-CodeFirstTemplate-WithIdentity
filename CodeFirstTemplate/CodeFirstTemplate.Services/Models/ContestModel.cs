using System;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using CodeFirstTemplate.DATA.Models;
using CodeFirstTemplate.Services.Mappings;

namespace CodeFirstTemplate.Services.Models
{
    public class ContestModel : IMapFrom<Contest>, IMapTo<Contest>, IHaveCustomMappings
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int RewardStrategyID { get; set; }

        public string RewardStrategyName { get; set; }

        public int VotingStrategyID { get; set; }

        public string VotingStrategyName { get; set; }

        public int ParticipationStrategyID { get; set; }

        public string ParticipationStrategyName { get; set; }

        public string MostVotedPicture { get; set; }

        public int DeadlineStrategyID { get; set; }

        public string DeadlineStrategyName { get; set; }

        public static Expression<Func<Contest, ContestModel>> Map
        {
            get
            {
                return c => new ContestModel
                {
                    ID = c.ID,
                    Title = c.Title,
                    Description = c.Description,
                    RewardStrategyID = c.RewardStrategyID,
                    VotingStrategyID = c.VotingStrategyID,
                    ParticipationStrategyID = c.ParticipationStrategyID,
                    DeadlineStrategyID = c.DeadlineStrategyID                  
                };
            }
        }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Contest, ContestModel>()
                .ForMember(x => x.RewardStrategyName, opt => opt.MapFrom(x => x.RewardStrategy.Name))
                .ForMember(x => x.VotingStrategyName, opt => opt.MapFrom(x => x.VotingStrategy.Name))
                .ForMember(x => x.ParticipationStrategyName, opt => opt.MapFrom(x => x.VotingStrategy.Name))
                .ForMember(x => x.DeadlineStrategyName, opt => opt.MapFrom(x => x.DeadlineStrategy.Name))
                .ForMember(x => x.MostVotedPicture, opt => opt.MapFrom(x => x.Pictures.OrderByDescending(p => p.Votes).Select(p => p.PictureUrl).Take(1)));
        }
    }
}
