
namespace OpenAIDemo
{
    partial class frmOpenAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpenAI));
            this.btnQuestion = new System.Windows.Forms.Button();
            this.textQuestion = new System.Windows.Forms.TextBox();
            this.textResponse = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChatGPT = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btnClearSettings = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textEndpoint2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textModelName2 = new System.Windows.Forms.TextBox();
            this.textCredentialKey2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textEndpoint1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textModelName1 = new System.Windows.Forms.TextBox();
            this.textCredentialKey1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.listLog = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabChatGPT.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(672, 25);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(86, 41);
            this.btnQuestion.TabIndex = 1;
            this.btnQuestion.Text = "Ask Question";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // textQuestion
            // 
            this.textQuestion.Location = new System.Drawing.Point(16, 25);
            this.textQuestion.Multiline = true;
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.Size = new System.Drawing.Size(638, 88);
            this.textQuestion.TabIndex = 0;
            // 
            // textResponse
            // 
            this.textResponse.Location = new System.Drawing.Point(16, 133);
            this.textResponse.Multiline = true;
            this.textResponse.Name = "textResponse";
            this.textResponse.Size = new System.Drawing.Size(638, 253);
            this.textResponse.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(672, 72);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 41);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChatGPT);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 428);
            this.tabControl1.TabIndex = 4;
            // 
            // tabChatGPT
            // 
            this.tabChatGPT.Controls.Add(this.textQuestion);
            this.tabChatGPT.Controls.Add(this.btnClear);
            this.tabChatGPT.Controls.Add(this.btnQuestion);
            this.tabChatGPT.Controls.Add(this.textResponse);
            this.tabChatGPT.Location = new System.Drawing.Point(4, 22);
            this.tabChatGPT.Name = "tabChatGPT";
            this.tabChatGPT.Padding = new System.Windows.Forms.Padding(3);
            this.tabChatGPT.Size = new System.Drawing.Size(772, 402);
            this.tabChatGPT.TabIndex = 0;
            this.tabChatGPT.Text = "ChatGPT";
            this.tabChatGPT.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.btnClearSettings);
            this.tabSettings.Controls.Add(this.btnRotate);
            this.tabSettings.Controls.Add(this.groupBox2);
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(772, 402);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // btnClearSettings
            // 
            this.btnClearSettings.Location = new System.Drawing.Point(673, 68);
            this.btnClearSettings.Name = "btnClearSettings";
            this.btnClearSettings.Size = new System.Drawing.Size(86, 41);
            this.btnClearSettings.TabIndex = 9;
            this.btnClearSettings.Text = "&Clear";
            this.btnClearSettings.UseVisualStyleBackColor = true;
            this.btnClearSettings.Click += new System.EventHandler(this.btnClearSettings_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(673, 21);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(86, 41);
            this.btnRotate.TabIndex = 8;
            this.btnRotate.Text = "&Rotate Order";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textEndpoint2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textModelName2);
            this.groupBox2.Controls.Add(this.textCredentialKey2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 177);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DR Site";
            // 
            // textEndpoint2
            // 
            this.textEndpoint2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEndpoint2.Location = new System.Drawing.Point(171, 39);
            this.textEndpoint2.Name = "textEndpoint2";
            this.textEndpoint2.Size = new System.Drawing.Size(458, 20);
            this.textEndpoint2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Azure OpenAI Model Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Azure OpenAI Endpoint";
            // 
            // textModelName2
            // 
            this.textModelName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textModelName2.Location = new System.Drawing.Point(171, 129);
            this.textModelName2.Name = "textModelName2";
            this.textModelName2.Size = new System.Drawing.Size(458, 20);
            this.textModelName2.TabIndex = 4;
            // 
            // textCredentialKey2
            // 
            this.textCredentialKey2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCredentialKey2.Location = new System.Drawing.Point(171, 84);
            this.textCredentialKey2.Name = "textCredentialKey2";
            this.textCredentialKey2.Size = new System.Drawing.Size(458, 20);
            this.textCredentialKey2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Azure OpenAI Credential Key:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textEndpoint1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textModelName1);
            this.groupBox1.Controls.Add(this.textCredentialKey1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Site";
            // 
            // textEndpoint1
            // 
            this.textEndpoint1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEndpoint1.Location = new System.Drawing.Point(171, 33);
            this.textEndpoint1.Name = "textEndpoint1";
            this.textEndpoint1.Size = new System.Drawing.Size(458, 20);
            this.textEndpoint1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Azure OpenAI Model Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Azure OpenAI Endpoint";
            // 
            // textModelName1
            // 
            this.textModelName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textModelName1.Location = new System.Drawing.Point(171, 123);
            this.textModelName1.Name = "textModelName1";
            this.textModelName1.Size = new System.Drawing.Size(458, 20);
            this.textModelName1.TabIndex = 4;
            // 
            // textCredentialKey1
            // 
            this.textCredentialKey1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCredentialKey1.Location = new System.Drawing.Point(171, 78);
            this.textCredentialKey1.Name = "textCredentialKey1";
            this.textCredentialKey1.Size = new System.Drawing.Size(458, 20);
            this.textCredentialKey1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Azure OpenAI Credential Key:";
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.listLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(772, 402);
            this.tabLog.TabIndex = 2;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // listLog
            // 
            this.listLog.FormattingEnabled = true;
            this.listLog.Location = new System.Drawing.Point(13, 18);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(743, 368);
            this.listLog.TabIndex = 0;
            // 
            // frmOpenAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 451);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOpenAI";
            this.Text = "OpenAI Demo - Guillermo Musumeci";
            this.Load += new System.EventHandler(this.frmOpenAI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabChatGPT.ResumeLayout(false);
            this.tabChatGPT.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.TextBox textQuestion;
        private System.Windows.Forms.TextBox textResponse;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChatGPT;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TextBox textEndpoint1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCredentialKey1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textModelName1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textEndpoint2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textModelName2;
        private System.Windows.Forms.TextBox textCredentialKey2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Button btnClearSettings;
        private System.Windows.Forms.Button btnRotate;
    }
}

