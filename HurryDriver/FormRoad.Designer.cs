namespace HurryDriver
{
    partial class FormRoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoad));
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreTimer = new System.Windows.Forms.Timer(this.components);
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.againB = new System.Windows.Forms.Button();
            this.menuB = new System.Windows.Forms.Button();
            this.recoveryTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DrawTimer
            // 
            this.DrawTimer.Interval = 1;
            this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
            // 
            // scoreTimer
            // 
            this.scoreTimer.Tick += new System.EventHandler(this.scoreTimer_Tick);
            // 
            // timeTimer
            // 
            this.timeTimer.Interval = 1000;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // againB
            // 
            this.againB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.againB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.againB.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.againB.FlatAppearance.BorderSize = 0;
            this.againB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.againB.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.againB.Location = new System.Drawing.Point(125, 275);
            this.againB.Name = "againB";
            this.againB.Size = new System.Drawing.Size(159, 53);
            this.againB.TabIndex = 1;
            this.againB.Text = "Again";
            this.againB.UseVisualStyleBackColor = false;
            this.againB.Visible = false;
            this.againB.Click += new System.EventHandler(this.againB_Click);
            // 
            // menuB
            // 
            this.menuB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuB.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.menuB.FlatAppearance.BorderSize = 0;
            this.menuB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuB.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuB.Location = new System.Drawing.Point(319, 275);
            this.menuB.Name = "menuB";
            this.menuB.Size = new System.Drawing.Size(159, 53);
            this.menuB.TabIndex = 2;
            this.menuB.Text = "Menu";
            this.menuB.UseVisualStyleBackColor = false;
            this.menuB.Visible = false;
            this.menuB.Click += new System.EventHandler(this.menuB_Click);
            // 
            // recoveryTimer
            // 
            this.recoveryTimer.Interval = 400;
            this.recoveryTimer.Tick += new System.EventHandler(this.recoveryTimer_Tick);
            // 
            // FormRoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.menuB);
            this.Controls.Add(this.againB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRoad";
            this.Text = "Hurry Driver";
            this.Deactivate += new System.EventHandler(this.FormRoad_Deactivate);
            this.Load += new System.EventHandler(this.FormRoad_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRoad_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormRoad_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer DrawTimer;
        private System.Windows.Forms.Timer scoreTimer;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Button againB;
        private System.Windows.Forms.Button menuB;
        private System.Windows.Forms.Timer recoveryTimer;
    }
}