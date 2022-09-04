
namespace RecorridoMatriz
{
    partial class frmLenguaje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rtxbSentencias = new System.Windows.Forms.RichTextBox();
            this.rtxbTokens = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgIden = new System.Windows.Forms.DataGridView();
            this.rtxbNombreError = new System.Windows.Forms.RichTextBox();
            this.rtxbNumError = new System.Windows.Forms.RichTextBox();
            this.dtgTablaDeSimbolos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtxbLineasCodigo = new System.Windows.Forms.RichTextBox();
            this.rtxbLineasTokens = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.lblTotalErrores = new System.Windows.Forms.Label();
            this.lblNumErrores = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RbtnGuardarArchivo = new RecorridoMatriz.RJButton();
            this.RbtnCargar = new RecorridoMatriz.RJButton();
            this.RbtnGuardarPrograma = new RecorridoMatriz.RJButton();
            this.RbtnNuevo = new RecorridoMatriz.RJButton();
            this.rbtnEjecutar = new RecorridoMatriz.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablaDeSimbolos)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxbSentencias
            // 
            this.rtxbSentencias.AcceptsTab = true;
            this.rtxbSentencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.rtxbSentencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbSentencias.Font = new System.Drawing.Font("Consolas", 9.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbSentencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtxbSentencias.Location = new System.Drawing.Point(97, 145);
            this.rtxbSentencias.Name = "rtxbSentencias";
            this.rtxbSentencias.Size = new System.Drawing.Size(710, 348);
            this.rtxbSentencias.TabIndex = 0;
            this.rtxbSentencias.Text = "INICIO\n\nFIN";
            this.rtxbSentencias.Click += new System.EventHandler(this.rtxbSentencias_Click);
            this.rtxbSentencias.TextChanged += new System.EventHandler(this.rtxbSentencias_TextChanged);
            this.rtxbSentencias.Enter += new System.EventHandler(this.rtxbSentencias_Enter);
            // 
            // rtxbTokens
            // 
            this.rtxbTokens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.rtxbTokens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbTokens.Font = new System.Drawing.Font("Consolas", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbTokens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rtxbTokens.Location = new System.Drawing.Point(960, 145);
            this.rtxbTokens.Name = "rtxbTokens";
            this.rtxbTokens.ReadOnly = true;
            this.rtxbTokens.Size = new System.Drawing.Size(404, 348);
            this.rtxbTokens.TabIndex = 4;
            this.rtxbTokens.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sentencias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(881, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tokens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(21, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Línea";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtgIden
            // 
            this.dtgIden.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.dtgIden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgIden.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgIden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgIden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgIden.ColumnHeadersHeight = 25;
            this.dtgIden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgIden.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgIden.EnableHeadersVisualStyles = false;
            this.dtgIden.Location = new System.Drawing.Point(17, 864);
            this.dtgIden.Margin = new System.Windows.Forms.Padding(2);
            this.dtgIden.Name = "dtgIden";
            this.dtgIden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgIden.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgIden.RowHeadersWidth = 72;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(81)))));
            this.dtgIden.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgIden.RowTemplate.Height = 31;
            this.dtgIden.Size = new System.Drawing.Size(1347, 212);
            this.dtgIden.TabIndex = 10;
            // 
            // rtxbNombreError
            // 
            this.rtxbNombreError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.rtxbNombreError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbNombreError.Font = new System.Drawing.Font("Consolas", 9.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbNombreError.ForeColor = System.Drawing.Color.Red;
            this.rtxbNombreError.Location = new System.Drawing.Point(97, 565);
            this.rtxbNombreError.Name = "rtxbNombreError";
            this.rtxbNombreError.ReadOnly = true;
            this.rtxbNombreError.Size = new System.Drawing.Size(538, 212);
            this.rtxbNombreError.TabIndex = 12;
            this.rtxbNombreError.Text = "";
            // 
            // rtxbNumError
            // 
            this.rtxbNumError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.rtxbNumError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbNumError.Font = new System.Drawing.Font("Consolas", 9.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbNumError.ForeColor = System.Drawing.Color.IndianRed;
            this.rtxbNumError.Location = new System.Drawing.Point(22, 566);
            this.rtxbNumError.Name = "rtxbNumError";
            this.rtxbNumError.ReadOnly = true;
            this.rtxbNumError.Size = new System.Drawing.Size(69, 212);
            this.rtxbNumError.TabIndex = 13;
            this.rtxbNumError.Text = "";
            // 
            // dtgTablaDeSimbolos
            // 
            this.dtgTablaDeSimbolos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgTablaDeSimbolos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgTablaDeSimbolos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.dtgTablaDeSimbolos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTablaDeSimbolos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgTablaDeSimbolos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTablaDeSimbolos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgTablaDeSimbolos.ColumnHeadersHeight = 30;
            this.dtgTablaDeSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgTablaDeSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTablaDeSimbolos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgTablaDeSimbolos.EnableHeadersVisualStyles = false;
            this.dtgTablaDeSimbolos.Location = new System.Drawing.Point(745, 565);
            this.dtgTablaDeSimbolos.Margin = new System.Windows.Forms.Padding(2);
            this.dtgTablaDeSimbolos.Name = "dtgTablaDeSimbolos";
            this.dtgTablaDeSimbolos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTablaDeSimbolos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgTablaDeSimbolos.RowHeadersWidth = 72;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(81)))));
            this.dtgTablaDeSimbolos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgTablaDeSimbolos.RowTemplate.Height = 31;
            this.dtgTablaDeSimbolos.Size = new System.Drawing.Size(619, 212);
            this.dtgTablaDeSimbolos.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "# Identificador";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 67;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo de dato";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 83;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 54;
            // 
            // rtxbLineasCodigo
            // 
            this.rtxbLineasCodigo.AcceptsTab = true;
            this.rtxbLineasCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.rtxbLineasCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbLineasCodigo.Font = new System.Drawing.Font("Consolas", 9.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbLineasCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(250)))));
            this.rtxbLineasCodigo.Location = new System.Drawing.Point(22, 145);
            this.rtxbLineasCodigo.Name = "rtxbLineasCodigo";
            this.rtxbLineasCodigo.Size = new System.Drawing.Size(69, 348);
            this.rtxbLineasCodigo.TabIndex = 15;
            this.rtxbLineasCodigo.Text = "1\n2\n3";
            this.rtxbLineasCodigo.TextChanged += new System.EventHandler(this.rtxbLineasCodigo_TextChanged);
            // 
            // rtxbLineasTokens
            // 
            this.rtxbLineasTokens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.rtxbLineasTokens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbLineasTokens.Font = new System.Drawing.Font("Consolas", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbLineasTokens.ForeColor = System.Drawing.Color.LightSalmon;
            this.rtxbLineasTokens.Location = new System.Drawing.Point(886, 145);
            this.rtxbLineasTokens.Name = "rtxbLineasTokens";
            this.rtxbLineasTokens.ReadOnly = true;
            this.rtxbLineasTokens.Size = new System.Drawing.Size(68, 348);
            this.rtxbLineasTokens.TabIndex = 16;
            this.rtxbLineasTokens.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(92, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Errores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(740, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tabla de símbolos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 837);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Matríz de transición";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(1242, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(25, 15);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(1273, 12);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(25, 25);
            this.iconButton3.TabIndex = 24;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 20;
            this.iconButton4.Location = new System.Drawing.Point(1304, 12);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(25, 25);
            this.iconButton4.TabIndex = 25;
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // lblTotalErrores
            // 
            this.lblTotalErrores.AutoSize = true;
            this.lblTotalErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalErrores.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalErrores.Location = new System.Drawing.Point(12, 785);
            this.lblTotalErrores.Name = "lblTotalErrores";
            this.lblTotalErrores.Size = new System.Drawing.Size(106, 13);
            this.lblTotalErrores.TabIndex = 31;
            this.lblTotalErrores.Text = "Total de Errores: ";
            this.lblTotalErrores.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblNumErrores
            // 
            this.lblNumErrores.AutoSize = true;
            this.lblNumErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumErrores.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumErrores.Location = new System.Drawing.Point(190, 785);
            this.lblNumErrores.Name = "lblNumErrores";
            this.lblNumErrores.Size = new System.Drawing.Size(14, 13);
            this.lblNumErrores.TabIndex = 32;
            this.lblNumErrores.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(9, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 28);
            this.label7.TabIndex = 33;
            this.label7.Text = "CAMY";
            // 
            // RbtnGuardarArchivo
            // 
            this.RbtnGuardarArchivo.BackColor = System.Drawing.Color.MediumBlue;
            this.RbtnGuardarArchivo.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.RbtnGuardarArchivo.BorderColor = System.Drawing.Color.MidnightBlue;
            this.RbtnGuardarArchivo.BorderRadius = 10;
            this.RbtnGuardarArchivo.BorderSize = 0;
            this.RbtnGuardarArchivo.FlatAppearance.BorderSize = 0;
            this.RbtnGuardarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbtnGuardarArchivo.ForeColor = System.Drawing.Color.White;
            this.RbtnGuardarArchivo.Location = new System.Drawing.Point(1017, 499);
            this.RbtnGuardarArchivo.Name = "RbtnGuardarArchivo";
            this.RbtnGuardarArchivo.Size = new System.Drawing.Size(202, 42);
            this.RbtnGuardarArchivo.TabIndex = 30;
            this.RbtnGuardarArchivo.Text = "Guardar Archivo";
            this.RbtnGuardarArchivo.TextColor = System.Drawing.Color.White;
            this.RbtnGuardarArchivo.UseVisualStyleBackColor = false;
            this.RbtnGuardarArchivo.Click += new System.EventHandler(this.RbtnGuardarArchivo_Click);
            // 
            // RbtnCargar
            // 
            this.RbtnCargar.BackColor = System.Drawing.Color.MediumBlue;
            this.RbtnCargar.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.RbtnCargar.BorderColor = System.Drawing.Color.MidnightBlue;
            this.RbtnCargar.BorderRadius = 10;
            this.RbtnCargar.BorderSize = 0;
            this.RbtnCargar.FlatAppearance.BorderSize = 0;
            this.RbtnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.RbtnCargar.ForeColor = System.Drawing.Color.White;
            this.RbtnCargar.Location = new System.Drawing.Point(339, 78);
            this.RbtnCargar.Name = "RbtnCargar";
            this.RbtnCargar.Size = new System.Drawing.Size(123, 56);
            this.RbtnCargar.TabIndex = 29;
            this.RbtnCargar.Text = "Cargar";
            this.RbtnCargar.TextColor = System.Drawing.Color.White;
            this.RbtnCargar.UseVisualStyleBackColor = false;
            this.RbtnCargar.Click += new System.EventHandler(this.RbtnCargar_Click);
            // 
            // RbtnGuardarPrograma
            // 
            this.RbtnGuardarPrograma.BackColor = System.Drawing.Color.MediumBlue;
            this.RbtnGuardarPrograma.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.RbtnGuardarPrograma.BorderColor = System.Drawing.Color.MidnightBlue;
            this.RbtnGuardarPrograma.BorderRadius = 10;
            this.RbtnGuardarPrograma.BorderSize = 0;
            this.RbtnGuardarPrograma.FlatAppearance.BorderSize = 0;
            this.RbtnGuardarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbtnGuardarPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.RbtnGuardarPrograma.ForeColor = System.Drawing.Color.White;
            this.RbtnGuardarPrograma.Location = new System.Drawing.Point(468, 78);
            this.RbtnGuardarPrograma.Name = "RbtnGuardarPrograma";
            this.RbtnGuardarPrograma.Size = new System.Drawing.Size(210, 56);
            this.RbtnGuardarPrograma.TabIndex = 28;
            this.RbtnGuardarPrograma.Text = "Guardar Programa";
            this.RbtnGuardarPrograma.TextColor = System.Drawing.Color.White;
            this.RbtnGuardarPrograma.UseVisualStyleBackColor = false;
            this.RbtnGuardarPrograma.Click += new System.EventHandler(this.RbtnGuardarPrograma_Click);
            // 
            // RbtnNuevo
            // 
            this.RbtnNuevo.BackColor = System.Drawing.Color.MediumBlue;
            this.RbtnNuevo.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.RbtnNuevo.BorderColor = System.Drawing.Color.MidnightBlue;
            this.RbtnNuevo.BorderRadius = 10;
            this.RbtnNuevo.BorderSize = 0;
            this.RbtnNuevo.FlatAppearance.BorderSize = 0;
            this.RbtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.RbtnNuevo.ForeColor = System.Drawing.Color.White;
            this.RbtnNuevo.Location = new System.Drawing.Point(210, 78);
            this.RbtnNuevo.Name = "RbtnNuevo";
            this.RbtnNuevo.Size = new System.Drawing.Size(123, 56);
            this.RbtnNuevo.TabIndex = 27;
            this.RbtnNuevo.Text = "Nuevo";
            this.RbtnNuevo.TextColor = System.Drawing.Color.White;
            this.RbtnNuevo.UseVisualStyleBackColor = false;
            this.RbtnNuevo.Click += new System.EventHandler(this.RbtnNuevo_Click);
            // 
            // rbtnEjecutar
            // 
            this.rbtnEjecutar.BackColor = System.Drawing.Color.MediumBlue;
            this.rbtnEjecutar.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.rbtnEjecutar.BorderColor = System.Drawing.Color.MidnightBlue;
            this.rbtnEjecutar.BorderRadius = 10;
            this.rbtnEjecutar.BorderSize = 0;
            this.rbtnEjecutar.FlatAppearance.BorderSize = 0;
            this.rbtnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbtnEjecutar.ForeColor = System.Drawing.Color.White;
            this.rbtnEjecutar.Location = new System.Drawing.Point(684, 78);
            this.rbtnEjecutar.Name = "rbtnEjecutar";
            this.rbtnEjecutar.Size = new System.Drawing.Size(123, 56);
            this.rbtnEjecutar.TabIndex = 26;
            this.rbtnEjecutar.Text = "Ejecutar";
            this.rbtnEjecutar.TextColor = System.Drawing.Color.White;
            this.rbtnEjecutar.UseVisualStyleBackColor = false;
            this.rbtnEjecutar.Click += new System.EventHandler(this.rbtnEjecutar_Click);
            // 
            // frmLenguaje
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNumErrores);
            this.Controls.Add(this.lblTotalErrores);
            this.Controls.Add(this.RbtnGuardarArchivo);
            this.Controls.Add(this.RbtnCargar);
            this.Controls.Add(this.RbtnGuardarPrograma);
            this.Controls.Add(this.RbtnNuevo);
            this.Controls.Add(this.rbtnEjecutar);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxbLineasTokens);
            this.Controls.Add(this.rtxbLineasCodigo);
            this.Controls.Add(this.dtgTablaDeSimbolos);
            this.Controls.Add(this.rtxbNumError);
            this.Controls.Add(this.rtxbNombreError);
            this.Controls.Add(this.dtgIden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxbTokens);
            this.Controls.Add(this.rtxbSentencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLenguaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lenguaje 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLenguaje_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablaDeSimbolos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxbSentencias;
        private System.Windows.Forms.RichTextBox rtxbTokens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgIden;
        private System.Windows.Forms.RichTextBox rtxbNombreError;
        private System.Windows.Forms.RichTextBox rtxbNumError;
        private System.Windows.Forms.DataGridView dtgTablaDeSimbolos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.RichTextBox rtxbLineasCodigo;
        private System.Windows.Forms.RichTextBox rtxbLineasTokens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private RJButton rbtnEjecutar;
        private RJButton RbtnNuevo;
        private RJButton RbtnGuardarPrograma;
        private RJButton RbtnCargar;
        private RJButton RbtnGuardarArchivo;
        private System.Windows.Forms.Label lblTotalErrores;
        private System.Windows.Forms.Label lblNumErrores;
        private System.Windows.Forms.Label label7;
    }
}

