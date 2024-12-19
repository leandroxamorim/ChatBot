namespace Sistema_Cadastro
{
    partial class FormCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.ComboMaritalS = new System.Windows.Forms.ComboBox();
            this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.checkCNH = new System.Windows.Forms.CheckBox();
            this.checkCAR = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioO = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.lista = new System.Windows.Forms.ListBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Marital Status";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(214, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(538, 29);
            this.txtName.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(214, 84);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(538, 29);
            this.txtDate.TabIndex = 5;
            // 
            // ComboMaritalS
            // 
            this.ComboMaritalS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboMaritalS.FormattingEnabled = true;
            this.ComboMaritalS.Location = new System.Drawing.Point(214, 130);
            this.ComboMaritalS.Name = "ComboMaritalS";
            this.ComboMaritalS.Size = new System.Drawing.Size(338, 32);
            this.ComboMaritalS.TabIndex = 6;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(214, 179);
            this.txtTelephone.Mask = "(00) 00000-0000";
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(338, 29);
            this.txtTelephone.TabIndex = 7;
            // 
            // checkCNH
            // 
            this.checkCNH.AutoSize = true;
            this.checkCNH.Location = new System.Drawing.Point(214, 234);
            this.checkCNH.Name = "checkCNH";
            this.checkCNH.Size = new System.Drawing.Size(92, 17);
            this.checkCNH.TabIndex = 8;
            this.checkCNH.Text = "Possui CNH ?";
            this.checkCNH.UseVisualStyleBackColor = true;
            // 
            // checkCAR
            // 
            this.checkCAR.AutoSize = true;
            this.checkCAR.Location = new System.Drawing.Point(214, 270);
            this.checkCAR.Name = "checkCAR";
            this.checkCAR.Size = new System.Drawing.Size(128, 17);
            this.checkCAR.TabIndex = 9;
            this.checkCAR.Text = "Possui carro próprio ?";
            this.checkCAR.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioF);
            this.groupBox1.Controls.Add(this.radioO);
            this.groupBox1.Controls.Add(this.radioM);
            this.groupBox1.Location = new System.Drawing.Point(214, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 115);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(19, 52);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(67, 17);
            this.radioF.TabIndex = 2;
            this.radioF.TabStop = true;
            this.radioF.Text = "Feminino";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // radioO
            // 
            this.radioO.AutoSize = true;
            this.radioO.Location = new System.Drawing.Point(19, 87);
            this.radioO.Name = "radioO";
            this.radioO.Size = new System.Drawing.Size(51, 17);
            this.radioO.TabIndex = 1;
            this.radioO.TabStop = true;
            this.radioO.Text = "Outro";
            this.radioO.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Checked = true;
            this.radioM.Location = new System.Drawing.Point(19, 19);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(73, 17);
            this.radioM.TabIndex = 0;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(47, 492);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(705, 134);
            this.lista.TabIndex = 11;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(47, 448);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(196, 27);
            this.BtnRegister.TabIndex = 12;
            this.BtnRegister.Text = "Cadastrar / Alterar";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(301, 448);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(196, 27);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Excluir\r\n";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(555, 448);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(196, 27);
            this.BtnClean.TabIndex = 14;
            this.BtnClean.Text = "Limpar";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkCAR);
            this.Controls.Add(this.checkCNH);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.ComboMaritalS);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.ComboBox ComboMaritalS;
        private System.Windows.Forms.MaskedTextBox txtTelephone;
        private System.Windows.Forms.CheckBox checkCNH;
        private System.Windows.Forms.CheckBox checkCAR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioO;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClean;
    }
}

