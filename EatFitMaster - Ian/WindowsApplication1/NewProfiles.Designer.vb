<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProfiles
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewProfiles))
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblGoalWeight = New System.Windows.Forms.Label()
        Me.lblGoalDate = New System.Windows.Forms.Label()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.EatFitDatabaseDataSet = New WindowsApplication1.EatFitDatabaseDataSet()
        Me.UserProfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserProfilesTableAdapter = New WindowsApplication1.EatFitDatabaseDataSetTableAdapters.UserProfilesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.EatFitDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.UserProfilesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserProfilesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtGoalWeight = New System.Windows.Forms.TextBox()
        Me.datGoalDate = New System.Windows.Forms.DateTimePicker()
        Me.chkNoRestrictions = New System.Windows.Forms.CheckBox()
        Me.chkVegetarian = New System.Windows.Forms.CheckBox()
        Me.chkVegan = New System.Windows.Forms.CheckBox()
        Me.chkGlutenFree = New System.Windows.Forms.CheckBox()
        Me.txtBMI = New System.Windows.Forms.TextBox()
        Me.chkPeanut = New System.Windows.Forms.CheckBox()
        Me.chkTreeNut = New System.Windows.Forms.CheckBox()
        Me.chkSoy = New System.Windows.Forms.CheckBox()
        Me.chkEgg = New System.Windows.Forms.CheckBox()
        Me.chkFish = New System.Windows.Forms.CheckBox()
        Me.chkShellfish = New System.Windows.Forms.CheckBox()
        Me.chkLactose = New System.Windows.Forms.CheckBox()
        Me.chkWheat = New System.Windows.Forms.CheckBox()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRestrictions = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReturningUser = New System.Windows.Forms.Button()
        Me.btnTempNav = New System.Windows.Forms.Button()
        CType(Me.EatFitDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfilesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserProfilesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(84, 168)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(45, 204)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(44, 240)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Last Name:"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(48, 276)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(57, 13)
        Me.lblSex.TabIndex = 7
        Me.lblSex.Text = "Sex (M/F):"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(76, 312)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 9
        Me.lblAge.Text = "Age:"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(47, 348)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(58, 13)
        Me.lblHeight.TabIndex = 11
        Me.lblHeight.Text = "Height (in):"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(44, 384)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(61, 13)
        Me.lblWeight.TabIndex = 13
        Me.lblWeight.Text = "Weight (lb):"
        '
        'lblGoalWeight
        '
        Me.lblGoalWeight.AutoSize = True
        Me.lblGoalWeight.Location = New System.Drawing.Point(36, 420)
        Me.lblGoalWeight.Name = "lblGoalWeight"
        Me.lblGoalWeight.Size = New System.Drawing.Size(69, 13)
        Me.lblGoalWeight.TabIndex = 15
        Me.lblGoalWeight.Text = "Goal Weight:"
        '
        'lblGoalDate
        '
        Me.lblGoalDate.AutoSize = True
        Me.lblGoalDate.Location = New System.Drawing.Point(47, 456)
        Me.lblGoalDate.Name = "lblGoalDate"
        Me.lblGoalDate.Size = New System.Drawing.Size(58, 13)
        Me.lblGoalDate.TabIndex = 17
        Me.lblGoalDate.Text = "Goal Date:"
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.Location = New System.Drawing.Point(76, 492)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(29, 13)
        Me.lblBMI.TabIndex = 27
        Me.lblBMI.Text = "BMI:"
        '
        'EatFitDatabaseDataSet
        '
        Me.EatFitDatabaseDataSet.DataSetName = "EatFitDatabaseDataSet"
        Me.EatFitDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserProfilesBindingSource
        '
        Me.UserProfilesBindingSource.DataMember = "UserProfiles"
        Me.UserProfilesBindingSource.DataSource = Me.EatFitDatabaseDataSet
        '
        'UserProfilesTableAdapter
        '
        Me.UserProfilesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.EatFitDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserProfilesTableAdapter = Me.UserProfilesTableAdapter
        '
        'UserProfilesBindingNavigator
        '
        Me.UserProfilesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserProfilesBindingNavigator.BindingSource = Me.UserProfilesBindingSource
        Me.UserProfilesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserProfilesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserProfilesBindingNavigator.Enabled = False
        Me.UserProfilesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserProfilesBindingNavigatorSaveItem})
        Me.UserProfilesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserProfilesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserProfilesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserProfilesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserProfilesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserProfilesBindingNavigator.Name = "UserProfilesBindingNavigator"
        Me.UserProfilesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserProfilesBindingNavigator.Size = New System.Drawing.Size(629, 25)
        Me.UserProfilesBindingNavigator.TabIndex = 0
        Me.UserProfilesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'UserProfilesBindingNavigatorSaveItem
        '
        Me.UserProfilesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserProfilesBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserProfilesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserProfilesBindingNavigatorSaveItem.Name = "UserProfilesBindingNavigatorSaveItem"
        Me.UserProfilesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UserProfilesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "ID", True))
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(124, 164)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 2
        Me.txtID.TabStop = False
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "First Name", True))
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Location = New System.Drawing.Point(124, 200)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 4
        Me.txtFirstName.TabStop = False
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Last Name", True))
        Me.txtLastName.Enabled = False
        Me.txtLastName.Location = New System.Drawing.Point(124, 236)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 6
        Me.txtLastName.TabStop = False
        '
        'txtSex
        '
        Me.txtSex.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Sex (M/F)", True))
        Me.txtSex.Enabled = False
        Me.txtSex.Location = New System.Drawing.Point(124, 272)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(100, 20)
        Me.txtSex.TabIndex = 8
        Me.txtSex.TabStop = False
        '
        'txtAge
        '
        Me.txtAge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Age", True))
        Me.txtAge.Enabled = False
        Me.txtAge.Location = New System.Drawing.Point(124, 308)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAge.TabIndex = 10
        Me.txtAge.TabStop = False
        '
        'txtHeight
        '
        Me.txtHeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Height (in)", True))
        Me.txtHeight.Enabled = False
        Me.txtHeight.Location = New System.Drawing.Point(124, 344)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 12
        Me.txtHeight.TabStop = False
        '
        'txtWeight
        '
        Me.txtWeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Weight (lb)", True))
        Me.txtWeight.Enabled = False
        Me.txtWeight.Location = New System.Drawing.Point(124, 380)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 14
        Me.txtWeight.TabStop = False
        '
        'txtGoalWeight
        '
        Me.txtGoalWeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Goal Weight", True))
        Me.txtGoalWeight.Enabled = False
        Me.txtGoalWeight.Location = New System.Drawing.Point(124, 416)
        Me.txtGoalWeight.Name = "txtGoalWeight"
        Me.txtGoalWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtGoalWeight.TabIndex = 16
        Me.txtGoalWeight.TabStop = False
        '
        'datGoalDate
        '
        Me.datGoalDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserProfilesBindingSource, "Goal Date", True))
        Me.datGoalDate.Enabled = False
        Me.datGoalDate.Location = New System.Drawing.Point(124, 452)
        Me.datGoalDate.Name = "datGoalDate"
        Me.datGoalDate.Size = New System.Drawing.Size(200, 20)
        Me.datGoalDate.TabIndex = 18
        '
        'chkNoRestrictions
        '
        Me.chkNoRestrictions.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "No Restrictions", True))
        Me.chkNoRestrictions.Enabled = False
        Me.chkNoRestrictions.Location = New System.Drawing.Point(363, 157)
        Me.chkNoRestrictions.Name = "chkNoRestrictions"
        Me.chkNoRestrictions.Size = New System.Drawing.Size(118, 24)
        Me.chkNoRestrictions.TabIndex = 20
        Me.chkNoRestrictions.Text = "No Restrictions"
        Me.chkNoRestrictions.UseVisualStyleBackColor = True
        '
        'chkVegetarian
        '
        Me.chkVegetarian.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Vegetarian", True))
        Me.chkVegetarian.Enabled = False
        Me.chkVegetarian.Location = New System.Drawing.Point(363, 183)
        Me.chkVegetarian.Name = "chkVegetarian"
        Me.chkVegetarian.Size = New System.Drawing.Size(104, 24)
        Me.chkVegetarian.TabIndex = 22
        Me.chkVegetarian.Text = "Vegetarian"
        Me.chkVegetarian.UseVisualStyleBackColor = True
        '
        'chkVegan
        '
        Me.chkVegan.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Vegan", True))
        Me.chkVegan.Enabled = False
        Me.chkVegan.Location = New System.Drawing.Point(363, 209)
        Me.chkVegan.Name = "chkVegan"
        Me.chkVegan.Size = New System.Drawing.Size(104, 24)
        Me.chkVegan.TabIndex = 24
        Me.chkVegan.Text = "Vegan"
        Me.chkVegan.UseVisualStyleBackColor = True
        '
        'chkGlutenFree
        '
        Me.chkGlutenFree.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Gluten Free", True))
        Me.chkGlutenFree.Enabled = False
        Me.chkGlutenFree.Location = New System.Drawing.Point(363, 235)
        Me.chkGlutenFree.Name = "chkGlutenFree"
        Me.chkGlutenFree.Size = New System.Drawing.Size(104, 24)
        Me.chkGlutenFree.TabIndex = 26
        Me.chkGlutenFree.Text = "Gluten Free"
        Me.chkGlutenFree.UseVisualStyleBackColor = True
        '
        'txtBMI
        '
        Me.txtBMI.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtBMI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "BMI", True))
        Me.txtBMI.Enabled = False
        Me.txtBMI.Location = New System.Drawing.Point(124, 488)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.ReadOnly = True
        Me.txtBMI.Size = New System.Drawing.Size(100, 20)
        Me.txtBMI.TabIndex = 28
        '
        'chkPeanut
        '
        Me.chkPeanut.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Peanut Allergy", True))
        Me.chkPeanut.Enabled = False
        Me.chkPeanut.Location = New System.Drawing.Point(487, 157)
        Me.chkPeanut.Name = "chkPeanut"
        Me.chkPeanut.Size = New System.Drawing.Size(104, 24)
        Me.chkPeanut.TabIndex = 30
        Me.chkPeanut.Text = "Peanut Allergy"
        Me.chkPeanut.UseVisualStyleBackColor = True
        '
        'chkTreeNut
        '
        Me.chkTreeNut.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Tree Nut Allergy", True))
        Me.chkTreeNut.Enabled = False
        Me.chkTreeNut.Location = New System.Drawing.Point(487, 183)
        Me.chkTreeNut.Name = "chkTreeNut"
        Me.chkTreeNut.Size = New System.Drawing.Size(104, 24)
        Me.chkTreeNut.TabIndex = 32
        Me.chkTreeNut.Text = "Tree Nut Allergy"
        Me.chkTreeNut.UseVisualStyleBackColor = True
        '
        'chkSoy
        '
        Me.chkSoy.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Soy Allergy", True))
        Me.chkSoy.Enabled = False
        Me.chkSoy.Location = New System.Drawing.Point(487, 209)
        Me.chkSoy.Name = "chkSoy"
        Me.chkSoy.Size = New System.Drawing.Size(104, 24)
        Me.chkSoy.TabIndex = 34
        Me.chkSoy.Text = "Soy Allergy"
        Me.chkSoy.UseVisualStyleBackColor = True
        '
        'chkEgg
        '
        Me.chkEgg.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Egg Allergy", True))
        Me.chkEgg.Enabled = False
        Me.chkEgg.Location = New System.Drawing.Point(487, 235)
        Me.chkEgg.Name = "chkEgg"
        Me.chkEgg.Size = New System.Drawing.Size(104, 24)
        Me.chkEgg.TabIndex = 36
        Me.chkEgg.Text = "Egg Allergy"
        Me.chkEgg.UseVisualStyleBackColor = True
        '
        'chkFish
        '
        Me.chkFish.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Fish Allergy", True))
        Me.chkFish.Enabled = False
        Me.chkFish.Location = New System.Drawing.Point(487, 261)
        Me.chkFish.Name = "chkFish"
        Me.chkFish.Size = New System.Drawing.Size(104, 24)
        Me.chkFish.TabIndex = 38
        Me.chkFish.Text = "Fish Allergy"
        Me.chkFish.UseVisualStyleBackColor = True
        '
        'chkShellfish
        '
        Me.chkShellfish.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Shellfish Allergy", True))
        Me.chkShellfish.Enabled = False
        Me.chkShellfish.Location = New System.Drawing.Point(487, 287)
        Me.chkShellfish.Name = "chkShellfish"
        Me.chkShellfish.Size = New System.Drawing.Size(104, 24)
        Me.chkShellfish.TabIndex = 40
        Me.chkShellfish.Text = "Shellfish Allergy"
        Me.chkShellfish.UseVisualStyleBackColor = True
        '
        'chkLactose
        '
        Me.chkLactose.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Lactose Allergy", True))
        Me.chkLactose.Enabled = False
        Me.chkLactose.Location = New System.Drawing.Point(487, 313)
        Me.chkLactose.Name = "chkLactose"
        Me.chkLactose.Size = New System.Drawing.Size(104, 24)
        Me.chkLactose.TabIndex = 42
        Me.chkLactose.Text = "Lactose Allergy"
        Me.chkLactose.UseVisualStyleBackColor = True
        '
        'chkWheat
        '
        Me.chkWheat.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Wheat Allergy", True))
        Me.chkWheat.Enabled = False
        Me.chkWheat.Location = New System.Drawing.Point(487, 339)
        Me.chkWheat.Name = "chkWheat"
        Me.chkWheat.Size = New System.Drawing.Size(104, 24)
        Me.chkWheat.TabIndex = 44
        Me.chkWheat.Text = "Wheat Allergy"
        Me.chkWheat.UseVisualStyleBackColor = True
        '
        'btnBMI
        '
        Me.btnBMI.Enabled = False
        Me.btnBMI.Location = New System.Drawing.Point(230, 486)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(157, 23)
        Me.btnBMI.TabIndex = 45
        Me.btnBMI.Text = "Calculate BMI"
        Me.btnBMI.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(33, 112)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(235, 36)
        Me.lblTitle.TabIndex = 46
        Me.lblTitle.Text = "Profile Attributes"
        '
        'lblRestrictions
        '
        Me.lblRestrictions.AutoSize = True
        Me.lblRestrictions.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestrictions.Location = New System.Drawing.Point(386, 112)
        Me.lblRestrictions.Name = "lblRestrictions"
        Me.lblRestrictions.Size = New System.Drawing.Size(172, 36)
        Me.lblRestrictions.TabIndex = 47
        Me.lblRestrictions.Text = "Restrictions"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(135, 49)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(359, 46)
        Me.lblWelcome.TabIndex = 48
        Me.lblWelcome.Text = "Welcome to Eat Fit"
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
        Me.btnNext.Location = New System.Drawing.Point(479, 504)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(138, 45)
        Me.btnNext.TabIndex = 49
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnNewUser
        '
        Me.btnNewUser.Location = New System.Drawing.Point(285, 322)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(130, 39)
        Me.btnNewUser.TabIndex = 50
        Me.btnNewUser.Text = "New User"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(285, 371)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 39)
        Me.btnDelete.TabIndex = 51
        Me.btnDelete.Text = "Delete Profile"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReturningUser
        '
        Me.btnReturningUser.Location = New System.Drawing.Point(285, 272)
        Me.btnReturningUser.Name = "btnReturningUser"
        Me.btnReturningUser.Size = New System.Drawing.Size(130, 39)
        Me.btnReturningUser.TabIndex = 52
        Me.btnReturningUser.Text = "Returning User"
        Me.btnReturningUser.UseVisualStyleBackColor = True
        '
        'btnTempNav
        '
        Me.btnTempNav.Location = New System.Drawing.Point(12, 526)
        Me.btnTempNav.Name = "btnTempNav"
        Me.btnTempNav.Size = New System.Drawing.Size(167, 23)
        Me.btnTempNav.TabIndex = 53
        Me.btnTempNav.Text = "temporary dev navigation ->"
        Me.btnTempNav.UseVisualStyleBackColor = True
        '
        'NewProfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(629, 561)
        Me.Controls.Add(Me.btnTempNav)
        Me.Controls.Add(Me.btnReturningUser)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblRestrictions)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnBMI)
        Me.Controls.Add(Me.chkWheat)
        Me.Controls.Add(Me.chkLactose)
        Me.Controls.Add(Me.chkShellfish)
        Me.Controls.Add(Me.chkFish)
        Me.Controls.Add(Me.chkEgg)
        Me.Controls.Add(Me.chkSoy)
        Me.Controls.Add(Me.chkTreeNut)
        Me.Controls.Add(Me.chkPeanut)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.txtBMI)
        Me.Controls.Add(Me.chkGlutenFree)
        Me.Controls.Add(Me.chkVegan)
        Me.Controls.Add(Me.chkVegetarian)
        Me.Controls.Add(Me.chkNoRestrictions)
        Me.Controls.Add(Me.lblGoalDate)
        Me.Controls.Add(Me.datGoalDate)
        Me.Controls.Add(Me.lblGoalWeight)
        Me.Controls.Add(Me.txtGoalWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.UserProfilesBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "NewProfiles"
        Me.Text = "Eat Fit"
        CType(Me.EatFitDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserProfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserProfilesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserProfilesBindingNavigator.ResumeLayout(False)
        Me.UserProfilesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EatFitDatabaseDataSet As EatFitDatabaseDataSet
    Friend WithEvents UserProfilesBindingSource As BindingSource
    Friend WithEvents UserProfilesTableAdapter As EatFitDatabaseDataSetTableAdapters.UserProfilesTableAdapter
    Friend WithEvents TableAdapterManager As EatFitDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserProfilesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents UserProfilesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtSex As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtGoalWeight As TextBox
    Friend WithEvents datGoalDate As DateTimePicker
    Friend WithEvents chkNoRestrictions As CheckBox
    Friend WithEvents chkVegetarian As CheckBox
    Friend WithEvents chkVegan As CheckBox
    Friend WithEvents chkGlutenFree As CheckBox
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents chkPeanut As CheckBox
    Friend WithEvents chkTreeNut As CheckBox
    Friend WithEvents chkSoy As CheckBox
    Friend WithEvents chkEgg As CheckBox
    Friend WithEvents chkFish As CheckBox
    Friend WithEvents chkShellfish As CheckBox
    Friend WithEvents chkLactose As CheckBox
    Friend WithEvents chkWheat As CheckBox
    Friend WithEvents btnBMI As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRestrictions As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents lblID As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblGoalWeight As Label
    Friend WithEvents lblGoalDate As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents btnNewUser As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnReturningUser As Button
    Friend WithEvents btnTempNav As Button
End Class
