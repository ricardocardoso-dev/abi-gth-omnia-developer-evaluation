using Ambev.DeveloperEvaluation.Domain.Events;
using StackExchange.Redis;
using System.Text.Json;

namespace Ambev.DeveloperEvaluation.Messaging;

public class RedisEventPublisher : IEventPublisher
{
    private readonly IConnectionMultiplexer _redis;

    public RedisEventPublisher(IConnectionMultiplexer redis)
    {
        _redis = redis;
    }

    public async Task PublishAsync(string eventType, object eventData)
    {
        var db = _redis.GetSubscriber();
        var message = JsonSerializer.Serialize(new { type = eventType, data = eventData });
        await db.PublishAsync("sales-events", message);
    }
}