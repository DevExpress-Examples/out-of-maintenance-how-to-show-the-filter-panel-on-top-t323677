using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using WindowsApplication3.Data;

namespace WindowsApplication3 {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
            recordBindingSource.DataSource = DataHelper.GetData(100);
            imageComboBoxEdit.Properties.Items.AddEnum(typeof(FilterPanelLocation));
            imageComboBoxEdit.EditValue = FilterPanelLocation.Top;

            treeList1.ActiveFilterString = "[ID] > 1";
        }

        private void OnFilterPanelLocationChanged(object sender, EventArgs e) {
            treeList1.FilterPanelLocation = (FilterPanelLocation)imageComboBoxEdit.EditValue;
        }
    }
}
