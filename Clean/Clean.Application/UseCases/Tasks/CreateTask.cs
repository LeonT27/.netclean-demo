using Clean.Application.Interfaces.Persistence;
using Clean.Application.Interfaces.Request;
using Clean.Domain.Entities;

namespace Clean.Application.UseCases.Tasks
{
    public class CreateTaskCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int IdCategory { get; set; }
    }

    public class CreateTask : IRequest<CreateTaskCommand, bool>
    {
        IModel _model;
        public CreateTask(IModel model)
        {
            _model = model;
        }

        public bool Handle(CreateTaskCommand request)
        {
            var entity = new Task
            {
                Name = request.Name,
                Description = request.Description,
                IdCategory = request.IdCategory
            };

            _model.Task.Add(entity);
            return _model.SaveChanges() > 0 ? true : false;
        }
    }
}
