using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace HiddenVilla_Server.Helper
{
  public static class IJSRuntimeExtention
  {
    public static async ValueTask ToastrSuccess(this IJSRuntime jsRuntime, string message)
    {
      await jsRuntime.InvokeVoidAsync("ShowToastr", "success", message);
    }
    
    public static async ValueTask ToastrError(this IJSRuntime jsRuntime, string message)
    {
      await jsRuntime.InvokeVoidAsync("ShowToastr", "error", message);
    }

    public static async ValueTask SweetAlertSuccess(this IJSRuntime jsRuntime, string message)
    {
      await jsRuntime.InvokeVoidAsync("ShowSweetAlert", "success", message);
    }
    
    public static async ValueTask SweetAlertError(this IJSRuntime jsRuntime, string message)
    {
      await jsRuntime.InvokeVoidAsync("ShowSweetAlert", "error", message);
    }
  }
}