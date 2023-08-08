
namespace app
{
    partial class frmDetalles
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dvgDetalles = new System.Windows.Forms.DataGridView();
            this.pbxDetalles = new System.Windows.Forms.PictureBox();
            this.tbxDescripcion = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgDetalles
            // 
            this.dvgDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgDetalles.Location = new System.Drawing.Point(12, 13);
            this.dvgDetalles.MultiSelect = false;
            this.dvgDetalles.Name = "dvgDetalles";
            this.dvgDetalles.RowHeadersWidth = 62;
            this.dvgDetalles.RowTemplate.Height = 28;
            this.dvgDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDetalles.Size = new System.Drawing.Size(802, 271);
            this.dvgDetalles.TabIndex = 0;
            // 
            // pbxDetalles
            // 
            this.pbxDetalles.Location = new System.Drawing.Point(457, 290);
            this.pbxDetalles.Name = "pbxDetalles";
            this.pbxDetalles.Size = new System.Drawing.Size(327, 369);
            this.pbxDetalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDetalles.TabIndex = 1;
            this.pbxDetalles.TabStop = false;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(40, 290);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(311, 369);
            this.tbxDescripcion.TabIndex = 0;
            this.tbxDescripcion.Text = "";
            // 
            // frmDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 671);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.pbxDetalles);
            this.Controls.Add(this.dvgDetalles);
            this.MaximizeBox = false;
            this.Name = "frmDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del articulo";
            this.Load += new System.EventHandler(this.frmDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgDetalles;
        private System.Windows.Forms.PictureBox pbxDetalles;
        private System.Windows.Forms.RichTextBox tbxDescripcion;
    }
}