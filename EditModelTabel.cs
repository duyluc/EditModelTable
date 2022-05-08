using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditModelTable
{
    public partial class EditModelTabel : UserControl
    {
        private PropertyInfo[] PropertyInfo { get; set; }
        public EditModelTabel()
        {
            InitializeComponent();
            this.Datagridview.Columns[0].Width = 80;
        }

        public void SetModel(PropertyInfo[] _propertyInfos)
        {
            this.PropertyInfo = _propertyInfos;
            foreach(PropertyInfo p in this.PropertyInfo)
            {
                DataGridViewRow newrow = new DataGridViewRow();
                DataGridViewTextBoxCell namecell = new DataGridViewTextBoxCell();
                namecell.Value = p.Name;
                DataGridViewCell valuecell = null;
                if(p.PropertyType == typeof(bool))
                {
                    valuecell = new DataGridViewCheckBoxCell();
                }
                else
                {
                    valuecell = new DataGridViewTextBoxCell();
                }
                valuecell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                newrow.Cells.Add(namecell);
                newrow.Cells.Add(valuecell);
                namecell.ReadOnly = true;
                this.Datagridview.Rows.Add(newrow);
            }
        }
    }
}
