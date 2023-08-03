using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace udemy.Pages;

[Authorize(Policy = "HrManagerOnly")]
public class HrManagerModel : PageModel
{
    private IHttpClientFactory httpClientFactory;

    [BindProperty]
    public List<WeatherForecastDTO> WeatherForecastItems { get; set; }

    public HrManagerModel(IHttpClientFactory httpClientFactory)
    {
        this.httpClientFactory = httpClientFactory;
    }

    public async Task OnGetAsync()
    {
        var httpClient = httpClientFactory.CreateClient("OurWebAPI");
        WeatherForecastItems = await httpClient.GetFromJsonAsync<List<WeatherForecastDTO>>("WeatherForecast");
    }
}
