using LiteDB;
using Newtonsoft.Json;
using restapi.Helpers;

namespace restapi.Models
{
    public abstract class Event
    {
        [JsonIgnore]
        public int Person { get; set; }

        public override string ToString()
        {
            return PublicJsonSerializer.SerializeObjectIndented(this);
        }
    }

    public class Entered : Event
    {
        [BsonIgnore]
        public int Employee { get => Person; set { Person = value; } }

        public override string ToString()
        {
            return PublicJsonSerializer.SerializeObjectIndented(this);
        }
    }

    public class Submittal : Event
    {
        [BsonIgnore]
        public int Submitter { get => Person; set { Person = value; } }

        public override string ToString()
        {
            return PublicJsonSerializer.SerializeObjectIndented(this);
        }
    }

    public class Cancellation : Event
    {
        [BsonIgnore]
        public int Canceller { get => Person; set { Person = value; } }

        public string Reason { get; set; }

        public override string ToString()
        {
            return PublicJsonSerializer.SerializeObjectIndented(this);
        }
    }

    public class Rejection : Event
    {
        [BsonIgnore]
        public int Rejecter { get => Person; set { Person = value; } }

        public string Reason { get; set; }

        public override string ToString()
        {
            return PublicJsonSerializer.SerializeObjectIndented(this);
        }
    }

    public class Approval : Event
    {
        [BsonIgnore]
        public int Approver { get => Person; set { Person = value; } }

        public override string ToString()
        {
            return PublicJsonSerializer.SerializeObjectIndented(this);
        }
    }
    
        public class Deletion : Event
    {
        [BsonIgnore]
        public int Deleter { get => Person; set { Person = value; } }

        public override string ToString()
        {
            return PublicJsonSerializer.SerializeObjectIndented(this);
        }
    }

}