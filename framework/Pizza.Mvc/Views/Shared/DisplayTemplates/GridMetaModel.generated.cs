﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Pizza.Mvc;
    
    #line 1 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
    using Pizza.Mvc.HtmlHelpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
    using Pizza.Mvc.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/DisplayTemplates/GridMetaModel.cshtml")]
    public partial class _Views_Shared_DisplayTemplates_GridMetaModel_cshtml_ : System.Web.Mvc.WebViewPage<Pizza.Mvc.Grid.Metamodel.GridMetamodel>
    {
        public _Views_Shared_DisplayTemplates_GridMetaModel_cshtml_()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
 if (Model.NewItemLink.IsEnabled)
{

            
            #line default
            #line hidden
WriteLiteral("    <p>\r\n");

WriteLiteral("        ");

            
            #line 8 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
    Write(Html.ActionLink(Model.NewItemLink.Text, ScriptKeys.Create));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n");

            
            #line 10 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 12 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
Write(Html.JqGrid(Model, Url.Action(Model.GetGridDataActionName)));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n<div");

WriteLiteral(" id=\"divConfirmDialog\"");

WriteLiteral(" class=\"modal fade\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content panel-warning\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-header panel-heading\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(">×</a>\r\n                <h3>");

            
            #line 20 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
               Write(UiTexts.Dialog_DeleteRowConfirmation_Title);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                <p>");

            
            #line 23 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
              Write(UiTexts.Dialog_DeleteRowConfirmation_Question);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"btnYes\"");

WriteLiteral(" class=\"btn btn-danger\"");

WriteLiteral(">");

            
            #line 26 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
                                                          Write(UiTexts.DialogButton_Yes);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
                                                                                       Write(UiTexts.DialogButton_No);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n");

            
            #line 35 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
    
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
     if (Model.DetailsLink.IsEnabled)
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("\r\n        var detailsLink = \'");

            
            #line 38 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
                      Write(Html.ActionLink(Model.DetailsLink.Text, ScriptKeys.Details, new {id = "_id_"}));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\r\n        function buildDetailsLink(cellvalue, options, rowobject) {\r\n       " +
"     var link = detailsLink.replace(\"_id_\", options.rowId);\r\n            return " +
"link;\r\n        }\r\n        ");

WriteLiteral("\r\n");

            
            #line 45 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 47 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
    
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
     if (Model.EditLink.IsEnabled)
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("\r\n        var editLink = \'");

            
            #line 50 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
                   Write(Html.ActionLink(Model.EditLink.Text, ScriptKeys.Edit, new { id = "_id_" }));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\r\n        function buildEditLink(cellvalue, options, rowobject) {\r\n          " +
"  var link = editLink.replace(\"_id_\", options.rowId);\r\n            return link;\r" +
"\n        }\r\n        ");

WriteLiteral("\r\n");

            
            #line 57 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    function buildDeleteLink(cellvalue, options, rowobject) {\r\n        var link" +
" = \"<a name=\'delete\' data-id=\'\" + options.rowId + \"\' href=\'\'>");

            
            #line 60 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
                                                                        Write(Model.DeleteLink.Text);

            
            #line default
            #line hidden
WriteLiteral(@"</a>"";
        return link;
    }

    function showConfirmDeleteDialog(e) {
        e.preventDefault();
        var rowId = $(this).attr('data-id');

        var sendDeleteRequest = function () {
            var rowId = $('#divConfirmDialog').data('rowId');

            console.log('Deleting: ' + rowId);

            $.ajax({
                dataType: ""json"",
                type: 'DELETE',
                url: '");

            
            #line 76 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
                 Write(Url.Action(ScriptKeys.Delete));

            
            #line default
            #line hidden
WriteLiteral(@"',
                data: { id: rowId },
                success: function (result) {
                    $('#mainGrid').trigger('reloadGrid');
                }
            });

            $('#divConfirmDialog').modal('hide');
            $('#btnYes').unbind();
        }

        $('#btnYes').click(sendDeleteRequest);

        $('#divConfirmDialog').data('rowId', rowId).modal({ show: true });
    }

    function gridComplete() {
        $(""[name='delete']"").click(showConfirmDeleteDialog);
    }
</script>
");

        }
    }
}
#pragma warning restore 1591
