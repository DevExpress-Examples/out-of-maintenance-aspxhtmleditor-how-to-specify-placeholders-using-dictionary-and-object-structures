Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.ASPxHtmlEditor
Imports DevExpress.Internal

Namespace Placeholder
    Partial Public Class Placeholder
        Inherits System.Web.UI.Page

        Private htmlPage As String = "<p>Text mail</p><p>Date: { DateNow } { TimeNow }</p><p>Signature: { FirstName } { LastName }</p>"

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsPostBack Then
                HtmlEditor.Html = htmlPage
            End If
        End Sub

        #Region "#ReplacePlaceholdersFromObject"
        Private Class PlaceholdersForDate
            Private [date] As Date = Date.Now
            Private formatDate As String = "d MMM yyyy"
            Private formatTime As String = "HH:mm"
            Public ReadOnly Property DateNow() As String
                Get
                    Return [date].ToString(formatDate)
                End Get
            End Property
            Public ReadOnly Property TimeNow() As String
                Get
                    Return [date].ToString(formatTime)
                End Get
            End Property
        End Class
        ' Replaces placeholders specified as an object
        Protected Sub Insert_Date(ByVal sender As Object, ByVal e As EventArgs)
            Dim placeholdersForDate As New PlaceholdersForDate()
            Dim html As String = HtmlEditor.Html
            Dim newHtml As String = ASPxHtmlEditor.ReplacePlaceholders(html, placeholdersForDate)
            HtmlEditor.Html = newHtml
        End Sub
        #End Region ' #ReplacePlaceholdersFromObject

        #Region "#ReplacePlaceholdersFromDictionary"
        Private PlaceholdersForSignature As New Dictionary(Of String, String)() From { _
            {"FirstName", "Mary"}, _
            {"LastName", "Bonn"} _
        }

        ' Replaces placeholders specified as a dictionary
        Protected Sub Insert_Signature(ByVal sender As Object, ByVal e As EventArgs)
            Dim html As String = HtmlEditor.Html
            Dim newHtml As String = ASPxHtmlEditor.ReplacePlaceholders(html, PlaceholdersForSignature)
            HtmlEditor.Html = newHtml
        End Sub
        #End Region ' #ReplacePlaceholdersFromDictionary

    End Class
End Namespace
