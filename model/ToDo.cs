﻿namespace SampleAPI.model
{
    public class ToDo
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public ToDo(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
