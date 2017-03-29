namespace CodeFirstTemplate.Services.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using CodeFirstTemplate.DATA.Models;
    using CodeFirstTemplate.DATA.Repositories;
    using CodeFirstTemplate.Services.Interfaces;
    using Mappings;
    using Models;

    public class ContestsServices : IContestsService
    {
        private readonly IDbRepository<Contest, int> contestsRepository;

        private IMapper Mapper = AutoMapperConfig.Configuration.CreateMapper();

        public ContestsServices(IDbRepository<Contest, int> contestsRepository)
        {
            this.contestsRepository = contestsRepository;
        }

        public IEnumerable<ContestModel> GetAll()
        {
            var contest = this.contestsRepository
                .GetAll();
            var contests = this.contestsRepository
                .GetAll()
                .ProjectTo<ContestModel>(AutoMapperConfig.Configuration)
                .ToList();

            return contests;
        }

        public Contest GetById(int id)
        {
            return this.contestsRepository.Find(id);
        }
    }


}
