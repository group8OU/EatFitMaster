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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewProfile))
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Sex__M_F_Label As System.Windows.Forms.Label
        Dim Height__in_Label As System.Windows.Forms.Label
        Dim Weight__lb_Label As System.Windows.Forms.Label
        Dim Goal_WeightLabel As System.Windows.Forms.Label
        Dim Gluten_FreeLabel As System.Windows.Forms.Label
        Dim Peanut_AllergyLabel As System.Windows.Forms.Label
        Dim Tree_Nut_AllergyLabel As System.Windows.Forms.Label
        Dim Soy_AllergyLabel As System.Windows.Forms.Label
        Dim Egg_AllergyLabel As System.Windows.Forms.Label
        Dim Fish_AllergyLabel As System.Windows.Forms.Label
        Dim Shellfish_AllergyLabel As System.Windows.Forms.Label
        Dim Lactose_AllergyLabel As System.Windows.Forms.Label
        Dim Wheat_AllergyLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim No_RestrictionsLabel As System.Windows.Forms.Label
        Dim VegetarianLabel As System.Windows.Forms.Label
        Dim VeganLabel As System.Windows.Forms.Label
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
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Sex__M_F_TextBox = New System.Windows.Forms.TextBox()
        Me.Height__in_TextBox = New System.Windows.Forms.TextBox()
        Me.Weight__lb_TextBox = New System.Windows.Forms.TextBox()
        Me.Goal_WeightTextBox = New System.Windows.Forms.TextBox()
        Me.Gluten_FreeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Peanut_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Tree_Nut_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Soy_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Egg_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Fish_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Shellfish_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Lactose_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Wheat_AllergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.AgeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.No_RestrictionsCheckBox = New System.Windows.Forms.CheckBox()
        Me.VegetarianCheckBox = New System.Windows.Forms.CheckBox()
        Me.VeganCheckBox = New System.Windows.Forms.CheckBox()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Sex__M_F_Label = New System.Windows.Forms.Label()
        Height__in_Label = New System.Windows.Forms.Label()
        Weight__lb_Label = New System.Windows.Forms.Label()
        Goal_WeightLabel = New System.Windows.Forms.Label()
        Gluten_FreeLabel = New System.Windows.Forms.Label()
        Peanut_AllergyLabel = New System.Windows.Forms.Label()
        Tree_Nut_AllergyLabel = New System.Windows.Forms.Label()
        Soy_AllergyLabel = New System.Windows.Forms.Label()
        Egg_AllergyLabel = New System.Windows.Forms.Label()
        Fish_AllergyLabel = New System.Windows.Forms.Label()
        Shellfish_AllergyLabel = New System.Windows.Forms.Label()
        Lactose_AllergyLabel = New System.Windows.Forms.Label()
        Wheat_AllergyLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        No_RestrictionsLabel = New System.Windows.Forms.Label()
        VegetarianLabel = New System.Windows.Forms.Label()
        VeganLabel = New System.Windows.Forms.Label()
        CType(Me.EatFitDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfilesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserProfilesBindingNavigator.SuspendLayout()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UserProfilesBindingNavigator.Size = New System.Drawing.Size(802, 25)
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'UserProfilesBindingNavigatorSaveItem
        '
        Me.UserProfilesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserProfilesBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserProfilesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserProfilesBindingNavigatorSaveItem.Name = "UserProfilesBindingNavigatorSaveItem"
        Me.UserProfilesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.UserProfilesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(42, 51)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 1
        First_NameLabel.Text = "First Name:"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(108, 48)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 2
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(51, 82)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 3
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(118, 79)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 4
        '
        'Sex__M_F_Label
        '
        Sex__M_F_Label.AutoSize = True
        Sex__M_F_Label.Location = New System.Drawing.Point(56, 111)
        Sex__M_F_Label.Name = "Sex__M_F_Label"
        Sex__M_F_Label.Size = New System.Drawing.Size(57, 13)
        Sex__M_F_Label.TabIndex = 5
        Sex__M_F_Label.Text = "Sex (M/F):"
        '
        'Sex__M_F_TextBox
        '
        Me.Sex__M_F_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Sex (M/F)", True))
        Me.Sex__M_F_TextBox.Location = New System.Drawing.Point(119, 108)
        Me.Sex__M_F_TextBox.Name = "Sex__M_F_TextBox"
        Me.Sex__M_F_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sex__M_F_TextBox.TabIndex = 6
        '
        'Height__in_Label
        '
        Height__in_Label.AutoSize = True
        Height__in_Label.Location = New System.Drawing.Point(58, 174)
        Height__in_Label.Name = "Height__in_Label"
        Height__in_Label.Size = New System.Drawing.Size(58, 13)
        Height__in_Label.TabIndex = 9
        Height__in_Label.Text = "Height (in):"
        '
        'Height__in_TextBox
        '
        Me.Height__in_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Height (in)", True))
        Me.Height__in_TextBox.Location = New System.Drawing.Point(122, 171)
        Me.Height__in_TextBox.Name = "Height__in_TextBox"
        Me.Height__in_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Height__in_TextBox.TabIndex = 10
        '
        'Weight__lb_Label
        '
        Weight__lb_Label.AutoSize = True
        Weight__lb_Label.Location = New System.Drawing.Point(62, 210)
        Weight__lb_Label.Name = "Weight__lb_Label"
        Weight__lb_Label.Size = New System.Drawing.Size(61, 13)
        Weight__lb_Label.TabIndex = 11
        Weight__lb_Label.Text = "Weight (lb):"
        '
        'Weight__lb_TextBox
        '
        Me.Weight__lb_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Weight (lb)", True))
        Me.Weight__lb_TextBox.Location = New System.Drawing.Point(129, 207)
        Me.Weight__lb_TextBox.Name = "Weight__lb_TextBox"
        Me.Weight__lb_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Weight__lb_TextBox.TabIndex = 12
        '
        'Goal_WeightLabel
        '
        Goal_WeightLabel.AutoSize = True
        Goal_WeightLabel.Location = New System.Drawing.Point(66, 241)
        Goal_WeightLabel.Name = "Goal_WeightLabel"
        Goal_WeightLabel.Size = New System.Drawing.Size(69, 13)
        Goal_WeightLabel.TabIndex = 13
        Goal_WeightLabel.Text = "Goal Weight:"
        '
        'Goal_WeightTextBox
        '
        Me.Goal_WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfilesBindingSource, "Goal Weight", True))
        Me.Goal_WeightTextBox.Location = New System.Drawing.Point(141, 238)
        Me.Goal_WeightTextBox.Name = "Goal_WeightTextBox"
        Me.Goal_WeightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Goal_WeightTextBox.TabIndex = 14
        '
        'Gluten_FreeLabel
        '
        Gluten_FreeLabel.AutoSize = True
        Gluten_FreeLabel.Location = New System.Drawing.Point(321, 139)
        Gluten_FreeLabel.Name = "Gluten_FreeLabel"
        Gluten_FreeLabel.Size = New System.Drawing.Size(65, 13)
        Gluten_FreeLabel.TabIndex = 21
        Gluten_FreeLabel.Text = "Gluten Free:"
        '
        'Gluten_FreeCheckBox
        '
        Me.Gluten_FreeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Gluten Free", True))
        Me.Gluten_FreeCheckBox.Location = New System.Drawing.Point(392, 134)
        Me.Gluten_FreeCheckBox.Name = "Gluten_FreeCheckBox"
        Me.Gluten_FreeCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Gluten_FreeCheckBox.TabIndex = 22
        Me.Gluten_FreeCheckBox.Text = "CheckBox1"
        Me.Gluten_FreeCheckBox.UseVisualStyleBackColor = True
        '
        'Peanut_AllergyLabel
        '
        Peanut_AllergyLabel.AutoSize = True
        Peanut_AllergyLabel.Location = New System.Drawing.Point(325, 166)
        Peanut_AllergyLabel.Name = "Peanut_AllergyLabel"
        Peanut_AllergyLabel.Size = New System.Drawing.Size(78, 13)
        Peanut_AllergyLabel.TabIndex = 23
        Peanut_AllergyLabel.Text = "Peanut Allergy:"
        '
        'Peanut_AllergyCheckBox
        '
        Me.Peanut_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Peanut Allergy", True))
        Me.Peanut_AllergyCheckBox.Location = New System.Drawing.Point(409, 161)
        Me.Peanut_AllergyCheckBox.Name = "Peanut_AllergyCheckBox"
        Me.Peanut_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Peanut_AllergyCheckBox.TabIndex = 24
        Me.Peanut_AllergyCheckBox.Text = "CheckBox1"
        Me.Peanut_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Tree_Nut_AllergyLabel
        '
        Tree_Nut_AllergyLabel.AutoSize = True
        Tree_Nut_AllergyLabel.Location = New System.Drawing.Point(330, 200)
        Tree_Nut_AllergyLabel.Name = "Tree_Nut_AllergyLabel"
        Tree_Nut_AllergyLabel.Size = New System.Drawing.Size(86, 13)
        Tree_Nut_AllergyLabel.TabIndex = 25
        Tree_Nut_AllergyLabel.Text = "Tree Nut Allergy:"
        '
        'Tree_Nut_AllergyCheckBox
        '
        Me.Tree_Nut_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Tree Nut Allergy", True))
        Me.Tree_Nut_AllergyCheckBox.Location = New System.Drawing.Point(422, 195)
        Me.Tree_Nut_AllergyCheckBox.Name = "Tree_Nut_AllergyCheckBox"
        Me.Tree_Nut_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Tree_Nut_AllergyCheckBox.TabIndex = 26
        Me.Tree_Nut_AllergyCheckBox.Text = "CheckBox1"
        Me.Tree_Nut_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Soy_AllergyLabel
        '
        Soy_AllergyLabel.AutoSize = True
        Soy_AllergyLabel.Location = New System.Drawing.Point(328, 226)
        Soy_AllergyLabel.Name = "Soy_AllergyLabel"
        Soy_AllergyLabel.Size = New System.Drawing.Size(62, 13)
        Soy_AllergyLabel.TabIndex = 27
        Soy_AllergyLabel.Text = "Soy Allergy:"
        '
        'Soy_AllergyCheckBox
        '
        Me.Soy_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Soy Allergy", True))
        Me.Soy_AllergyCheckBox.Location = New System.Drawing.Point(396, 221)
        Me.Soy_AllergyCheckBox.Name = "Soy_AllergyCheckBox"
        Me.Soy_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Soy_AllergyCheckBox.TabIndex = 28
        Me.Soy_AllergyCheckBox.Text = "CheckBox1"
        Me.Soy_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Egg_AllergyLabel
        '
        Egg_AllergyLabel.AutoSize = True
        Egg_AllergyLabel.Location = New System.Drawing.Point(336, 255)
        Egg_AllergyLabel.Name = "Egg_AllergyLabel"
        Egg_AllergyLabel.Size = New System.Drawing.Size(63, 13)
        Egg_AllergyLabel.TabIndex = 29
        Egg_AllergyLabel.Text = "Egg Allergy:"
        '
        'Egg_AllergyCheckBox
        '
        Me.Egg_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Egg Allergy", True))
        Me.Egg_AllergyCheckBox.Location = New System.Drawing.Point(405, 250)
        Me.Egg_AllergyCheckBox.Name = "Egg_AllergyCheckBox"
        Me.Egg_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Egg_AllergyCheckBox.TabIndex = 30
        Me.Egg_AllergyCheckBox.Text = "CheckBox1"
        Me.Egg_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Fish_AllergyLabel
        '
        Fish_AllergyLabel.AutoSize = True
        Fish_AllergyLabel.Location = New System.Drawing.Point(331, 287)
        Fish_AllergyLabel.Name = "Fish_AllergyLabel"
        Fish_AllergyLabel.Size = New System.Drawing.Size(63, 13)
        Fish_AllergyLabel.TabIndex = 31
        Fish_AllergyLabel.Text = "Fish Allergy:"
        '
        'Fish_AllergyCheckBox
        '
        Me.Fish_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Fish Allergy", True))
        Me.Fish_AllergyCheckBox.Location = New System.Drawing.Point(400, 282)
        Me.Fish_AllergyCheckBox.Name = "Fish_AllergyCheckBox"
        Me.Fish_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Fish_AllergyCheckBox.TabIndex = 32
        Me.Fish_AllergyCheckBox.Text = "CheckBox1"
        Me.Fish_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Shellfish_AllergyLabel
        '
        Shellfish_AllergyLabel.AutoSize = True
        Shellfish_AllergyLabel.Location = New System.Drawing.Point(330, 324)
        Shellfish_AllergyLabel.Name = "Shellfish_AllergyLabel"
        Shellfish_AllergyLabel.Size = New System.Drawing.Size(83, 13)
        Shellfish_AllergyLabel.TabIndex = 33
        Shellfish_AllergyLabel.Text = "Shellfish Allergy:"
        '
        'Shellfish_AllergyCheckBox
        '
        Me.Shellfish_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Shellfish Allergy", True))
        Me.Shellfish_AllergyCheckBox.Location = New System.Drawing.Point(419, 319)
        Me.Shellfish_AllergyCheckBox.Name = "Shellfish_AllergyCheckBox"
        Me.Shellfish_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Shellfish_AllergyCheckBox.TabIndex = 34
        Me.Shellfish_AllergyCheckBox.Text = "CheckBox1"
        Me.Shellfish_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Lactose_AllergyLabel
        '
        Lactose_AllergyLabel.AutoSize = True
        Lactose_AllergyLabel.Location = New System.Drawing.Point(336, 358)
        Lactose_AllergyLabel.Name = "Lactose_AllergyLabel"
        Lactose_AllergyLabel.Size = New System.Drawing.Size(82, 13)
        Lactose_AllergyLabel.TabIndex = 35
        Lactose_AllergyLabel.Text = "Lactose Allergy:"
        '
        'Lactose_AllergyCheckBox
        '
        Me.Lactose_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Lactose Allergy", True))
        Me.Lactose_AllergyCheckBox.Location = New System.Drawing.Point(424, 353)
        Me.Lactose_AllergyCheckBox.Name = "Lactose_AllergyCheckBox"
        Me.Lactose_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Lactose_AllergyCheckBox.TabIndex = 36
        Me.Lactose_AllergyCheckBox.Text = "CheckBox1"
        Me.Lactose_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'Wheat_AllergyLabel
        '
        Wheat_AllergyLabel.AutoSize = True
        Wheat_AllergyLabel.Location = New System.Drawing.Point(336, 388)
        Wheat_AllergyLabel.Name = "Wheat_AllergyLabel"
        Wheat_AllergyLabel.Size = New System.Drawing.Size(76, 13)
        Wheat_AllergyLabel.TabIndex = 37
        Wheat_AllergyLabel.Text = "Wheat Allergy:"
        '
        'Wheat_AllergyCheckBox
        '
        Me.Wheat_AllergyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Wheat Allergy", True))
        Me.Wheat_AllergyCheckBox.Location = New System.Drawing.Point(418, 383)
        Me.Wheat_AllergyCheckBox.Name = "Wheat_AllergyCheckBox"
        Me.Wheat_AllergyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Wheat_AllergyCheckBox.TabIndex = 38
        Me.Wheat_AllergyCheckBox.Text = "CheckBox1"
        Me.Wheat_AllergyCheckBox.UseVisualStyleBackColor = True
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(62, 139)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 38
        AgeLabel.Text = "Age:"
        '
        'AgeNumericUpDown
        '
        Me.AgeNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserProfilesBindingSource, "Age", True))
        Me.AgeNumericUpDown.Location = New System.Drawing.Point(97, 139)
        Me.AgeNumericUpDown.Name = "AgeNumericUpDown"
        Me.AgeNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.AgeNumericUpDown.TabIndex = 39
        '
        'No_RestrictionsLabel
        '
        No_RestrictionsLabel.AutoSize = True
        No_RestrictionsLabel.Location = New System.Drawing.Point(328, 40)
        No_RestrictionsLabel.Name = "No_RestrictionsLabel"
        No_RestrictionsLabel.Size = New System.Drawing.Size(82, 13)
        No_RestrictionsLabel.TabIndex = 39
        No_RestrictionsLabel.Text = "No Restrictions:"
        '
        'No_RestrictionsCheckBox
        '
        Me.No_RestrictionsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "No Restrictions", True))
        Me.No_RestrictionsCheckBox.Location = New System.Drawing.Point(416, 35)
        Me.No_RestrictionsCheckBox.Name = "No_RestrictionsCheckBox"
        Me.No_RestrictionsCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.No_RestrictionsCheckBox.TabIndex = 40
        Me.No_RestrictionsCheckBox.Text = "CheckBox1"
        Me.No_RestrictionsCheckBox.UseVisualStyleBackColor = True
        '
        'VegetarianLabel
        '
        VegetarianLabel.AutoSize = True
        VegetarianLabel.Location = New System.Drawing.Point(339, 71)
        VegetarianLabel.Name = "VegetarianLabel"
        VegetarianLabel.Size = New System.Drawing.Size(61, 13)
        VegetarianLabel.TabIndex = 40
        VegetarianLabel.Text = "Vegetarian:"
        '
        'VegetarianCheckBox
        '
        Me.VegetarianCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Vegetarian", True))
        Me.VegetarianCheckBox.Location = New System.Drawing.Point(406, 66)
        Me.VegetarianCheckBox.Name = "VegetarianCheckBox"
        Me.VegetarianCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.VegetarianCheckBox.TabIndex = 41
        Me.VegetarianCheckBox.Text = "CheckBox1"
        Me.VegetarianCheckBox.UseVisualStyleBackColor = True
        '
        'VeganLabel
        '
        VeganLabel.AutoSize = True
        VeganLabel.Location = New System.Drawing.Point(347, 111)
        VeganLabel.Name = "VeganLabel"
        VeganLabel.Size = New System.Drawing.Size(41, 13)
        VeganLabel.TabIndex = 41
        VeganLabel.Text = "Vegan:"
        '
        'VeganCheckBox
        '
        Me.VeganCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserProfilesBindingSource, "Vegan", True))
        Me.VeganCheckBox.Location = New System.Drawing.Point(394, 106)
        Me.VeganCheckBox.Name = "VeganCheckBox"
        Me.VeganCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.VeganCheckBox.TabIndex = 42
        Me.VeganCheckBox.Text = "CheckBox1"
        Me.VeganCheckBox.UseVisualStyleBackColor = True
        '
        'NewProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 427)
        Me.Controls.Add(VeganLabel)
        Me.Controls.Add(Me.VeganCheckBox)
        Me.Controls.Add(VegetarianLabel)
        Me.Controls.Add(Me.VegetarianCheckBox)
        Me.Controls.Add(No_RestrictionsLabel)
        Me.Controls.Add(Me.No_RestrictionsCheckBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeNumericUpDown)
        Me.Controls.Add(Wheat_AllergyLabel)
        Me.Controls.Add(Me.Wheat_AllergyCheckBox)
        Me.Controls.Add(Lactose_AllergyLabel)
        Me.Controls.Add(Me.Lactose_AllergyCheckBox)
        Me.Controls.Add(Shellfish_AllergyLabel)
        Me.Controls.Add(Me.Shellfish_AllergyCheckBox)
        Me.Controls.Add(Fish_AllergyLabel)
        Me.Controls.Add(Me.Fish_AllergyCheckBox)
        Me.Controls.Add(Egg_AllergyLabel)
        Me.Controls.Add(Me.Egg_AllergyCheckBox)
        Me.Controls.Add(Soy_AllergyLabel)
        Me.Controls.Add(Me.Soy_AllergyCheckBox)
        Me.Controls.Add(Tree_Nut_AllergyLabel)
        Me.Controls.Add(Me.Tree_Nut_AllergyCheckBox)
        Me.Controls.Add(Peanut_AllergyLabel)
        Me.Controls.Add(Me.Peanut_AllergyCheckBox)
        Me.Controls.Add(Gluten_FreeLabel)
        Me.Controls.Add(Me.Gluten_FreeCheckBox)
        Me.Controls.Add(Goal_WeightLabel)
        Me.Controls.Add(Me.Goal_WeightTextBox)
        Me.Controls.Add(Weight__lb_Label)
        Me.Controls.Add(Me.Weight__lb_TextBox)
        Me.Controls.Add(Height__in_Label)
        Me.Controls.Add(Me.Height__in_TextBox)
        Me.Controls.Add(Sex__M_F_Label)
        Me.Controls.Add(Me.Sex__M_F_TextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Me.UserProfilesBindingNavigator)
        Me.Name = "NewProfile"
        Me.Text = "NewProfile"
        CType(Me.EatFitDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserProfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserProfilesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserProfilesBindingNavigator.ResumeLayout(False)
        Me.UserProfilesBindingNavigator.PerformLayout()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Sex__M_F_TextBox As TextBox
    Friend WithEvents Height__in_TextBox As TextBox
    Friend WithEvents Weight__lb_TextBox As TextBox
    Friend WithEvents Goal_WeightTextBox As TextBox
    Friend WithEvents Gluten_FreeCheckBox As CheckBox
    Friend WithEvents Peanut_AllergyCheckBox As CheckBox
    Friend WithEvents Tree_Nut_AllergyCheckBox As CheckBox
    Friend WithEvents Soy_AllergyCheckBox As CheckBox
    Friend WithEvents Egg_AllergyCheckBox As CheckBox
    Friend WithEvents Fish_AllergyCheckBox As CheckBox
    Friend WithEvents Shellfish_AllergyCheckBox As CheckBox
    Friend WithEvents Lactose_AllergyCheckBox As CheckBox
    Friend WithEvents Wheat_AllergyCheckBox As CheckBox
    Friend WithEvents AgeNumericUpDown As NumericUpDown
    Friend WithEvents No_RestrictionsCheckBox As CheckBox
    Friend WithEvents VegetarianCheckBox As CheckBox
    Friend WithEvents VeganCheckBox As CheckBox
End Class
