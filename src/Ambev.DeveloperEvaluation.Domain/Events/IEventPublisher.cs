namespace Ambev.DeveloperEvaluation.Domain.Events;

public interface IEventPublisher
{
    Task PublishAsync(string eventType, object eventData);
}