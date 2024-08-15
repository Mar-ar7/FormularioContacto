namespace FormularioContacto
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

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
            labelNombre = new Label();
            labelEmail = new Label();
            labelMensaje = new Label();
            textBoxNombre = new TextBox();
            textBoxEmail = new TextBox();
            textBoxMensaje = new TextBox();
            buttonEnviar = new Button();
            labelEstado = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(53, 20);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(87, 23);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(53, 75);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(219, 23);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Correo Electrónico:";
            // 
            // labelMensaje
            // 
            labelMensaje.AutoSize = true;
            labelMensaje.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMensaje.Location = new Point(53, 134);
            labelMensaje.Name = "labelMensaje";
            labelMensaje.Size = new Size(98, 23);
            labelMensaje.TabIndex = 2;
            labelMensaje.Text = "Mensaje:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(273, 12);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(500, 27);
            textBoxNombre.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(273, 68);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(500, 27);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxMensaje
            // 
            textBoxMensaje.Location = new Point(273, 131);
            textBoxMensaje.Multiline = true;
            textBoxMensaje.Name = "textBoxMensaje";
            textBoxMensaje.Size = new Size(500, 79);
            textBoxMensaje.TabIndex = 5;
            // 
            // buttonEnviar
            // 
            buttonEnviar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEnviar.Location = new Point(40, 291);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(107, 41);
            buttonEnviar.TabIndex = 6;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstado.ForeColor = Color.FromArgb(0, 192, 0);
            labelEstado.Location = new Point(345, 348);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(0, 23);
            labelEstado.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(182, 291);
            button1.Name = "button1";
            button1.Size = new Size(108, 41);
            button1.TabIndex = 8;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelEstado);
            Controls.Add(buttonEnviar);
            Controls.Add(textBoxMensaje);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNombre);
            Controls.Add(labelMensaje);
            Controls.Add(labelEmail);
            Controls.Add(labelNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private Label labelEmail;
        private Label labelMensaje;
        private TextBox textBoxNombre;
        private TextBox textBoxEmail;
        private TextBox textBoxMensaje;
        private Button buttonEnviar;
        private Label labelEstado;
        private Button button1;
    }
}
