<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventory
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBoxSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ButtonClearSelectedAndImagePreview = New Guna.UI2.WinForms.Guna2Button()
        Me.CheckBoxByID = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.CheckBoxByName = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ButtonRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonClearAll = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSave = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBoxID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBoxPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBoxAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBoxName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBoxImagePreview = New System.Windows.Forms.PictureBox()
        Me.PictureBoxImageInput = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.BorderRadius = 12
        Me.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxSearch.DefaultText = ""
        Me.TextBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxSearch.DisabledState.Parent = Me.TextBoxSearch
        Me.TextBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxSearch.FocusedState.Parent = Me.TextBoxSearch
        Me.TextBoxSearch.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxSearch.HoverState.Parent = Me.TextBoxSearch
        Me.TextBoxSearch.Location = New System.Drawing.Point(116, 274)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxSearch.PlaceholderText = ""
        Me.TextBoxSearch.SelectedText = ""
        Me.TextBoxSearch.ShadowDecoration.Parent = Me.TextBoxSearch
        Me.TextBoxSearch.Size = New System.Drawing.Size(274, 32)
        Me.TextBoxSearch.TabIndex = 17
        '
        'ButtonClearSelectedAndImagePreview
        '
        Me.ButtonClearSelectedAndImagePreview.BorderRadius = 12
        Me.ButtonClearSelectedAndImagePreview.CheckedState.Parent = Me.ButtonClearSelectedAndImagePreview
        Me.ButtonClearSelectedAndImagePreview.CustomImages.Parent = Me.ButtonClearSelectedAndImagePreview
        Me.ButtonClearSelectedAndImagePreview.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ButtonClearSelectedAndImagePreview.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearSelectedAndImagePreview.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonClearSelectedAndImagePreview.HoverState.Parent = Me.ButtonClearSelectedAndImagePreview
        Me.ButtonClearSelectedAndImagePreview.Location = New System.Drawing.Point(27, 223)
        Me.ButtonClearSelectedAndImagePreview.Name = "ButtonClearSelectedAndImagePreview"
        Me.ButtonClearSelectedAndImagePreview.ShadowDecoration.Parent = Me.ButtonClearSelectedAndImagePreview
        Me.ButtonClearSelectedAndImagePreview.Size = New System.Drawing.Size(174, 33)
        Me.ButtonClearSelectedAndImagePreview.TabIndex = 20
        Me.ButtonClearSelectedAndImagePreview.Text = "Clear Image"
        '
        'CheckBoxByID
        '
        Me.CheckBoxByID.Animated = True
        Me.CheckBoxByID.AutoSize = True
        Me.CheckBoxByID.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxByID.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBoxByID.CheckedState.BorderRadius = 2
        Me.CheckBoxByID.CheckedState.BorderThickness = 0
        Me.CheckBoxByID.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBoxByID.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxByID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CheckBoxByID.Location = New System.Drawing.Point(534, 277)
        Me.CheckBoxByID.Name = "CheckBoxByID"
        Me.CheckBoxByID.Size = New System.Drawing.Size(109, 27)
        Me.CheckBoxByID.TabIndex = 40
        Me.CheckBoxByID.Text = "Search by ID"
        Me.CheckBoxByID.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckBoxByID.UncheckedState.BorderRadius = 2
        Me.CheckBoxByID.UncheckedState.BorderThickness = 0
        Me.CheckBoxByID.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckBoxByID.UseVisualStyleBackColor = False
        '
        'CheckBoxByName
        '
        Me.CheckBoxByName.Animated = True
        Me.CheckBoxByName.AutoSize = True
        Me.CheckBoxByName.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxByName.Checked = True
        Me.CheckBoxByName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBoxByName.CheckedState.BorderRadius = 2
        Me.CheckBoxByName.CheckedState.BorderThickness = 0
        Me.CheckBoxByName.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBoxByName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxByName.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxByName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CheckBoxByName.Location = New System.Drawing.Point(399, 277)
        Me.CheckBoxByName.Name = "CheckBoxByName"
        Me.CheckBoxByName.Size = New System.Drawing.Size(135, 27)
        Me.CheckBoxByName.TabIndex = 39
        Me.CheckBoxByName.Text = "Search by name"
        Me.CheckBoxByName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckBoxByName.UncheckedState.BorderRadius = 2
        Me.CheckBoxByName.UncheckedState.BorderThickness = 0
        Me.CheckBoxByName.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckBoxByName.UseVisualStyleBackColor = False
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRefresh.BorderRadius = 12
        Me.ButtonRefresh.CheckedState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.CustomImages.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ButtonRefresh.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonRefresh.HoverState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Location = New System.Drawing.Point(490, 119)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.ShadowDecoration.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Size = New System.Drawing.Size(115, 45)
        Me.ButtonRefresh.TabIndex = 37
        Me.ButtonRefresh.Text = "Refresh"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDelete.BorderRadius = 12
        Me.ButtonDelete.CheckedState.Parent = Me.ButtonDelete
        Me.ButtonDelete.CustomImages.Parent = Me.ButtonDelete
        Me.ButtonDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ButtonDelete.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonDelete.HoverState.Parent = Me.ButtonDelete
        Me.ButtonDelete.Location = New System.Drawing.Point(490, 69)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.ShadowDecoration.Parent = Me.ButtonDelete
        Me.ButtonDelete.Size = New System.Drawing.Size(115, 45)
        Me.ButtonDelete.TabIndex = 36
        Me.ButtonDelete.Text = "Delete"
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEdit.BorderRadius = 12
        Me.ButtonEdit.CheckedState.Parent = Me.ButtonEdit
        Me.ButtonEdit.CustomImages.Parent = Me.ButtonEdit
        Me.ButtonEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ButtonEdit.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonEdit.HoverState.Parent = Me.ButtonEdit
        Me.ButtonEdit.Location = New System.Drawing.Point(490, 18)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.ShadowDecoration.Parent = Me.ButtonEdit
        Me.ButtonEdit.Size = New System.Drawing.Size(115, 45)
        Me.ButtonEdit.TabIndex = 35
        Me.ButtonEdit.Text = "Edit"
        '
        'ButtonClearAll
        '
        Me.ButtonClearAll.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClearAll.BorderRadius = 12
        Me.ButtonClearAll.CheckedState.Parent = Me.ButtonClearAll
        Me.ButtonClearAll.CustomImages.Parent = Me.ButtonClearAll
        Me.ButtonClearAll.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ButtonClearAll.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearAll.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonClearAll.HoverState.Parent = Me.ButtonClearAll
        Me.ButtonClearAll.Location = New System.Drawing.Point(458, 174)
        Me.ButtonClearAll.Name = "ButtonClearAll"
        Me.ButtonClearAll.ShadowDecoration.Parent = Me.ButtonClearAll
        Me.ButtonClearAll.Size = New System.Drawing.Size(147, 45)
        Me.ButtonClearAll.TabIndex = 32
        Me.ButtonClearAll.Text = "Clear All"
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSave.BorderRadius = 12
        Me.ButtonSave.CheckedState.Parent = Me.ButtonSave
        Me.ButtonSave.CustomImages.Parent = Me.ButtonSave
        Me.ButtonSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ButtonSave.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonSave.HoverState.Parent = Me.ButtonSave
        Me.ButtonSave.Location = New System.Drawing.Point(21, 174)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.ShadowDecoration.Parent = Me.ButtonSave
        Me.ButtonSave.Size = New System.Drawing.Size(147, 45)
        Me.ButtonSave.TabIndex = 31
        Me.ButtonSave.Text = "Save"
        '
        'TextBoxID
        '
        Me.TextBoxID.Animated = True
        Me.TextBoxID.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxID.BorderRadius = 12
        Me.TextBoxID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxID.DefaultText = ""
        Me.TextBoxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxID.DisabledState.Parent = Me.TextBoxID
        Me.TextBoxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxID.FocusedState.Parent = Me.TextBoxID
        Me.TextBoxID.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxID.HoverState.Parent = Me.TextBoxID
        Me.TextBoxID.Location = New System.Drawing.Point(116, 56)
        Me.TextBoxID.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxID.PlaceholderText = ""
        Me.TextBoxID.SelectedText = ""
        Me.TextBoxID.ShadowDecoration.Parent = Me.TextBoxID
        Me.TextBoxID.Size = New System.Drawing.Size(368, 32)
        Me.TextBoxID.TabIndex = 28
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Animated = True
        Me.TextBoxPrice.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxPrice.BorderRadius = 12
        Me.TextBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxPrice.DefaultText = ""
        Me.TextBoxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxPrice.DisabledState.Parent = Me.TextBoxPrice
        Me.TextBoxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxPrice.FocusedState.Parent = Me.TextBoxPrice
        Me.TextBoxPrice.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxPrice.HoverState.Parent = Me.TextBoxPrice
        Me.TextBoxPrice.Location = New System.Drawing.Point(116, 94)
        Me.TextBoxPrice.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxPrice.PlaceholderText = ""
        Me.TextBoxPrice.SelectedText = ""
        Me.TextBoxPrice.ShadowDecoration.Parent = Me.TextBoxPrice
        Me.TextBoxPrice.Size = New System.Drawing.Size(368, 32)
        Me.TextBoxPrice.TabIndex = 27
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.Animated = True
        Me.TextBoxAmount.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxAmount.BorderRadius = 12
        Me.TextBoxAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxAmount.DefaultText = ""
        Me.TextBoxAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxAmount.DisabledState.Parent = Me.TextBoxAmount
        Me.TextBoxAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxAmount.FocusedState.Parent = Me.TextBoxAmount
        Me.TextBoxAmount.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxAmount.HoverState.Parent = Me.TextBoxAmount
        Me.TextBoxAmount.Location = New System.Drawing.Point(116, 132)
        Me.TextBoxAmount.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxAmount.PlaceholderText = ""
        Me.TextBoxAmount.SelectedText = ""
        Me.TextBoxAmount.ShadowDecoration.Parent = Me.TextBoxAmount
        Me.TextBoxAmount.Size = New System.Drawing.Size(368, 32)
        Me.TextBoxAmount.TabIndex = 26
        '
        'TextBoxName
        '
        Me.TextBoxName.Animated = True
        Me.TextBoxName.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxName.BorderRadius = 12
        Me.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxName.DefaultText = ""
        Me.TextBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxName.DisabledState.Parent = Me.TextBoxName
        Me.TextBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxName.FocusedState.Parent = Me.TextBoxName
        Me.TextBoxName.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxName.HoverState.Parent = Me.TextBoxName
        Me.TextBoxName.Location = New System.Drawing.Point(116, 18)
        Me.TextBoxName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxName.PlaceholderText = ""
        Me.TextBoxName.SelectedText = ""
        Me.TextBoxName.ShadowDecoration.Parent = Me.TextBoxName
        Me.TextBoxName.Size = New System.Drawing.Size(368, 32)
        Me.TextBoxName.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 26)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(14, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 26)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(16, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 26)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(16, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 26)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(39, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 26)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Search :"
        '
        'DataGridView1
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(44, 315)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(609, 249)
        Me.DataGridView1.TabIndex = 46
        Me.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 30
        Me.DataGridView1.ThemeStyle.ReadOnly = False
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(44, 257)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(859, 10)
        Me.Guna2Separator1.TabIndex = 47
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.TextBoxName)
        Me.Guna2Panel1.Controls.Add(Me.TextBoxAmount)
        Me.Guna2Panel1.Controls.Add(Me.TextBoxPrice)
        Me.Guna2Panel1.Controls.Add(Me.TextBoxID)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.ButtonEdit)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.ButtonClearAll)
        Me.Guna2Panel1.Controls.Add(Me.ButtonDelete)
        Me.Guna2Panel1.Controls.Add(Me.ButtonSave)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.ButtonRefresh)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(35, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(618, 239)
        Me.Guna2Panel1.TabIndex = 48
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.Controls.Add(Me.PictureBoxImageInput)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(678, 12)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(225, 239)
        Me.Guna2Panel2.TabIndex = 49
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderRadius = 10
        Me.Guna2Panel3.Controls.Add(Me.PictureBoxImagePreview)
        Me.Guna2Panel3.Controls.Add(Me.ButtonClearSelectedAndImagePreview)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(678, 297)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(225, 267)
        Me.Guna2Panel3.TabIndex = 50
        '
        'PictureBoxImagePreview
        '
        Me.PictureBoxImagePreview.Location = New System.Drawing.Point(19, 14)
        Me.PictureBoxImagePreview.Name = "PictureBoxImagePreview"
        Me.PictureBoxImagePreview.Size = New System.Drawing.Size(187, 201)
        Me.PictureBoxImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImagePreview.TabIndex = 34
        Me.PictureBoxImagePreview.TabStop = False
        '
        'PictureBoxImageInput
        '
        Me.PictureBoxImageInput.Image = Global.inventory_management_system.My.Resources.Resources.empty_box
        Me.PictureBoxImageInput.Location = New System.Drawing.Point(19, 18)
        Me.PictureBoxImageInput.Name = "PictureBoxImageInput"
        Me.PictureBoxImageInput.Size = New System.Drawing.Size(187, 201)
        Me.PictureBoxImageInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImageInput.TabIndex = 29
        Me.PictureBoxImageInput.TabStop = False
        '
        'inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(915, 590)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBoxByID)
        Me.Controls.Add(Me.CheckBoxByName)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "inventory"
        Me.Text = "inventory"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBoxSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ButtonClearSelectedAndImagePreview As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CheckBoxByID As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents CheckBoxByName As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ButtonRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBoxImagePreview As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonClearAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBoxImageInput As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBoxPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBoxAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBoxName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
End Class
