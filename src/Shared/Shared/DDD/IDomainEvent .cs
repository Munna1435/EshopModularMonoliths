using MediatR;

namespace Shared.DDD
{
    public interface IDomainEvent : INotification
    {
        //public Guid EventId { get; } = Guid.NewGuid();
        Guid EventId => Guid.NewGuid();
        public DateTime OccurredOn => DateTime.Now;
        public string EventType => GetType().AssemblyQualifiedName!;
    }
}
