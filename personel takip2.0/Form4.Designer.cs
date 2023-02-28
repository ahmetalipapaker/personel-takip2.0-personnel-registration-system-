namespace personel_takip2._0
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textbox33 = new System.Windows.Forms.TextBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.sqlpersoneltakipDataSet9 = new personel_takip2._0.sqlpersoneltakipDataSet9();
            this.sqlpersoneltakipDataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlpersoneltakipDataSet9BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sqlpersoneltakipDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlpersoneltakipDataSet9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlpersoneltakipDataSet9BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(26, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textbox33
            // 
            this.textbox33.Location = new System.Drawing.Point(187, 126);
            this.textbox33.Name = "textbox33";
            this.textbox33.Size = new System.Drawing.Size(213, 22);
            this.textbox33.TabIndex = 5;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ForeColor = System.Drawing.Color.Green;
            this.btnguncelle.Location = new System.Drawing.Point(135, 190);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(136, 45);
            this.btnguncelle.TabIndex = 8;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // sqlpersoneltakipDataSet9
            // 
            this.sqlpersoneltakipDataSet9.DataSetName = "sqlpersoneltakipDataSet9";
            this.sqlpersoneltakipDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlpersoneltakipDataSet9BindingSource
            // 
            this.sqlpersoneltakipDataSet9BindingSource.DataSource = this.sqlpersoneltakipDataSet9;
            this.sqlpersoneltakipDataSet9BindingSource.Position = 0;
            // 
            // sqlpersoneltakipDataSet9BindingSource1
            // 
            this.sqlpersoneltakipDataSet9BindingSource1.DataSource = this.sqlpersoneltakipDataSet9;
            this.sqlpersoneltakipDataSet9BindingSource1.Position = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 41);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.textbox33);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.sqlpersoneltakipDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlpersoneltakipDataSet9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlpersoneltakipDataSet9BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textbox33;
        private System.Windows.Forms.Button btnguncelle;
        private sqlpersoneltakipDataSet9 sqlpersoneltakipDataSet9;
        private System.Windows.Forms.BindingSource sqlpersoneltakipDataSet9BindingSource;
        private System.Windows.Forms.BindingSource sqlpersoneltakipDataSet9BindingSource1;
        private System.Windows.Forms.Button button1;
    }
}