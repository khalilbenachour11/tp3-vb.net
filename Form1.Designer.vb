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
        ComboBoxTaille = New ComboBox()
        ColorDialog1 = New ColorDialog()
        CheckChampignons = New CheckBox()
        CheckOlives = New CheckBox()
        CheckPoivrons = New CheckBox()
        CheckFromage = New CheckBox()
        RadioCrouteFine = New RadioButton()
        RadioCrouteClassique = New RadioButton()
        RadioCrouteEpaisse = New RadioButton()
        BtnAfficher = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ComboBoxTaille
        ' 
        ComboBoxTaille.BackColor = Color.Silver
        ComboBoxTaille.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        ComboBoxTaille.ForeColor = Color.Black
        ComboBoxTaille.FormattingEnabled = True
        ComboBoxTaille.Location = New Point(148, 27)
        ComboBoxTaille.Name = "ComboBoxTaille"
        ComboBoxTaille.Size = New Size(449, 27)
        ComboBoxTaille.TabIndex = 0
        ' 
        ' CheckChampignons
        ' 
        CheckChampignons.AutoSize = True
        CheckChampignons.BackColor = Color.Teal
        CheckChampignons.Font = New Font("Arial Black", 10.2F, FontStyle.Bold Or FontStyle.Underline)
        CheckChampignons.Location = New Point(475, 289)
        CheckChampignons.Name = "CheckChampignons"
        CheckChampignons.Size = New Size(155, 28)
        CheckChampignons.TabIndex = 1
        CheckChampignons.Text = "Champignons"
        CheckChampignons.UseVisualStyleBackColor = False
        ' 
        ' CheckOlives
        ' 
        CheckOlives.AutoSize = True
        CheckOlives.BackColor = Color.Teal
        CheckOlives.Font = New Font("Arial Black", 10.2F, FontStyle.Bold Or FontStyle.Underline)
        CheckOlives.ForeColor = Color.Black
        CheckOlives.Location = New Point(475, 120)
        CheckOlives.Name = "CheckOlives"
        CheckOlives.Size = New Size(89, 28)
        CheckOlives.TabIndex = 2
        CheckOlives.Text = "Olives"
        CheckOlives.UseVisualStyleBackColor = False
        ' 
        ' CheckPoivrons
        ' 
        CheckPoivrons.AutoSize = True
        CheckPoivrons.BackColor = Color.Teal
        CheckPoivrons.Font = New Font("Arial Black", 10.2F, FontStyle.Bold Or FontStyle.Underline)
        CheckPoivrons.Location = New Point(475, 180)
        CheckPoivrons.Name = "CheckPoivrons"
        CheckPoivrons.Size = New Size(111, 28)
        CheckPoivrons.TabIndex = 3
        CheckPoivrons.Text = "Poivrons"
        CheckPoivrons.UseVisualStyleBackColor = False
        ' 
        ' CheckFromage
        ' 
        CheckFromage.AutoSize = True
        CheckFromage.BackColor = Color.Teal
        CheckFromage.Font = New Font("Arial Black", 10.2F, FontStyle.Bold Or FontStyle.Underline)
        CheckFromage.Location = New Point(475, 239)
        CheckFromage.Name = "CheckFromage"
        CheckFromage.Size = New Size(111, 28)
        CheckFromage.TabIndex = 4
        CheckFromage.Text = "Fromage"
        CheckFromage.UseVisualStyleBackColor = False
        ' 
        ' RadioCrouteFine
        ' 
        RadioCrouteFine.AutoSize = True
        RadioCrouteFine.BackColor = Color.Teal
        RadioCrouteFine.Font = New Font("Arial Black", 10.2F, FontStyle.Bold Or FontStyle.Underline)
        RadioCrouteFine.Location = New Point(148, 120)
        RadioCrouteFine.Name = "RadioCrouteFine"
        RadioCrouteFine.Size = New Size(138, 28)
        RadioCrouteFine.TabIndex = 5
        RadioCrouteFine.TabStop = True
        RadioCrouteFine.Text = "Croute Fine"
        RadioCrouteFine.UseVisualStyleBackColor = False
        ' 
        ' RadioCrouteClassique
        ' 
        RadioCrouteClassique.AutoSize = True
        RadioCrouteClassique.BackColor = Color.Teal
        RadioCrouteClassique.Font = New Font("Arial Black", 10.2F, FontStyle.Bold Or FontStyle.Underline)
        RadioCrouteClassique.Location = New Point(148, 206)
        RadioCrouteClassique.Name = "RadioCrouteClassique"
        RadioCrouteClassique.Size = New Size(188, 28)
        RadioCrouteClassique.TabIndex = 6
        RadioCrouteClassique.TabStop = True
        RadioCrouteClassique.Text = "Croute Classique"
        RadioCrouteClassique.UseVisualStyleBackColor = False
        ' 
        ' RadioCrouteEpaisse
        ' 
        RadioCrouteEpaisse.AutoSize = True
        RadioCrouteEpaisse.BackColor = Color.Teal
        RadioCrouteEpaisse.Font = New Font("Arial Black", 10.2F, FontStyle.Bold Or FontStyle.Underline)
        RadioCrouteEpaisse.Location = New Point(148, 288)
        RadioCrouteEpaisse.Name = "RadioCrouteEpaisse"
        RadioCrouteEpaisse.Size = New Size(170, 28)
        RadioCrouteEpaisse.TabIndex = 7
        RadioCrouteEpaisse.TabStop = True
        RadioCrouteEpaisse.Text = "Croute Epaisse"
        RadioCrouteEpaisse.UseVisualStyleBackColor = False
        ' 
        ' BtnAfficher
        ' 
        BtnAfficher.BackColor = Color.FromArgb(255, 223, 186)
        BtnAfficher.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        BtnAfficher.Location = New Point(266, 372)
        BtnAfficher.Name = "BtnAfficher"
        BtnAfficher.Size = New Size(240, 41)
        BtnAfficher.TabIndex = 8
        BtnAfficher.Text = "Afficher la commande"
        BtnAfficher.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(331, 404)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(BtnAfficher)
        Controls.Add(RadioCrouteEpaisse)
        Controls.Add(RadioCrouteClassique)
        Controls.Add(RadioCrouteFine)
        Controls.Add(CheckFromage)
        Controls.Add(CheckPoivrons)
        Controls.Add(CheckOlives)
        Controls.Add(CheckChampignons)
        Controls.Add(ComboBoxTaille)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBoxTaille As ComboBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents CheckChampignons As CheckBox
    Friend WithEvents CheckOlives As CheckBox
    Friend WithEvents CheckPoivrons As CheckBox
    Friend WithEvents CheckFromage As CheckBox
    Friend WithEvents RadioCrouteFine As RadioButton
    Friend WithEvents RadioCrouteClassique As RadioButton
    Friend WithEvents RadioCrouteEpaisse As RadioButton
    Friend WithEvents BtnAfficher As Button
    Friend WithEvents Label1 As Label

End Class
