namespace AptWinForm
{
    partial class Form12
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EntrAPT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label2 = new System.Windows.Forms.Label();
            this.NameAPT = new System.Windows.Forms.TextBox();
            this.Server = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EntrAPT
            // 
            this.EntrAPT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.EntrAPT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.EntrAPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.EntrAPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntrAPT.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntrAPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EntrAPT.Location = new System.Drawing.Point(38, 25);
            this.EntrAPT.Name = "EntrAPT";
            this.EntrAPT.Size = new System.Drawing.Size(169, 30);
            this.EntrAPT.TabIndex = 0;
            this.EntrAPT.Text = "EntrAPT";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(38, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(35, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cash register computer";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(35, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "info";
            // 
            // NameAPT
            // 
            this.NameAPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NameAPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameAPT.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameAPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NameAPT.Location = new System.Drawing.Point(38, 202);
            this.NameAPT.Name = "NameAPT";
            this.NameAPT.Size = new System.Drawing.Size(169, 30);
            this.NameAPT.TabIndex = 4;
            this.NameAPT.Text = "NemeAPT";
            // 
            // Server
            // 
            this.Server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Server.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Server.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Server.Location = new System.Drawing.Point(38, 262);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(169, 30);
            this.Server.TabIndex = 5;
            this.Server.Text = "Server";
            // 
            // IP
            // 
            this.IP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IP.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IP.Location = new System.Drawing.Point(38, 320);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(169, 30);
            this.IP.TabIndex = 6;
            this.IP.Text = "IP";
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add.Location = new System.Drawing.Point(38, 385);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(169, 37);
            this.add.TabIndex = 7;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Black;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reset.Image = global::AptWinForm.Properties.Resources.pngwing_com__1_;
            this.reset.Location = new System.Drawing.Point(231, 18);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(44, 43);
            this.reset.TabIndex = 9;
            this.reset.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(131, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "DSir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(849, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.add);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.NameAPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EntrAPT);
            this.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Name = "Form12";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.Windows.Forms.TextBox EntrAPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.TextBox NameAPT;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button button2;
    }
}

