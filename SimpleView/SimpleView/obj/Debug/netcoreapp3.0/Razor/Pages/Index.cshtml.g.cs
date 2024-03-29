#pragma checksum "/Users/virajsanghvi/Desktop/SimpleView/SimpleView/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847b845cc8fb5d07f8af076fdf3b0728c3010ec8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SimpleView.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace SimpleView.Pages
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
#line 1 "/Users/virajsanghvi/Desktop/SimpleView/SimpleView/Pages/_ViewImports.cshtml"
using SimpleView;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847b845cc8fb5d07f8af076fdf3b0728c3010ec8", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719f206a91909b3f14582863a96d27d3cbe8c060", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "847b845cc8fb5d07f8af076fdf3b0728c3010ec82971", async() => {
                WriteLiteral(@"
    <meta charset='utf-8' />
    <title>Airport Explorer</title>
    <meta name='viewport' content='initial-scale=1,maximum-scale=1,user-scalable=no' />
    <script src='https://api.mapbox.com/mapbox-gl-js/v1.4.1/mapbox-gl.js'></script>
    <link href='https://api.mapbox.com/mapbox-gl-js/v1.4.1/mapbox-gl.css' rel='stylesheet' />
    <style>
        body { margin:0; padding:0; }
        #map { position:absolute; left:0px; top:40px; bottom:20px; width:100%; }
        #infoi {
          z-index: 50;
        }
        #container {
          width: 200px;
          height: 200px;
          position: absolute;
        }
        .btn-secondary,
        .btn-secondary:hover,
        .btn-secondary:active,
        .btn-secondary:visited,
        .btn-secondary:focus {
            background-color: #8064A2;
            border-color: #8064A2;
        }
    </style>
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "847b845cc8fb5d07f8af076fdf3b0728c3010ec84786", async() => {
                WriteLiteral(@"
    <div id='map'></div>
    <script>
        mapboxgl.accessToken = 'pk.eyJ1IjoidmlyYWpzYW5naHZpMSIsImEiOiJjazF4djRmaWIwZGo2M29wY2lxY2pvZzliIn0.o84srF8i23dd9KCYAS7ntw';
        var map = new mapboxgl.Map({
            container: 'map',
            style: 'mapbox://styles/mapbox/satellite-v9'
        });

");
                WriteLiteral("        var scale = new mapboxgl.ScaleControl({\n            unit: \'imperial\'\n        });\n        map.addControl(scale);\n        scale.setUnit(\'metric\');\n\n");
                WriteLiteral(@"        var nav = new mapboxgl.NavigationControl();
        map.addControl(nav, 'top-left');

        map.on('load', function () {
         map.addLayer({
                id: 'map_fires',
                type: 'circle',
                'layout': {
                    'visibility': 'none'
                    },
                source: {
                        type: 'vector',
                        url: 'mapbox://virajsanghvi1.ck7mkw38'
                    },
                'source-layer': 'MODIS_C6_Global_48h-9u1r8m',
                'paint': {
                        'circle-radius': {
                        'base': 1.75,
                        'stops': [[12, 2], [22, 180]]
                        },
                        'circle-color': ""#40ff00""
                    }
                });
         map.addLayer({
                id: 'a_hngos',
                type: 'circle',
                'layout': {
                    'visibility': 'none'
                    },
                source: {
            ");
                WriteLiteral(@"            type: 'vector',
                        url: 'mapbox://virajsanghvi1.0s2ln3oc'
                    },
                'source-layer': '12_projects',
                'paint': {
                        'circle-radius': {
                        'base': 1.75,
                        'stops': [[12, 2], [22, 180]]
                        },
                        'circle-color': ""#54578a""
                    }
                });
         
        });
       
        function fires() {
            var visibility = map.getLayoutProperty('map_fires', 'visibility');
 
            if (visibility === 'visible') {
                map.setLayoutProperty('map_fires', 'visibility', 'none');
            } else {
                map.setLayoutProperty('map_fires', 'visibility', 'visible');
                }
            };

        function a_hngos() {
            var visibility = map.getLayoutProperty('a_hngos', 'visibility');
 
            if (visibility === 'visible') {
                map.setLayoutProperty('a_h");
                WriteLiteral(@"ngos', 'visibility', 'none');
            } else {
                map.setLayoutProperty('a_hngos', 'visibility', 'visible');
                }
            };

        function svi_UScounty() {
            var visibility = map.getLayoutProperty('map_fires', 'visibility');
            if (visibility === 'visible') {
                map.setStyle('mapbox://styles/virajsanghvi1/ck1z8opwv45d51cntduka5wry');
                         map.addLayer({
                id: 'map_fires',
                type: 'circle',
                'layout': {
                    'visibility': 'none'
                    },
                source: {
                        type: 'vector',
                        url: 'mapbox://virajsanghvi1.ck7mkw38'
                    },
                'source-layer': 'MODIS_C6_Global_48h-9u1r8m',
                'paint': {
                        'circle-radius': {
                        'base': 1.75,
                        'stops': [[12, 2], [22, 180]]
                        },
                  ");
                WriteLiteral(@"      'circle-color': ""#40ff00""
                    }
                });
         map.addLayer({
                id: 'a_hngos',
                type: 'circle',
                'layout': {
                    'visibility': 'none'
                    },
                source: {
                        type: 'vector',
                        url: 'mapbox://virajsanghvi1.0s2ln3oc'
                    },
                'source-layer': '12_projects',
                'paint': {
                        'circle-radius': {
                        'base': 1.75,
                        'stops': [[12, 2], [22, 180]]
                        },
                        'circle-color': ""#54578a""
                    }
                });
            } else {
                map.setStyle('mapbox://styles/mapbox/satellite-v9');
                         map.addLayer({
                id: 'map_fires',
                type: 'circle',
                'layout': {
                    'visibility': 'none'
                    },
    ");
                WriteLiteral(@"            source: {
                        type: 'vector',
                        url: 'mapbox://virajsanghvi1.ck7mkw38'
                    },
                'source-layer': 'MODIS_C6_Global_48h-9u1r8m',
                'paint': {
                        'circle-radius': {
                        'base': 1.75,
                        'stops': [[12, 2], [22, 180]]
                        },
                        'circle-color': ""#40ff00""
                    }
                });
         map.addLayer({
                id: 'a_hngos',
                type: 'circle',
                'layout': {
                    'visibility': 'none'
                    },
                source: {
                        type: 'vector',
                        url: 'mapbox://virajsanghvi1.0s2ln3oc'
                    },
                'source-layer': '12_projects',
                'paint': {
                        'circle-radius': {
                        'base': 1.75,
                        'stops': [[12, 2], [22,");
                WriteLiteral(@" 180]]
                        },
                        'circle-color': ""#54578a""
                    }
                });
                }
            };
    </script>
    <div id=""container"">
      <div id=""infoi"">
        <div class=""dropdown"">
          <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenu2"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Dropdown
          </button>
          <div class=""dropdown-menu"" aria-labelledby=""dropdownMenu2"">
            <h6 class=""dropdown-header"">Environmental Hazards</h6>
            <button class=""dropdown-item"" type=""button"" id=""eh_fires"" onclick=""fires()"">Fires</button>
            <div class=""dropdown-divider""></div>
            <h6 class=""dropdown-header"">SVI</h6>
            <button class=""dropdown-item"" type=""button"" id=""svi_UScounty"" onclick=""svi_UScounty()"">United States SVI</button>
            <div class=""dropdown-divider""></div>
            <h6 class=""dropdown-header"">Help</h6>
        ");
                WriteLiteral("    <button class=\"dropdown-item\" type=\"button\" id=\"a_hngos\" onclick=\"a_hngos()\">Active Humanitarian NGOs</button>\n          </div>\n        </div>\n      </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
