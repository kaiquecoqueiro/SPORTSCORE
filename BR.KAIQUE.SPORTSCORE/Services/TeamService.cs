using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BR.KAIQUE.SPORTSCORE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;


namespace BR.KAIQUE.SPORTSCORE.Services
{
    public class TeamService : ITeamService
    {
        private readonly IOptions<FootbalDataAPI> config;

        public TeamService(IOptions<FootbalDataAPI> config)
        {
            this.config = config;
        }
        public List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>();

            try
            {
                using (var client = new HttpClient())
                {
                    var a = config.Value;

                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = client.GetAsync(a.BaseURL + "teams").Result;
                    response.Headers.Add("X-Auth-Token", a.Key);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        
                        var result = JsonConvert.DeserializeObject<RootObject>(content);

                        teams.AddRange(result.teams);
                    } 
                }
            }
            catch (System.Exception ex)
            {

            }

            return teams;
        }
    }
}
