#pragma checksum "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\Chitiet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef367d006d50b474cac016aa4060d428737e5006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chitiet), @"mvc.1.0.view", @"/Views/Home/Chitiet.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 6 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\Chitiet.cshtml"
using Slot10.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef367d006d50b474cac016aa4060d428737e5006", @"/Views/Home/Chitiet.cshtml")]
    #nullable restore
    public class Views_Home_Chitiet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#00ebd0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef367d006d50b474cac016aa4060d428737e50063435", async() => {
                WriteLiteral(@"
          <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
     <script src=""https://cdn.jsdelivr.net/npm/popperjs/core@2.11.5/dist/umd/popper.min.js"" integrity=""sha384-Xe+8cL9oJa6tN/veChSP7q+mnSPaj5Bcu9mPX5F5xIGE0DVittaqT5lorf0EI7Vk"" crossorigin=""anonymous""></script>
     <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.min.js"" integrity=""sha384-kjU+l4N0Yf4ZOJErLsIcvOU2qSb74wXpOhqTvwVx3OElZRweTnQ6d31fXEoRD1Jy"" crossorigin=""anonymous""></script>
   

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef367d006d50b474cac016aa4060d428737e50065088", async() => {
                WriteLiteral(@"
<a href=""/Home/DanhsachDMH"">Quay lại</a>

        <p style=""text-align:center; color:red;font-size:25px;"">Chi tiết đơn mua hàng</p>
        <table border=1  class=""table table-success table-striped"" >

            <tr>
                <td>ID sản phẩm</td>
                <td>Tên sản phẩm</td>
                <td>Hình ảnh</td>
                <td>Giá tiền</td>
                <td>Loại sản phẩm</td>
                <td>Số lượng</td>
            </tr>
");
#nullable restore
#line 29 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\Chitiet.cshtml"
         foreach(ChiTietDh item in ViewBag.list)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 32 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\Chitiet.cshtml"
               Write(item.SanphamNavigation.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\Chitiet.cshtml"
               Write(item.SanphamNavigation.Tensp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td > <img");
                BeginWriteAttribute("src", " src=\"", 1571, "\"", 1606, 1);
#nullable restore
#line 34 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\Chitiet.cshtml"
WriteAttributeValue("", 1577, item.SanphamNavigation.Image, 1577, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\" height:200px; width:200px;\"/></td>\r\n                <td>");
#nullable restore
#line 35 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\Chitiet.cshtml"
               Write(item.SanphamNavigation.Gia);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\Chitiet.cshtml"
                 using(var co= new WebShopContext())
                {
                    Brand b = co.Brands.Where(x => x.Id == item.SanphamNavigation.Brand).SingleOrDefault();

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>");
#nullable restore
#line 39 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\Chitiet.cshtml"
                   Write(b.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 40 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\Chitiet.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("               <td>");
#nullable restore
#line 41 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\Chitiet.cshtml"
              Write(item.Soluong);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n              \r\n            </tr>\r\n");
#nullable restore
#line 44 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\Chitiet.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
