namespace CodeFirstTemplate.Services.Interfaces
{
    using System.Collections.Generic;
    using DATA.Models;
    using Models;

    public interface IContestsService
    {
        IEnumerable<ContestModel> GetAll();

        Contest GetById(int id);
    }
}
