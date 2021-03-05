#pragma checksum "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07bd589e786a8d963773ce0a74650cbeac06e94c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RecipesVersion2.Pages.Recipes.Pages_Recipes_RecipeDisplay), @"mvc.1.0.razor-page", @"/Pages/Recipes/RecipeDisplay.cshtml")]
namespace RecipesVersion2.Pages.Recipes
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
#line 1 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\_ViewImports.cshtml"
using RecipesVersion2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07bd589e786a8d963773ce0a74650cbeac06e94c", @"/Pages/Recipes/RecipeDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34afc02fc2b745fb834c44d76286e6c546036155", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Recipes_RecipeDisplay : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    <link rel=\"Stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 153, "\"", 197, 1);
#nullable restore
#line 8 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml"
WriteAttributeValue("", 160, Href("~/css/RecipeDisplayStyle.css"), 160, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<div class=\"row mt-1\">\r\n    <div class=\"col\">\r\n        <h1>");
#nullable restore
#line 14 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml"
       Write(Html.DisplayFor(model => model.Recipe.RecipeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"col text-right\">\r\n        <h2 class=\"mb-0 mt-2\">");
#nullable restore
#line 17 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml"
                         Write(Html.DisplayFor(model => model.Recipe.Cuisine.CuisineName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 17 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.Recipe.Course.CourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <hr />\r\n");
            WriteLiteral("</div>\r\n<hr class=\"rounded\">\r\n<div id=\"RecipeDisplay\" class=\"row\">\r\n    <div class=\"col-4\">\r\n        <h3>Ingredients</h3>\r\n        <ul>\r\n");
#nullable restore
#line 52 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml"
             foreach (var item in Model.Recipe.RecipeIngredients)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    ");
#nullable restore
#line 55 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 56 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml"
               Write(Html.DisplayFor(modelItem => item.Unit.UnitName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 57 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml"
               Write(Html.DisplayFor(modelItem => item.RecipeIngredientName.IngredientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 59 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"col-8\">\r\n        <h3>Instructions</h3>\r\n        <ul>\r\n");
#nullable restore
#line 65 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml"
             foreach (var item in Model.Recipe.Instruction)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    ");
#nullable restore
#line 68 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml"
               Write(Html.DisplayFor(modelItem => item.InstructionText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 70 "C:\Users\AcademyPgh\source\repos\RecipesVersion2\Pages\Recipes\RecipeDisplay.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipesVersion2.Pages.Recipes.RecipeDisplayModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipesVersion2.Pages.Recipes.RecipeDisplayModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipesVersion2.Pages.Recipes.RecipeDisplayModel>)PageContext?.ViewData;
        public RecipesVersion2.Pages.Recipes.RecipeDisplayModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
