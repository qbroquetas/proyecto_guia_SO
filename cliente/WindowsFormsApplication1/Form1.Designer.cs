namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PalindromoRadioButton = new System.Windows.Forms.RadioButton();
            this.AlturaRadioButton = new System.Windows.Forms.RadioButton();
            this.AlturaTextBox = new System.Windows.Forms.TextBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.PeticionesBtn = new System.Windows.Forms.Button();
            this.ContLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(155, 38);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 22);
            this.nombre.TabIndex = 3;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(155, 221);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(100, 28);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Enviar";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.PalindromoRadioButton);
            this.groupBox1.Controls.Add(this.AlturaRadioButton);
            this.groupBox1.Controls.Add(this.AlturaTextBox);
            this.groupBox1.Controls.Add(this.DisconnectButton);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SendButton);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(16, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 347);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // PalindromoRadioButton
            // 
            this.PalindromoRadioButton.AutoSize = true;
            this.PalindromoRadioButton.Location = new System.Drawing.Point(155, 170);
            this.PalindromoRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.PalindromoRadioButton.Name = "PalindromoRadioButton";
            this.PalindromoRadioButton.Size = new System.Drawing.Size(238, 21);
            this.PalindromoRadioButton.TabIndex = 13;
            this.PalindromoRadioButton.TabStop = true;
            this.PalindromoRadioButton.Text = "Dime si mi nombre es palíndromo";
            this.PalindromoRadioButton.UseVisualStyleBackColor = true;
            // 
            // AlturaRadioButton
            // 
            this.AlturaRadioButton.AutoSize = true;
            this.AlturaRadioButton.Location = new System.Drawing.Point(155, 141);
            this.AlturaRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.AlturaRadioButton.Name = "AlturaRadioButton";
            this.AlturaRadioButton.Size = new System.Drawing.Size(128, 21);
            this.AlturaRadioButton.TabIndex = 12;
            this.AlturaRadioButton.TabStop = true;
            this.AlturaRadioButton.Text = "Dime si soy alto";
            this.AlturaRadioButton.UseVisualStyleBackColor = true;
            // 
            // AlturaTextBox
            // 
            this.AlturaTextBox.Location = new System.Drawing.Point(35, 141);
            this.AlturaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlturaTextBox.Name = "AlturaTextBox";
            this.AlturaTextBox.Size = new System.Drawing.Size(106, 22);
            this.AlturaTextBox.TabIndex = 11;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(221, 301);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(110, 23);
            this.DisconnectButton.TabIndex = 10;
            this.DisconnectButton.Text = "Desconectar";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(66, 301);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(96, 23);
            this.connectButton.TabIndex = 9;
            this.connectButton.Text = "Conectar";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(155, 112);
            this.Longitud.Margin = new System.Windows.Forms.Padding(4);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(220, 21);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(155, 84);
            this.Bonito.Margin = new System.Windows.Forms.Padding(4);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(207, 21);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // PeticionesBtn
            // 
            this.PeticionesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeticionesBtn.Location = new System.Drawing.Point(574, 245);
            this.PeticionesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PeticionesBtn.Name = "PeticionesBtn";
            this.PeticionesBtn.Size = new System.Drawing.Size(217, 57);
            this.PeticionesBtn.TabIndex = 14;
            this.PeticionesBtn.Text = "¿Cuántas Peticiones?";
            this.PeticionesBtn.UseVisualStyleBackColor = true;
            this.PeticionesBtn.Click += new System.EventHandler(this.PeticionesBtn_Click);
            // 
            // ContLbl
            // 
            this.ContLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContLbl.Location = new System.Drawing.Point(574, 324);
            this.ContLbl.Name = "ContLbl";
            this.ContLbl.Size = new System.Drawing.Size(70, 65);
            this.ContLbl.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 692);
            this.Controls.Add(this.ContLbl);
            this.Controls.Add(this.PeticionesBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.RadioButton AlturaRadioButton;
        private System.Windows.Forms.TextBox AlturaTextBox;
        private System.Windows.Forms.RadioButton PalindromoRadioButton;
        private System.Windows.Forms.Button PeticionesBtn;
        private System.Windows.Forms.Label ContLbl;
    }
}

