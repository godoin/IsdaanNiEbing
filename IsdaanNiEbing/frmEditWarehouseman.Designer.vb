﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditWarehouseman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label1 = New Label()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ImageAlign = ContentAlignment.MiddleLeft
        Label5.Location = New Point(29, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(186, 26)
        Label5.TabIndex = 52
        Label5.Text = "Edit Warehouseman"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(29, 290)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(287, 35)
        TextBox3.TabIndex = 51
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(29, 268)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 19)
        Label1.TabIndex = 50
        Label1.Text = "Contact"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(29, 225)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(287, 35)
        TextBox4.TabIndex = 49
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(29, 203)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 19)
        Label2.TabIndex = 48
        Label2.Text = "Last Name"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(106, 364)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 31)
        Button2.TabIndex = 47
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(214, 364)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 31)
        Button1.TabIndex = 46
        Button1.Text = "Update"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(29, 161)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(287, 35)
        TextBox2.TabIndex = 45
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(29, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 19)
        Label4.TabIndex = 44
        Label4.Text = "Middle Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(29, 96)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(287, 35)
        TextBox1.TabIndex = 43
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(29, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 19)
        Label3.TabIndex = 42
        Label3.Text = "First Name"
        ' 
        ' frmEditWarehouseman
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(344, 431)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label1)
        Controls.Add(TextBox4)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Name = "frmEditWarehouseman"
        Text = "frmEditWarehouseman"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
End Class
