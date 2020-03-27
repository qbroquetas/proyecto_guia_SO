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
            this.SendButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CelsiusTextBox = new System.Windows.Forms.TextBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.ToCelsiusRadio = new System.Windows.Forms.RadioButton();
            this.ToFahrenheitRadio = new System.Windows.Forms.RadioButton();
            this.FahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperature Converter";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(155, 234);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(100, 28);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Convert";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FahrenheitTextBox);
            this.groupBox1.Controls.Add(this.CelsiusTextBox);
            this.groupBox1.Controls.Add(this.DisconnectButton);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.ToCelsiusRadio);
            this.groupBox1.Controls.Add(this.ToFahrenheitRadio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SendButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 347);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // CelsiusTextBox
            // 
            this.CelsiusTextBox.Location = new System.Drawing.Point(261, 144);
            this.CelsiusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CelsiusTextBox.Name = "CelsiusTextBox";
            this.CelsiusTextBox.Size = new System.Drawing.Size(106, 22);
            this.CelsiusTextBox.TabIndex = 11;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(221, 301);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(110, 23);
            this.DisconnectButton.TabIndex = 10;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(66, 301);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(96, 23);
            this.connectButton.TabIndex = 9;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ToCelsiusRadio
            // 
            this.ToCelsiusRadio.AutoSize = true;
            this.ToCelsiusRadio.Location = new System.Drawing.Point(45, 173);
            this.ToCelsiusRadio.Margin = new System.Windows.Forms.Padding(4);
            this.ToCelsiusRadio.Name = "ToCelsiusRadio";
            this.ToCelsiusRadio.Size = new System.Drawing.Size(162, 21);
            this.ToCelsiusRadio.TabIndex = 7;
            this.ToCelsiusRadio.TabStop = true;
            this.ToCelsiusRadio.Text = "Fahrenheit to Celsius";
            this.ToCelsiusRadio.UseVisualStyleBackColor = true;
            // 
            // ToFahrenheitRadio
            // 
            this.ToFahrenheitRadio.AutoSize = true;
            this.ToFahrenheitRadio.Location = new System.Drawing.Point(45, 145);
            this.ToFahrenheitRadio.Margin = new System.Windows.Forms.Padding(4);
            this.ToFahrenheitRadio.Name = "ToFahrenheitRadio";
            this.ToFahrenheitRadio.Size = new System.Drawing.Size(162, 21);
            this.ToFahrenheitRadio.TabIndex = 8;
            this.ToFahrenheitRadio.TabStop = true;
            this.ToFahrenheitRadio.Text = "Celsius to Fahrenheit";
            this.ToFahrenheitRadio.UseVisualStyleBackColor = true;
            // 
            // FahrenheitTextBox
            // 
            this.FahrenheitTextBox.Location = new System.Drawing.Point(261, 174);
            this.FahrenheitTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FahrenheitTextBox.Name = "FahrenheitTextBox";
            this.FahrenheitTextBox.Size = new System.Drawing.Size(106, 22);
            this.FahrenheitTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ºC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "ºF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 692);
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
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ToCelsiusRadio;
        private System.Windows.Forms.RadioButton ToFahrenheitRadio;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.TextBox CelsiusTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FahrenheitTextBox;
    }
}

