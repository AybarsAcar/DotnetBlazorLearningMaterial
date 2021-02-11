using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;

namespace HiddenVilla_Server.Service.IService
{
  /**
   * interacts with the wwwroot folder to interact with the files there
   */
  public interface IFileUpload
  {
    // used to upload the file into our wwwroot folder
    Task<string> UploadFile(IBrowserFile file);

    bool DeleteFile(string fileName);
  }
}