namespace Clean.Application.Interfaces.Request
{
    public interface IRequest<in I, out O>
    {
        O Handle(I request);
    }

    public interface IRequest<out O>
    {
        O Handle();
    }
}
