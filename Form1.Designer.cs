
namespace MQTT_Client_CanSat_Competition
{
    partial class Form1
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
            this.publishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // publishButton
            // 
            this.publishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.publishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publishButton.Font = new System.Drawing.Font("Roboto Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishButton.ForeColor = System.Drawing.Color.White;
            this.publishButton.Location = new System.Drawing.Point(224, 71);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(330, 271);
            this.publishButton.TabIndex = 1;
            this.publishButton.Text = "PUBLISH";
            this.publishButton.UseVisualStyleBackColor = false;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.publishButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button publishButton;
    }
}

