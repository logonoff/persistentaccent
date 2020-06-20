using System.ComponentModel;
using System.Windows.Forms;

namespace persistent_accent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.end = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.forceSetAccent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Text = "persistentaccent";
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // end
            // 
            this.end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.end.Location = new System.Drawing.Point(247, 226);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(75, 23);
            this.end.TabIndex = 0;
            this.end.Text = "Exit";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.Location = new System.Drawing.Point(12, 12);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(310, 208);
            this.logBox.TabIndex = 1;
            // 
            // forceSetAccent
            // 
            this.forceSetAccent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.forceSetAccent.Location = new System.Drawing.Point(111, 226);
            this.forceSetAccent.Name = "forceSetAccent";
            this.forceSetAccent.Size = new System.Drawing.Size(130, 23);
            this.forceSetAccent.TabIndex = 0;
            this.forceSetAccent.Text = "Change accent now";
            this.forceSetAccent.UseVisualStyleBackColor = true;
            this.forceSetAccent.Click += new System.EventHandler(this.forceSetAccent_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.forceSetAccent);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.end);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.Text = "PersistentAccent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon trayIcon;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button end;
        private TextBox logBox;
        private Button forceSetAccent;
    }
}

