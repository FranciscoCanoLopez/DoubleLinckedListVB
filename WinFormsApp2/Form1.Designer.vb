<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtData = New System.Windows.Forms.TextBox()
        lblData = New System.Windows.Forms.Label()
        lvDisplay = New System.Windows.Forms.ListView()
        btnAgg = New System.Windows.Forms.Button()
        btnDelete = New System.Windows.Forms.Button()
        btnSearch = New System.Windows.Forms.Button()
        SuspendLayout()
        ' 
        ' txtData
        ' 
        txtData.Location = New Drawing.Point(283, 79)
        txtData.Name = "txtData"
        txtData.Size = New Drawing.Size(125, 27)
        txtData.TabIndex = 8
        ' 
        ' lblData
        ' 
        lblData.AutoSize = True
        lblData.Font = New Drawing.Font("Segoe UI", 16.2F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
        lblData.Location = New Drawing.Point(283, 26)
        lblData.Name = "lblData"
        lblData.Size = New Drawing.Size(79, 38)
        lblData.TabIndex = 10
        lblData.Text = "Data"
        ' 
        ' lvDisplay
        ' 
        lvDisplay.Font = New Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
        lvDisplay.Location = New Drawing.Point(12, 16)
        lvDisplay.Name = "lvDisplay"
        lvDisplay.Size = New Drawing.Size(220, 213)
        lvDisplay.TabIndex = 12
        lvDisplay.UseCompatibleStateImageBehavior = False
        lvDisplay.View = System.Windows.Forms.View.Details
        lvDisplay.Columns.Add("Posición", 100)
        lvDisplay.Columns.Add("Dato", 100)
        ' 
        ' btnAgg
        ' 
        btnAgg.Location = New Drawing.Point(283, 123)
        btnAgg.Name = "btnAgg"
        btnAgg.Size = New Drawing.Size(94, 29)
        btnAgg.TabIndex = 13
        btnAgg.Text = "Agg"
        btnAgg.UseVisualStyleBackColor = True
        AddHandler btnAgg.Click, AddressOf btnAgg_Click
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Drawing.Point(283, 158)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Drawing.Size(94, 29)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        AddHandler btnDelete.Click, AddressOf btnDelete_Click
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Drawing.Point(283, 193)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Drawing.Size(94, 29)
        btnSearch.TabIndex = 15
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        AddHandler btnSearch.Click, AddressOf btnSearch_Click
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New Drawing.SizeF(8.0F, 20.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New Drawing.Size(434, 264)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnAgg)
        Controls.Add(lvDisplay)
        Controls.Add(lblData)
        Controls.Add(txtData)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private txtData As System.Windows.Forms.TextBox
    Private lblData As System.Windows.Forms.Label
    Private lvDisplay As System.Windows.Forms.ListView
    Private btnAgg As System.Windows.Forms.Button
    Private btnDelete As System.Windows.Forms.Button
    Private btnSearch As System.Windows.Forms.Button

End Class
