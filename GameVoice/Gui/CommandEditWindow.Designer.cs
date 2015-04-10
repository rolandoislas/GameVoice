namespace GameVoice.Gui {
    partial class CommandEditWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.comboBoxMain = new System.Windows.Forms.ComboBox();
            this.textBoxVoiceCommand = new System.Windows.Forms.TextBox();
            this.labelVoiceCommand = new System.Windows.Forms.Label();
            this.labelMacro = new System.Windows.Forms.Label();
            this.textBoxMacro = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddCommand = new System.Windows.Forms.Button();
            this.buttonSaveCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMain
            // 
            this.comboBoxMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMain.FormattingEnabled = true;
            this.comboBoxMain.Location = new System.Drawing.Point(12, 12);
            this.comboBoxMain.Name = "comboBoxMain";
            this.comboBoxMain.Size = new System.Drawing.Size(260, 21);
            this.comboBoxMain.TabIndex = 0;
            this.comboBoxMain.SelectionChangeCommitted += new System.EventHandler(this.itemSelected);
            // 
            // textBoxVoiceCommand
            // 
            this.textBoxVoiceCommand.Location = new System.Drawing.Point(102, 43);
            this.textBoxVoiceCommand.Name = "textBoxVoiceCommand";
            this.textBoxVoiceCommand.Size = new System.Drawing.Size(170, 20);
            this.textBoxVoiceCommand.TabIndex = 1;
            // 
            // labelVoiceCommand
            // 
            this.labelVoiceCommand.AutoSize = true;
            this.labelVoiceCommand.Location = new System.Drawing.Point(12, 46);
            this.labelVoiceCommand.Name = "labelVoiceCommand";
            this.labelVoiceCommand.Size = new System.Drawing.Size(84, 13);
            this.labelVoiceCommand.TabIndex = 2;
            this.labelVoiceCommand.Text = "Vocal Command";
            // 
            // labelMacro
            // 
            this.labelMacro.AutoSize = true;
            this.labelMacro.Location = new System.Drawing.Point(61, 72);
            this.labelMacro.Name = "labelMacro";
            this.labelMacro.Size = new System.Drawing.Size(37, 13);
            this.labelMacro.TabIndex = 3;
            this.labelMacro.Text = "Macro";
            // 
            // textBoxMacro
            // 
            this.textBoxMacro.Location = new System.Drawing.Point(102, 69);
            this.textBoxMacro.Name = "textBoxMacro";
            this.textBoxMacro.Size = new System.Drawing.Size(170, 20);
            this.textBoxMacro.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(12, 130);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(93, 130);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.writeCommands);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(106, 95);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.deleteCommand);
            // 
            // buttonAddCommand
            // 
            this.buttonAddCommand.Location = new System.Drawing.Point(187, 95);
            this.buttonAddCommand.Name = "buttonAddCommand";
            this.buttonAddCommand.Size = new System.Drawing.Size(89, 23);
            this.buttonAddCommand.TabIndex = 8;
            this.buttonAddCommand.Text = "Add Command";
            this.buttonAddCommand.UseVisualStyleBackColor = true;
            this.buttonAddCommand.Click += new System.EventHandler(this.addCommand);
            // 
            // buttonSaveCommand
            // 
            this.buttonSaveCommand.Location = new System.Drawing.Point(7, 95);
            this.buttonSaveCommand.Name = "buttonSaveCommand";
            this.buttonSaveCommand.Size = new System.Drawing.Size(93, 23);
            this.buttonSaveCommand.TabIndex = 9;
            this.buttonSaveCommand.Text = "Save Command";
            this.buttonSaveCommand.UseVisualStyleBackColor = true;
            this.buttonSaveCommand.Click += new System.EventHandler(this.saveCommand);
            // 
            // CommandEditWindow
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(284, 163);
            this.Controls.Add(this.buttonSaveCommand);
            this.Controls.Add(this.buttonAddCommand);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxMacro);
            this.Controls.Add(this.labelMacro);
            this.Controls.Add(this.labelVoiceCommand);
            this.Controls.Add(this.textBoxVoiceCommand);
            this.Controls.Add(this.comboBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CommandEditWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Edit Commands";
            this.Load += new System.EventHandler(this.init);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMain;
        private System.Windows.Forms.TextBox textBoxVoiceCommand;
        private System.Windows.Forms.Label labelVoiceCommand;
        private System.Windows.Forms.Label labelMacro;
        private System.Windows.Forms.TextBox textBoxMacro;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddCommand;
        private System.Windows.Forms.Button buttonSaveCommand;
    }
}