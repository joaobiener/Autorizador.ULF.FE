using Microsoft.AspNetCore.Components;

namespace Autorizador.ULF.FE.Client.Pages.Exception;

public partial class CustomNotFound
{
    [Inject]
    public NavigationManager navigationManager { get; set; }

    public void NavigateToHome()
    {
        navigationManager.NavigateTo("index");
    }
}
