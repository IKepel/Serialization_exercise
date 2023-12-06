using Newtonsoft.Json;

namespace Serialization_exercise
{
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        [JsonIgnore]
        public int Weight { get; set; }

    }
}
