namespace ClientesMicrosipPortal.guis
{
    partial class frmCambCondPago
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambCondPago));
            this.gridClientesMicrosip = new DevExpress.XtraGrid.GridControl();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvClientesMicrosip = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClaveCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomCobrador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcobradorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvendedorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuarioCreador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclienteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcondPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbVendedorSistema = new System.Windows.Forms.Label();
            this.lbCobrador = new System.Windows.Forms.Label();
            this.lbVendedor = new System.Windows.Forms.Label();
            this.lbUsuarioMicrosip = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClientesB = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gcClientesCambio = new DevExpress.XtraGrid.GridControl();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClaveCliente1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRuta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomCobrador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcobradorId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomVendedor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvendedorId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuarioCreador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclienteId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbCPN = new System.Windows.Forms.Label();
            this.lbCPA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesMicrosip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientesMicrosip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClientesCambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClientesMicrosip
            // 
            this.gridClientesMicrosip.DataSource = this.clienteBindingSource;
            this.gridClientesMicrosip.Location = new System.Drawing.Point(12, 139);
            this.gridClientesMicrosip.MainView = this.gvClientesMicrosip;
            this.gridClientesMicrosip.Name = "gridClientesMicrosip";
            this.gridClientesMicrosip.Size = new System.Drawing.Size(775, 255);
            this.gridClientesMicrosip.TabIndex = 2;
            this.gridClientesMicrosip.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientesMicrosip});
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(ClientesMicrosipPortal.clases.Cliente);
            // 
            // gvClientesMicrosip
            // 
            this.gvClientesMicrosip.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvClientesMicrosip.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvClientesMicrosip.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvClientesMicrosip.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvClientesMicrosip.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientesMicrosip.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvClientesMicrosip.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gvClientesMicrosip.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gvClientesMicrosip.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gvClientesMicrosip.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvClientesMicrosip.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientesMicrosip.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvClientesMicrosip.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvClientesMicrosip.Appearance.Empty.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvClientesMicrosip.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientesMicrosip.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvClientesMicrosip.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvClientesMicrosip.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvClientesMicrosip.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientesMicrosip.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvClientesMicrosip.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvClientesMicrosip.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvClientesMicrosip.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gvClientesMicrosip.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gvClientesMicrosip.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientesMicrosip.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvClientesMicrosip.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvClientesMicrosip.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvClientesMicrosip.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientesMicrosip.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvClientesMicrosip.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvClientesMicrosip.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvClientesMicrosip.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvClientesMicrosip.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvClientesMicrosip.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvClientesMicrosip.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvClientesMicrosip.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvClientesMicrosip.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvClientesMicrosip.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvClientesMicrosip.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvClientesMicrosip.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvClientesMicrosip.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvClientesMicrosip.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvClientesMicrosip.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientesMicrosip.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvClientesMicrosip.Appearance.GroupRow.Options.UseFont = true;
            this.gvClientesMicrosip.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvClientesMicrosip.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvClientesMicrosip.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvClientesMicrosip.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvClientesMicrosip.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientesMicrosip.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvClientesMicrosip.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gvClientesMicrosip.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvClientesMicrosip.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvClientesMicrosip.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvClientesMicrosip.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientesMicrosip.Appearance.OddRow.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.OddRow.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gvClientesMicrosip.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gvClientesMicrosip.Appearance.Preview.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.Preview.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvClientesMicrosip.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvClientesMicrosip.Appearance.Row.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.Row.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvClientesMicrosip.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gvClientesMicrosip.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientesMicrosip.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvClientesMicrosip.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvClientesMicrosip.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvClientesMicrosip.Appearance.VertLine.Options.UseBackColor = true;
            this.gvClientesMicrosip.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClaveCliente,
            this.colNombre,
            this.colRutaID,
            this.colRuta,
            this.colnomCobrador,
            this.colcobradorId,
            this.colnomVendedor,
            this.colvendedorId,
            this.colusuarioCreador,
            this.colclienteId,
            this.colcondPago});
            this.gvClientesMicrosip.GridControl = this.gridClientesMicrosip;
            this.gvClientesMicrosip.Name = "gvClientesMicrosip";
            this.gvClientesMicrosip.OptionsBehavior.Editable = false;
            this.gvClientesMicrosip.OptionsCustomization.AllowColumnMoving = false;
            this.gvClientesMicrosip.OptionsCustomization.AllowGroup = false;
            this.gvClientesMicrosip.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvClientesMicrosip.OptionsView.EnableAppearanceEvenRow = true;
            this.gvClientesMicrosip.OptionsView.EnableAppearanceOddRow = true;
            this.gvClientesMicrosip.OptionsView.ShowGroupPanel = false;
            this.gvClientesMicrosip.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvClientesMicrosip_RowCellStyle);
            // 
            // colClaveCliente
            // 
            this.colClaveCliente.FieldName = "ClaveCliente";
            this.colClaveCliente.Name = "colClaveCliente";
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // colRutaID
            // 
            this.colRutaID.FieldName = "RutaID";
            this.colRutaID.Name = "colRutaID";
            // 
            // colRuta
            // 
            this.colRuta.FieldName = "Ruta";
            this.colRuta.Name = "colRuta";
            this.colRuta.Visible = true;
            this.colRuta.VisibleIndex = 1;
            // 
            // colnomCobrador
            // 
            this.colnomCobrador.FieldName = "nomCobrador";
            this.colnomCobrador.Name = "colnomCobrador";
            // 
            // colcobradorId
            // 
            this.colcobradorId.FieldName = "cobradorId";
            this.colcobradorId.Name = "colcobradorId";
            // 
            // colnomVendedor
            // 
            this.colnomVendedor.FieldName = "nomVendedor";
            this.colnomVendedor.Name = "colnomVendedor";
            // 
            // colvendedorId
            // 
            this.colvendedorId.FieldName = "vendedorId";
            this.colvendedorId.Name = "colvendedorId";
            // 
            // colusuarioCreador
            // 
            this.colusuarioCreador.FieldName = "usuarioCreador";
            this.colusuarioCreador.Name = "colusuarioCreador";
            // 
            // colclienteId
            // 
            this.colclienteId.FieldName = "clienteId";
            this.colclienteId.Name = "colclienteId";
            // 
            // colcondPago
            // 
            this.colcondPago.FieldName = "condPago";
            this.colcondPago.Name = "colcondPago";
            // 
            // lbVendedorSistema
            // 
            this.lbVendedorSistema.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.lbVendedorSistema.Location = new System.Drawing.Point(640, 9);
            this.lbVendedorSistema.Name = "lbVendedorSistema";
            this.lbVendedorSistema.Size = new System.Drawing.Size(225, 16);
            this.lbVendedorSistema.TabIndex = 30;
            this.lbVendedorSistema.Text = "lbVendedorSistema";
            this.lbVendedorSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCobrador
            // 
            this.lbCobrador.AutoSize = true;
            this.lbCobrador.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.lbCobrador.Location = new System.Drawing.Point(411, 58);
            this.lbCobrador.Name = "lbCobrador";
            this.lbCobrador.Size = new System.Drawing.Size(71, 16);
            this.lbCobrador.TabIndex = 29;
            this.lbCobrador.Text = "lbCobrador";
            // 
            // lbVendedor
            // 
            this.lbVendedor.AutoSize = true;
            this.lbVendedor.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.lbVendedor.Location = new System.Drawing.Point(411, 33);
            this.lbVendedor.Name = "lbVendedor";
            this.lbVendedor.Size = new System.Drawing.Size(73, 16);
            this.lbVendedor.TabIndex = 28;
            this.lbVendedor.Text = "lbVendedor";
            // 
            // lbUsuarioMicrosip
            // 
            this.lbUsuarioMicrosip.AutoSize = true;
            this.lbUsuarioMicrosip.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.lbUsuarioMicrosip.Location = new System.Drawing.Point(136, 33);
            this.lbUsuarioMicrosip.Name = "lbUsuarioMicrosip";
            this.lbUsuarioMicrosip.Size = new System.Drawing.Size(108, 16);
            this.lbUsuarioMicrosip.TabIndex = 27;
            this.lbUsuarioMicrosip.Text = "lbUsuarioMicrosip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Vendedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cobrador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Usuario Microsip:";
            // 
            // btnCambiar
            // 
            this.btnCambiar.AutoSize = true;
            this.btnCambiar.Enabled = false;
            this.btnCambiar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCambiar.Location = new System.Drawing.Point(401, 601);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 26);
            this.btnCambiar.TabIndex = 31;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Usuario Microsip:";
            // 
            // tbClientesB
            // 
            this.tbClientesB.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tbClientesB.Location = new System.Drawing.Point(139, 110);
            this.tbClientesB.Name = "tbClientesB";
            this.tbClientesB.Size = new System.Drawing.Size(648, 23);
            this.tbClientesB.TabIndex = 33;
            this.tbClientesB.TextChanged += new System.EventHandler(this.tbClientesB_TextChanged);
            // 
            // btnQuitar
            // 
            this.btnQuitar.AutoSize = true;
            this.btnQuitar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnQuitar.Location = new System.Drawing.Point(793, 416);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(72, 26);
            this.btnQuitar.TabIndex = 34;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(793, 139);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(72, 26);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gcClientesCambio
            // 
            this.gcClientesCambio.DataSource = this.clienteBindingSource1;
            this.gcClientesCambio.Location = new System.Drawing.Point(12, 416);
            this.gcClientesCambio.MainView = this.gridView1;
            this.gcClientesCambio.Name = "gcClientesCambio";
            this.gcClientesCambio.Size = new System.Drawing.Size(775, 179);
            this.gcClientesCambio.TabIndex = 36;
            this.gcClientesCambio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataSource = typeof(ClientesMicrosipPortal.clases.Cliente);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClaveCliente1,
            this.colNombre1,
            this.colRutaID1,
            this.colRuta1,
            this.colnomCobrador1,
            this.colcobradorId1,
            this.colnomVendedor1,
            this.colvendedorId1,
            this.colusuarioCreador1,
            this.colclienteId1});
            this.gridView1.GridControl = this.gcClientesCambio;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colClaveCliente1
            // 
            this.colClaveCliente1.FieldName = "ClaveCliente";
            this.colClaveCliente1.Name = "colClaveCliente1";
            // 
            // colNombre1
            // 
            this.colNombre1.FieldName = "Nombre";
            this.colNombre1.Name = "colNombre1";
            this.colNombre1.Visible = true;
            this.colNombre1.VisibleIndex = 0;
            // 
            // colRutaID1
            // 
            this.colRutaID1.FieldName = "RutaID";
            this.colRutaID1.Name = "colRutaID1";
            // 
            // colRuta1
            // 
            this.colRuta1.FieldName = "Ruta";
            this.colRuta1.Name = "colRuta1";
            this.colRuta1.Visible = true;
            this.colRuta1.VisibleIndex = 1;
            // 
            // colnomCobrador1
            // 
            this.colnomCobrador1.FieldName = "nomCobrador";
            this.colnomCobrador1.Name = "colnomCobrador1";
            // 
            // colcobradorId1
            // 
            this.colcobradorId1.FieldName = "cobradorId";
            this.colcobradorId1.Name = "colcobradorId1";
            // 
            // colnomVendedor1
            // 
            this.colnomVendedor1.FieldName = "nomVendedor";
            this.colnomVendedor1.Name = "colnomVendedor1";
            // 
            // colvendedorId1
            // 
            this.colvendedorId1.FieldName = "vendedorId";
            this.colvendedorId1.Name = "colvendedorId1";
            // 
            // colusuarioCreador1
            // 
            this.colusuarioCreador1.FieldName = "usuarioCreador";
            this.colusuarioCreador1.Name = "colusuarioCreador1";
            // 
            // colclienteId1
            // 
            this.colclienteId1.FieldName = "clienteId";
            this.colclienteId1.Name = "colclienteId1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Clientes a cambiar:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(793, 448);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(72, 26);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbCPN
            // 
            this.lbCPN.AutoSize = true;
            this.lbCPN.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.lbCPN.Location = new System.Drawing.Point(640, 90);
            this.lbCPN.Name = "lbCPN";
            this.lbCPN.Size = new System.Drawing.Size(41, 16);
            this.lbCPN.TabIndex = 42;
            this.lbCPN.Text = "lbCPN";
            // 
            // lbCPA
            // 
            this.lbCPA.AutoSize = true;
            this.lbCPA.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.lbCPA.Location = new System.Drawing.Point(187, 91);
            this.lbCPA.Name = "lbCPA";
            this.lbCPA.Size = new System.Drawing.Size(41, 16);
            this.lbCPA.TabIndex = 41;
            this.lbCPA.Text = "lbCPA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Condición Pago Anterior:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(480, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Condicion Pago Nueva:";
            // 
            // frmCambCondPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 639);
            this.Controls.Add(this.lbCPN);
            this.Controls.Add(this.lbCPA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gcClientesCambio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.tbClientesB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lbVendedorSistema);
            this.Controls.Add(this.lbCobrador);
            this.Controls.Add(this.lbVendedor);
            this.Controls.Add(this.lbUsuarioMicrosip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridClientesMicrosip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCambCondPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Condición de Pago";
            this.Load += new System.EventHandler(this.frmCambCondPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesMicrosip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientesMicrosip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClientesCambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridClientesMicrosip;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientesMicrosip;
        private System.Windows.Forms.Label lbVendedorSistema;
        private System.Windows.Forms.Label lbCobrador;
        private System.Windows.Forms.Label lbVendedor;
        private System.Windows.Forms.Label lbUsuarioMicrosip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClientesB;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private DevExpress.XtraGrid.GridControl gcClientesCambio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaID;
        private DevExpress.XtraGrid.Columns.GridColumn colRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colnomCobrador;
        private DevExpress.XtraGrid.Columns.GridColumn colcobradorId;
        private DevExpress.XtraGrid.Columns.GridColumn colnomVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn colvendedorId;
        private DevExpress.XtraGrid.Columns.GridColumn colusuarioCreador;
        private DevExpress.XtraGrid.Columns.GridColumn colclienteId;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveCliente1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaID1;
        private DevExpress.XtraGrid.Columns.GridColumn colRuta1;
        private DevExpress.XtraGrid.Columns.GridColumn colnomCobrador1;
        private DevExpress.XtraGrid.Columns.GridColumn colcobradorId1;
        private DevExpress.XtraGrid.Columns.GridColumn colnomVendedor1;
        private DevExpress.XtraGrid.Columns.GridColumn colvendedorId1;
        private DevExpress.XtraGrid.Columns.GridColumn colusuarioCreador1;
        private DevExpress.XtraGrid.Columns.GridColumn colclienteId1;
        private System.Windows.Forms.Label lbCPN;
        private System.Windows.Forms.Label lbCPA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraGrid.Columns.GridColumn colcondPago;
    }
}