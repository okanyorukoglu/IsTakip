#pragma checksum "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69ed9527c19514a37e7a9889caad51f400d7deb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_IsEmri_GorevlendirPersonel), @"mvc.1.0.view", @"/Areas/Admin/Views/IsEmri/GorevlendirPersonel.cshtml")]
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
#line 3 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.AciliyetDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.BildirimDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69ed9527c19514a37e7a9889caad51f400d7deb5", @"/Areas/Admin/Views/IsEmri/GorevlendirPersonel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"467107639a7ee0733b4b9fbd1569d61db72ba729", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_IsEmri_GorevlendirPersonel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonelGorevlendirListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:10rem!important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtaPersonel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::YSKProje.ToDo.Web.TagHelpers.GorevAppUserIdTagHelper __YSKProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
  
    ViewData["Title"] = "GorevlendirPersonel";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""row mt-2"">




        <div class=""col-md-4"">
            <div class=""card "">
                <div class=""card-header"">
                    <h4 class=""text-center lead pt-2"">Görev Bilgileri</h4>
                </div>


                <div class=""card-body"">
                    <h5 class=""card-title"">");
#nullable restore
#line 20 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                      Write(Model.Gorev.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">\r\n                        ");
#nullable restore
#line 22 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                   Write(Model.Gorev.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p class=\"card-text\">\r\n                        <strong> Aciliyet Durumu:</strong> <span class=\"badge badge-primary\"> ");
#nullable restore
#line 25 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                                                                         Write(Model.Gorev.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </p>

                </div>
            </div>
        </div>
        <div class=""col-md-8"">
         
            <div class=""card  mb-3"">
                <div class=""card-header"">
                    <h5 class=""card-title"">Personel Bilgileri</h5>
                </div>
              
                <div class=""row no-gutters"">
                    <div class=""col-md-4"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "69ed9527c19514a37e7a9889caad51f400d7deb58115", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1249, "~/img/", 1249, 6, true);
#nullable restore
#line 40 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
AddHtmlAttributeValue("", 1255, Model.AppUser.Picture, 1255, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 40 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
AddHtmlAttributeValue("", 1334, Model.AppUser.Name, 1334, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 44 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                              Write(Model.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                                                  Write(Model.AppUser.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getirGorevAppUserId", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69ed9527c19514a37e7a9889caad51f400d7deb511227", async() => {
            }
            );
            __YSKProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper = CreateTagHelper<global::YSKProje.ToDo.Web.TagHelpers.GorevAppUserIdTagHelper>();
            __tagHelperExecutionContext.Add(__YSKProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper);
#nullable restore
#line 46 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
__YSKProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper.AppUserId = Model.AppUser.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("app-user-id", __YSKProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper.AppUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n                            <p class=\"card-text\">\r\n                                <small class=\"text-muted\">");
#nullable restore
#line 49 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                                     Write(Model.AppUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"col-md-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69ed9527c19514a37e7a9889caad51f400d7deb513375", async() => {
                WriteLiteral("\r\n                <p class=\"lead\">\r\n                    Yukarıdaki göreve ilgili personel atanacaktır. Bu işlemi gerçekleştirmek istediğinizden emin misiniz?\r\n                </p>\r\n                <div class=\"form-group text-center\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69ed9527c19514a37e7a9889caad51f400d7deb513899", async() => {
                    WriteLiteral("<i class=\"fas fa-chevron-circle-left mr-2\"></i>Hayır Vazgeç");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                                  WriteLiteral(Model.Gorev.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"PersonelId\"");
                BeginWriteAttribute("value", " value=\"", 2621, "\"", 2646, 1);
#nullable restore
#line 65 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
WriteAttributeValue("", 2629, Model.AppUser.Id, 2629, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"GorevId\"");
                BeginWriteAttribute("value", " value=\"", 2707, "\"", 2730, 1);
#nullable restore
#line 66 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
WriteAttributeValue("", 2715, Model.Gorev.Id, 2715, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <button type=\"submit\" class=\"btn btn-info \"><i class=\"fas fa-check mr-2\"></i> Evet Görevlendir</button>\r\n                </div>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonelGorevlendirListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
