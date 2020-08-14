#pragma checksum "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Grafik\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0939647894f1ac286206c5ba1bae0c89d5e90b3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Grafik_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Grafik/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0939647894f1ac286206c5ba1bae0c89d5e90b3d", @"/Areas/Admin/Views/Grafik/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"467107639a7ee0733b4b9fbd1569d61db72ba729", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Grafik_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\OKAN\Desktop\IsTakipPlatformu\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Grafik\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n<div class=\"col-md-6\"><div id=\"piechart\" class=\"w-100\" style=\" height: 500px;\"></div></div>\r\n<div class=\"col-md-6\"><div id=\"piechart_3d\" class=\"w-100\" style=\" height: 500px;\"></div></div>\r\n\r\n\r\n\r\n");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script type=""text/javascript"">






        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {


            let enCokIsTamamlayan = [['Personel Adı', 'Görev Sayısı']];
            $.ajax({
                type: ""Get"",
                url: ""./Grafik/EnCokTamamlayan"",
                async: false,
                success: function (data) {
                    let gelenObje = jQuery.parseJSON(data);
                    $.each(gelenObje, (index, value) => {
                        enCokIsTamamlayan.push([value.Isim, value.GorevSayisi]);
                    });

                }
            })

            let EnCokCalisan = [['Personel Adı', 'Görev Sayısı']];


            var data = google.visualization.arrayToDataTable(enCokIsTamamlayan);

            var options = {
                t");
                WriteLiteral(@"itle: 'My Daily Activities'
            };

            var chart = new google.visualization.PieChart(document.getElementById('piechart'));

            chart.draw(data, options);
        }

        google.charts.load(""current"", { packages: [""corechart""] });
        google.charts.setOnLoadCallback(drawChart2);
        function drawChart2() {


            $.ajax({
                type: ""Get"",
                url: ""./Grafik/EnCokCalisan"",
                async: false,
                success: function (data) {
                    let gelenObje2 = jQuery.parseJSON(data);
                    $.each(gelenObje2, (index, value) => {
                        EnCokCalisan.push([value.Isim, value.GorevSayisi]);
                    });

                }
            })
            var data = google.visualization.arrayToDataTable(EnCokCalisan);

            var options = {
                title: 'Şuan İşte Çalışan Personeller',
                is3D: true,
            };

            var ch");
                WriteLiteral("art = new google.visualization.PieChart(document.getElementById(\'piechart_3d\'));\r\n            chart.draw(data, options);\r\n        }\r\n    </script>\r\n\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591