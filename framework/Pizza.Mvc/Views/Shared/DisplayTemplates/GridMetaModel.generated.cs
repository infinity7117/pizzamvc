﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/DisplayTemplates/GridMetaModel.cshtml")]
    public partial class _Views_Shared_DisplayTemplates_GridMetaModel_cshtml_ : System.Web.Mvc.WebViewPage<Pizza.Mvc.Grid.Metamodel.GridMetamodel>
    {
        public _Views_Shared_DisplayTemplates_GridMetaModel_cshtml_()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
 if (Model.NewItemLink.IsEnabled)
{

            
            #line default
            #line hidden
WriteLiteral("    <p>\r\n");

WriteLiteral("        ");

            
            #line 7 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
    Write(Html.ActionLink(Model.NewItemLink.Text, ScriptKeys.Create));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n");

            
            #line 9 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
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

WriteLiteral(">×</a>\r\n                <h3>Delete confirmation</h3>\r\n            </div>\r\n       " +
"     <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                <p>Are you sure to delete this record?</p>\r\n            </div>" +
"\r\n            <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"btnYes\"");

WriteLiteral(" class=\"btn btn-danger\"");

WriteLiteral(">Yes</a>\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(">No</a>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    var detailsLink = \'");

            
            #line 34 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
                   Write(Html.ActionLink("Details", ScriptKeys.Details, new { id = "_id_" }));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n    var editLink = \'");

            
            #line 35 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
                Write(Html.ActionLink("Edit", ScriptKeys.Edit, new { id = "_id_" }));

            
            #line default
            #line hidden
WriteLiteral(@"';

    function buildDetailsLink(cellvalue, options, rowobject) {
        var link = detailsLink.replace(""_id_"", options.rowId);
        return link;
    }

    function buildEditLink(cellvalue, options, rowobject) {
        var link = editLink.replace(""_id_"", options.rowId);
        return link;
    }

    function buildDeleteLink(cellvalue, options, rowobject) {
        var link = ""<a name='delete' data-id='"" + options.rowId + ""' href=''>Delete</a>"";
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

            
            #line 64 "..\..\Views\Shared\DisplayTemplates\GridMetaModel.cshtml"
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

        // Hack for missing 'All' option in dropdowns
        $(""select[id^='gs_']"").each(function () {
            var option = $(this).find('option:first');
            option.text('All');
        });
    }
</script>
");

        }
    }
}
#pragma warning restore 1591
