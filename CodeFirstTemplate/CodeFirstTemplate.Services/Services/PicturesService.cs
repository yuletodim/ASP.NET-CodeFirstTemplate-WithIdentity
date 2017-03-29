namespace CodeFirstTemplate.Services.Services
{
    using System;
    using System.Linq;
    using DATA.Models;
    using CodeFirstTemplate.Services.Interfaces;
    using DATA.Repositories;

    public class PicturesService : IPictuiresService
    {
        private readonly IDbRepository<Picture, int> picturesRepository;

        public PicturesService(IDbRepository<Picture, int> picturesRepository)
        {
            this.picturesRepository = picturesRepository;
        }

        public IQueryable<Picture> GetAll()
        {
            throw new NotImplementedException();
        }

        public Picture GetById()
        {
            throw new NotImplementedException();
        }
    }
}
