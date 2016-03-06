<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("We are totally going to bring up the pariot thing.")
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.lstBxCustomers = New System.Windows.Forms.ListBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.lblForName = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblForAddress = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblForPhone = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblForEmail = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblForStatus = New System.Windows.Forms.Label()
        Me.cmBxStatus = New System.Windows.Forms.ComboBox()
        Me.lblForNotes = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCSave = New System.Windows.Forms.Button()
        Me.txtBxCEmail = New System.Windows.Forms.TextBox()
        Me.txtBxCPhone = New System.Windows.Forms.TextBox()
        Me.txtBxCAddress = New System.Windows.Forms.TextBox()
        Me.txtBxCName = New System.Windows.Forms.TextBox()
        Me.lblForCEmail = New System.Windows.Forms.Label()
        Me.lblForCName = New System.Windows.Forms.Label()
        Me.lblForCPhone = New System.Windows.Forms.Label()
        Me.lblCreateForm = New System.Windows.Forms.Label()
        Me.lblForCAddress = New System.Windows.Forms.Label()
        Me.lstNotes = New System.Windows.Forms.ListView()
        Me.btnAddNote = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.POS408_Team_A_CRM.My.Resources.Resources.sideBarBG
        Me.PictureBox1.Location = New System.Drawing.Point(9, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 2000)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.Location = New System.Drawing.Point(244, 20)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(734, 56)
        Me.lblProgram.TabIndex = 1
        Me.lblProgram.Text = "Customer Relationship System"
        '
        'lstBxCustomers
        '
        Me.lstBxCustomers.FormattingEnabled = True
        Me.lstBxCustomers.Items.AddRange(New Object() {"The Vampire Lestate", "Gilbert Godfrey"})
        Me.lstBxCustomers.Location = New System.Drawing.Point(25, 214)
        Me.lstBxCustomers.Name = "lstBxCustomers"
        Me.lstBxCustomers.Size = New System.Drawing.Size(178, 199)
        Me.lstBxCustomers.TabIndex = 2
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(25, 419)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(91, 23)
        Me.btnAddNew.TabIndex = 3
        Me.btnAddNew.Text = "New Customer"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'lblForName
        '
        Me.lblForName.AutoSize = True
        Me.lblForName.Location = New System.Drawing.Point(254, 111)
        Me.lblForName.Name = "lblForName"
        Me.lblForName.Size = New System.Drawing.Size(38, 13)
        Me.lblForName.TabIndex = 4
        Me.lblForName.Text = "Name:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(307, 111)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(77, 13)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Gilbert Godfrey"
        '
        'lblForAddress
        '
        Me.lblForAddress.AutoSize = True
        Me.lblForAddress.Location = New System.Drawing.Point(254, 147)
        Me.lblForAddress.Name = "lblForAddress"
        Me.lblForAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblForAddress.TabIndex = 6
        Me.lblForAddress.Text = "Address:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(307, 147)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(196, 13)
        Me.lblAddress.TabIndex = 7
        Me.lblAddress.Text = "123 Gilbert Way, New York, NY 123456"
        '
        'lblForPhone
        '
        Me.lblForPhone.AutoSize = True
        Me.lblForPhone.Location = New System.Drawing.Point(254, 182)
        Me.lblForPhone.Name = "lblForPhone"
        Me.lblForPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblForPhone.TabIndex = 8
        Me.lblForPhone.Text = "Phone:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(307, 182)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(73, 13)
        Me.lblPhone.TabIndex = 9
        Me.lblPhone.Text = "213-555-9999"
        '
        'lblForEmail
        '
        Me.lblForEmail.AutoSize = True
        Me.lblForEmail.Location = New System.Drawing.Point(254, 214)
        Me.lblForEmail.Name = "lblForEmail"
        Me.lblForEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblForEmail.TabIndex = 10
        Me.lblForEmail.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "gilbert@godfrey.net"
        '
        'lblForStatus
        '
        Me.lblForStatus.AutoSize = True
        Me.lblForStatus.Location = New System.Drawing.Point(254, 247)
        Me.lblForStatus.Name = "lblForStatus"
        Me.lblForStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblForStatus.TabIndex = 12
        Me.lblForStatus.Text = "Status:"
        '
        'cmBxStatus
        '
        Me.cmBxStatus.FormattingEnabled = True
        Me.cmBxStatus.Items.AddRange(New Object() {"Contacted", "Unreachable", "Interested", "Uninterested", "Don't Contact", "Under Contract"})
        Me.cmBxStatus.Location = New System.Drawing.Point(307, 243)
        Me.cmBxStatus.Name = "cmBxStatus"
        Me.cmBxStatus.Size = New System.Drawing.Size(121, 21)
        Me.cmBxStatus.TabIndex = 13
        '
        'lblForNotes
        '
        Me.lblForNotes.AutoSize = True
        Me.lblForNotes.Location = New System.Drawing.Point(603, 110)
        Me.lblForNotes.Name = "lblForNotes"
        Me.lblForNotes.Size = New System.Drawing.Size(85, 13)
        Me.lblForNotes.TabIndex = 14
        Me.lblForNotes.Text = "Customer Notes:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCSave)
        Me.Panel1.Controls.Add(Me.txtBxCEmail)
        Me.Panel1.Controls.Add(Me.txtBxCPhone)
        Me.Panel1.Controls.Add(Me.txtBxCAddress)
        Me.Panel1.Controls.Add(Me.txtBxCName)
        Me.Panel1.Controls.Add(Me.lblForCEmail)
        Me.Panel1.Controls.Add(Me.lblForCName)
        Me.Panel1.Controls.Add(Me.lblForCPhone)
        Me.Panel1.Controls.Add(Me.lblCreateForm)
        Me.Panel1.Controls.Add(Me.lblForCAddress)
        Me.Panel1.Location = New System.Drawing.Point(239, 296)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 210)
        Me.Panel1.TabIndex = 17
        Me.Panel1.Visible = False
        '
        'btnCSave
        '
        Me.btnCSave.Location = New System.Drawing.Point(230, 177)
        Me.btnCSave.Name = "btnCSave"
        Me.btnCSave.Size = New System.Drawing.Size(75, 23)
        Me.btnCSave.TabIndex = 24
        Me.btnCSave.Text = "Save"
        Me.btnCSave.UseVisualStyleBackColor = True
        '
        'txtBxCEmail
        '
        Me.txtBxCEmail.Location = New System.Drawing.Point(73, 143)
        Me.txtBxCEmail.Name = "txtBxCEmail"
        Me.txtBxCEmail.Size = New System.Drawing.Size(233, 20)
        Me.txtBxCEmail.TabIndex = 23
        '
        'txtBxCPhone
        '
        Me.txtBxCPhone.Location = New System.Drawing.Point(73, 107)
        Me.txtBxCPhone.Name = "txtBxCPhone"
        Me.txtBxCPhone.Size = New System.Drawing.Size(233, 20)
        Me.txtBxCPhone.TabIndex = 22
        '
        'txtBxCAddress
        '
        Me.txtBxCAddress.Location = New System.Drawing.Point(73, 76)
        Me.txtBxCAddress.Name = "txtBxCAddress"
        Me.txtBxCAddress.Size = New System.Drawing.Size(233, 20)
        Me.txtBxCAddress.TabIndex = 21
        '
        'txtBxCName
        '
        Me.txtBxCName.Location = New System.Drawing.Point(73, 39)
        Me.txtBxCName.Name = "txtBxCName"
        Me.txtBxCName.Size = New System.Drawing.Size(233, 20)
        Me.txtBxCName.TabIndex = 2
        '
        'lblForCEmail
        '
        Me.lblForCEmail.AutoSize = True
        Me.lblForCEmail.Location = New System.Drawing.Point(18, 146)
        Me.lblForCEmail.Name = "lblForCEmail"
        Me.lblForCEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblForCEmail.TabIndex = 20
        Me.lblForCEmail.Text = "Email:"
        '
        'lblForCName
        '
        Me.lblForCName.AutoSize = True
        Me.lblForCName.Location = New System.Drawing.Point(18, 43)
        Me.lblForCName.Name = "lblForCName"
        Me.lblForCName.Size = New System.Drawing.Size(38, 13)
        Me.lblForCName.TabIndex = 1
        Me.lblForCName.Text = "Name:"
        '
        'lblForCPhone
        '
        Me.lblForCPhone.AutoSize = True
        Me.lblForCPhone.Location = New System.Drawing.Point(18, 114)
        Me.lblForCPhone.Name = "lblForCPhone"
        Me.lblForCPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblForCPhone.TabIndex = 19
        Me.lblForCPhone.Text = "Phone:"
        '
        'lblCreateForm
        '
        Me.lblCreateForm.AutoSize = True
        Me.lblCreateForm.Location = New System.Drawing.Point(15, 13)
        Me.lblCreateForm.Name = "lblCreateForm"
        Me.lblCreateForm.Size = New System.Drawing.Size(85, 13)
        Me.lblCreateForm.TabIndex = 0
        Me.lblCreateForm.Text = "Create Customer"
        '
        'lblForCAddress
        '
        Me.lblForCAddress.AutoSize = True
        Me.lblForCAddress.Location = New System.Drawing.Point(18, 79)
        Me.lblForCAddress.Name = "lblForCAddress"
        Me.lblForCAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblForCAddress.TabIndex = 18
        Me.lblForCAddress.Text = "Address:"
        '
        'lstNotes
        '
        Me.lstNotes.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lstNotes.Location = New System.Drawing.Point(606, 130)
        Me.lstNotes.Name = "lstNotes"
        Me.lstNotes.Size = New System.Drawing.Size(354, 329)
        Me.lstNotes.TabIndex = 18
        Me.lstNotes.UseCompatibleStateImageBehavior = False
        Me.lstNotes.View = System.Windows.Forms.View.List
        '
        'btnAddNote
        '
        Me.btnAddNote.Location = New System.Drawing.Point(884, 466)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNote.TabIndex = 19
        Me.btnAddNote.Text = "New Note"
        Me.btnAddNote.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 538)
        Me.Controls.Add(Me.btnAddNote)
        Me.Controls.Add(Me.lstNotes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblForNotes)
        Me.Controls.Add(Me.cmBxStatus)
        Me.Controls.Add(Me.lblForStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblForEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblForPhone)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblForAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblForName)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.lstBxCustomers)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMain"
        Me.Text = "Kudler Fine Foods CRM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblProgram As System.Windows.Forms.Label
    Friend WithEvents lstBxCustomers As System.Windows.Forms.ListBox
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents lblForName As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblForAddress As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblForPhone As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblForEmail As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblForStatus As System.Windows.Forms.Label
    Friend WithEvents cmBxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblForNotes As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCreateForm As System.Windows.Forms.Label
    Friend WithEvents btnCSave As System.Windows.Forms.Button
    Friend WithEvents txtBxCEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtBxCPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtBxCAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtBxCName As System.Windows.Forms.TextBox
    Friend WithEvents lblForCEmail As System.Windows.Forms.Label
    Friend WithEvents lblForCName As System.Windows.Forms.Label
    Friend WithEvents lblForCPhone As System.Windows.Forms.Label
    Friend WithEvents lblForCAddress As System.Windows.Forms.Label
    Friend WithEvents lstNotes As System.Windows.Forms.ListView
    Friend WithEvents btnAddNote As System.Windows.Forms.Button

End Class
