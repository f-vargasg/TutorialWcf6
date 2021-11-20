
namespace TutorialWcf6.WinTestService
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butGetEmployee = new System.Windows.Forms.Button();
            this.butSaveEmployee = new System.Windows.Forms.Button();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmbEmployeeType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnualSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHourlyPay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(225, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(290, 26);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(225, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 26);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date of Birth:";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(225, 76);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(290, 26);
            this.txtGender.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // butGetEmployee
            // 
            this.butGetEmployee.Location = new System.Drawing.Point(127, 287);
            this.butGetEmployee.Name = "butGetEmployee";
            this.butGetEmployee.Size = new System.Drawing.Size(169, 58);
            this.butGetEmployee.TabIndex = 9;
            this.butGetEmployee.Text = "Get Employee";
            this.butGetEmployee.UseVisualStyleBackColor = true;
            this.butGetEmployee.Click += new System.EventHandler(this.butGetEmployee_Click);
            // 
            // butSaveEmployee
            // 
            this.butSaveEmployee.Location = new System.Drawing.Point(336, 287);
            this.butSaveEmployee.Name = "butSaveEmployee";
            this.butSaveEmployee.Size = new System.Drawing.Size(169, 58);
            this.butSaveEmployee.TabIndex = 10;
            this.butSaveEmployee.Text = "Save Employee";
            this.butSaveEmployee.UseVisualStyleBackColor = true;
            this.butSaveEmployee.Click += new System.EventHandler(this.butSaveEmployee_Click);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(225, 104);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(150, 26);
            this.dtpDateOfBirth.TabIndex = 4;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(-1, 342);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 20);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = "label5";
            // 
            // cmbEmployeeType
            // 
            this.cmbEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeType.FormattingEnabled = true;
            this.cmbEmployeeType.Location = new System.Drawing.Point(225, 132);
            this.cmbEmployeeType.Name = "cmbEmployeeType";
            this.cmbEmployeeType.Size = new System.Drawing.Size(290, 28);
            this.cmbEmployeeType.TabIndex = 5;
            this.cmbEmployeeType.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Employee Type:";
            // 
            // txtAnualSalary
            // 
            this.txtAnualSalary.Location = new System.Drawing.Point(225, 162);
            this.txtAnualSalary.Name = "txtAnualSalary";
            this.txtAnualSalary.Size = new System.Drawing.Size(290, 26);
            this.txtAnualSalary.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Annual Salary:";
            // 
            // txtHourlyPay
            // 
            this.txtHourlyPay.Location = new System.Drawing.Point(225, 192);
            this.txtHourlyPay.Name = "txtHourlyPay";
            this.txtHourlyPay.Size = new System.Drawing.Size(290, 26);
            this.txtHourlyPay.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hourly Pay:";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(225, 220);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(290, 26);
            this.txtHoursWorked.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Hours Worked:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 367);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHourlyPay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAnualSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbEmployeeType);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.butSaveEmployee);
            this.Controls.Add(this.butGetEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butGetEmployee;
        private System.Windows.Forms.Button butSaveEmployee;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox cmbEmployeeType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnualSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHourlyPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label label8;
    }
}

