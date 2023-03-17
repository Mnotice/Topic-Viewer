using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicsController : ControllerBase
    {
        private readonly List<Topic> _topics;

        public TopicsController()
        {
            // initialize the topics
            _topics = new List<Topic>
            {
                new Topic("Math"),
                new Topic("Biology"),
                new Topic("Accounting")
            };
        }

        [HttpGet]
        public IEnumerable<Topic> Get()
        {
            // return all the topics
            return _topics;
        }

        [HttpGet("{id}")]
        public Topic Get(int id)
        {
            // return the topic with the specified id
            return _topics[id];
        }
    }

    public class Topic
    {
        public string Name { get; set; }
        public List<string> Subtopics { get; set; }

        public Topic(string name)
        {
            Name = name;
            Subtopics = new List<string>();
        }
    }
}
