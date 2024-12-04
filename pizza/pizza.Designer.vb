<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pizza
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
        lst_demande = New ComboBox()
        hk_champigion = New CheckBox()
        hk_olives = New CheckBox()
        hk_poissons = New CheckBox()
        hk_fromage = New CheckBox()
        rd_fine = New RadioButton()
        rd_classique = New RadioButton()
        rd_épaise = New RadioButton()
        Btn_click = New Button()
        SuspendLayout()
        ' 
        ' lst_demande
        ' 
        lst_demande.FormattingEnabled = True
        lst_demande.Items.AddRange(New Object() {"petite", "grande", "moyenne"})
        lst_demande.Location = New Point(238, 0)
        lst_demande.Name = "lst_demande"
        lst_demande.Size = New Size(151, 28)
        lst_demande.TabIndex = 0
        ' 
        ' hk_champigion
        ' 
        hk_champigion.AutoSize = True
        hk_champigion.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        hk_champigion.Location = New Point(85, 132)
        hk_champigion.Name = "hk_champigion"
        hk_champigion.Size = New Size(118, 24)
        hk_champigion.TabIndex = 1
        hk_champigion.Text = "champignion"
        hk_champigion.UseVisualStyleBackColor = False
        ' 
        ' hk_olives
        ' 
        hk_olives.AutoSize = True
        hk_olives.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        hk_olives.Location = New Point(85, 205)
        hk_olives.Name = "hk_olives"
        hk_olives.Size = New Size(69, 24)
        hk_olives.TabIndex = 2
        hk_olives.Text = "olives"
        hk_olives.UseVisualStyleBackColor = False
        ' 
        ' hk_poissons
        ' 
        hk_poissons.AutoSize = True
        hk_poissons.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        hk_poissons.Location = New Point(85, 288)
        hk_poissons.Name = "hk_poissons"
        hk_poissons.Size = New Size(88, 24)
        hk_poissons.TabIndex = 3
        hk_poissons.Text = "poissons"
        hk_poissons.UseVisualStyleBackColor = False
        ' 
        ' hk_fromage
        ' 
        hk_fromage.AutoSize = True
        hk_fromage.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        hk_fromage.Location = New Point(85, 353)
        hk_fromage.Name = "hk_fromage"
        hk_fromage.Size = New Size(191, 24)
        hk_fromage.TabIndex = 4
        hk_fromage.Text = "fromage supplimentaire"
        hk_fromage.UseVisualStyleBackColor = False
        ' 
        ' rd_fine
        ' 
        rd_fine.AutoSize = True
        rd_fine.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic)
        rd_fine.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        rd_fine.Location = New Point(85, 67)
        rd_fine.Name = "rd_fine"
        rd_fine.Size = New Size(151, 35)
        rd_fine.TabIndex = 5
        rd_fine.TabStop = True
        rd_fine.Text = "croute fine"
        rd_fine.UseVisualStyleBackColor = True
        ' 
        ' rd_classique
        ' 
        rd_classique.AutoSize = True
        rd_classique.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic)
        rd_classique.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        rd_classique.Location = New Point(273, 67)
        rd_classique.Name = "rd_classique"
        rd_classique.Size = New Size(208, 35)
        rd_classique.TabIndex = 6
        rd_classique.TabStop = True
        rd_classique.Text = "croute classique"
        rd_classique.UseVisualStyleBackColor = True
        ' 
        ' rd_épaise
        ' 
        rd_épaise.AutoSize = True
        rd_épaise.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic)
        rd_épaise.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        rd_épaise.Location = New Point(509, 67)
        rd_épaise.Name = "rd_épaise"
        rd_épaise.Size = New Size(178, 35)
        rd_épaise.TabIndex = 7
        rd_épaise.TabStop = True
        rd_épaise.Text = "croute épaise"
        rd_épaise.UseVisualStyleBackColor = True
        ' 
        ' Btn_click
        ' 
        Btn_click.BackColor = Color.White
        Btn_click.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Btn_click.ForeColor = Color.Black
        Btn_click.Location = New Point(316, 398)
        Btn_click.Name = "Btn_click"
        Btn_click.Size = New Size(269, 51)
        Btn_click.TabIndex = 8
        Btn_click.Text = "afficher la commande"
        Btn_click.UseVisualStyleBackColor = False
        ' 
        ' pizza
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_click)
        Controls.Add(rd_épaise)
        Controls.Add(rd_classique)
        Controls.Add(rd_fine)
        Controls.Add(hk_fromage)
        Controls.Add(hk_poissons)
        Controls.Add(hk_olives)
        Controls.Add(hk_champigion)
        Controls.Add(lst_demande)
        Name = "pizza"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lst_demande As ComboBox
    Friend WithEvents hk_champigion As CheckBox
    Friend WithEvents hk_olives As CheckBox
    Friend WithEvents hk_poissons As CheckBox
    Friend WithEvents hk_fromage As CheckBox
    Friend WithEvents rd_fine As RadioButton
    Friend WithEvents rd_classique As RadioButton
    Friend WithEvents rd_épaise As RadioButton
    Friend WithEvents Btn_click As Button

End Class
