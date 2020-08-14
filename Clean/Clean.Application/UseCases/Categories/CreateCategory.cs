using Clean.Application.Interfaces.Persistence;
using Clean.Application.Interfaces.Request;
using Clean.Domain.Entities;

namespace Clean.Application.UseCases.Categories
{
    public class CreateCategory : IRequest<string, bool>
    {
        IModel _model;

        public CreateCategory(IModel model)
        {
            _model = model;
        }

        public bool Handle(string request)
        {
            var entity = new Category
            {
                Name = request
            };

            _model.Category.Add(entity);
            return _model.SaveChanges() > 0 ? true : false;
        }
    }
}
