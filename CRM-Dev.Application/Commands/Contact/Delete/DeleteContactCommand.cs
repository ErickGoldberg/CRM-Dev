using MediatR;

namespace CRM_Dev.Application.Commands.Contact.Delete
{
    public class DeleteContactCommand : IRequest<bool>
    {
        public DeleteContactCommand(int id) => Id = id;

        public int Id { get; private set; }
    }
}
