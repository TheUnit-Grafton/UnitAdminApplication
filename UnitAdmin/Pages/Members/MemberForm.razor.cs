using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Inputs;
using System;
using System.IO;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Members
{
    public partial class MemberForm : ComponentBase
    {
        protected override void OnParametersSet()
        {
            if (string.IsNullOrWhiteSpace(model.PhotoPath))
            {
               
            }
            else
            {
               
            }
        }

        private void UploadPhoto(UploadChangeEventArgs args)
        {
            foreach (var file in args.Files)
            {
                var imageGuid = new Guid();
                var path = "../../Images/" + imageGuid + "_" + file.FileInfo.Name;
                model.PhotoPath = path;
                FileStream filestream = new FileStream(path , FileMode.Create , FileAccess.Write);
                file.Stream.WriteTo(filestream);
                filestream.Close();
                file.Stream.Close();
            }
        }
    }
}
