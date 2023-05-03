﻿namespace TextFileToUi
{
    partial class MainForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblBirthCity = new System.Windows.Forms.Label();
            this.lblRoleSpecificAttr = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtBirthYear = new System.Windows.Forms.TextBox();
            this.txtBirthCity = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtRoleSpecificAttr = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFullName.Location = new System.Drawing.Point(44, 38);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(80, 20);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBirthYear.Location = new System.Drawing.Point(44, 97);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(96, 20);
            this.lblBirthYear.TabIndex = 4;
            this.lblBirthYear.Text = "Year or birth";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFaculty.Location = new System.Drawing.Point(44, 214);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(60, 20);
            this.lblFaculty.TabIndex = 8;
            this.lblFaculty.Text = "Faculty";
            // 
            // lblBirthCity
            // 
            this.lblBirthCity.AutoSize = true;
            this.lblBirthCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBirthCity.Location = new System.Drawing.Point(44, 152);
            this.lblBirthCity.Name = "lblBirthCity";
            this.lblBirthCity.Size = new System.Drawing.Size(35, 20);
            this.lblBirthCity.TabIndex = 6;
            this.lblBirthCity.Text = "City";
            // 
            // lblRoleSpecificAttr
            // 
            this.lblRoleSpecificAttr.AutoSize = true;
            this.lblRoleSpecificAttr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRoleSpecificAttr.Location = new System.Drawing.Point(44, 330);
            this.lblRoleSpecificAttr.Name = "lblRoleSpecificAttr";
            this.lblRoleSpecificAttr.Size = new System.Drawing.Size(120, 20);
            this.lblRoleSpecificAttr.TabIndex = 12;
            this.lblRoleSpecificAttr.Text = "role specific attr";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRole.Location = new System.Drawing.Point(44, 271);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 20);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "Role";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFullName.Location = new System.Drawing.Point(200, 35);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(202, 26);
            this.txtFullName.TabIndex = 13;
            // 
            // txtBirthYear
            // 
            this.txtBirthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBirthYear.Location = new System.Drawing.Point(200, 94);
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.Size = new System.Drawing.Size(202, 26);
            this.txtBirthYear.TabIndex = 14;
            // 
            // txtBirthCity
            // 
            this.txtBirthCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBirthCity.Location = new System.Drawing.Point(200, 149);
            this.txtBirthCity.Name = "txtBirthCity";
            this.txtBirthCity.Size = new System.Drawing.Size(202, 26);
            this.txtBirthCity.TabIndex = 15;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFaculty.Location = new System.Drawing.Point(200, 211);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(202, 26);
            this.txtFaculty.TabIndex = 16;
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRole.Location = new System.Drawing.Point(200, 268);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(202, 26);
            this.txtRole.TabIndex = 17;
            // 
            // txtRoleSpecificAttr
            // 
            this.txtRoleSpecificAttr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRoleSpecificAttr.Location = new System.Drawing.Point(200, 324);
            this.txtRoleSpecificAttr.Name = "txtRoleSpecificAttr";
            this.txtRoleSpecificAttr.Size = new System.Drawing.Size(202, 26);
            this.txtRoleSpecificAttr.TabIndex = 18;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpen.Location = new System.Drawing.Point(163, 410);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(139, 35);
            this.btnOpen.TabIndex = 19;
            this.btnOpen.Text = "Open file";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 505);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtRoleSpecificAttr);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.txtBirthCity);
            this.Controls.Add(this.txtBirthYear);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblRoleSpecificAttr);
            this.Controls.Add(this.lblBirthCity);
            this.Controls.Add(this.lblBirthYear);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblRole);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "User data display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblBirthCity;
        private System.Windows.Forms.Label lblRoleSpecificAttr;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtBirthYear;
        private System.Windows.Forms.TextBox txtBirthCity;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtRoleSpecificAttr;
        private System.Windows.Forms.Button btnOpen;
    }
}
