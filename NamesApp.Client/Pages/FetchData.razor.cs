using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using NamesApp.Client;
using NamesApp.Client.Shared;

namespace NamesApp.Client.Pages
{
    public partial class FetchData :ComponentBase, IHandleEvent
    {
        int num;
        List<int> lst = new List<int>();
        protected override async Task OnInitializedAsync()
        {
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
        }

        private void UpdateValue() => this.lst.Add(new Random().Next(10, 100));
    }
}