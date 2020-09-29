namespace Desktopper
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
            this.btn_save_layout = new System.Windows.Forms.Button();
            this.btn_load_layout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_save_layout
            // 
            this.btn_save_layout.Location = new System.Drawing.Point(12, 12);
            this.btn_save_layout.Name = "btn_save_layout";
            this.btn_save_layout.Size = new System.Drawing.Size(100, 50);
            this.btn_save_layout.TabIndex = 0;
            this.btn_save_layout.Text = "Save Layout";
            this.btn_save_layout.UseVisualStyleBackColor = true;
            this.btn_save_layout.Click += new System.EventHandler(this.btn_save_layout_Click);
            // 
            // btn_load_layout
            // 
            this.btn_load_layout.Location = new System.Drawing.Point(127, 12);
            this.btn_load_layout.Name = "btn_load_layout";
            this.btn_load_layout.Size = new System.Drawing.Size(100, 50);
            this.btn_load_layout.TabIndex = 0;
            this.btn_load_layout.Text = "Load Layout";
            this.btn_load_layout.UseVisualStyleBackColor = true;
            this.btn_load_layout.Click += new System.EventHandler(this.btn_load_layout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 75);
            this.Controls.Add(this.btn_load_layout);
            this.Controls.Add(this.btn_save_layout);
            this.Name = "Form1";
            this.Text = "Desktopper!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save_layout;
        private System.Windows.Forms.Button btn_load_layout;
    }
}

