# 1. Project Overview
**Project Name:**  
AI Football News Observer

**Purpose (Why?):**  
I am building this project as part of my growth talk goals and to improve my knowledge and understanding of AI and Azure, and integration of AI and Azure to .NET 10 app.

**Problem Statement:**  
The projects organize football news for a user. It gathers from the internet news that can be interesting for the user, and prepares a summary every day, with the links to full content if user wants to deepen the knowledge.

**High-Level Description:**  
From a user's perspective, when the user logs into the system, he already sees the summary of news (the summary was prepared by the system in the background). User can manage topics that are interesting to him by adding topics or/and websites that should be scrapped to find information.

**Success Criteria:**  
Project will be considered successful, if it will be deployed to production (on Azure), doing the job for one user.

# 2. Goals & Non-Goals
**Goals** 
- Learn and practice some of Azure services
- Apply AI in a real scenario
- Use .NET with AI
- Try several agentic coding models - practice proper prompt-coding

**Non-Goals**  
- Not intended for multiple users
- Not optimized for massive scale
- Frontend does not need to be top-notch

# 3. Target Users & Use Cases
**Target Users:**  
I will be the only person using the app (or the person that I share credentials with). But it will be one user.

**Key Use Cases / User Stories:**  
- As a user, I can read summary of football news from today, so I can stay up-to-date with everything.  
- As a user, I can read summaries of football news from last 7 days, so I can catch up on the news I missed.  
- As a user, I can modify topics I'm interested in, so I can read about areas that I'm into.  
- As a user, I can modify websites used for summaries, so I can read information from sources that I trust and like.

# 4. Architecture Overview
**Frontend:** React v19.2  
**Backend API:** .NET 10  
**AI component:** Azure OpenAI Service or Azure AI Foundry, depending on my research  
**Database & storage:** TBA, probably Azure Cosmos DB with MongoDB  
**Infrastructure:** Azure  
**Containerization:** Docker

# 5. Technology Stack
**Frontend**  
React v19.2  
Tailwind for styling  
**Backend**  
.NET 10  
Entity Framework Core  
**AI / Intelligence**  
Azure OpenAI Service or Azure AI Foundry  
Integrates with backend using Microsoft.Agents.AI  
**Data & Storage**  
TBA, depending on the cost. There are 2 options:
- Mongo DB installed inside of docker container on Virtual Machine
- Azure Cosmos DB with MongoDB  

**Infrastructure & DevOps**  
TBA, depending on the costs.  
Azure: To pick up from: App Service, Virtual Machines, CosmosDB  
Terraform  
Docker  
Secrets in Azure Key Vault  
**Agentic coding**  
Github Copilot extension in Visual Studio with Claude Sonnet 4.6, Claude Opus 4.6, GPT-5.3-Codex, GPT-5.4 or others, depending on the needs, efficiency, and new models available

# 6. Deployment & Environment Strategy
**Environments:**  
Local development  
Production  

**Deployment Flow:**  
TBA, firstly I need to understand deployment to Azure.

# 7. Security Considerations
All API endpoints need to be protected from unauthorized access.  
HTTPS configuration with TLS 1.3.  
JWT authentication. One user with data prefilled in DB. No possibility to reset password.  
Password hashed in DB using bcrypt algorithm.  

# 8. Observability & Quality
Simple logging strategy.  
Monitor LLM tokens usage.

# 9. Development Plan (Phases)
**Phase 1 – Foundation**  
Create Github repository.  
Create .NET 10 Web Api project with basic configuration.   

**Phase 2 – Validate achievability**  
Connect Azure AI service into backend app.  
Try using Azure AI for scrapping news.  
Try using Azure AI to summarize news.  

**Phase 3 – Backend**  
Create docker compose with .NET and Mongo DB database.  
Prepare database structure.  
Implement background jobs, scraping and summarizing news for user, run in intervals.  
Store prepared data in MongoDB database.  
Add authorization.  

**Phase 4 – UI**  
Add frontend to docker-compose.  
Prepare frontend UI for user.  
Implement all use cases.  

**Phase 5 – Deployment**  
Analyze pricing of Azure resources and pick best configuration.  
Prepare deployment automation with Terraform.  
Deploy resources to Azure.  

**Phase 6 - Monitoring**  
Add monitoring page with LLM tokens usage.  
Add logs from app to monitoring page.  

# 10. Risks & Open Questions
Azure costs may be too expensive to host it without exceeding free Azure credits.  
AI may not be capable of scrapping websites (for example - blocked by captcha).

# 11. Documentation Plan
README overview  
OneNote with my own thoughts, shared later in repository.  
Local setup instructions  
Deployment instructions  
Known limitations  

# 12. Stretch Ideas
Multiple users.  
Adapt for other categories (geopolitics, business, sport).


