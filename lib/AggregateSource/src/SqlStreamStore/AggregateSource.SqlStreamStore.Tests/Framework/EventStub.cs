using Newtonsoft.Json;

namespace AggregateSource.SqlStreamStore.Tests
{
    public class EventStub 
    {
        public int Value { get; set; }

        public EventStub() { }

        [JsonConstructor]
        public EventStub(int value)
        {
            Value = value;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as EventStub);
        }

        bool Equals(EventStub @event)
        {
            return !ReferenceEquals(@event, null) && Value.Equals(@event.Value);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return Value.GetHashCode() * 10 + 2;
            }
        }
    }
}