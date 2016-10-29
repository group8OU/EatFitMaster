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
        Dim lblID As System.Windows.Forms.Label
        Dim lblFirstName As System.Windows.Forms.Label
        Dim lblLastName As System.Windows.Forms.Label
        Dim lblSex As System.Windows.Forms.Label
        Dim lblAge As System.Windows.Forms.Label
        Dim lblHeight As System.Windows.Forms.Label
        Dim lblWeight As System.Windows.Forms.Label
        Dim lblGoalWeight As System.Windows.Forms.Label
        Dim lblGoalDate As System.Windows.Forms.Label
        Dim lblBMI As System.Windows.Forms.Label
        Me.EatFitDatabaseDataSet = New WindowsApplication1.EatFitDatabaseDataSet()
        Me.UserProfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserProfilesTableAdapter = New WindowsApplication1.EatFitDatabaseDataSetTableAdapters.UserProfilesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.EatFitDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.UserProfilesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
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
        Me.No_RestrictionsCheckBox = New System.Windows.Forms.CheckBox()
        Me.VegetarianCheckBox = New System.Windows.Forms.CheckBox()
        Me.VeganCheckBox = New System.Windows.Forms.CheckBox()
        Me.Gluten_FreeCheckBox = New System.Windows.Forms.CheckBox()
        Me.txtBMI = New System.Windows.Forms.TextBox()
        Me.Peanut_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Tree_Nut_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Soy_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Egg_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Fish_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Shellfish_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Lactose_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Wheat_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRestrictions = New System.Windows.Forms.Label()
        lblID = New System.Windows.Forms.Label()
        lblFirstName = New System.Windows.Forms.Label()
        lblLastName = New System.Windows.Forms.Label()
        lblSex = New System.Windows.Forms.Label()
        lblAge = New System.Windows.Forms.Label()
        lblHeight = New System.Windows.Forms.Label()
        lblWeight = New System.Windows.Forms.Label()
        lblGoalWeight = New System.Windows.Forms.Label()
        lblGoalDate = New System.Windows.Forms.Label()
        lblBMI = New System.Windows.Forms.Label()
        CType(Me.EatFitDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfilesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserProfilesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'UserProfilesBindingNavigatorSaveItem
        '
        Me.UserProfilesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserProfilesBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserProfilesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserProfilesBindingNavigatorSaveItem.Name = "UserProfilesBindingNavigatorSaveItem"
        Me.UserProfilesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UserProfilesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'lblID
        '
        lblID.AutoSize = True
        lblID.Location = New System.Drawing.Point(81, 98)
        lblID.Name = "lblID"
        lblID.Size = New System.Drawing.Size(21, 13)
        lblID.TabIndex = 1
        lblID.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "ID", True))
        Me.txtID.Location = New System.Drawing.Point(121, 94)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 2
        '
        'lblFirstName
        '
        lblFirstName.AutoSize = True
        lblFirstName.Location = New System.Drawing.Point(42, 134)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New System.Drawing.Size(60, 13)
        lblFirstName.TabIndex = 3
        lblFirstName.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "First Name", True))
        Me.txtFirstName.Location = New System.Drawing.Point(121, 130)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 4
        '
        'lblLastName
        '
        lblLastName.AutoSize = True
        lblLastName.Location = New System.Drawing.Point(41, 170)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New System.Drawing.Size(61, 13)
        lblLastName.TabIndex = 5
        lblLastName.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Last Name", True))
        Me.txtLastName.Location = New System.Drawing.Point(121, 166)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 6
        '
        'lblSex
        '
        lblSex.AutoSize = True
        lblSex.Location = New System.Drawing.Point(45, 206)
        lblSex.Name = "lblSex"
        lblSex.Size = New System.Drawing.Size(57, 13)
        lblSex.TabIndex = 7
        lblSex.Text = "Sex (M/F):"
        '
        'txtSex
        '
        Me.txtSex.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Sex (M/F)", True))
        Me.txtSex.Location = New System.Drawing.Point(121, 202)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(100, 20)
        Me.txtSex.TabIndex = 8
        '
        'lblAge
        '
        lblAge.AutoSize = True
        lblAge.Location = New System.Drawing.Point(73, 242)
        lblAge.Name = "lblAge"
        lblAge.Size = New System.Drawing.Size(29, 13)
        lblAge.TabIndex = 9
        lblAge.Text = "Age:"
        '
        'txtAge
        '
        Me.txtAge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Age", True))
        Me.txtAge.Location = New System.Drawing.Point(121, 238)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAge.TabIndex = 10
        '
        'lblHeight
        '
        lblHeight.AutoSize = True
        lblHeight.Location = New System.Drawing.Point(44, 278)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New System.Drawing.Size(58, 13)
        lblHeight.TabIndex = 11
        lblHeight.Text = "Height (in):"
        '
        'txtHeight
        '
        Me.txtHeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Height (in)", True))
        Me.txtHeight.Location = New System.Drawing.Point(121, 274)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 12
        '
        'lblWeight
        '
        lblWeight.AutoSize = True
        lblWeight.Location = New System.Drawing.Point(41, 314)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New System.Drawing.Size(61, 13)
        lblWeight.TabIndex = 13
        lblWeight.Text = "Weight (lb):"
        '
        'txtWeight
        '
        Me.txtWeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Weight (lb)", True))
        Me.txtWeight.Location = New System.Drawing.Point(121, 310)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 14
        '
        'lblGoalWeight
        '
        lblGoalWeight.AutoSize = True
        lblGoalWeight.Location = New System.Drawing.Point(33, 350)
        lblGoalWeight.Name = "lblGoalWeight"
        lblGoalWeight.Size = New System.Drawing.Size(69, 13)
        lblGoalWeight.TabIndex = 15
        lblGoalWeight.Text = "Goal Weight:"
        '
        'txtGoalWeight
        '
        Me.txtGoalWeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Goal Weight", True))
        Me.txtGoalWeight.Location = New System.Drawing.Point(121, 346)
        Me.txtGoalWeight.Name = "txtGoalWeight"
        Me.txtGoalWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtGoalWeight.TabIndex = 16
        '
        'lblGoalDate
        '
        lblGoalDate.AutoSize = True
        lblGoalDate.Location = New System.Drawing.Point(44, 386)
        lblGoalDate.Name = "lblGoalDate"
        lblGoalDate.Size = New System.Drawing.Size(58, 13)
        lblGoalDate.TabIndex = 17
        lblGoalDate.Text = "Goal Date:"
        '
        'datGoalDate
        '
        Me.datGoalDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserProfilesBindingSource, "Goal Date", True))
        Me.datGoalDate.Location = New System.Drawing.Point(121, 382)
        Me.datGoalDate.Name = "datGoalDate"
        Me.datGoalDate.Size = New System.Drawing.Size(200, 20)
        Me.datGoalDate.TabIndex = 18
        '
        'No_RestrictionsCheckBox
        '
        Me.No_RestrictionsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "No Restrictions", True))
        Me.No_RestrictionsCheckBox.Location = New System.Drawing.Point(360, 87)
        Me.No_RestrictionsCheckBox.Name = "No_RestrictionsCheckBox"
        Me.No_RestrictionsCheckBox.Size = New System.Drawing.Size(118, 24)
        Me.No_RestrictionsCheckBox.TabIndex = 20
        Me.No_RestrictionsCheckBox.Text = "No Restrictions"
        Me.No_RestrictionsCheckBox.UseVisualStyleBackColor = True
        '
        'VegetarianCheckBox
        '
        Me.VegetarianCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Vegetarian", True))
        Me.VegetarianCheckBox.Location = New System.Drawing.Point(360, 113)
        Me.VegetarianCheckBox.Name = "VegetarianCheckBox"
        Me.VegetarianCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.VegetarianCheckBox.TabIndex = 22
        Me.VegetarianCheckBox.Text = "Vegetarian"
        Me.VegetarianCheckBox.UseVisualStyleBackColor = True
        '
        'VeganCheckBox
        '
        Me.VeganCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Vegan", True))
        Me.VeganCheckBox.Location = New System.Drawing.Point(360, 139)
        Me.VeganCheckBox.Name = "VeganCheckBox"
        Me.VeganCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.VeganCheckBox.TabIndex = 24
        Me.VeganCheckBox.Text = "Vegan"
        Me.VeganCheckBox.UseVisualStyleBackColor = True
        '
        'Gluten_FreeCheckBox
        '
        Me.Gluten_FreeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Gluten Free", True))
        Me.Gluten_FreeCheckBox.Location = New System.Drawing.Point(360, 165)
        Me.Gluten_FreeCheckBox.Name = "Gluten_FreeCheckBox"
        Me.Gluten_FreeCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Gluten_FreeCheckBox.TabIndex = 26
        Me.Gluten_FreeCheckBox.Text = "Gluten Free"
        Me.Gluten_FreeCheckBox.UseVisualStyleBackColor = True
        '
        'lblBMI
        '
        lblBMI.AutoSize = True
        lblBMI.Location = New System.Drawing.Point(73, 422)
        lblBMI.Name = "lblBMI"
        lblBMI.Size = New System.Drawing.Size(29, 13)
        lblBMI.TabIndex = 27
        lblBMI.Text = "BMI:"
        '
        'txtBMI
        '
        Me.txtBMI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "BMI", True))
        Me.txtBMI.Location = New System.Drawing.Point(121, 418)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.Size = New System.Drawing.Size(100, 20)
        Me.txtBMI.TabIndex = 28
        '
        'Peanut_AllergyCheckBox
        '
        Me.Peanut_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Peanut Allergy", True))
        Me.Peanut_AllergyCheckBox.Location = New System.Drawing.Point(484, 87)
        Me.Peanut_AllergyCheckBox.Name = "Peanut_AllergyCheckBox"
        Me.Peanut_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Peanut_AllergyCheckBox.TabIndex = 30
        Me.Peanut_AllergyCheckBox.Text = "Peanut Allergy"
        Me.Peanut_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Tree_Nut_AllergyCheckBox
        '
        Me.Tree_Nut_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Tree Nut Allergy", True))
        Me.Tree_Nut_AllergyCheckBox.Location = New System.Drawing.Point(484, 113)
        Me.Tree_Nut_AllergyCheckBox.Name = "Tree_Nut_AllergyCheckBox"
        Me.Tree_Nut_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Tree_Nut_AllergyCheckBox.TabIndex = 32
        Me.Tree_Nut_AllergyCheckBox.Text = "Tree Nut Allergy"
        Me.Tree_Nut_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Soy_AllergyCheckBox
        '
        Me.Soy_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Soy Allergy", True))
        Me.Soy_AllergyCheckBox.Location = New System.Drawing.Point(484, 139)
        Me.Soy_AllergyCheckBox.Name = "Soy_AllergyCheckBox"
        Me.Soy_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Soy_AllergyCheckBox.TabIndex = 34
        Me.Soy_AllergyCheckBox.Text = "Soy Allergy"
        Me.Soy_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Egg_AllergyCheckBox
        '
        Me.Egg_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Egg Allergy", True))
        Me.Egg_AllergyCheckBox.Location = New System.Drawing.Point(484, 165)
        Me.Egg_AllergyCheckBox.Name = "Egg_AllergyCheckBox"
        Me.Egg_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Egg_AllergyCheckBox.TabIndex = 36
        Me.Egg_AllergyCheckBox.Text = "Egg Allergy"
        Me.Egg_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Fish_AllergyCheckBox
        '
        Me.Fish_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Fish Allergy", True))
        Me.Fish_AllergyCheckBox.Location = New System.Drawing.Point(484, 191)
        Me.Fish_AllergyCheckBox.Name = "Fish_AllergyCheckBox"
        Me.Fish_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Fish_AllergyCheckBox.TabIndex = 38
        Me.Fish_AllergyCheckBox.Text = "Fish Allergy"
        Me.Fish_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Shellfish_AllergyCheckBox
        '
        Me.Shellfish_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Shellfish Allergy", True))
        Me.Shellfish_AllergyCheckBox.Location = New System.Drawing.Point(484, 217)
        Me.Shellfish_AllergyCheckBox.Name = "Shellfish_AllergyCheckBox"
        Me.Shellfish_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Shellfish_AllergyCheckBox.TabIndex = 40
        Me.Shellfish_AllergyCheckBox.Text = "Shellfish Allergy"
        Me.Shellfish_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Lactose_AllergyCheckBox
        '
        Me.Lactose_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Lactose Allergy", True))
        Me.Lactose_AllergyCheckBox.Location = New System.Drawing.Point(484, 243)
        Me.Lactose_AllergyCheckBox.Name = "Lactose_AllergyCheckBox"
        Me.Lactose_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Lactose_AllergyCheckBox.TabIndex = 42
        Me.Lactose_AllergyCheckBox.Text = "Lactose Allergy"
        Me.Lactose_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Wheat_AllergyCheckBox
        '
        Me.Wheat_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Wheat Allergy", True))
        Me.Wheat_AllergyCheckBox.Location = New System.Drawing.Point(484, 269)
        Me.Wheat_AllergyCheckBox.Name = "Wheat_AllergyCheckBox"
        Me.Wheat_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Wheat_AllergyCheckBox.TabIndex = 44
        Me.Wheat_AllergyCheckBox.Text = "Wheat Allergy"
        Me.Wheat_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'btnBMI
        '
        Me.btnBMI.Location = New System.Drawing.Point(227, 416)
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
        Me.lblTitle.Location = New System.Drawing.Point(12, 42)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(235, 36)
        Me.lblTitle.TabIndex = 46
        Me.lblTitle.Text = "Profile Attributes"
        '
        'lblRestrictions
        '
        Me.lblRestrictions.AutoSize = True
        Me.lblRestrictions.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestrictions.Location = New System.Drawing.Point(353, 42)
        Me.lblRestrictions.Name = "lblRestrictions"
        Me.lblRestrictions.Size = New System.Drawing.Size(172, 36)
        Me.lblRestrictions.TabIndex = 47
        Me.lblRestrictions.Text = "Restrictions"
        '
        'NewProfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 480)
        Me.Controls.Add(Me.lblRestrictions)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnBMI)
        Me.Controls.Add(Me.Wheat_AllergyCheckBox)
        Me.Controls.Add(Me.Lactose_AllergyCheckBox)
        Me.Controls.Add(Me.Shellfish_AllergyCheckBox)
        Me.Controls.Add(Me.Fish_AllergyCheckBox)
        Me.Controls.Add(Me.Egg_AllergyCheckBox)
        Me.Controls.Add(Me.Soy_AllergyCheckBox)
        Me.Controls.Add(Me.Tree_Nut_AllergyCheckBox)
        Me.Controls.Add(Me.Peanut_AllergyCheckBox)
        Me.Controls.Add(lblBMI)
        Me.Controls.Add(Me.txtBMI)
        Me.Controls.Add(Me.Gluten_FreeCheckBox)
        Me.Controls.Add(Me.VeganCheckBox)
        Me.Controls.Add(Me.VegetarianCheckBox)
        Me.Controls.Add(Me.No_RestrictionsCheckBox)
        Me.Controls.Add(lblGoalDate)
        Me.Controls.Add(Me.datGoalDate)
        Me.Controls.Add(lblGoalWeight)
        Me.Controls.Add(Me.txtGoalWeight)
        Me.Controls.Add(lblWeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(lblHeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(lblAge)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(lblSex)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(lblID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.UserProfilesBindingNavigator)
        Me.Name = "NewProfiles"
        Me.Text = "NewProfiles"
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
    Friend WithEvents No_RestrictionsCheckBox As CheckBox
    Friend WithEvents VegetarianCheckBox As CheckBox
    Friend WithEvents VeganCheckBox As CheckBox
    Friend WithEvents Gluten_FreeCheckBox As CheckBox
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents Peanut_AllergyCheckBox As CheckBox
    Friend WithEvents Tree_Nut_AllergyCheckBox As CheckBox
    Friend WithEvents Soy_AllergyCheckBox As CheckBox
    Friend WithEvents Egg_AllergyCheckBox As CheckBox
    Friend WithEvents Fish_AllergyCheckBox As CheckBox
    Friend WithEvents Shellfish_AllergyCheckBox As CheckBox
    Friend WithEvents Lactose_AllergyCheckBox As CheckBox
    Friend WithEvents Wheat_AllergyCheckBox As CheckBox
    Friend WithEvents btnBMI As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRestrictions As Label
End Class
