﻿namespace Memento
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
            this.rText = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.Redo_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rText
            // 
            this.rText.Location = new System.Drawing.Point(57, 39);
            this.rText.Name = "rText";
            this.rText.Size = new System.Drawing.Size(530, 209);
            this.rText.TabIndex = 0;
            this.rText.Text = "";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(57, 279);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(110, 50);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Location = new System.Drawing.Point(198, 279);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(110, 50);
            this.undoBtn.TabIndex = 2;
            this.undoBtn.Text = "&Undo";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // Redo_btn
            // 
            this.Redo_btn.Location = new System.Drawing.Point(335, 279);
            this.Redo_btn.Name = "Redo_btn";
            this.Redo_btn.Size = new System.Drawing.Size(110, 50);
            this.Redo_btn.TabIndex = 3;
            this.Redo_btn.Text = "&Redo";
            this.Redo_btn.UseVisualStyleBackColor = true;
            this.Redo_btn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 361);
            this.Controls.Add(this.Redo_btn);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.rText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rText;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button Redo_btn;
    }
}

