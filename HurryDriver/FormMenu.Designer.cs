namespace HurryDriver
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.newgameB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.timeButton = new System.Windows.Forms.Button();
            this.tillcrashB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newgameB
            // 
            this.newgameB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newgameB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newgameB.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.newgameB.FlatAppearance.BorderSize = 0;
            this.newgameB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newgameB.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgameB.Location = new System.Drawing.Point(220, 75);
            this.newgameB.Name = "newgameB";
            this.newgameB.Size = new System.Drawing.Size(159, 53);
            this.newgameB.TabIndex = 0;
            this.newgameB.Text = "New Game";
            this.newgameB.UseVisualStyleBackColor = false;
            this.newgameB.Click += new System.EventHandler(this.newgameB_Click);
            // 
            // exitB
            // 
            this.exitB.AutoSize = true;
            this.exitB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitB.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.exitB.FlatAppearance.BorderSize = 0;
            this.exitB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitB.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitB.Location = new System.Drawing.Point(220, 349);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(159, 53);
            this.exitB.TabIndex = 1;
            this.exitB.Text = "Exit";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // timeButton
            // 
            this.timeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.timeButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.timeButton.FlatAppearance.BorderSize = 0;
            this.timeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timeButton.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeButton.Location = new System.Drawing.Point(220, 75);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(159, 53);
            this.timeButton.TabIndex = 2;
            this.timeButton.Text = "Time";
            this.timeButton.UseVisualStyleBackColor = false;
            this.timeButton.Click += new System.EventHandler(this.timeButton_Click);
            // 
            // tillcrashB
            // 
            this.tillcrashB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tillcrashB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tillcrashB.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.tillcrashB.FlatAppearance.BorderSize = 0;
            this.tillcrashB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tillcrashB.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tillcrashB.Location = new System.Drawing.Point(220, 147);
            this.tillcrashB.Name = "tillcrashB";
            this.tillcrashB.Size = new System.Drawing.Size(159, 53);
            this.tillcrashB.TabIndex = 3;
            this.tillcrashB.Text = "Till Crash";
            this.tillcrashB.UseVisualStyleBackColor = false;
            this.tillcrashB.Click += new System.EventHandler(this.tillcrashB_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::HurryDriver.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.newgameB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newgameB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Button timeButton;
        private System.Windows.Forms.Button tillcrashB;
    }
}

