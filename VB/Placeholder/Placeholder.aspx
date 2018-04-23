<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Placeholder.aspx.vb" Inherits="Placeholder.Placeholder" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.ASPxHtmlEditor.v15.1, Version=15.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxHtmlEditor" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v15.1, Version=15.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--region #Markup-->
            <dx:ASPxHtmlEditor ID="HtmlEditor" ClientInstanceName="HtmlEditor" runat="server">
                <Toolbars>
                    <dx:HtmlEditorToolbar>
                        <Items>
                            <dx:ToolbarUndoButton>
                            </dx:ToolbarUndoButton>
                            <dx:ToolbarRedoButton>
                            </dx:ToolbarRedoButton>
                            <dx:ToolbarBoldButton BeginGroup="True">
                            </dx:ToolbarBoldButton>
                            <dx:ToolbarItalicButton>
                            </dx:ToolbarItalicButton>
                            <dx:ToolbarUnderlineButton>
                            </dx:ToolbarUnderlineButton>
                            <dx:ToolbarStrikethroughButton>
                            </dx:ToolbarStrikethroughButton>
                            <dx:ToolbarJustifyLeftButton BeginGroup="True">
                            </dx:ToolbarJustifyLeftButton>
                            <dx:ToolbarJustifyCenterButton>
                            </dx:ToolbarJustifyCenterButton>
                            <dx:ToolbarJustifyRightButton>
                            </dx:ToolbarJustifyRightButton>
                            <dx:ToolbarInsertPlaceholderDialogButton>
                            </dx:ToolbarInsertPlaceholderDialogButton>
                        </Items>
                    </dx:HtmlEditorToolbar>
                </Toolbars>
                <Placeholders>
                    <dx:HtmlEditorPlaceholderItem Value="DateNow" />
                    <dx:HtmlEditorPlaceholderItem Value="TimeNow" />
                    <dx:HtmlEditorPlaceholderItem Value="FirstName" />
                    <dx:HtmlEditorPlaceholderItem Value="LastName" />
                </Placeholders>
            </dx:ASPxHtmlEditor>
            <dx:ASPxButton ID="SignatureButton" runat="server" OnClick="Insert_Signature" 
                Text="Insert Signature"></dx:ASPxButton>
            <dx:ASPxButton ID="DateButton" runat="server" OnClick="Insert_Date" Text="Insert Date">
            </dx:ASPxButton>
            <!--endregion #Markup-->
        </div>
    </form>
</body>
</html>