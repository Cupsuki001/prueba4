namespace prueba4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode4 = new TreeNode("Efectivo");
            TreeNode treeNode5 = new TreeNode("Credito");
            TreeNode treeNode6 = new TreeNode("Tipos de pago", new TreeNode[] { treeNode4, treeNode5 });
            groupBox2 = new GroupBox();
            BTNbase = new Button();
            TXBdesc = new TextBox();
            label14 = new Label();
            TXBdinero = new TextBox();
            TXBsub = new TextBox();
            label13 = new Label();
            label5 = new Label();
            TXBtipopago = new TextBox();
            label12 = new Label();
            TXBimpuesto = new TextBox();
            label11 = new Label();
            label8 = new Label();
            TXBvuelt = new TextBox();
            TXBsubfact = new TextBox();
            label6 = new Label();
            label7 = new Label();
            TXBfact = new TextBox();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            LBLning = new Label();
            CHKdesc = new CheckBox();
            button1 = new Button();
            TXBdola = new TextBox();
            TXBcord = new TextBox();
            CMBtipo = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            BTNpagar = new Button();
            treeView1 = new TreeView();
            MSKcant = new MaskedTextBox();
            MSKcodigo = new MaskedTextBox();
            label4 = new Label();
            LBLconta = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            TXBnomb = new TextBox();
            BTNborrar = new Button();
            TXBadi = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TXBprecio = new TextBox();
            TXBttdesc = new TextBox();
            label15 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.AppWorkspace;
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(TXBttdesc);
            groupBox2.Controls.Add(BTNbase);
            groupBox2.Controls.Add(TXBdesc);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(TXBdinero);
            groupBox2.Controls.Add(TXBsub);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TXBtipopago);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(TXBimpuesto);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(TXBvuelt);
            groupBox2.Controls.Add(TXBsubfact);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(TXBfact);
            groupBox2.Location = new Point(12, 409);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1101, 225);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // BTNbase
            // 
            BTNbase.Location = new Point(947, 164);
            BTNbase.Name = "BTNbase";
            BTNbase.Size = new Size(94, 29);
            BTNbase.TabIndex = 52;
            BTNbase.Text = "Base de DT";
            BTNbase.UseVisualStyleBackColor = true;
            // 
            // TXBdesc
            // 
            TXBdesc.Location = new Point(934, 51);
            TXBdesc.Name = "TXBdesc";
            TXBdesc.Size = new Size(125, 27);
            TXBdesc.TabIndex = 51;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(816, 54);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 50;
            label14.Text = "Descuento";
            // 
            // TXBdinero
            // 
            TXBdinero.Location = new Point(650, 47);
            TXBdinero.Name = "TXBdinero";
            TXBdinero.Size = new Size(125, 27);
            TXBdinero.TabIndex = 5;
            // 
            // TXBsub
            // 
            TXBsub.BackColor = Color.Gainsboro;
            TXBsub.Location = new Point(61, 71);
            TXBsub.Margin = new Padding(3, 4, 3, 4);
            TXBsub.Name = "TXBsub";
            TXBsub.Size = new Size(114, 27);
            TXBsub.TabIndex = 49;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(507, 47);
            label13.Name = "label13";
            label13.Size = new Size(124, 20);
            label13.TabIndex = 4;
            label13.Text = "Dinero ingresado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 32);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 48;
            label5.Text = "Sub total product";
            // 
            // TXBtipopago
            // 
            TXBtipopago.Location = new Point(650, 166);
            TXBtipopago.Name = "TXBtipopago";
            TXBtipopago.Size = new Size(125, 27);
            TXBtipopago.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(533, 173);
            label12.Name = "label12";
            label12.Size = new Size(99, 20);
            label12.TabIndex = 2;
            label12.Text = "Tipo de pago";
            // 
            // TXBimpuesto
            // 
            TXBimpuesto.BackColor = Color.Gainsboro;
            TXBimpuesto.Location = new Point(53, 184);
            TXBimpuesto.Name = "TXBimpuesto";
            TXBimpuesto.Size = new Size(125, 27);
            TXBimpuesto.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(546, 111);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 1;
            label11.Text = "Vuelto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 148);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 45;
            label8.Text = "Impuesto";
            // 
            // TXBvuelt
            // 
            TXBvuelt.Location = new Point(650, 103);
            TXBvuelt.Name = "TXBvuelt";
            TXBvuelt.Size = new Size(125, 27);
            TXBvuelt.TabIndex = 0;
            // 
            // TXBsubfact
            // 
            TXBsubfact.BackColor = Color.Gainsboro;
            TXBsubfact.Location = new Point(262, 71);
            TXBsubfact.Margin = new Padding(3, 4, 3, 4);
            TXBsubfact.Name = "TXBsubfact";
            TXBsubfact.Size = new Size(114, 27);
            TXBsubfact.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 32);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 38;
            label6.Text = "Sub total factura";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 148);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 39;
            label7.Text = "Total factura";
            // 
            // TXBfact
            // 
            TXBfact.BackColor = Color.Gainsboro;
            TXBfact.Location = new Point(262, 184);
            TXBfact.Margin = new Padding(3, 4, 3, 4);
            TXBfact.Name = "TXBfact";
            TXBfact.Size = new Size(114, 27);
            TXBfact.TabIndex = 41;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(CHKdesc);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(TXBdola);
            groupBox1.Controls.Add(TXBcord);
            groupBox1.Controls.Add(CMBtipo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(BTNpagar);
            groupBox1.Controls.Add(treeView1);
            groupBox1.Location = new Point(716, 14);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(397, 388);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pago";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGray;
            groupBox3.Controls.Add(LBLning);
            groupBox3.Location = new Point(218, 311);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(154, 68);
            groupBox3.TabIndex = 37;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pago";
            // 
            // LBLning
            // 
            LBLning.AutoSize = true;
            LBLning.Location = new Point(47, 29);
            LBLning.Name = "LBLning";
            LBLning.Size = new Size(77, 20);
            LBLning.TabIndex = 0;
            LBLning.Text = "NINGUNO";
            // 
            // CHKdesc
            // 
            CHKdesc.AutoSize = true;
            CHKdesc.BackColor = SystemColors.Control;
            CHKdesc.Location = new Point(243, 281);
            CHKdesc.Name = "CHKdesc";
            CHKdesc.Size = new Size(101, 24);
            CHKdesc.TabIndex = 36;
            CHKdesc.Text = "Descuento";
            CHKdesc.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(67, 331);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 35;
            button1.Text = "Limpiar Datos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TXBdola
            // 
            TXBdola.BackColor = Color.Silver;
            TXBdola.Location = new Point(230, 213);
            TXBdola.Name = "TXBdola";
            TXBdola.Size = new Size(125, 27);
            TXBdola.TabIndex = 34;
            TXBdola.KeyPress += TXBdola_KeyPress;
            // 
            // TXBcord
            // 
            TXBcord.BackColor = Color.Silver;
            TXBcord.Location = new Point(230, 96);
            TXBcord.Name = "TXBcord";
            TXBcord.Size = new Size(125, 27);
            TXBcord.TabIndex = 33;
            TXBcord.KeyPress += TXBcord_KeyPress;
            // 
            // CMBtipo
            // 
            CMBtipo.DropDownStyle = ComboBoxStyle.DropDownList;
            CMBtipo.FormattingEnabled = true;
            CMBtipo.Items.AddRange(new object[] { "Cordoba", "Dolares", "Mixto" });
            CMBtipo.Location = new Point(53, 212);
            CMBtipo.Margin = new Padding(3, 4, 3, 4);
            CMBtipo.Name = "CMBtipo";
            CMBtipo.Size = new Size(138, 28);
            CMBtipo.TabIndex = 28;
            CMBtipo.SelectedIndexChanged += CMBtipo_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(256, 157);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 31;
            label10.Text = "Dolares";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(256, 40);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 30;
            label9.Text = "Cordoba";
            // 
            // BTNpagar
            // 
            BTNpagar.Location = new Point(81, 277);
            BTNpagar.Margin = new Padding(3, 4, 3, 4);
            BTNpagar.Name = "BTNpagar";
            BTNpagar.Size = new Size(86, 31);
            BTNpagar.TabIndex = 32;
            BTNpagar.Text = "Pagar";
            BTNpagar.UseVisualStyleBackColor = true;
            BTNpagar.Click += BTNpagar_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(30, 35);
            treeView1.Margin = new Padding(3, 4, 3, 4);
            treeView1.Name = "treeView1";
            treeNode4.Name = "Nodo1";
            treeNode4.Text = "Efectivo";
            treeNode5.Name = "Nodo2";
            treeNode5.Text = "Credito";
            treeNode6.Name = "Nodo0";
            treeNode6.Text = "Tipos de pago";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode6 });
            treeView1.Size = new Size(181, 149);
            treeView1.TabIndex = 25;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // MSKcant
            // 
            MSKcant.Location = new Point(425, 51);
            MSKcant.Mask = "99999";
            MSKcant.Name = "MSKcant";
            MSKcant.Size = new Size(125, 27);
            MSKcant.TabIndex = 44;
            MSKcant.ValidatingType = typeof(int);
            // 
            // MSKcodigo
            // 
            MSKcodigo.Location = new Point(125, 55);
            MSKcodigo.Mask = "99999";
            MSKcodigo.Name = "MSKcodigo";
            MSKcodigo.Size = new Size(125, 27);
            MSKcodigo.TabIndex = 42;
            MSKcodigo.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 58);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 37;
            label4.Text = "Cantidad";
            // 
            // LBLconta
            // 
            LBLconta.AutoSize = true;
            LBLconta.Location = new Point(696, 178);
            LBLconta.Name = "LBLconta";
            LBLconta.Size = new Size(0, 20);
            LBLconta.TabIndex = 36;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4 });
            dataGridView1.Location = new Point(12, 202);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(698, 200);
            dataGridView1.TabIndex = 35;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cdigo producto";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre producto";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio producto";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cantidad";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Subtotal producto";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // TXBnomb
            // 
            TXBnomb.Location = new Point(125, 133);
            TXBnomb.Margin = new Padding(3, 4, 3, 4);
            TXBnomb.Name = "TXBnomb";
            TXBnomb.Size = new Size(125, 27);
            TXBnomb.TabIndex = 34;
            TXBnomb.KeyPress += TXBnomb_KeyPress;
            // 
            // BTNborrar
            // 
            BTNborrar.Location = new Point(582, 123);
            BTNborrar.Margin = new Padding(3, 4, 3, 4);
            BTNborrar.Name = "BTNborrar";
            BTNborrar.Size = new Size(86, 31);
            BTNborrar.TabIndex = 33;
            BTNborrar.Text = "Borrar";
            BTNborrar.UseVisualStyleBackColor = true;
            BTNborrar.Click += BTNborrar_Click;
            // 
            // TXBadi
            // 
            TXBadi.Location = new Point(582, 51);
            TXBadi.Margin = new Padding(3, 4, 3, 4);
            TXBadi.Name = "TXBadi";
            TXBadi.Size = new Size(86, 31);
            TXBadi.TabIndex = 32;
            TXBadi.Text = "Adicionar";
            TXBadi.UseVisualStyleBackColor = true;
            TXBadi.Click += TXBadi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 130);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 31;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 145);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 30;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 55);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 29;
            label1.Text = "Codigo";
            // 
            // TXBprecio
            // 
            TXBprecio.Location = new Point(425, 123);
            TXBprecio.Name = "TXBprecio";
            TXBprecio.Size = new Size(125, 27);
            TXBprecio.TabIndex = 51;
            TXBprecio.KeyPress += TXBprecio_KeyPress;
            // 
            // TXBttdesc
            // 
            TXBttdesc.Location = new Point(934, 104);
            TXBttdesc.Name = "TXBttdesc";
            TXBttdesc.Size = new Size(125, 27);
            TXBttdesc.TabIndex = 53;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(786, 110);
            label15.Name = "label15";
            label15.Size = new Size(142, 20);
            label15.TabIndex = 54;
            label15.Text = "Total con descuento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 655);
            Controls.Add(TXBprecio);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(MSKcant);
            Controls.Add(MSKcodigo);
            Controls.Add(label4);
            Controls.Add(LBLconta);
            Controls.Add(dataGridView1);
            Controls.Add(TXBnomb);
            Controls.Add(BTNborrar);
            Controls.Add(TXBadi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SuperCompr";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox TXBdinero;
        private Label label13;
        private TextBox TXBtipopago;
        private Label label12;
        private Label label11;
        private TextBox TXBvuelt;
        private TextBox TXBsub;
        private Label label5;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox TXBdola;
        private TextBox TXBcord;
        private ComboBox CMBtipo;
        private Button BTNpagar;
        private Label label10;
        private Label label9;
        private TreeView treeView1;
        private TextBox TXBimpuesto;
        private Label label8;
        private MaskedTextBox MSKcant;
        private MaskedTextBox MSKcodigo;
        private TextBox TXBfact;
        private TextBox TXBsubfact;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label LBLconta;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private TextBox TXBnomb;
        private Button BTNborrar;
        private Button TXBadi;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox CHKdesc;
        private Button BTNbase;
        private TextBox TXBdesc;
        private Label label14;
        private GroupBox groupBox3;
        private Label LBLning;
        private TextBox TXBprecio;
        private Label label15;
        private TextBox TXBttdesc;
    }
}
