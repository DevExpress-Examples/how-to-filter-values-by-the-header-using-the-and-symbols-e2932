using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxGridView;
using DevExpress.Data.Filtering;

public partial class _Default : System.Web.UI.Page {
	protected void ASPxGridView1_ProcessColumnAutoFilter(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewAutoFilterEventArgs e) {
		if (e.Column.FieldName != "UnitPrice")
			return;

		if (e.Kind == GridViewAutoFilterEventKind.CreateCriteria) {
			if ((e.Value.Length > 1) && ((e.Value[0] == '<') || (e.Value[0] == '>')))
				e.Criteria = CriteriaOperator.TryParse("[UnitPrice]" + e.Value);
		}
		else if (e.Kind == GridViewAutoFilterEventKind.ExtractDisplayText) {
			if (e.Value.Length > 0) {
				BinaryOperator bo = (BinaryOperator)e.Criteria;
				string operatorSymbol = String.Empty;
				switch (bo.OperatorType) {
					case BinaryOperatorType.Greater:
						operatorSymbol = ">";
						break;
					case BinaryOperatorType.Less:
						operatorSymbol = "<";
						break;
				}
				e.Value = operatorSymbol + e.Value;
			}
		}
	}
}
