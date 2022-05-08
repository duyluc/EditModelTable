
namespace EditModelTable
{
    partial class EditModelTabel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Datagridview = new System.Windows.Forms.DataGridView();
            this.PropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Datagridview
            // 
            this.Datagridview.AllowUserToAddRows = false;
            this.Datagridview.AllowUserToDeleteRows = false;
            this.Datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyName,
            this.Value});
            this.Datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Datagridview.Location = new System.Drawing.Point(0, 0);
            this.Datagridview.Name = "Datagridview";
            this.Datagridview.Size = new System.Drawing.Size(492, 461);
            this.Datagridview.TabIndex = 0;
            // 
            // PropertyName
            // 
            this.PropertyName.FillWeight = 91.37056F;
            this.PropertyName.HeaderText = "Property Name";
            this.PropertyName.MinimumWidth = 80;
            this.PropertyName.Name = "PropertyName";
            this.PropertyName.ReadOnly = true;
            this.PropertyName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Value
            // 
            this.Value.FillWeight = 108.6294F;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // EditModelTabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Datagridview);
            this.Name = "EditModelTabel";
            this.Size = new System.Drawing.Size(492, 461);
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView Datagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}
