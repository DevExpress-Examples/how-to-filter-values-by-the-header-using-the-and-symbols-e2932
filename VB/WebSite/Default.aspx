<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>How to filter values with header filter with using of '&gt;' and '&lt;' symbols</title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="AccessDataSource1"
				KeyFieldName="ProductID" OnProcessColumnAutoFilter="ASPxGridView1_ProcessColumnAutoFilter">
				<Columns>
					<dx:GridViewDataTextColumn FieldName="ProductID" ReadOnly="True" VisibleIndex="0">
						<EditFormSettings Visible="False" />
						<Settings AllowAutoFilter="False" />
					</dx:GridViewDataTextColumn>
					<dx:GridViewDataTextColumn FieldName="ProductName" VisibleIndex="1">
						<Settings AllowAutoFilter="False" />
					</dx:GridViewDataTextColumn>
					<dx:GridViewDataTextColumn FieldName="QuantityPerUnit" VisibleIndex="2">
						<Settings AllowAutoFilter="False" />
					</dx:GridViewDataTextColumn>
					<dx:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="3">
					</dx:GridViewDataTextColumn>
					<dx:GridViewDataTextColumn FieldName="UnitsInStock" VisibleIndex="4">
						<Settings AllowAutoFilter="False" />
					</dx:GridViewDataTextColumn>
					<dx:GridViewDataTextColumn FieldName="UnitsOnOrder" VisibleIndex="5">
						<Settings AllowAutoFilter="False" />
					</dx:GridViewDataTextColumn>
				</Columns>
				<Settings ShowFilterRow="True" />
			</dx:ASPxGridView>
		</div>
		<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
			SelectCommand="SELECT [ProductID], [ProductName], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [UnitsOnOrder] FROM [Products]">
		</asp:AccessDataSource>
	</form>
</body>
</html>