#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "488aa2f21a6d3e3c761871ec0bf2f295695db71a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_Templates_Runtime), @"default", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml")]
namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles
{
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"488aa2f21a6d3e3c761871ec0bf2f295695db71a", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml")]
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_Templates_Runtime
    {
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 11 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
  
    Func<dynamic, object> foo = 

#line default
#line hidden
#nullable disable
            item => new Template(async(__razor_template_writer) => {
                PushWriter(__razor_template_writer);
                WriteLiteral("This works ");
#nullable restore
#line 12 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
                                             Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("!");
                PopWriter();
            }
            )
#nullable restore
#line 12 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
                                                               ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
Write(foo(""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
   
    Func<dynamic, object> bar = 

#line default
#line hidden
#nullable disable
            item => new Template(async(__razor_template_writer) => {
                PushWriter(__razor_template_writer);
                WriteLiteral("<p");
                BeginWriteAttribute("class", " class=\"", 411, "\"", 424, 1);
#nullable restore
#line 17 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
WriteAttributeValue("", 419, item, 419, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Hello</p>");
                PopWriter();
            }
            )
#nullable restore
#line 17 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
                                                           ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
Write(bar("myclass"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 22 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
Write(Repeat(10, item => new Template(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("<li>Item #");
#nullable restore
#line 22 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
    WriteLiteral("</li>");
    PopWriter();
}
)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n\r\n<p>\r\n");
#nullable restore
#line 26 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
Write(Repeat(10,
    item => new Template(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral(" This is line#");
#nullable restore
#line 27 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
               Write(item);

#line default
#line hidden
#nullable disable
    WriteLiteral(" of markup<br/>\r\n");
    PopWriter();
}
)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p>\r\n");
#nullable restore
#line 32 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
Write(Repeat(10,
    item => new Template(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral(": This is line#");
#nullable restore
#line 33 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
                Write(item);

#line default
#line hidden
#nullable disable
    WriteLiteral(" of markup<br />\r\n");
    PopWriter();
}
)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p>\r\n");
#nullable restore
#line 38 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
Write(Repeat(10,
    item => new Template(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral(":: This is line#");
#nullable restore
#line 39 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
                 Write(item);

#line default
#line hidden
#nullable disable
    WriteLiteral(" of markup<br />\r\n");
    PopWriter();
}
)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n\r\n<ul>\r\n    ");
#nullable restore
#line 45 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
Write(Repeat(10, item => new Template(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("<li>\r\n        Item #");
#nullable restore
#line 46 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
         Write(item);

#line default
#line hidden
#nullable disable
    WriteLiteral("\r\n");
#nullable restore
#line 47 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
          var parent = item;

#line default
#line hidden
#nullable disable
    WriteLiteral("        <ul>\r\n            <li>Child Items... ?</li>\r\n");
    WriteLiteral("        </ul>\r\n    </li>");
    PopWriter();
}
)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul> ");
        }
        #pragma warning restore 1998
#nullable restore
#line 1 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Templates.cshtml"
            
    public HelperResult Repeat(int times, Func<int, object> template) {
        return new HelperResult((writer) => {
            for(int i = 0; i < times; i++) {
                ((HelperResult)template(i)).WriteTo(writer);
            }
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
