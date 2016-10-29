<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProfile
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
        Dim lblFirstName As System.Windows.Forms.Label
        Dim lblLastName As System.Windows.Forms.Label
        Dim lblSex As System.Windows.Forms.Label
        Dim lblHeight As System.Windows.Forms.Label
        Dim lblWeight As System.Windows.Forms.Label
        Dim lblGoalWeight As System.Windows.Forms.Label
        Dim lblGluten As System.Windows.Forms.Label
        Dim lblPeanut As System.Windows.Forms.Label
        Dim lblTreeNut As System.Windows.Forms.Label
        Dim lblSoy As System.Windows.Forms.Label
        Dim lblEgg As System.Windows.Forms.Label
        Dim lblFish As System.Windows.Forms.Label
        Dim lblShellfish As System.Windows.Forms.Label
        Dim lblLactose As System.Windows.Forms.Label
        Dim lblWheat As System.Windows.Forms.Label
        Dim lblNoRestrictions As System.Windows.Forms.Label
        Dim lblVegetarian As System.Windows.Forms.Label
        Dim lblVegan As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewProfile))
        Dim lblAge As System.Windows.Forms.Label
        Dim lblGoalDate As System.Windows.Forms.Label
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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtGoalWeight = New System.Windows.Forms.TextBox()
        Me.chkGluten = New System.Windows.Forms.CheckBox()
        Me.chkPeanut = New System.Windows.Forms.CheckBox()
        Me.chkTreeNut = New System.Windows.Forms.CheckBox()
        Me.chkSoy = New System.Windows.Forms.CheckBox()
        Me.chkEgg = New System.Windows.Forms.CheckBox()
        Me.chkFish = New System.Windows.Forms.CheckBox()
        Me.chkShellfish = New System.Windows.Forms.CheckBox()
        Me.chkLactose = New System.Windows.Forms.CheckBox()
        Me.chkWheat = New System.Windows.Forms.CheckBox()
        Me.chkNoRestrictions = New System.Windows.Forms.CheckBox()
        Me.chkVegetarian = New System.Windows.Forms.CheckBox()
        Me.chkVegan = New System.Windows.Forms.CheckBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.datGoalDate = New System.Windows.Forms.DateTimePicker()
        lblFirstName = New System.Windows.Forms.Label()
        lblLastName = New System.Windows.Forms.Label()
        lblSex = New System.Windows.Forms.Label()
        lblHeight = New System.Windows.Forms.Label()
        lblWeight = New System.Windows.Forms.Label()
        lblGoalWeight = New System.Windows.Forms.Label()
        lblGluten = New System.Windows.Forms.Label()
        lblPeanut = New System.Windows.Forms.Label()
        lblTreeNut = New System.Windows.Forms.Label()
        lblSoy = New System.Windows.Forms.Label()
        lblEgg = New System.Windows.Forms.Label()
        lblFish = New System.Windows.Forms.Label()
        lblShellfish = New System.Windows.Forms.Label()
        lblLactose = New System.Windows.Forms.Label()
        lblWheat = New System.Windows.Forms.Label()
        lblNoRestrictions = New System.Windows.Forms.Label()
        lblVegetarian = New System.Windows.Forms.Label()
        lblVegan = New System.Windows.Forms.Label()
        lblAge = New System.Windows.Forms.Label()
        lblGoalDate = New System.Windows.Forms.Label()
        CType(Me.EatFitDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfilesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserProfilesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        lblFirstName.AutoSize = True
        lblFirstName.Location = New System.Drawing.Point(42, 51)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New System.Drawing.Size(60, 13)
        lblFirstName.TabIndex = 1
        lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        lblLastName.AutoSize = True
        lblLastName.Location = New System.Drawing.Point(42, 82)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New System.Drawing.Size(61, 13)
        lblLastName.TabIndex = 3
        lblLastName.Text = "Last Name:"
        '
        'lblSex
        '
        lblSex.AutoSize = True
        lblSex.Location = New System.Drawing.Point(42, 111)
        lblSex.Name = "lblSex"
        lblSex.Size = New System.Drawing.Size(57, 13)
        lblSex.TabIndex = 5
        lblSex.Text = "Sex (M/F):"
        '
        'lblHeight
        '
        lblHeight.AutoSize = True
        lblHeight.Location = New System.Drawing.Point(42, 174)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New System.Drawing.Size(58, 13)
        lblHeight.TabIndex = 9
        lblHeight.Text = "Height (in):"
        '
        'lblWeight
        '
        lblWeight.AutoSize = True
        lblWeight.Location = New System.Drawing.Point(42, 210)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New System.Drawing.Size(61, 13)
        lblWeight.TabIndex = 11
        lblWeight.Text = "Weight (lb):"
        '
        'lblGoalWeight
        '
        lblGoalWeight.AutoSize = True
        lblGoalWeight.Location = New System.Drawing.Point(42, 241)
        lblGoalWeight.Name = "lblGoalWeight"
        lblGoalWeight.Size = New System.Drawing.Size(69, 13)
        lblGoalWeight.TabIndex = 13
        lblGoalWeight.Text = "Goal Weight:"
        '
        'lblGluten
        '
        lblGluten.AutoSize = True
        lblGluten.Location = New System.Drawing.Point(504, 132)
        lblGluten.Name = "lblGluten"
        lblGluten.Size = New System.Drawing.Size(65, 13)
        lblGluten.TabIndex = 21
        lblGluten.Text = "Gluten Free:"
        '
        'lblPeanut
        '
        lblPeanut.AutoSize = True
        lblPeanut.Location = New System.Drawing.Point(491, 159)
        lblPeanut.Name = "lblPeanut"
        lblPeanut.Size = New System.Drawing.Size(78, 13)
        lblPeanut.TabIndex = 23
        lblPeanut.Text = "Peanut Allergy:"
        '
        'lblTreeNut
        '
        lblTreeNut.AutoSize = True
        lblTreeNut.Location = New System.Drawing.Point(483, 193)
        lblTreeNut.Name = "lblTreeNut"
        lblTreeNut.Size = New System.Drawing.Size(86, 13)
        lblTreeNut.TabIndex = 25
        lblTreeNut.Text = "Tree Nut Allergy:"
        '
        'lblSoy
        '
        lblSoy.AutoSize = True
        lblSoy.Location = New System.Drawing.Point(507, 219)
        lblSoy.Name = "lblSoy"
        lblSoy.Size = New System.Drawing.Size(62, 13)
        lblSoy.TabIndex = 27
        lblSoy.Text = "Soy Allergy:"
        '
        'lblEgg
        '
        lblEgg.AutoSize = True
        lblEgg.Location = New System.Drawing.Point(506, 248)
        lblEgg.Name = "lblEgg"
        lblEgg.Size = New System.Drawing.Size(63, 13)
        lblEgg.TabIndex = 29
        lblEgg.Text = "Egg Allergy:"
        '
        'lblFish
        '
        lblFish.AutoSize = True
        lblFish.Location = New System.Drawing.Point(506, 280)
        lblFish.Name = "lblFish"
        lblFish.Size = New System.Drawing.Size(63, 13)
        lblFish.TabIndex = 31
        lblFish.Text = "Fish Allergy:"
        '
        'lblShellfish
        '
        lblShellfish.AutoSize = True
        lblShellfish.Location = New System.Drawing.Point(486, 317)
        lblShellfish.Name = "lblShellfish"
        lblShellfish.Size = New System.Drawing.Size(83, 13)
        lblShellfish.TabIndex = 33
        lblShellfish.Text = "Shellfish Allergy:"
        '
        'lblLactose
        '
        lblLactose.AutoSize = True
        lblLactose.Location = New System.Drawing.Point(487, 351)
        lblLactose.Name = "lblLactose"
        lblLactose.Size = New System.Drawing.Size(82, 13)
        lblLactose.TabIndex = 35
        lblLactose.Text = "Lactose Allergy:"
        '
        'lblWheat
        '
        lblWheat.AutoSize = True
        lblWheat.Location = New System.Drawing.Point(493, 381)
        lblWheat.Name = "lblWheat"
        lblWheat.Size = New System.Drawing.Size(76, 13)
        lblWheat.TabIndex = 37
        lblWheat.Text = "Wheat Allergy:"
        '
        'lblNoRestrictions
        '
        lblNoRestrictions.AutoSize = True
        lblNoRestrictions.Location = New System.Drawing.Point(487, 33)
        lblNoRestrictions.Name = "lblNoRestrictions"
        lblNoRestrictions.Size = New System.Drawing.Size(82, 13)
        lblNoRestrictions.TabIndex = 39
        lblNoRestrictions.Text = "No Restrictions:"
        '
        'lblVegetarian
        '
        lblVegetarian.AutoSize = True
        lblVegetarian.Location = New System.Drawing.Point(508, 64)
        lblVegetarian.Name = "lblVegetarian"
        lblVegetarian.Size = New System.Drawing.Size(61, 13)
        lblVegetarian.TabIndex = 40
        lblVegetarian.Text = "Vegetarian:"
        '
        'lblVegan
        '
        lblVegan.AutoSize = True
        lblVegan.Location = New System.Drawing.Point(528, 104)
        lblVegan.Name = "lblVegan"
        lblVegan.Size = New System.Drawing.Size(41, 13)
        lblVegan.TabIndex = 41
        lblVegan.Text = "Vegan:"
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
        Me.UserProfilesBindingNavigator.Size = New System.Drawing.Size(802, 25)
        Me.UserProfilesBindingNavigator.TabIndex = 0
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
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "First Name", True))
        Me.txtFirstName.Location = New System.Drawing.Point(108, 48)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Last Name", True))
        Me.txtLastName.Location = New System.Drawing.Point(118, 79)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 4
        '
        'txtSex
        '
        Me.txtSex.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Sex (M/F)", True))
        Me.txtSex.Location = New System.Drawing.Point(119, 108)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(100, 20)
        Me.txtSex.TabIndex = 6
        '
        'txtHeight
        '
        Me.txtHeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Height (in)", True))
        Me.txtHeight.Location = New System.Drawing.Point(122, 171)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 10
        '
        'txtWeight
        '
        Me.txtWeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Weight (lb)", True))
        Me.txtWeight.Location = New System.Drawing.Point(129, 207)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 12
        '
        'txtGoalWeight
        '
        Me.txtGoalWeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Goal Weight", True))
        Me.txtGoalWeight.Location = New System.Drawing.Point(141, 238)
        Me.txtGoalWeight.Name = "txtGoalWeight"
        Me.txtGoalWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtGoalWeight.TabIndex = 14
        '
        'chkGluten
        '
        Me.chkGluten.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Gluten Free", True))
        Me.chkGluten.Location = New System.Drawing.Point(575, 127)
        Me.chkGluten.Name = "chkGluten"
        Me.chkGluten.Size = New System.Drawing.Size(104, 24)
        Me.chkGluten.TabIndex = 22
        Me.chkGluten.UseVisualStyleBackColor = True
        '
        'chkPeanut
        '
        Me.chkPeanut.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Peanut Allergy", True))
        Me.chkPeanut.Location = New System.Drawing.Point(575, 154)
        Me.chkPeanut.Name = "chkPeanut"
        Me.chkPeanut.Size = New System.Drawing.Size(104, 24)
        Me.chkPeanut.TabIndex = 24
        Me.chkPeanut.UseVisualStyleBackColor = True
        '
        'chkTreeNut
        '
        Me.chkTreeNut.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Tree Nut Allergy", True))
        Me.chkTreeNut.Location = New System.Drawing.Point(575, 188)
        Me.chkTreeNut.Name = "chkTreeNut"
        Me.chkTreeNut.Size = New System.Drawing.Size(104, 24)
        Me.chkTreeNut.TabIndex = 26
        Me.chkTreeNut.UseVisualStyleBackColor = True
        '
        'chkSoy
        '
        Me.chkSoy.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Soy Allergy", True))
        Me.chkSoy.Location = New System.Drawing.Point(575, 214)
        Me.chkSoy.Name = "chkSoy"
        Me.chkSoy.Size = New System.Drawing.Size(104, 24)
        Me.chkSoy.TabIndex = 28
        Me.chkSoy.UseVisualStyleBackColor = True
        '
        'chkEgg
        '
        Me.chkEgg.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Egg Allergy", True))
        Me.chkEgg.Location = New System.Drawing.Point(575, 243)
        Me.chkEgg.Name = "chkEgg"
        Me.chkEgg.Size = New System.Drawing.Size(104, 24)
        Me.chkEgg.TabIndex = 30
        Me.chkEgg.UseVisualStyleBackColor = True
        '
        'chkFish
        '
        Me.chkFish.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Fish Allergy", True))
        Me.chkFish.Location = New System.Drawing.Point(575, 275)
        Me.chkFish.Name = "chkFish"
        Me.chkFish.Size = New System.Drawing.Size(104, 24)
        Me.chkFish.TabIndex = 32
        Me.chkFish.UseVisualStyleBackColor = True
        '
        'chkShellfish
        '
        Me.chkShellfish.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Shellfish Allergy", True))
        Me.chkShellfish.Location = New System.Drawing.Point(575, 312)
        Me.chkShellfish.Name = "chkShellfish"
        Me.chkShellfish.Size = New System.Drawing.Size(104, 24)
        Me.chkShellfish.TabIndex = 34
        Me.chkShellfish.UseVisualStyleBackColor = True
        '
        'chkLactose
        '
        Me.chkLactose.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Lactose Allergy", True))
        Me.chkLactose.Location = New System.Drawing.Point(575, 346)
        Me.chkLactose.Name = "chkLactose"
        Me.chkLactose.Size = New System.Drawing.Size(104, 24)
        Me.chkLactose.TabIndex = 36
        Me.chkLactose.UseVisualStyleBackColor = True
        '
        'chkWheat
        '
        Me.chkWheat.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Wheat Allergy", True))
        Me.chkWheat.Location = New System.Drawing.Point(575, 376)
        Me.chkWheat.Name = "chkWheat"
        Me.chkWheat.Size = New System.Drawing.Size(104, 24)
        Me.chkWheat.TabIndex = 38
        Me.chkWheat.UseVisualStyleBackColor = True
        '
        'chkNoRestrictions
        '
        Me.chkNoRestrictions.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "No Restrictions", True))
        Me.chkNoRestrictions.Location = New System.Drawing.Point(575, 28)
        Me.chkNoRestrictions.Name = "chkNoRestrictions"
        Me.chkNoRestrictions.Size = New System.Drawing.Size(104, 24)
        Me.chkNoRestrictions.TabIndex = 40
        Me.chkNoRestrictions.UseVisualStyleBackColor = True
        '
        'chkVegetarian
        '
        Me.chkVegetarian.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Vegetarian", True))
        Me.chkVegetarian.Location = New System.Drawing.Point(575, 59)
        Me.chkVegetarian.Name = "chkVegetarian"
        Me.chkVegetarian.Size = New System.Drawing.Size(104, 24)
        Me.chkVegetarian.TabIndex = 41
        Me.chkVegetarian.UseVisualStyleBackColor = True
        '
        'chkVegan
        '
        Me.chkVegan.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Vegan", True))
        Me.chkVegan.Location = New System.Drawing.Point(575, 99)
        Me.chkVegan.Name = "chkVegan"
        Me.chkVegan.Size = New System.Drawing.Size(104, 24)
        Me.chkVegan.TabIndex = 42
        Me.chkVegan.UseVisualStyleBackColor = True
        '
        'lblAge
        '
        lblAge.AutoSize = True
        lblAge.Location = New System.Drawing.Point(42, 146)
        lblAge.Name = "lblAge"
        lblAge.Size = New System.Drawing.Size(29, 13)
        lblAge.TabIndex = 42
        lblAge.Text = "Age:"
        '
        'txtAge
        '
        Me.txtAge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Age", True))
        Me.txtAge.Location = New System.Drawing.Point(108, 143)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAge.TabIndex = 43
        '
        'lblGoalDate
        '
        lblGoalDate.AutoSize = True
        lblGoalDate.Location = New System.Drawing.Point(44, 362)
        lblGoalDate.Name = "lblGoalDate"
        lblGoalDate.Size = New System.Drawing.Size(58, 13)
        lblGoalDate.TabIndex = 43
        lblGoalDate.Text = "Goal Date:"
        AddHandler lblGoalDate.Click, AddressOf Me.Goal_DateLabel_Click
        '
        'datGoalDate
        '
        Me.datGoalDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserProfilesBindingSource, "Goal Date", True))
        Me.datGoalDate.Location = New System.Drawing.Point(108, 358)
        Me.datGoalDate.Name = "datGoalDate"
        Me.datGoalDate.Size = New System.Drawing.Size(200, 20)
        Me.datGoalDate.TabIndex = 44
        '
        'NewProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 427)
        Me.Controls.Add(lblGoalDate)
        Me.Controls.Add(Me.datGoalDate)
        Me.Controls.Add(lblAge)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(lblVegan)
        Me.Controls.Add(Me.chkVegan)
        Me.Controls.Add(lblVegetarian)
        Me.Controls.Add(Me.chkVegetarian)
        Me.Controls.Add(lblNoRestrictions)
        Me.Controls.Add(Me.chkNoRestrictions)
        Me.Controls.Add(lblWheat)
        Me.Controls.Add(Me.chkWheat)
        Me.Controls.Add(lblLactose)
        Me.Controls.Add(Me.chkLactose)
        Me.Controls.Add(lblShellfish)
        Me.Controls.Add(Me.chkShellfish)
        Me.Controls.Add(lblFish)
        Me.Controls.Add(Me.chkFish)
        Me.Controls.Add(lblEgg)
        Me.Controls.Add(Me.chkEgg)
        Me.Controls.Add(lblSoy)
        Me.Controls.Add(Me.chkSoy)
        Me.Controls.Add(lblTreeNut)
        Me.Controls.Add(Me.chkTreeNut)
        Me.Controls.Add(lblPeanut)
        Me.Controls.Add(Me.chkPeanut)
        Me.Controls.Add(lblGluten)
        Me.Controls.Add(Me.chkGluten)
        Me.Controls.Add(lblGoalWeight)
        Me.Controls.Add(Me.txtGoalWeight)
        Me.Controls.Add(lblWeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(lblHeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(lblSex)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.UserProfilesBindingNavigator)
        Me.Name = "NewProfile"
        Me.Text = "NewProfile"
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
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtSex As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtGoalWeight As TextBox
    Friend WithEvents chkGluten As CheckBox
    Friend WithEvents chkPeanut As CheckBox
    Friend WithEvents chkTreeNut As CheckBox
    Friend WithEvents chkSoy As CheckBox
    Friend WithEvents chkEgg As CheckBox
    Friend WithEvents chkFish As CheckBox
    Friend WithEvents chkShellfish As CheckBox
    Friend WithEvents chkLactose As CheckBox
    Friend WithEvents chkWheat As CheckBox
    Friend WithEvents chkNoRestrictions As CheckBox
    Friend WithEvents chkVegetarian As CheckBox
    Friend WithEvents chkVegan As CheckBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents datGoalDate As DateTimePicker
End Class
