using Client.Services;
using IdentityModel.Client;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using ShopApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Client.Pages;
public partial class Books
{
    private List<BookModel> ListBooks = new();
    [Inject] private HttpClient HttpClient { get; set; }
    [Inject] private IConfiguration Configuration { get; set; }
    [Inject] private ITokenService TokenService { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var tokenResponse = await TokenService.GetTokenAsync("api.read");
        this.HttpClient.SetBearerToken(tokenResponse.AccessToken);

        var result = await HttpClient.GetAsync(Configuration["apiUrl"] + "/api/book");

        if (result.IsSuccessStatusCode)
        {
            ListBooks = await result.Content.ReadFromJsonAsync<List<BookModel>>();
        }
    }

}
