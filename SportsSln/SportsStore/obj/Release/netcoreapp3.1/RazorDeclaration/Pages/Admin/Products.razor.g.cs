#pragma checksum "D:\Github\ASPNETCoreProProjects\SportsSln\SportsStore\Pages\Admin\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "148f0b5bab185b91415faeaa1aeb72270183a270"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SportsStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\Github\ASPNETCoreProProjects\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\ASPNETCoreProProjects\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Github\ASPNETCoreProProjects\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Github\ASPNETCoreProProjects\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Github\ASPNETCoreProProjects\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Github\ASPNETCoreProProjects\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Products : OwningComponentBase<IStoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "D:\Github\ASPNETCoreProProjects\SportsSln\SportsStore\Pages\Admin\Products.razor"
      
    public IStoreRepository Repository => Service;

    public IEnumerable<Product> ProductData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        ProductData = await Repository.Products.ToListAsync();
    }

    public async Task DeleteProduct(Product p)
    {
        Repository.DeleteProduct(p);
        await UpdateData();
    }


    public string GetDetailsUrl(long id) =>
    $"/admin/products/details/{id}";
    public string GetEditUrl(long id) =>
        $"/admin/products/edit/{id}";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
