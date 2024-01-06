namespace Electronics_store
{
    partial class Components
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Components));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboResistors = new System.Windows.Forms.ComboBox();
            this.resistorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asmDataSet = new Electronics_store.asmDataSet();
            this.resistorsTableAdapter = new Electronics_store.asmDataSetTableAdapters.ResistorsTableAdapter();
            this.comboTransistors = new System.Windows.Forms.ComboBox();
            this.transistorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asmDataSet1 = new Electronics_store.asmDataSet1();
            this.transistorsTableAdapter = new Electronics_store.asmDataSet1TableAdapters.TransistorsTableAdapter();
            this.numQuantityRes = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.numQuantityTrans = new System.Windows.Forms.NumericUpDown();
            this.iCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asmDataSet2 = new Electronics_store.asmDataSet2();
            this.iCTableAdapter = new Electronics_store.asmDataSet2TableAdapters.ICTableAdapter();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transistorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asmDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(790, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(252, 113);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(790, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // comboResistors
            // 
            this.comboResistors.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::Electronics_store.Properties.Settings.Default, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboResistors.DisplayMember = "Name";
            this.comboResistors.FormattingEnabled = true;
            this.comboResistors.Location = new System.Drawing.Point(83, 67);
            this.comboResistors.Name = global::Electronics_store.Properties.Settings.Default.Name;
            this.comboResistors.Size = new System.Drawing.Size(169, 24);
            this.comboResistors.TabIndex = 3;
            this.comboResistors.ValueMember = "Id";
            // 
            // resistorsBindingSource
            // 
            this.resistorsBindingSource.DataMember = "Resistors";
            this.resistorsBindingSource.DataSource = this.asmDataSet;
            // 
            // asmDataSet
            // 
            this.asmDataSet.DataSetName = "asmDataSet";
            this.asmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resistorsTableAdapter
            // 
            this.resistorsTableAdapter.ClearBeforeFill = true;
            // 
            // comboTransistors
            // 
            this.comboTransistors.DisplayMember = "Name";
            this.comboTransistors.FormattingEnabled = true;
            this.comboTransistors.Location = new System.Drawing.Point(83, 328);
            this.comboTransistors.Name = "comboTransistors";
            this.comboTransistors.Size = new System.Drawing.Size(169, 24);
            this.comboTransistors.TabIndex = 4;
            // 
            // transistorsBindingSource
            // 
            this.transistorsBindingSource.DataMember = "Transistors";
            this.transistorsBindingSource.DataSource = this.asmDataSet1;
            // 
            // asmDataSet1
            // 
            this.asmDataSet1.DataSetName = "asmDataSet1";
            this.asmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transistorsTableAdapter
            // 
            this.transistorsTableAdapter.ClearBeforeFill = true;
            // 
            // numQuantityRes
            // 
            this.numQuantityRes.Location = new System.Drawing.Point(299, 69);
            this.numQuantityRes.Name = "numQuantityRes";
            this.numQuantityRes.Size = new System.Drawing.Size(120, 22);
            this.numQuantityRes.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numQuantityTrans
            // 
            this.numQuantityTrans.Location = new System.Drawing.Point(299, 328);
            this.numQuantityTrans.Name = "numQuantityTrans";
            this.numQuantityTrans.Size = new System.Drawing.Size(120, 22);
            this.numQuantityTrans.TabIndex = 7;
            // 
            // iCBindingSource
            // 
            this.iCBindingSource.DataMember = "IC";
            this.iCBindingSource.DataSource = this.asmDataSet2;
            // 
            // asmDataSet2
            // 
            this.asmDataSet2.DataSetName = "asmDataSet2";
            this.asmDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iCTableAdapter
            // 
            this.iCTableAdapter.ClearBeforeFill = true;
            // 
            // Components
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 619);
            this.Controls.Add(this.numQuantityTrans);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numQuantityRes);
            this.Controls.Add(this.comboTransistors);
            this.Controls.Add(this.comboResistors);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(pictureBox1);
            this.Name = "Components";
            this.Text = "Components";
            this.Load += new System.EventHandler(this.Components_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transistorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asmDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboResistors;
        private asmDataSet asmDataSet;
        private System.Windows.Forms.BindingSource resistorsBindingSource;
        private asmDataSetTableAdapters.ResistorsTableAdapter resistorsTableAdapter;
        private System.Windows.Forms.ComboBox comboTransistors;
        private asmDataSet1 asmDataSet1;
        private System.Windows.Forms.BindingSource transistorsBindingSource;
        private asmDataSet1TableAdapters.TransistorsTableAdapter transistorsTableAdapter;
        private System.Windows.Forms.NumericUpDown numQuantityRes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numQuantityTrans;
        private asmDataSet2 asmDataSet2;
        private System.Windows.Forms.BindingSource iCBindingSource;
        private asmDataSet2TableAdapters.ICTableAdapter iCTableAdapter;
    }
}