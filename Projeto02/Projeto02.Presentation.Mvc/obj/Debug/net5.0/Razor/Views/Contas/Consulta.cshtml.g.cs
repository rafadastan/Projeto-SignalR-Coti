#pragma checksum "C:\Users\Samsung\Desktop\COTI - Aulas\2021 - C# WebDeveloper Avançado Sab 2021\Aula 09 - 28.08.21\Projeto02\Projeto02.Presentation.Mvc\Views\Contas\Consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42c1ab97a2188f4be06bab75b7b5be3b676d2208"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contas_Consulta), @"mvc.1.0.view", @"/Views/Contas/Consulta.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42c1ab97a2188f4be06bab75b7b5be3b676d2208", @"/Views/Contas/Consulta.cshtml")]
    public class Views_Contas_Consulta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.6.0.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h5>Consulta de Contas</h5>
<hr />

<div class=""row"">
    <div class=""col-md-12"">
        <div id=""grafico""></div>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <div id=""mensagem"" style=""display: none;"" class=""alert alert-success alert-dismissible fade show"" role=""alert"">
            <button type=""button"" class=""btn-close"" id=""alert-close"" aria-label=""Close""></button>
            <h4 class=""alert-heading"">Nova conta cadastrada com sucesso!</h4>
            <hr />
            <div>Nome: <strong id=""nome""></strong></div>
            <div>Valor: <strong id=""valor""></strong></div>
            <div>Categoria: <strong id=""categoria""></strong></div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c1ab97a2188f4be06bab75b7b5be3b676d22084250", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c1ab97a2188f4be06bab75b7b5be3b676d22085349", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script src=""https://code.highcharts.com/highcharts.js""></script>
    <script src=""https://code.highcharts.com/highcharts-3d.js""></script>
    <script src=""https://code.highcharts.com/modules/exporting.js""></script>
    <script src=""https://code.highcharts.com/modules/export-data.js""></script>

    <script>

        //conectando no HUB..
        const connection = new signalR
            .HubConnectionBuilder()
            .withUrl(""/contashub"")
            .build();

        //iniciando a conexão
        connection.start()
            .catch(
                e => console.log(e)
            );

        //escutando as mensagens do hub
        connection.on('ReceiveMessage', (data) => {

            //imprimindo os dados
            $(""#nome"").html(data.model.nome);
            $(""#valor"").html(data.model.valor);
            $(""#categoria"").html(data.model.categoria == 1 ? ""Débito"" : ""Crédito"");

            $(""#mensagem"").show();

            var array = [];

            ");
                WriteLiteral(@"for (var i = 0; i < data.result.length; i++) {
                array.push([
                    data.result[i].categoria, data.result[i].total
                ]);
            }

            new Highcharts.Chart({
                chart: {
                    type: 'pie',
                    renderTo: 'grafico'
                },
                title: {
                    text: 'Total de Contas por Categoria'
                },
                subtitle: {
                    text: 'Somatório das contas por categoria'
                },
                plotOptions: {
                    pie: {
                        innerSize: '60%'
                    }
                },
                exporting: {
                    enabled: false
                },
                credits: {
                    enabled: false
                },
                series: [{
                    data: array
                }]
            })
        });

        $(document).ready(function () ");
                WriteLiteral("{\r\n            $(\"#alert-close\").click(function () {\r\n                $(\"#mensagem\").hide();\r\n            });\r\n        });\r\n\r\n    </script>\r\n");
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
