namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_num7 = new System.Windows.Forms.Button();
            this.btn_num5 = new System.Windows.Forms.Button();
            this.btn_num8 = new System.Windows.Forms.Button();
            this.btn_pm = new System.Windows.Forms.Button();
            this.btn_num1 = new System.Windows.Forms.Button();
            this.btn_num4 = new System.Windows.Forms.Button();
            this.btn_num9 = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_num6 = new System.Windows.Forms.Button();
            this.btn_num3 = new System.Windows.Forms.Button();
            this.btn_num0 = new System.Windows.Forms.Button();
            this.btn_num2 = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_minor = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.lbl_text = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_num7
            // 
            this.btn_num7.Location = new System.Drawing.Point(4, 160);
            this.btn_num7.Name = "btn_num7";
            this.btn_num7.Size = new System.Drawing.Size(72, 54);
            this.btn_num7.TabIndex = 0;
            this.btn_num7.TabStop = false;
            this.btn_num7.Text = "7";
            this.btn_num7.UseVisualStyleBackColor = true;
            this.btn_num7.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num5
            // 
            this.btn_num5.Location = new System.Drawing.Point(82, 220);
            this.btn_num5.Name = "btn_num5";
            this.btn_num5.Size = new System.Drawing.Size(72, 54);
            this.btn_num5.TabIndex = 1;
            this.btn_num5.TabStop = false;
            this.btn_num5.Text = "5";
            this.btn_num5.UseVisualStyleBackColor = true;
            this.btn_num5.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num8
            // 
            this.btn_num8.Location = new System.Drawing.Point(82, 160);
            this.btn_num8.Name = "btn_num8";
            this.btn_num8.Size = new System.Drawing.Size(72, 54);
            this.btn_num8.TabIndex = 2;
            this.btn_num8.TabStop = false;
            this.btn_num8.Text = "8";
            this.btn_num8.UseVisualStyleBackColor = true;
            this.btn_num8.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_pm
            // 
            this.btn_pm.Location = new System.Drawing.Point(4, 340);
            this.btn_pm.Name = "btn_pm";
            this.btn_pm.Size = new System.Drawing.Size(72, 54);
            this.btn_pm.TabIndex = 3;
            this.btn_pm.TabStop = false;
            this.btn_pm.Text = "+/-";
            this.btn_pm.UseVisualStyleBackColor = true;
            this.btn_pm.Click += new System.EventHandler(this.btn_pm_Click);
            // 
            // btn_num1
            // 
            this.btn_num1.Location = new System.Drawing.Point(4, 280);
            this.btn_num1.Name = "btn_num1";
            this.btn_num1.Size = new System.Drawing.Size(72, 54);
            this.btn_num1.TabIndex = 4;
            this.btn_num1.TabStop = false;
            this.btn_num1.Text = "1";
            this.btn_num1.UseVisualStyleBackColor = true;
            this.btn_num1.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num4
            // 
            this.btn_num4.Location = new System.Drawing.Point(4, 220);
            this.btn_num4.Name = "btn_num4";
            this.btn_num4.Size = new System.Drawing.Size(72, 54);
            this.btn_num4.TabIndex = 5;
            this.btn_num4.TabStop = false;
            this.btn_num4.Text = "4";
            this.btn_num4.UseVisualStyleBackColor = true;
            this.btn_num4.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num9
            // 
            this.btn_num9.Location = new System.Drawing.Point(160, 160);
            this.btn_num9.Name = "btn_num9";
            this.btn_num9.Size = new System.Drawing.Size(72, 54);
            this.btn_num9.TabIndex = 6;
            this.btn_num9.TabStop = false;
            this.btn_num9.Text = "9";
            this.btn_num9.UseVisualStyleBackColor = true;
            this.btn_num9.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.Location = new System.Drawing.Point(160, 340);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(72, 54);
            this.btn_dot.TabIndex = 7;
            this.btn_dot.TabStop = false;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num6
            // 
            this.btn_num6.Location = new System.Drawing.Point(160, 220);
            this.btn_num6.Name = "btn_num6";
            this.btn_num6.Size = new System.Drawing.Size(72, 54);
            this.btn_num6.TabIndex = 8;
            this.btn_num6.TabStop = false;
            this.btn_num6.Text = "6";
            this.btn_num6.UseVisualStyleBackColor = true;
            this.btn_num6.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num3
            // 
            this.btn_num3.Location = new System.Drawing.Point(160, 280);
            this.btn_num3.Name = "btn_num3";
            this.btn_num3.Size = new System.Drawing.Size(72, 54);
            this.btn_num3.TabIndex = 9;
            this.btn_num3.TabStop = false;
            this.btn_num3.Text = "3";
            this.btn_num3.UseVisualStyleBackColor = true;
            this.btn_num3.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num0
            // 
            this.btn_num0.Location = new System.Drawing.Point(82, 340);
            this.btn_num0.Name = "btn_num0";
            this.btn_num0.Size = new System.Drawing.Size(72, 54);
            this.btn_num0.TabIndex = 10;
            this.btn_num0.TabStop = false;
            this.btn_num0.Text = "0";
            this.btn_num0.UseVisualStyleBackColor = true;
            this.btn_num0.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num2
            // 
            this.btn_num2.Location = new System.Drawing.Point(82, 280);
            this.btn_num2.Name = "btn_num2";
            this.btn_num2.Size = new System.Drawing.Size(72, 54);
            this.btn_num2.TabIndex = 11;
            this.btn_num2.TabStop = false;
            this.btn_num2.Text = "2";
            this.btn_num2.UseVisualStyleBackColor = true;
            this.btn_num2.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(238, 160);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(72, 54);
            this.btn_mul.TabIndex = 12;
            this.btn_mul.TabStop = false;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.NumOperator);
            // 
            // btn_minor
            // 
            this.btn_minor.Location = new System.Drawing.Point(238, 220);
            this.btn_minor.Name = "btn_minor";
            this.btn_minor.Size = new System.Drawing.Size(72, 54);
            this.btn_minor.TabIndex = 13;
            this.btn_minor.TabStop = false;
            this.btn_minor.Text = "-";
            this.btn_minor.UseVisualStyleBackColor = true;
            this.btn_minor.Click += new System.EventHandler(this.NumOperator);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(238, 280);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(72, 54);
            this.btn_add.TabIndex = 14;
            this.btn_add.TabStop = false;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.NumOperator);
            // 
            // btn_total
            // 
            this.btn_total.Location = new System.Drawing.Point(238, 340);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(72, 54);
            this.btn_total.TabIndex = 15;
            this.btn_total.TabStop = false;
            this.btn_total.Text = "=";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(238, 100);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(72, 54);
            this.btn_del.TabIndex = 16;
            this.btn_del.TabStop = false;
            this.btn_del.Text = "del\r\n";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(160, 100);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(72, 54);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.TabStop = false;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.Location = new System.Drawing.Point(82, 100);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(72, 54);
            this.btn_CE.TabIndex = 18;
            this.btn_CE.TabStop = false;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(4, 100);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(72, 54);
            this.btn_div.TabIndex = 19;
            this.btn_div.TabStop = false;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.NumOperator);
            // 
            // lbl_text
            // 
            this.lbl_text.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_text.Location = new System.Drawing.Point(4, 38);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_text.Size = new System.Drawing.Size(306, 45);
            this.lbl_text.TabIndex = 20;
            this.lbl_text.Text = "0";
            this.lbl_text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_state
            // 
            this.lbl_state.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_state.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_state.Location = new System.Drawing.Point(2, 15);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(298, 23);
            this.lbl_state.TabIndex = 21;
            this.lbl_state.Text = "수정";
            this.lbl_state.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_total;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(317, 397);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_minor);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_num2);
            this.Controls.Add(this.btn_num0);
            this.Controls.Add(this.btn_num3);
            this.Controls.Add(this.btn_num6);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_num9);
            this.Controls.Add(this.btn_num4);
            this.Controls.Add(this.btn_num1);
            this.Controls.Add(this.btn_pm);
            this.Controls.Add(this.btn_num8);
            this.Controls.Add(this.btn_num5);
            this.Controls.Add(this.btn_num7);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "계산기";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_num7;
        private System.Windows.Forms.Button btn_num5;
        private System.Windows.Forms.Button btn_num8;
        private System.Windows.Forms.Button btn_pm;
        private System.Windows.Forms.Button btn_num1;
        private System.Windows.Forms.Button btn_num4;
        private System.Windows.Forms.Button btn_num9;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_num6;
        private System.Windows.Forms.Button btn_num3;
        private System.Windows.Forms.Button btn_num0;
        private System.Windows.Forms.Button btn_num2;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_minor;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Label lbl_state;
    }
}

