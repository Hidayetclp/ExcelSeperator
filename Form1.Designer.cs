namespace Seperator
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
            this.textBox_Browse = new System.Windows.Forms.TextBox();
            this.button_Browse = new System.Windows.Forms.Button();
            this.label_stepWarn = new System.Windows.Forms.Label();
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.panel_Back = new System.Windows.Forms.Panel();
            this.label_Browse_Save = new System.Windows.Forms.Label();
            this.textBox_Browse2 = new System.Windows.Forms.TextBox();
            this.button_Browse2 = new System.Windows.Forms.Button();
            this.textBox_worksheet = new System.Windows.Forms.TextBox();
            this.label_worksheet = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button_start = new System.Windows.Forms.Button();
            this.panel_Back.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Browse
            // 
            this.textBox_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Browse.Location = new System.Drawing.Point(128, 56);
            this.textBox_Browse.Name = "textBox_Browse";
            this.textBox_Browse.Size = new System.Drawing.Size(420, 20);
            this.textBox_Browse.TabIndex = 0;
            this.textBox_Browse.TextChanged += new System.EventHandler(this.texbox_Browse_TextChanged);
            // 
            // button_Browse
            // 
            this.button_Browse.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_Browse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Browse.Location = new System.Drawing.Point(39, 53);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(75, 23);
            this.button_Browse.TabIndex = 1;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = false;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // label_stepWarn
            // 
            this.label_stepWarn.AutoSize = true;
            this.label_stepWarn.BackColor = System.Drawing.Color.Wheat;
            this.label_stepWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stepWarn.Location = new System.Drawing.Point(300, 121);
            this.label_stepWarn.Name = "label_stepWarn";
            this.label_stepWarn.Size = new System.Drawing.Size(248, 17);
            this.label_stepWarn.TabIndex = 2;
            this.label_stepWarn.Text = "Please enter rows number each Excell";
            this.label_stepWarn.Click += new System.EventHandler(this.label_stepWarn_Click);
            // 
            // textBox_step
            // 
            this.textBox_step.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_step.Location = new System.Drawing.Point(554, 120);
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.Size = new System.Drawing.Size(29, 20);
            this.textBox_step.TabIndex = 3;
            this.textBox_step.TextChanged += new System.EventHandler(this.textBox_step_TextChanged);
            // 
            // panel_Back
            // 
            this.panel_Back.BackColor = System.Drawing.Color.Wheat;
            this.panel_Back.Controls.Add(this.label_Browse_Save);
            this.panel_Back.Controls.Add(this.textBox_Browse2);
            this.panel_Back.Controls.Add(this.button_Browse2);
            this.panel_Back.Controls.Add(this.textBox_worksheet);
            this.panel_Back.Controls.Add(this.label_worksheet);
            this.panel_Back.Controls.Add(this.progressBar);
            this.panel_Back.Controls.Add(this.button_start);
            this.panel_Back.Controls.Add(this.textBox_step);
            this.panel_Back.Controls.Add(this.label_stepWarn);
            this.panel_Back.Controls.Add(this.button_Browse);
            this.panel_Back.Controls.Add(this.textBox_Browse);
            this.panel_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Back.Location = new System.Drawing.Point(0, 0);
            this.panel_Back.Name = "panel_Back";
            this.panel_Back.Size = new System.Drawing.Size(596, 376);
            this.panel_Back.TabIndex = 0;
            this.panel_Back.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Back_Paint);
            // 
            // label_Browse_Save
            // 
            this.label_Browse_Save.AutoSize = true;
            this.label_Browse_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Browse_Save.Location = new System.Drawing.Point(195, 172);
            this.label_Browse_Save.Name = "label_Browse_Save";
            this.label_Browse_Save.Size = new System.Drawing.Size(200, 17);
            this.label_Browse_Save.TabIndex = 2;
            this.label_Browse_Save.Text = "Please select folder for Saving";
            this.label_Browse_Save.Click += new System.EventHandler(this.label_Browse_Save_Click);
            // 
            // textBox_Browse2
            // 
            this.textBox_Browse2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Browse2.Location = new System.Drawing.Point(128, 208);
            this.textBox_Browse2.Name = "textBox_Browse2";
            this.textBox_Browse2.Size = new System.Drawing.Size(420, 20);
            this.textBox_Browse2.TabIndex = 11;
            this.textBox_Browse2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_Browse2
            // 
            this.button_Browse2.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_Browse2.Location = new System.Drawing.Point(39, 208);
            this.button_Browse2.Name = "button_Browse2";
            this.button_Browse2.Size = new System.Drawing.Size(75, 23);
            this.button_Browse2.TabIndex = 10;
            this.button_Browse2.Text = "Browse";
            this.button_Browse2.UseVisualStyleBackColor = false;
            this.button_Browse2.Click += new System.EventHandler(this.button_Browse2_Click);
            // 
            // textBox_worksheet
            // 
            this.textBox_worksheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_worksheet.Location = new System.Drawing.Point(249, 120);
            this.textBox_worksheet.Name = "textBox_worksheet";
            this.textBox_worksheet.Size = new System.Drawing.Size(29, 20);
            this.textBox_worksheet.TabIndex = 9;
            this.textBox_worksheet.TextChanged += new System.EventHandler(this.textBox_worksheet_TextChanged);
            // 
            // label_worksheet
            // 
            this.label_worksheet.AutoSize = true;
            this.label_worksheet.BackColor = System.Drawing.Color.Wheat;
            this.label_worksheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_worksheet.Location = new System.Drawing.Point(24, 120);
            this.label_worksheet.Name = "label_worksheet";
            this.label_worksheet.Size = new System.Drawing.Size(219, 17);
            this.label_worksheet.TabIndex = 8;
            this.label_worksheet.Text = "Please enter the worksheet name";
            this.label_worksheet.Click += new System.EventHandler(this.label_worksheet_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar.ForeColor = System.Drawing.Color.OrangeRed;
            this.progressBar.Location = new System.Drawing.Point(128, 287);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(420, 27);
            this.progressBar.TabIndex = 6;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_start.Location = new System.Drawing.Point(39, 287);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 24);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 376);
            this.Controls.Add(this.panel_Back);
            this.Name = "Form1";
            this.Text = "Seperator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Back.ResumeLayout(false);
            this.panel_Back.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Browse;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.Label label_stepWarn;
        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.Panel panel_Back;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textBox_worksheet;
        private System.Windows.Forms.Label label_worksheet;
        private System.Windows.Forms.Label label_Browse_Save;
        private System.Windows.Forms.TextBox textBox_Browse2;
        private System.Windows.Forms.Button button_Browse2;
    }
}

