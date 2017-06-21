namespace ClientesMicrosipPortal.guis
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gridClientesMicrosip = new DevExpress.XtraGrid.GridControl();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvClientesMicrosip = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomCobrador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuarioCreador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.gridClientesAExportar = new DevExpress.XtraGrid.GridControl();
            this.gvClientesAExportar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRuta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cambiaCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfig = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbUsuarioMicrosip = new System.Windows.Forms.Label();
            this.lbVendedor = new System.Windows.Forms.Label();
            this.lbCobrador = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.lbVendedorSistema = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCambCondPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesMicrosip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientesMicrosip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesAExportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientesAExportar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(375, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Exportar clientes al portal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridClientesMicrosip
            // 
            this.gridClientesMicrosip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClientesMicrosip.DataSource = this.clienteBindingSource;
            this.gridClientesMicrosip.Location = new System.Drawing.Point(12, 129);
            this.gridClientesMicrosip.MainView = this.gvClientesMicrosip;
            this.gridClientesMicrosip.Name = "gridClientesMicrosip";
            this.gridClientesMicrosip.Size = new System.Drawing.Size(882, 245);
            this.gridClientesMicrosip.TabIndex = 1;
            this.gridClientesMicrosip.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientesMicrosip});
            this.gridClientesMicrosip.Click += new System.EventHandler(this.gridClientesMicrosip_Click);
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
            this.colNombre,
            this.colRuta,
            this.colnomCobrador,
            this.colnomVendedor,
            this.colusuarioCreador});
            this.gvClientesMicrosip.GridControl = this.gridClientesMicrosip;
            this.gvClientesMicrosip.Name = "gvClientesMicrosip";
            this.gvClientesMicrosip.OptionsBehavior.Editable = false;
            this.gvClientesMicrosip.OptionsCustomization.AllowColumnMoving = false;
            this.gvClientesMicrosip.OptionsCustomization.AllowGroup = false;
            this.gvClientesMicrosip.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvClientesMicrosip.OptionsView.ColumnAutoWidth = false;
            this.gvClientesMicrosip.OptionsView.EnableAppearanceEvenRow = true;
            this.gvClientesMicrosip.OptionsView.EnableAppearanceOddRow = true;
            this.gvClientesMicrosip.OptionsView.ShowGroupPanel = false;
            this.gvClientesMicrosip.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvClientesMicrosip_RowCellStyle);
            this.gvClientesMicrosip.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvClientesMicrosip_FocusedRowChanged);
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
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
            this.colnomCobrador.Caption = "Cobrador";
            this.colnomCobrador.FieldName = "nomCobrador";
            this.colnomCobrador.Name = "colnomCobrador";
            this.colnomCobrador.Visible = true;
            this.colnomCobrador.VisibleIndex = 2;
            // 
            // colnomVendedor
            // 
            this.colnomVendedor.Caption = "Vendedor";
            this.colnomVendedor.FieldName = "nomVendedor";
            this.colnomVendedor.Name = "colnomVendedor";
            this.colnomVendedor.Visible = true;
            this.colnomVendedor.VisibleIndex = 3;
            // 
            // colusuarioCreador
            // 
            this.colusuarioCreador.Caption = "Usuario Creador";
            this.colusuarioCreador.FieldName = "usuarioCreador";
            this.colusuarioCreador.Name = "colusuarioCreador";
            this.colusuarioCreador.Visible = true;
            this.colusuarioCreador.VisibleIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente:";
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbBusqueda.Location = new System.Drawing.Point(70, 84);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(824, 23);
            this.txbBusqueda.TabIndex = 3;
            this.txbBusqueda.TextChanged += new System.EventHandler(this.txbBusqueda_TextChanged);
            // 
            // gridClientesAExportar
            // 
            this.gridClientesAExportar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClientesAExportar.DataSource = this.clienteBindingSource;
            this.gridClientesAExportar.Location = new System.Drawing.Point(12, 396);
            this.gridClientesAExportar.MainView = this.gvClientesAExportar;
            this.gridClientesAExportar.Name = "gridClientesAExportar";
            this.gridClientesAExportar.Size = new System.Drawing.Size(882, 222);
            this.gridClientesAExportar.TabIndex = 5;
            this.gridClientesAExportar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientesAExportar});
            // 
            // gvClientesAExportar
            // 
            this.gvClientesAExportar.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gvClientesAExportar.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gvClientesAExportar.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gvClientesAExportar.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvClientesAExportar.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientesAExportar.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvClientesAExportar.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.gvClientesAExportar.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(183)))));
            this.gvClientesAExportar.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.gvClientesAExportar.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvClientesAExportar.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientesAExportar.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvClientesAExportar.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvClientesAExportar.Appearance.Empty.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gvClientesAExportar.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientesAExportar.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gvClientesAExportar.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gvClientesAExportar.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gvClientesAExportar.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvClientesAExportar.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientesAExportar.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvClientesAExportar.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(126)))));
            this.gvClientesAExportar.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvClientesAExportar.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(128)))), ((int)(((byte)(88)))));
            this.gvClientesAExportar.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvClientesAExportar.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvClientesAExportar.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.gvClientesAExportar.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvClientesAExportar.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gvClientesAExportar.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gvClientesAExportar.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gvClientesAExportar.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvClientesAExportar.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientesAExportar.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvClientesAExportar.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gvClientesAExportar.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gvClientesAExportar.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvClientesAExportar.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvClientesAExportar.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gvClientesAExportar.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gvClientesAExportar.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvClientesAExportar.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvClientesAExportar.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvClientesAExportar.Appearance.GroupFooter.Options.UseFont = true;
            this.gvClientesAExportar.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(126)))));
            this.gvClientesAExportar.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gvClientesAExportar.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gvClientesAExportar.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gvClientesAExportar.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvClientesAExportar.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientesAExportar.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvClientesAExportar.Appearance.GroupRow.Options.UseFont = true;
            this.gvClientesAExportar.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gvClientesAExportar.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gvClientesAExportar.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gvClientesAExportar.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvClientesAExportar.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientesAExportar.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvClientesAExportar.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(207)))), ((int)(((byte)(170)))));
            this.gvClientesAExportar.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.gvClientesAExportar.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(168)))), ((int)(((byte)(128)))));
            this.gvClientesAExportar.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.gvClientesAExportar.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.gvClientesAExportar.Appearance.Preview.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.Preview.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvClientesAExportar.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvClientesAExportar.Appearance.Row.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.Row.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvClientesAExportar.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(133)))));
            this.gvClientesAExportar.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvClientesAExportar.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvClientesAExportar.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvClientesAExportar.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvClientesAExportar.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.gvClientesAExportar.Appearance.VertLine.Options.UseBackColor = true;
            this.gvClientesAExportar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre1,
            this.colRuta1,
            this.cambiaCP});
            this.gvClientesAExportar.GridControl = this.gridClientesAExportar;
            this.gvClientesAExportar.Name = "gvClientesAExportar";
            this.gvClientesAExportar.OptionsCustomization.AllowColumnMoving = false;
            this.gvClientesAExportar.OptionsCustomization.AllowGroup = false;
            this.gvClientesAExportar.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvClientesAExportar.OptionsView.ColumnAutoWidth = false;
            this.gvClientesAExportar.OptionsView.EnableAppearanceEvenRow = true;
            this.gvClientesAExportar.OptionsView.ShowGroupPanel = false;
            this.gvClientesAExportar.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvClientesAExportar_RowCellStyle);
            this.gvClientesAExportar.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvClientesAExportar_ShowingEditor);
            // 
            // colNombre1
            // 
            this.colNombre1.FieldName = "Nombre";
            this.colNombre1.Name = "colNombre1";
            this.colNombre1.OptionsColumn.AllowEdit = false;
            this.colNombre1.OptionsColumn.AllowMove = false;
            this.colNombre1.Visible = true;
            this.colNombre1.VisibleIndex = 1;
            // 
            // colRuta1
            // 
            this.colRuta1.FieldName = "Ruta";
            this.colRuta1.Name = "colRuta1";
            this.colRuta1.OptionsColumn.AllowEdit = false;
            this.colRuta1.OptionsColumn.AllowMove = false;
            this.colRuta1.Visible = true;
            this.colRuta1.VisibleIndex = 2;
            // 
            // cambiaCP
            // 
            this.cambiaCP.Caption = "Cambia CP";
            this.cambiaCP.FieldName = "cambiaCP";
            this.cambiaCP.Name = "cambiaCP";
            this.cambiaCP.Visible = true;
            this.cambiaCP.VisibleIndex = 0;
            this.cambiaCP.Width = 60;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(900, 129);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(72, 26);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.AutoSize = true;
            this.btnQuitar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(900, 396);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(72, 26);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportar.AutoSize = true;
            this.btnExportar.Enabled = false;
            this.btnExportar.Location = new System.Drawing.Point(455, 624);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 26);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Clientes en Microsip:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Clientes a exportar al portal:";
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.AutoSize = true;
            this.btnConfig.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Location = new System.Drawing.Point(900, 41);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(72, 26);
            this.btnConfig.TabIndex = 11;
            this.btnConfig.Text = "Config.";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Usuario Microsip:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cobrador:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vendedor:";
            // 
            // lbUsuarioMicrosip
            // 
            this.lbUsuarioMicrosip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsuarioMicrosip.AutoSize = true;
            this.lbUsuarioMicrosip.Location = new System.Drawing.Point(136, 40);
            this.lbUsuarioMicrosip.Name = "lbUsuarioMicrosip";
            this.lbUsuarioMicrosip.Size = new System.Drawing.Size(108, 16);
            this.lbUsuarioMicrosip.TabIndex = 15;
            this.lbUsuarioMicrosip.Text = "lbUsuarioMicrosip";
            // 
            // lbVendedor
            // 
            this.lbVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVendedor.AutoSize = true;
            this.lbVendedor.Location = new System.Drawing.Point(375, 40);
            this.lbVendedor.Name = "lbVendedor";
            this.lbVendedor.Size = new System.Drawing.Size(73, 16);
            this.lbVendedor.TabIndex = 16;
            this.lbVendedor.Text = "lbVendedor";
            // 
            // lbCobrador
            // 
            this.lbCobrador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCobrador.AutoSize = true;
            this.lbCobrador.Location = new System.Drawing.Point(375, 65);
            this.lbCobrador.Name = "lbCobrador";
            this.lbCobrador.Size = new System.Drawing.Size(71, 16);
            this.lbCobrador.TabIndex = 17;
            this.lbCobrador.Text = "lbCobrador";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(159, 110);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(47, 16);
            this.lbError.TabIndex = 18;
            this.lbError.Text = "lbError";
            // 
            // lbVendedorSistema
            // 
            this.lbVendedorSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVendedorSistema.Location = new System.Drawing.Point(615, 9);
            this.lbVendedorSistema.Name = "lbVendedorSistema";
            this.lbVendedorSistema.Size = new System.Drawing.Size(357, 16);
            this.lbVendedorSistema.TabIndex = 19;
            this.lbVendedorSistema.Text = "lbVendedorSistema";
            this.lbVendedorSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(900, 428);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(72, 26);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limipiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCambCondPago
            // 
            this.btnCambCondPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCambCondPago.AutoSize = true;
            this.btnCambCondPago.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambCondPago.Location = new System.Drawing.Point(699, 41);
            this.btnCambCondPago.Name = "btnCambCondPago";
            this.btnCambCondPago.Size = new System.Drawing.Size(195, 26);
            this.btnCambCondPago.TabIndex = 21;
            this.btnCambCondPago.Text = "Cambiar Condición de Pago";
            this.btnCambCondPago.UseVisualStyleBackColor = true;
            this.btnCambCondPago.Click += new System.EventHandler(this.btnCambCondPago_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.btnCambCondPago);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lbVendedorSistema);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.lbCobrador);
            this.Controls.Add(this.lbVendedor);
            this.Controls.Add(this.lbUsuarioMicrosip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gridClientesAExportar);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridClientesMicrosip);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1000, 701);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar clientes desde Microsip al portal www.loscorrales.com";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.Shown += new System.EventHandler(this.Frm_Principal_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesMicrosip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientesMicrosip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesAExportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientesAExportar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private DevExpress.XtraGrid.GridControl gridClientesMicrosip;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientesMicrosip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBusqueda;
        private DevExpress.XtraGrid.GridControl gridClientesAExportar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientesAExportar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colRuta1;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbUsuarioMicrosip;
        private System.Windows.Forms.Label lbVendedor;
        private System.Windows.Forms.Label lbCobrador;
        private System.Windows.Forms.Label lbError;
        private DevExpress.XtraGrid.Columns.GridColumn colnomCobrador;
        private DevExpress.XtraGrid.Columns.GridColumn colnomVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn colusuarioCreador;
        private System.Windows.Forms.Label lbVendedorSistema;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCambCondPago;
        private DevExpress.XtraGrid.Columns.GridColumn cambiaCP;
    }
}