Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Data.Filtering

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub ASPxGridView1_ProcessColumnAutoFilter(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewAutoFilterEventArgs)
		If e.Column.FieldName <> "UnitPrice" Then
			Return
		End If

		If e.Kind = GridViewAutoFilterEventKind.CreateCriteria Then
			If (e.Value.Length > 1) AndAlso ((e.Value(0) = "<"c) OrElse (e.Value(0) = ">"c)) Then
				e.Criteria = CriteriaOperator.TryParse("[UnitPrice]" & e.Value)
			End If
		ElseIf e.Kind = GridViewAutoFilterEventKind.ExtractDisplayText Then
			If e.Value.Length > 0 Then
				Dim bo As BinaryOperator = CType(e.Criteria, BinaryOperator)
				Dim operatorSymbol As String = String.Empty
				Select Case bo.OperatorType
					Case BinaryOperatorType.Greater
						operatorSymbol = ">"
					Case BinaryOperatorType.Less
						operatorSymbol = "<"
				End Select
				e.Value = operatorSymbol & e.Value
			End If
		End If
	End Sub
End Class
