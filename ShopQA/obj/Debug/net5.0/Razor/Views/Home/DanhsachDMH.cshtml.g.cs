#pragma checksum "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\DanhsachDMH.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b894d7a23e98d2a2ecca65b1c3ae936a880df13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DanhsachDMH), @"mvc.1.0.view", @"/Views/Home/DanhsachDMH.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 6 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\DanhsachDMH.cshtml"
using Slot10.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\DanhsachDMH.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b894d7a23e98d2a2ecca65b1c3ae936a880df13", @"/Views/Home/DanhsachDMH.cshtml")]
    #nullable restore
    public class Views_Home_DanhsachDMH : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b894d7a23e98d2a2ecca65b1c3ae936a880df133690", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b894d7a23e98d2a2ecca65b1c3ae936a880df135342", async() => {
                WriteLiteral(@"
        <a href=""/Home/Trangchu"">Quay lai</a>
        <p style=""text-align:center; color:red;font-size:25px;"">Danh sách đơn mua hàng</p>
        <table border=1 class=""table table-success table-striped"" style=""text-align:center"" >
            <tr>
                <th>ID Đơn mua hàng</th>
                <th>Người mua hàng</th>
                <th>Giá trị đơn hàng</th>
                <th>Địa chỉ nhận hàng</th>
                <th>Ngày mua</th>
                 <th>Ghi chú</th>
                  <th> Chi tiết đơn hàng</th>
            </tr>
");
#nullable restore
#line 29 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\DanhsachDMH.cshtml"
         foreach(DonHang item in ViewBag.list)
        {
            List<ChiTietDh> list = new List<ChiTietDh>();
                string text=null;
            using (var context = new WebShopContext())
            {
                list = context.ChiTietDhs.Where(x => x.Iddh == item.Id).ToList();
                foreach(ChiTietDh item1 in list)
                {
                    item1.SanphamNavigation = context.SanPhams.Where(x => x.Id == item1.Sanpham).Single();
                }
            }
              foreach(ChiTietDh item1 in list)
                {
                text += item1.SanphamNavigation.Tensp + " so luong:" + item1.Soluong + " --- ";
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 46 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\DanhsachDMH.cshtml"
               Write(item.LuotMua);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\DanhsachDMH.cshtml"
               Write(item.NguoiMuaNavigation.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 48 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\DanhsachDMH.cshtml"
               Write(item.GiaTri);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\DanhsachDMH.cshtml"
               Write(item.Diachi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\DanhsachDMH.cshtml"
               Write(item.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\DanhsachDMH.cshtml"
               Write(item.Note);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td><a");
                BeginWriteAttribute("href", " href=\"", 2483, "\"", 2515, 2);
                WriteAttributeValue("", 2490, "/Home/Chitiet?id=", 2490, 17, true);
#nullable restore
#line 52 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\DanhsachDMH.cshtml"
WriteAttributeValue("", 2507, item.Id, 2507, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> Xem chi tiết</a></td>\r\n              \r\n            </tr>\r\n");
#nullable restore
#line 55 "D:\PRN301\Project Final\1-file-.sql-217480201030_Đinh-Quang-Tuấn-_K47ACNTT\(1) 217480201030_Đinh Quang Tuấn _K47ACNTT\ShopQA\Views\Home\DanhsachDMH.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n\r\n    ");
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
