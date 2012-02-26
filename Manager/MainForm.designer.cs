using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace COMPortTerminal
{
   
    [ global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated() ]
    public partial class MainForm : System.Windows.Forms.Form 
    { 
        
        // Form overrides dispose to clean up the component list.
        [ System.Diagnostics.DebuggerNonUserCode() ]
        protected override void Dispose( bool disposing ) 
        { 
            if ( disposing && components != null ) 
            { 
                components.Dispose(); 
            } 
            base.Dispose( disposing ); 
        } 
        
        
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components; 
        
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() 
        {
            this.components = new System.ComponentModel.Container();
            this.rtbMonitor = new System.Windows.Forms.RichTextBox();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.btnPort = new System.Windows.Forms.Button();
            this.btnOpenOrClosePort = new System.Windows.Forms.Button();
            this.tmrLookForPortChanges = new System.Windows.Forms.Timer(this.components);
            this.statusLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.OrderListBox = new System.Windows.Forms.ListBox();
            this.buttton4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.AddCard = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tablePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RequestBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rtbMonitor
            // 
            this.rtbMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMonitor.Location = new System.Drawing.Point(534, 87);
            this.rtbMonitor.Name = "rtbMonitor";
            this.rtbMonitor.Size = new System.Drawing.Size(182, 72);
            this.rtbMonitor.TabIndex = 7;
            this.rtbMonitor.Text = "";
            // 
            // rtbStatus
            // 
            this.rtbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbStatus.BackColor = System.Drawing.SystemColors.Control;
            this.rtbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStatus.Location = new System.Drawing.Point(534, 329);
            this.rtbStatus.Margin = new System.Windows.Forms.Padding(5);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.ReadOnly = true;
            this.rtbStatus.Size = new System.Drawing.Size(82, 26);
            this.rtbStatus.TabIndex = 8;
            this.rtbStatus.Text = "";
            // 
            // btnPort
            // 
            this.btnPort.AutoSize = true;
            this.btnPort.Location = new System.Drawing.Point(534, 409);
            this.btnPort.Name = "btnPort";
            this.btnPort.Size = new System.Drawing.Size(77, 27);
            this.btnPort.TabIndex = 10;
            this.btnPort.Text = "Port Settings";
            this.btnPort.UseVisualStyleBackColor = true;
            // 
            // btnOpenOrClosePort
            // 
            this.btnOpenOrClosePort.AutoSize = true;
            this.btnOpenOrClosePort.Location = new System.Drawing.Point(625, 409);
            this.btnOpenOrClosePort.Name = "btnOpenOrClosePort";
            this.btnOpenOrClosePort.Size = new System.Drawing.Size(95, 27);
            this.btnOpenOrClosePort.TabIndex = 11;
            this.btnOpenOrClosePort.Text = "Open COM Port";
            this.btnOpenOrClosePort.UseVisualStyleBackColor = true;
            // 
            // tmrLookForPortChanges
            // 
            this.tmrLookForPortChanges.Interval = 1000;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(347, 43);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 20;
            this.statusLabel.Text = "label1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(144, 322);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 47);
            this.button5.TabIndex = 19;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // OrderListBox
            // 
            this.OrderListBox.FormattingEnabled = true;
            this.OrderListBox.Location = new System.Drawing.Point(144, 44);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(186, 264);
            this.OrderListBox.TabIndex = 18;
            // 
            // buttton4
            // 
            this.buttton4.Location = new System.Drawing.Point(13, 40);
            this.buttton4.Name = "buttton4";
            this.buttton4.Size = new System.Drawing.Size(51, 35);
            this.buttton4.TabIndex = 17;
            this.buttton4.Text = "button4";
            this.buttton4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(77, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 35);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AddCard
            // 
            this.AddCard.Location = new System.Drawing.Point(77, 40);
            this.AddCard.Name = "AddCard";
            this.AddCard.Size = new System.Drawing.Size(51, 35);
            this.AddCard.TabIndex = 15;
            this.AddCard.Text = "Add Card";
            this.AddCard.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tablePanel
            // 
            this.tablePanel.Location = new System.Drawing.Point(17, 122);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(111, 251);
            this.tablePanel.TabIndex = 13;
            // 
            // RequestBox
            // 
            this.RequestBox.FormattingEnabled = true;
            this.RequestBox.Location = new System.Drawing.Point(346, 83);
            this.RequestBox.Name = "RequestBox";
            this.RequestBox.Size = new System.Drawing.Size(141, 290);
            this.RequestBox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 469);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.OrderListBox);
            this.Controls.Add(this.buttton4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AddCard);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.RequestBox);
            this.Controls.Add(this.btnOpenOrClosePort);
            this.Controls.Add(this.btnPort);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.rtbMonitor);
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Dim Sum Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        
        internal /* TRANSINFO: WithEvents */ System.Windows.Forms.RichTextBox rtbMonitor;
        internal /* TRANSINFO: WithEvents */ System.Windows.Forms.RichTextBox rtbStatus; 
        internal /* TRANSINFO: WithEvents */ System.Windows.Forms.Button btnPort; 
        internal /* TRANSINFO: WithEvents */ System.Windows.Forms.Button btnOpenOrClosePort; 
        internal /* TRANSINFO: WithEvents */ System.Windows.Forms.Timer tmrLookForPortChanges;
        private Label statusLabel;
        private Button button5;
        private ListBox OrderListBox;
        private Button buttton4;
        private Button button3;
        private Button AddCard;
        private Button button2;
        private FlowLayoutPanel tablePanel;
        private ListBox RequestBox; 
        
        
    } 
    
    
} 
