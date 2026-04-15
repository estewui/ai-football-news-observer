using API.AI;
using Azure.AI.Projects;
using Azure.Identity;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly FoundryClient _foundryClient;

        public NewsController(FoundryClient foundryClient)
        {
            _foundryClient = foundryClient;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            var endpoint = "https://football-news-ai-foundry.services.ai.azure.com/openai/v1/";
            var deploymentName = "DeepSeek-V3.2";

            var agent = new AIProjectClient(new Uri(endpoint), new DefaultAzureCredential())
                .AsAIAgent(model: deploymentName, name: "FootballNewsSummarizer", instructions: "You are an AI agent specializing in football (soccer) news discovery and summarization. Your task is to scan multiple internet portals, identify the most interesting and relevant football news, and produce concise, accurate summaries for human readers.");

            var response = await agent.RunAsync("Read all articles on first 3 pages on website https://transfery.info/tag/polska and summarize them. Summarize every one article. Each article - 50 words maximum.");

            return Ok(response);
        }
    }
}
