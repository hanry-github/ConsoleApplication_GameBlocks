<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WonderlandThemePark
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WonderlandThemePark))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblThemePark = New System.Windows.Forms.Label()
        Me.cbThemePark = New System.Windows.Forms.ComboBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerNumber = New System.Windows.Forms.TextBox()
        Me.lblCustomerNumber = New System.Windows.Forms.Label()
        Me.txtAdults = New System.Windows.Forms.TextBox()
        Me.lblAdults = New System.Windows.Forms.Label()
        Me.txtSeniorCitizen = New System.Windows.Forms.TextBox()
        Me.lblSeniorCitizen = New System.Windows.Forms.Label()
        Me.txtChildren = New System.Windows.Forms.TextBox()
        Me.lblChildren = New System.Windows.Forms.Label()
        Me.gbCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.rbRegular = New System.Windows.Forms.RadioButton()
        Me.rbExpress = New System.Windows.Forms.RadioButton()
        Me.rbVVIP = New System.Windows.Forms.RadioButton()
        Me.rbExpressUnlimited = New System.Windows.Forms.RadioButton()
        Me.gbTicketTypes = New System.Windows.Forms.GroupBox()
        Me.chkCruise = New System.Windows.Forms.CheckBox()
        Me.chkBananaBoat = New System.Windows.Forms.CheckBox()
        Me.chkDuckBoat = New System.Windows.Forms.CheckBox()
        Me.chkCoupleTrain = New System.Windows.Forms.CheckBox()
        Me.chkElectricTrain = New System.Windows.Forms.CheckBox()
        Me.chkLocomotiveTrain = New System.Windows.Forms.CheckBox()
        Me.gbBoatAndTrainRide = New System.Windows.Forms.GroupBox()
        Me.gbShows = New System.Windows.Forms.GroupBox()
        Me.chkNightFirework = New System.Windows.Forms.CheckBox()
        Me.chkDayFirework = New System.Windows.Forms.CheckBox()
        Me.chkDolphinShow = New System.Windows.Forms.CheckBox()
        Me.chkMagicalShow = New System.Windows.Forms.CheckBox()
        Me.gbFoodMenu = New System.Windows.Forms.GroupBox()
        Me.chkJapeneseMenu = New System.Windows.Forms.CheckBox()
        Me.chkMalayMenu = New System.Windows.Forms.CheckBox()
        Me.chkChineseMenu = New System.Windows.Forms.CheckBox()
        Me.chkWesternMenu = New System.Windows.Forms.CheckBox()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.lblAnsTickets = New System.Windows.Forms.Label()
        Me.lblAnsTypes = New System.Windows.Forms.Label()
        Me.lblTypes = New System.Windows.Forms.Label()
        Me.lblAnsBoatAndTrainRide = New System.Windows.Forms.Label()
        Me.lblBoatAndTrainRide = New System.Windows.Forms.Label()
        Me.lblAnsShows = New System.Windows.Forms.Label()
        Me.lblShows = New System.Windows.Forms.Label()
        Me.lblAnsFoodMenu = New System.Windows.Forms.Label()
        Me.lblFoodMenu = New System.Windows.Forms.Label()
        Me.lblAnsSubTotal1 = New System.Windows.Forms.Label()
        Me.lblSubTotal1 = New System.Windows.Forms.Label()
        Me.lblAnsDiscount = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblAnsSubTotal2 = New System.Windows.Forms.Label()
        Me.lblSubTotal2 = New System.Windows.Forms.Label()
        Me.lblAnsGST = New System.Windows.Forms.Label()
        Me.lblGST = New System.Windows.Forms.Label()
        Me.lblAnsTotalPackage = New System.Windows.Forms.Label()
        Me.lblTotalPackage = New System.Windows.Forms.Label()
        Me.gbCosts = New System.Windows.Forms.GroupBox()
        Me.lblAnsRefNo = New System.Windows.Forms.Label()
        Me.lblRefNo = New System.Windows.Forms.Label()
        Me.lblAnsQuoteDate = New System.Windows.Forms.Label()
        Me.lblQuoteDate = New System.Windows.Forms.Label()
        Me.lblAnsValidTo = New System.Windows.Forms.Label()
        Me.lblValidto = New System.Windows.Forms.Label()
        Me.gbRefNo = New System.Windows.Forms.GroupBox()
        Me.gbButton = New System.Windows.Forms.GroupBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBookPackage = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.gbCustomerDetails.SuspendLayout()
        Me.gbTicketTypes.SuspendLayout()
        Me.gbBoatAndTrainRide.SuspendLayout()
        Me.gbShows.SuspendLayout()
        Me.gbFoodMenu.SuspendLayout()
        Me.gbCosts.SuspendLayout()
        Me.gbRefNo.SuspendLayout()
        Me.gbButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(71, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(525, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Wonderland Theme Park Online Ticketing and Booking"
        '
        'lblThemePark
        '
        Me.lblThemePark.AutoSize = True
        Me.lblThemePark.BackColor = System.Drawing.Color.Transparent
        Me.lblThemePark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThemePark.ForeColor = System.Drawing.Color.Transparent
        Me.lblThemePark.Location = New System.Drawing.Point(12, 18)
        Me.lblThemePark.Name = "lblThemePark"
        Me.lblThemePark.Size = New System.Drawing.Size(85, 16)
        Me.lblThemePark.TabIndex = 1
        Me.lblThemePark.Text = "Theme Park:"
        '
        'cbThemePark
        '
        Me.cbThemePark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbThemePark.FormattingEnabled = True
        Me.cbThemePark.Location = New System.Drawing.Point(156, 15)
        Me.cbThemePark.Name = "cbThemePark"
        Me.cbThemePark.Size = New System.Drawing.Size(139, 24)
        Me.cbThemePark.TabIndex = 2
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.Color.Transparent
        Me.lblCustomerName.Location = New System.Drawing.Point(12, 48)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(108, 16)
        Me.lblCustomerName.TabIndex = 3
        Me.lblCustomerName.Text = "Customer Name:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(156, 45)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(139, 22)
        Me.txtCustomerName.TabIndex = 4
        '
        'txtCustomerNumber
        '
        Me.txtCustomerNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtCustomerNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerNumber.Location = New System.Drawing.Point(156, 73)
        Me.txtCustomerNumber.Name = "txtCustomerNumber"
        Me.txtCustomerNumber.Size = New System.Drawing.Size(139, 22)
        Me.txtCustomerNumber.TabIndex = 6
        '
        'lblCustomerNumber
        '
        Me.lblCustomerNumber.AutoSize = True
        Me.lblCustomerNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerNumber.ForeColor = System.Drawing.Color.Transparent
        Me.lblCustomerNumber.Location = New System.Drawing.Point(12, 76)
        Me.lblCustomerNumber.Name = "lblCustomerNumber"
        Me.lblCustomerNumber.Size = New System.Drawing.Size(119, 16)
        Me.lblCustomerNumber.TabIndex = 5
        Me.lblCustomerNumber.Text = "Customer Number:"
        '
        'txtAdults
        '
        Me.txtAdults.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdults.Location = New System.Drawing.Point(156, 101)
        Me.txtAdults.Name = "txtAdults"
        Me.txtAdults.Size = New System.Drawing.Size(139, 22)
        Me.txtAdults.TabIndex = 8
        '
        'lblAdults
        '
        Me.lblAdults.AutoSize = True
        Me.lblAdults.BackColor = System.Drawing.Color.Transparent
        Me.lblAdults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdults.ForeColor = System.Drawing.Color.Transparent
        Me.lblAdults.Location = New System.Drawing.Point(12, 104)
        Me.lblAdults.Name = "lblAdults"
        Me.lblAdults.Size = New System.Drawing.Size(48, 16)
        Me.lblAdults.TabIndex = 7
        Me.lblAdults.Text = "Adults:"
        '
        'txtSeniorCitizen
        '
        Me.txtSeniorCitizen.BackColor = System.Drawing.SystemColors.Window
        Me.txtSeniorCitizen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeniorCitizen.Location = New System.Drawing.Point(156, 129)
        Me.txtSeniorCitizen.Name = "txtSeniorCitizen"
        Me.txtSeniorCitizen.Size = New System.Drawing.Size(139, 22)
        Me.txtSeniorCitizen.TabIndex = 10
        '
        'lblSeniorCitizen
        '
        Me.lblSeniorCitizen.AutoSize = True
        Me.lblSeniorCitizen.BackColor = System.Drawing.Color.Transparent
        Me.lblSeniorCitizen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeniorCitizen.ForeColor = System.Drawing.Color.Transparent
        Me.lblSeniorCitizen.Location = New System.Drawing.Point(12, 132)
        Me.lblSeniorCitizen.Name = "lblSeniorCitizen"
        Me.lblSeniorCitizen.Size = New System.Drawing.Size(92, 16)
        Me.lblSeniorCitizen.TabIndex = 9
        Me.lblSeniorCitizen.Text = "Senior Citizen:"
        '
        'txtChildren
        '
        Me.txtChildren.BackColor = System.Drawing.SystemColors.Window
        Me.txtChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChildren.Location = New System.Drawing.Point(156, 157)
        Me.txtChildren.Name = "txtChildren"
        Me.txtChildren.Size = New System.Drawing.Size(139, 22)
        Me.txtChildren.TabIndex = 12
        '
        'lblChildren
        '
        Me.lblChildren.AutoSize = True
        Me.lblChildren.BackColor = System.Drawing.Color.Transparent
        Me.lblChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildren.ForeColor = System.Drawing.Color.Transparent
        Me.lblChildren.Location = New System.Drawing.Point(12, 160)
        Me.lblChildren.Name = "lblChildren"
        Me.lblChildren.Size = New System.Drawing.Size(60, 16)
        Me.lblChildren.TabIndex = 11
        Me.lblChildren.Text = "Children:"
        '
        'gbCustomerDetails
        '
        Me.gbCustomerDetails.BackColor = System.Drawing.Color.DarkBlue
        Me.gbCustomerDetails.Controls.Add(Me.txtChildren)
        Me.gbCustomerDetails.Controls.Add(Me.lblChildren)
        Me.gbCustomerDetails.Controls.Add(Me.txtSeniorCitizen)
        Me.gbCustomerDetails.Controls.Add(Me.lblSeniorCitizen)
        Me.gbCustomerDetails.Controls.Add(Me.txtAdults)
        Me.gbCustomerDetails.Controls.Add(Me.lblAdults)
        Me.gbCustomerDetails.Controls.Add(Me.txtCustomerNumber)
        Me.gbCustomerDetails.Controls.Add(Me.lblCustomerNumber)
        Me.gbCustomerDetails.Controls.Add(Me.txtCustomerName)
        Me.gbCustomerDetails.Controls.Add(Me.lblCustomerName)
        Me.gbCustomerDetails.Controls.Add(Me.cbThemePark)
        Me.gbCustomerDetails.Controls.Add(Me.lblThemePark)
        Me.gbCustomerDetails.ForeColor = System.Drawing.Color.Aqua
        Me.gbCustomerDetails.Location = New System.Drawing.Point(6, 58)
        Me.gbCustomerDetails.Name = "gbCustomerDetails"
        Me.gbCustomerDetails.Size = New System.Drawing.Size(305, 198)
        Me.gbCustomerDetails.TabIndex = 13
        Me.gbCustomerDetails.TabStop = False
        Me.gbCustomerDetails.Text = "Customer Details"
        '
        'rbRegular
        '
        Me.rbRegular.AutoSize = True
        Me.rbRegular.BackColor = System.Drawing.Color.Transparent
        Me.rbRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRegular.ForeColor = System.Drawing.Color.Transparent
        Me.rbRegular.Location = New System.Drawing.Point(10, 21)
        Me.rbRegular.Name = "rbRegular"
        Me.rbRegular.Size = New System.Drawing.Size(74, 20)
        Me.rbRegular.TabIndex = 14
        Me.rbRegular.Text = "Regular"
        Me.rbRegular.UseVisualStyleBackColor = False
        '
        'rbExpress
        '
        Me.rbExpress.AutoSize = True
        Me.rbExpress.BackColor = System.Drawing.Color.Transparent
        Me.rbExpress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExpress.ForeColor = System.Drawing.Color.Transparent
        Me.rbExpress.Location = New System.Drawing.Point(10, 47)
        Me.rbExpress.Name = "rbExpress"
        Me.rbExpress.Size = New System.Drawing.Size(75, 20)
        Me.rbExpress.TabIndex = 15
        Me.rbExpress.Text = "Express"
        Me.rbExpress.UseVisualStyleBackColor = False
        '
        'rbVVIP
        '
        Me.rbVVIP.AutoSize = True
        Me.rbVVIP.BackColor = System.Drawing.Color.Transparent
        Me.rbVVIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVVIP.ForeColor = System.Drawing.Color.Transparent
        Me.rbVVIP.Location = New System.Drawing.Point(156, 46)
        Me.rbVVIP.Name = "rbVVIP"
        Me.rbVVIP.Size = New System.Drawing.Size(56, 20)
        Me.rbVVIP.TabIndex = 17
        Me.rbVVIP.Text = "VVIP"
        Me.rbVVIP.UseVisualStyleBackColor = False
        '
        'rbExpressUnlimited
        '
        Me.rbExpressUnlimited.AutoSize = True
        Me.rbExpressUnlimited.BackColor = System.Drawing.Color.Transparent
        Me.rbExpressUnlimited.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExpressUnlimited.ForeColor = System.Drawing.Color.Transparent
        Me.rbExpressUnlimited.Location = New System.Drawing.Point(156, 20)
        Me.rbExpressUnlimited.Name = "rbExpressUnlimited"
        Me.rbExpressUnlimited.Size = New System.Drawing.Size(134, 20)
        Me.rbExpressUnlimited.TabIndex = 16
        Me.rbExpressUnlimited.Text = "Express Unlimited"
        Me.rbExpressUnlimited.UseVisualStyleBackColor = False
        '
        'gbTicketTypes
        '
        Me.gbTicketTypes.BackColor = System.Drawing.Color.DarkBlue
        Me.gbTicketTypes.Controls.Add(Me.rbVVIP)
        Me.gbTicketTypes.Controls.Add(Me.rbExpressUnlimited)
        Me.gbTicketTypes.Controls.Add(Me.rbExpress)
        Me.gbTicketTypes.Controls.Add(Me.rbRegular)
        Me.gbTicketTypes.ForeColor = System.Drawing.Color.Aqua
        Me.gbTicketTypes.Location = New System.Drawing.Point(6, 271)
        Me.gbTicketTypes.Name = "gbTicketTypes"
        Me.gbTicketTypes.Size = New System.Drawing.Size(305, 82)
        Me.gbTicketTypes.TabIndex = 18
        Me.gbTicketTypes.TabStop = False
        Me.gbTicketTypes.Text = "Ticket Types"
        '
        'chkCruise
        '
        Me.chkCruise.AutoSize = True
        Me.chkCruise.BackColor = System.Drawing.Color.Transparent
        Me.chkCruise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCruise.ForeColor = System.Drawing.Color.Transparent
        Me.chkCruise.Location = New System.Drawing.Point(11, 19)
        Me.chkCruise.Name = "chkCruise"
        Me.chkCruise.Size = New System.Drawing.Size(97, 20)
        Me.chkCruise.TabIndex = 19
        Me.chkCruise.Text = "Cruise Ride"
        Me.chkCruise.UseVisualStyleBackColor = False
        '
        'chkBananaBoat
        '
        Me.chkBananaBoat.AutoSize = True
        Me.chkBananaBoat.BackColor = System.Drawing.Color.Transparent
        Me.chkBananaBoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBananaBoat.ForeColor = System.Drawing.Color.Transparent
        Me.chkBananaBoat.Location = New System.Drawing.Point(11, 45)
        Me.chkBananaBoat.Name = "chkBananaBoat"
        Me.chkBananaBoat.Size = New System.Drawing.Size(137, 20)
        Me.chkBananaBoat.TabIndex = 20
        Me.chkBananaBoat.Text = "Banana Boat Ride"
        Me.chkBananaBoat.UseVisualStyleBackColor = False
        '
        'chkDuckBoat
        '
        Me.chkDuckBoat.AutoSize = True
        Me.chkDuckBoat.BackColor = System.Drawing.Color.Transparent
        Me.chkDuckBoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDuckBoat.ForeColor = System.Drawing.Color.Transparent
        Me.chkDuckBoat.Location = New System.Drawing.Point(11, 71)
        Me.chkDuckBoat.Name = "chkDuckBoat"
        Me.chkDuckBoat.Size = New System.Drawing.Size(121, 20)
        Me.chkDuckBoat.TabIndex = 21
        Me.chkDuckBoat.Text = "Duck Boat Ride"
        Me.chkDuckBoat.UseVisualStyleBackColor = False
        '
        'chkCoupleTrain
        '
        Me.chkCoupleTrain.AutoSize = True
        Me.chkCoupleTrain.BackColor = System.Drawing.Color.Transparent
        Me.chkCoupleTrain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCoupleTrain.ForeColor = System.Drawing.Color.Transparent
        Me.chkCoupleTrain.Location = New System.Drawing.Point(168, 71)
        Me.chkCoupleTrain.Name = "chkCoupleTrain"
        Me.chkCoupleTrain.Size = New System.Drawing.Size(136, 20)
        Me.chkCoupleTrain.TabIndex = 24
        Me.chkCoupleTrain.Text = "Couple Train Ride"
        Me.chkCoupleTrain.UseVisualStyleBackColor = False
        '
        'chkElectricTrain
        '
        Me.chkElectricTrain.AutoSize = True
        Me.chkElectricTrain.BackColor = System.Drawing.Color.Transparent
        Me.chkElectricTrain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkElectricTrain.ForeColor = System.Drawing.Color.Transparent
        Me.chkElectricTrain.Location = New System.Drawing.Point(168, 45)
        Me.chkElectricTrain.Name = "chkElectricTrain"
        Me.chkElectricTrain.Size = New System.Drawing.Size(137, 20)
        Me.chkElectricTrain.TabIndex = 23
        Me.chkElectricTrain.Text = "Electric Train Ride"
        Me.chkElectricTrain.UseVisualStyleBackColor = False
        '
        'chkLocomotiveTrain
        '
        Me.chkLocomotiveTrain.AutoSize = True
        Me.chkLocomotiveTrain.BackColor = System.Drawing.Color.Transparent
        Me.chkLocomotiveTrain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLocomotiveTrain.ForeColor = System.Drawing.Color.Transparent
        Me.chkLocomotiveTrain.Location = New System.Drawing.Point(168, 19)
        Me.chkLocomotiveTrain.Name = "chkLocomotiveTrain"
        Me.chkLocomotiveTrain.Size = New System.Drawing.Size(163, 20)
        Me.chkLocomotiveTrain.TabIndex = 22
        Me.chkLocomotiveTrain.Text = "Locomotive Train Ride"
        Me.chkLocomotiveTrain.UseVisualStyleBackColor = False
        '
        'gbBoatAndTrainRide
        '
        Me.gbBoatAndTrainRide.BackColor = System.Drawing.Color.DarkBlue
        Me.gbBoatAndTrainRide.Controls.Add(Me.chkCoupleTrain)
        Me.gbBoatAndTrainRide.Controls.Add(Me.chkElectricTrain)
        Me.gbBoatAndTrainRide.Controls.Add(Me.chkLocomotiveTrain)
        Me.gbBoatAndTrainRide.Controls.Add(Me.chkDuckBoat)
        Me.gbBoatAndTrainRide.Controls.Add(Me.chkBananaBoat)
        Me.gbBoatAndTrainRide.Controls.Add(Me.chkCruise)
        Me.gbBoatAndTrainRide.ForeColor = System.Drawing.Color.Aqua
        Me.gbBoatAndTrainRide.Location = New System.Drawing.Point(318, 58)
        Me.gbBoatAndTrainRide.Name = "gbBoatAndTrainRide"
        Me.gbBoatAndTrainRide.Size = New System.Drawing.Size(345, 103)
        Me.gbBoatAndTrainRide.TabIndex = 25
        Me.gbBoatAndTrainRide.TabStop = False
        Me.gbBoatAndTrainRide.Text = "Boat and Train Ride"
        '
        'gbShows
        '
        Me.gbShows.BackColor = System.Drawing.Color.DarkBlue
        Me.gbShows.Controls.Add(Me.chkNightFirework)
        Me.gbShows.Controls.Add(Me.chkDayFirework)
        Me.gbShows.Controls.Add(Me.chkDolphinShow)
        Me.gbShows.Controls.Add(Me.chkMagicalShow)
        Me.gbShows.ForeColor = System.Drawing.Color.Aqua
        Me.gbShows.Location = New System.Drawing.Point(317, 176)
        Me.gbShows.Name = "gbShows"
        Me.gbShows.Size = New System.Drawing.Size(348, 80)
        Me.gbShows.TabIndex = 26
        Me.gbShows.TabStop = False
        Me.gbShows.Text = "Shows"
        '
        'chkNightFirework
        '
        Me.chkNightFirework.AutoSize = True
        Me.chkNightFirework.BackColor = System.Drawing.Color.Transparent
        Me.chkNightFirework.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNightFirework.ForeColor = System.Drawing.Color.Transparent
        Me.chkNightFirework.Location = New System.Drawing.Point(168, 45)
        Me.chkNightFirework.Name = "chkNightFirework"
        Me.chkNightFirework.Size = New System.Drawing.Size(149, 20)
        Me.chkNightFirework.TabIndex = 23
        Me.chkNightFirework.Text = "Night-Firework Show"
        Me.chkNightFirework.UseVisualStyleBackColor = False
        '
        'chkDayFirework
        '
        Me.chkDayFirework.AutoSize = True
        Me.chkDayFirework.BackColor = System.Drawing.Color.Transparent
        Me.chkDayFirework.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDayFirework.ForeColor = System.Drawing.Color.Transparent
        Me.chkDayFirework.Location = New System.Drawing.Point(168, 19)
        Me.chkDayFirework.Name = "chkDayFirework"
        Me.chkDayFirework.Size = New System.Drawing.Size(143, 20)
        Me.chkDayFirework.TabIndex = 22
        Me.chkDayFirework.Text = "Day-Firework Show"
        Me.chkDayFirework.UseVisualStyleBackColor = False
        '
        'chkDolphinShow
        '
        Me.chkDolphinShow.AutoSize = True
        Me.chkDolphinShow.BackColor = System.Drawing.Color.Transparent
        Me.chkDolphinShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDolphinShow.ForeColor = System.Drawing.Color.Transparent
        Me.chkDolphinShow.Location = New System.Drawing.Point(12, 45)
        Me.chkDolphinShow.Name = "chkDolphinShow"
        Me.chkDolphinShow.Size = New System.Drawing.Size(109, 20)
        Me.chkDolphinShow.TabIndex = 20
        Me.chkDolphinShow.Text = "Dolphin Show"
        Me.chkDolphinShow.UseVisualStyleBackColor = False
        '
        'chkMagicalShow
        '
        Me.chkMagicalShow.AutoSize = True
        Me.chkMagicalShow.BackColor = System.Drawing.Color.Transparent
        Me.chkMagicalShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMagicalShow.ForeColor = System.Drawing.Color.Transparent
        Me.chkMagicalShow.Location = New System.Drawing.Point(12, 19)
        Me.chkMagicalShow.Name = "chkMagicalShow"
        Me.chkMagicalShow.Size = New System.Drawing.Size(111, 20)
        Me.chkMagicalShow.TabIndex = 19
        Me.chkMagicalShow.Text = "Magical Show"
        Me.chkMagicalShow.UseVisualStyleBackColor = False
        '
        'gbFoodMenu
        '
        Me.gbFoodMenu.BackColor = System.Drawing.Color.DarkBlue
        Me.gbFoodMenu.Controls.Add(Me.chkJapeneseMenu)
        Me.gbFoodMenu.Controls.Add(Me.chkMalayMenu)
        Me.gbFoodMenu.Controls.Add(Me.chkChineseMenu)
        Me.gbFoodMenu.Controls.Add(Me.chkWesternMenu)
        Me.gbFoodMenu.ForeColor = System.Drawing.Color.Aqua
        Me.gbFoodMenu.Location = New System.Drawing.Point(317, 271)
        Me.gbFoodMenu.Name = "gbFoodMenu"
        Me.gbFoodMenu.Size = New System.Drawing.Size(348, 82)
        Me.gbFoodMenu.TabIndex = 27
        Me.gbFoodMenu.TabStop = False
        Me.gbFoodMenu.Text = "Food Menu"
        '
        'chkJapeneseMenu
        '
        Me.chkJapeneseMenu.AutoSize = True
        Me.chkJapeneseMenu.BackColor = System.Drawing.Color.Transparent
        Me.chkJapeneseMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJapeneseMenu.ForeColor = System.Drawing.Color.Transparent
        Me.chkJapeneseMenu.Location = New System.Drawing.Point(168, 48)
        Me.chkJapeneseMenu.Name = "chkJapeneseMenu"
        Me.chkJapeneseMenu.Size = New System.Drawing.Size(124, 20)
        Me.chkJapeneseMenu.TabIndex = 23
        Me.chkJapeneseMenu.Text = "Japanese Menu"
        Me.chkJapeneseMenu.UseVisualStyleBackColor = False
        '
        'chkMalayMenu
        '
        Me.chkMalayMenu.AutoSize = True
        Me.chkMalayMenu.BackColor = System.Drawing.Color.Transparent
        Me.chkMalayMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMalayMenu.ForeColor = System.Drawing.Color.Transparent
        Me.chkMalayMenu.Location = New System.Drawing.Point(168, 22)
        Me.chkMalayMenu.Name = "chkMalayMenu"
        Me.chkMalayMenu.Size = New System.Drawing.Size(100, 20)
        Me.chkMalayMenu.TabIndex = 22
        Me.chkMalayMenu.Text = "Malay Menu"
        Me.chkMalayMenu.UseVisualStyleBackColor = False
        '
        'chkChineseMenu
        '
        Me.chkChineseMenu.AutoSize = True
        Me.chkChineseMenu.BackColor = System.Drawing.Color.Transparent
        Me.chkChineseMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChineseMenu.ForeColor = System.Drawing.Color.Transparent
        Me.chkChineseMenu.Location = New System.Drawing.Point(12, 47)
        Me.chkChineseMenu.Name = "chkChineseMenu"
        Me.chkChineseMenu.Size = New System.Drawing.Size(112, 20)
        Me.chkChineseMenu.TabIndex = 20
        Me.chkChineseMenu.Text = "Chinese Menu"
        Me.chkChineseMenu.UseVisualStyleBackColor = False
        '
        'chkWesternMenu
        '
        Me.chkWesternMenu.AutoSize = True
        Me.chkWesternMenu.BackColor = System.Drawing.Color.Transparent
        Me.chkWesternMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWesternMenu.ForeColor = System.Drawing.Color.Transparent
        Me.chkWesternMenu.Location = New System.Drawing.Point(12, 21)
        Me.chkWesternMenu.Name = "chkWesternMenu"
        Me.chkWesternMenu.Size = New System.Drawing.Size(113, 20)
        Me.chkWesternMenu.TabIndex = 19
        Me.chkWesternMenu.Text = "Western Menu"
        Me.chkWesternMenu.UseVisualStyleBackColor = False
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.BackColor = System.Drawing.Color.Transparent
        Me.lblTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTickets.ForeColor = System.Drawing.Color.Transparent
        Me.lblTickets.Location = New System.Drawing.Point(11, 21)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(55, 16)
        Me.lblTickets.TabIndex = 13
        Me.lblTickets.Text = "Tickets:"
        Me.lblTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnsTickets
        '
        Me.lblAnsTickets.BackColor = System.Drawing.SystemColors.Window
        Me.lblAnsTickets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnsTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsTickets.ForeColor = System.Drawing.Color.Black
        Me.lblAnsTickets.Location = New System.Drawing.Point(155, 16)
        Me.lblAnsTickets.Name = "lblAnsTickets"
        Me.lblAnsTickets.Size = New System.Drawing.Size(139, 26)
        Me.lblAnsTickets.TabIndex = 28
        Me.lblAnsTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnsTypes
        '
        Me.lblAnsTypes.BackColor = System.Drawing.SystemColors.Window
        Me.lblAnsTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnsTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsTypes.ForeColor = System.Drawing.Color.Black
        Me.lblAnsTypes.Location = New System.Drawing.Point(156, 48)
        Me.lblAnsTypes.Name = "lblAnsTypes"
        Me.lblAnsTypes.Size = New System.Drawing.Size(139, 26)
        Me.lblAnsTypes.TabIndex = 30
        Me.lblAnsTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTypes
        '
        Me.lblTypes.AutoSize = True
        Me.lblTypes.BackColor = System.Drawing.Color.Transparent
        Me.lblTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypes.ForeColor = System.Drawing.Color.Transparent
        Me.lblTypes.Location = New System.Drawing.Point(12, 53)
        Me.lblTypes.Name = "lblTypes"
        Me.lblTypes.Size = New System.Drawing.Size(50, 16)
        Me.lblTypes.TabIndex = 29
        Me.lblTypes.Text = "Types:"
        Me.lblTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnsBoatAndTrainRide
        '
        Me.lblAnsBoatAndTrainRide.BackColor = System.Drawing.SystemColors.Window
        Me.lblAnsBoatAndTrainRide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnsBoatAndTrainRide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsBoatAndTrainRide.ForeColor = System.Drawing.Color.Black
        Me.lblAnsBoatAndTrainRide.Location = New System.Drawing.Point(156, 79)
        Me.lblAnsBoatAndTrainRide.Name = "lblAnsBoatAndTrainRide"
        Me.lblAnsBoatAndTrainRide.Size = New System.Drawing.Size(139, 26)
        Me.lblAnsBoatAndTrainRide.TabIndex = 32
        Me.lblAnsBoatAndTrainRide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBoatAndTrainRide
        '
        Me.lblBoatAndTrainRide.AutoSize = True
        Me.lblBoatAndTrainRide.BackColor = System.Drawing.Color.Transparent
        Me.lblBoatAndTrainRide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoatAndTrainRide.ForeColor = System.Drawing.Color.Transparent
        Me.lblBoatAndTrainRide.Location = New System.Drawing.Point(12, 84)
        Me.lblBoatAndTrainRide.Name = "lblBoatAndTrainRide"
        Me.lblBoatAndTrainRide.Size = New System.Drawing.Size(131, 16)
        Me.lblBoatAndTrainRide.TabIndex = 31
        Me.lblBoatAndTrainRide.Text = "Boat and Train Ride:"
        Me.lblBoatAndTrainRide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnsShows
        '
        Me.lblAnsShows.BackColor = System.Drawing.SystemColors.Window
        Me.lblAnsShows.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnsShows.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsShows.ForeColor = System.Drawing.Color.Black
        Me.lblAnsShows.Location = New System.Drawing.Point(156, 109)
        Me.lblAnsShows.Name = "lblAnsShows"
        Me.lblAnsShows.Size = New System.Drawing.Size(139, 26)
        Me.lblAnsShows.TabIndex = 34
        Me.lblAnsShows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblShows
        '
        Me.lblShows.AutoSize = True
        Me.lblShows.BackColor = System.Drawing.Color.Transparent
        Me.lblShows.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShows.ForeColor = System.Drawing.Color.Transparent
        Me.lblShows.Location = New System.Drawing.Point(12, 114)
        Me.lblShows.Name = "lblShows"
        Me.lblShows.Size = New System.Drawing.Size(51, 16)
        Me.lblShows.TabIndex = 33
        Me.lblShows.Text = "Shows:"
        Me.lblShows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnsFoodMenu
        '
        Me.lblAnsFoodMenu.BackColor = System.Drawing.SystemColors.Window
        Me.lblAnsFoodMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnsFoodMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsFoodMenu.ForeColor = System.Drawing.Color.Black
        Me.lblAnsFoodMenu.Location = New System.Drawing.Point(155, 140)
        Me.lblAnsFoodMenu.Name = "lblAnsFoodMenu"
        Me.lblAnsFoodMenu.Size = New System.Drawing.Size(139, 26)
        Me.lblAnsFoodMenu.TabIndex = 36
        Me.lblAnsFoodMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFoodMenu
        '
        Me.lblFoodMenu.AutoSize = True
        Me.lblFoodMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblFoodMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodMenu.ForeColor = System.Drawing.Color.Transparent
        Me.lblFoodMenu.Location = New System.Drawing.Point(11, 145)
        Me.lblFoodMenu.Name = "lblFoodMenu"
        Me.lblFoodMenu.Size = New System.Drawing.Size(79, 16)
        Me.lblFoodMenu.TabIndex = 35
        Me.lblFoodMenu.Text = "Food Menu:"
        Me.lblFoodMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnsSubTotal1
        '
        Me.lblAnsSubTotal1.BackColor = System.Drawing.SystemColors.Window
        Me.lblAnsSubTotal1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnsSubTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsSubTotal1.ForeColor = System.Drawing.Color.Black
        Me.lblAnsSubTotal1.Location = New System.Drawing.Point(155, 171)
        Me.lblAnsSubTotal1.Name = "lblAnsSubTotal1"
        Me.lblAnsSubTotal1.Size = New System.Drawing.Size(139, 26)
        Me.lblAnsSubTotal1.TabIndex = 38
        Me.lblAnsSubTotal1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubTotal1
        '
        Me.lblSubTotal1.AutoSize = True
        Me.lblSubTotal1.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal1.ForeColor = System.Drawing.Color.Transparent
        Me.lblSubTotal1.Location = New System.Drawing.Point(11, 176)
        Me.lblSubTotal1.Name = "lblSubTotal1"
        Me.lblSubTotal1.Size = New System.Drawing.Size(84, 16)
        Me.lblSubTotal1.TabIndex = 37
        Me.lblSubTotal1.Text = "Sub Total(1):"
        Me.lblSubTotal1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnsDiscount
        '
        Me.lblAnsDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAnsDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnsDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsDiscount.ForeColor = System.Drawing.Color.Black
        Me.lblAnsDiscount.Location = New System.Drawing.Point(155, 203)
        Me.lblAnsDiscount.Name = "lblAnsDiscount"
        Me.lblAnsDiscount.Size = New System.Drawing.Size(140, 26)
        Me.lblAnsDiscount.TabIndex = 40
        Me.lblAnsDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(12, 208)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(63, 16)
        Me.lblDiscount.TabIndex = 39
        Me.lblDiscount.Text = "Discount:"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnsSubTotal2
        '
        Me.lblAnsSubTotal2.BackColor = System.Drawing.SystemColors.Window
        Me.lblAnsSubTotal2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnsSubTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsSubTotal2.ForeColor = System.Drawing.Color.Black
        Me.lblAnsSubTotal2.Location = New System.Drawing.Point(155, 235)
        Me.lblAnsSubTotal2.Name = "lblAnsSubTotal2"
        Me.lblAnsSubTotal2.Size = New System.Drawing.Size(139, 26)
        Me.lblAnsSubTotal2.TabIndex = 42
        Me.lblAnsSubTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubTotal2
        '
        Me.lblSubTotal2.AutoSize = True
        Me.lblSubTotal2.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal2.ForeColor = System.Drawing.Color.Transparent
        Me.lblSubTotal2.Location = New System.Drawing.Point(11, 240)
        Me.lblSubTotal2.Name = "lblSubTotal2"
        Me.lblSubTotal2.Size = New System.Drawing.Size(84, 16)
        Me.lblSubTotal2.TabIndex = 41
        Me.lblSubTotal2.Text = "Sub Total(2):"
        Me.lblSubTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnsGST
        '
        Me.lblAnsGST.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblAnsGST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnsGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsGST.ForeColor = System.Drawing.Color.Black
        Me.lblAnsGST.Location = New System.Drawing.Point(155, 266)
        Me.lblAnsGST.Name = "lblAnsGST"
        Me.lblAnsGST.Size = New System.Drawing.Size(139, 26)
        Me.lblAnsGST.TabIndex = 44
        Me.lblAnsGST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGST
        '
        Me.lblGST.AutoSize = True
        Me.lblGST.BackColor = System.Drawing.Color.Transparent
        Me.lblGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGST.ForeColor = System.Drawing.Color.Transparent
        Me.lblGST.Location = New System.Drawing.Point(11, 271)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(61, 16)
        Me.lblGST.TabIndex = 43
        Me.lblGST.Text = "GST 6%:"
        Me.lblGST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnsTotalPackage
        '
        Me.lblAnsTotalPackage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAnsTotalPackage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnsTotalPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsTotalPackage.ForeColor = System.Drawing.Color.Black
        Me.lblAnsTotalPackage.Location = New System.Drawing.Point(155, 296)
        Me.lblAnsTotalPackage.Name = "lblAnsTotalPackage"
        Me.lblAnsTotalPackage.Size = New System.Drawing.Size(139, 26)
        Me.lblAnsTotalPackage.TabIndex = 46
        Me.lblAnsTotalPackage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalPackage
        '
        Me.lblTotalPackage.AutoSize = True
        Me.lblTotalPackage.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPackage.ForeColor = System.Drawing.Color.Red
        Me.lblTotalPackage.Location = New System.Drawing.Point(11, 301)
        Me.lblTotalPackage.Name = "lblTotalPackage"
        Me.lblTotalPackage.Size = New System.Drawing.Size(100, 16)
        Me.lblTotalPackage.TabIndex = 45
        Me.lblTotalPackage.Text = "Total Package:"
        Me.lblTotalPackage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbCosts
        '
        Me.gbCosts.BackColor = System.Drawing.Color.DarkBlue
        Me.gbCosts.Controls.Add(Me.lblAnsTotalPackage)
        Me.gbCosts.Controls.Add(Me.lblTotalPackage)
        Me.gbCosts.Controls.Add(Me.lblAnsGST)
        Me.gbCosts.Controls.Add(Me.lblGST)
        Me.gbCosts.Controls.Add(Me.lblAnsSubTotal2)
        Me.gbCosts.Controls.Add(Me.lblSubTotal2)
        Me.gbCosts.Controls.Add(Me.lblAnsDiscount)
        Me.gbCosts.Controls.Add(Me.lblDiscount)
        Me.gbCosts.Controls.Add(Me.lblAnsSubTotal1)
        Me.gbCosts.Controls.Add(Me.lblSubTotal1)
        Me.gbCosts.Controls.Add(Me.lblAnsFoodMenu)
        Me.gbCosts.Controls.Add(Me.lblFoodMenu)
        Me.gbCosts.Controls.Add(Me.lblAnsShows)
        Me.gbCosts.Controls.Add(Me.lblShows)
        Me.gbCosts.Controls.Add(Me.lblAnsBoatAndTrainRide)
        Me.gbCosts.Controls.Add(Me.lblBoatAndTrainRide)
        Me.gbCosts.Controls.Add(Me.lblAnsTypes)
        Me.gbCosts.Controls.Add(Me.lblTypes)
        Me.gbCosts.Controls.Add(Me.lblAnsTickets)
        Me.gbCosts.Controls.Add(Me.lblTickets)
        Me.gbCosts.ForeColor = System.Drawing.Color.Aqua
        Me.gbCosts.Location = New System.Drawing.Point(6, 370)
        Me.gbCosts.Name = "gbCosts"
        Me.gbCosts.Size = New System.Drawing.Size(305, 335)
        Me.gbCosts.TabIndex = 47
        Me.gbCosts.TabStop = False
        Me.gbCosts.Text = "Costs"
        '
        'lblAnsRefNo
        '
        Me.lblAnsRefNo.BackColor = System.Drawing.SystemColors.Window
        Me.lblAnsRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsRefNo.ForeColor = System.Drawing.Color.Black
        Me.lblAnsRefNo.Location = New System.Drawing.Point(173, 24)
        Me.lblAnsRefNo.Name = "lblAnsRefNo"
        Me.lblAnsRefNo.Size = New System.Drawing.Size(139, 26)
        Me.lblAnsRefNo.TabIndex = 48
        Me.lblAnsRefNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefNo.ForeColor = System.Drawing.Color.Transparent
        Me.lblRefNo.Location = New System.Drawing.Point(29, 29)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(53, 16)
        Me.lblRefNo.TabIndex = 47
        Me.lblRefNo.Text = "Ref No:"
        Me.lblRefNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnsQuoteDate
        '
        Me.lblAnsQuoteDate.BackColor = System.Drawing.SystemColors.Window
        Me.lblAnsQuoteDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsQuoteDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsQuoteDate.ForeColor = System.Drawing.Color.Black
        Me.lblAnsQuoteDate.Location = New System.Drawing.Point(173, 56)
        Me.lblAnsQuoteDate.Name = "lblAnsQuoteDate"
        Me.lblAnsQuoteDate.Size = New System.Drawing.Size(139, 26)
        Me.lblAnsQuoteDate.TabIndex = 50
        Me.lblAnsQuoteDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuoteDate
        '
        Me.lblQuoteDate.AutoSize = True
        Me.lblQuoteDate.BackColor = System.Drawing.Color.Transparent
        Me.lblQuoteDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuoteDate.ForeColor = System.Drawing.Color.Transparent
        Me.lblQuoteDate.Location = New System.Drawing.Point(29, 61)
        Me.lblQuoteDate.Name = "lblQuoteDate"
        Me.lblQuoteDate.Size = New System.Drawing.Size(79, 16)
        Me.lblQuoteDate.TabIndex = 49
        Me.lblQuoteDate.Text = "Quote Date:"
        Me.lblQuoteDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnsValidTo
        '
        Me.lblAnsValidTo.BackColor = System.Drawing.SystemColors.Window
        Me.lblAnsValidTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsValidTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsValidTo.ForeColor = System.Drawing.Color.Black
        Me.lblAnsValidTo.Location = New System.Drawing.Point(173, 87)
        Me.lblAnsValidTo.Name = "lblAnsValidTo"
        Me.lblAnsValidTo.Size = New System.Drawing.Size(139, 26)
        Me.lblAnsValidTo.TabIndex = 52
        Me.lblAnsValidTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblValidto
        '
        Me.lblValidto.AutoSize = True
        Me.lblValidto.BackColor = System.Drawing.Color.Transparent
        Me.lblValidto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidto.ForeColor = System.Drawing.Color.Transparent
        Me.lblValidto.Location = New System.Drawing.Point(29, 92)
        Me.lblValidto.Name = "lblValidto"
        Me.lblValidto.Size = New System.Drawing.Size(56, 16)
        Me.lblValidto.TabIndex = 51
        Me.lblValidto.Text = "Valid to:"
        Me.lblValidto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbRefNo
        '
        Me.gbRefNo.BackColor = System.Drawing.Color.DarkBlue
        Me.gbRefNo.Controls.Add(Me.lblAnsValidTo)
        Me.gbRefNo.Controls.Add(Me.lblValidto)
        Me.gbRefNo.Controls.Add(Me.lblAnsQuoteDate)
        Me.gbRefNo.Controls.Add(Me.lblQuoteDate)
        Me.gbRefNo.Controls.Add(Me.lblAnsRefNo)
        Me.gbRefNo.Controls.Add(Me.lblRefNo)
        Me.gbRefNo.Location = New System.Drawing.Point(318, 370)
        Me.gbRefNo.Name = "gbRefNo"
        Me.gbRefNo.Size = New System.Drawing.Size(346, 135)
        Me.gbRefNo.TabIndex = 53
        Me.gbRefNo.TabStop = False
        '
        'gbButton
        '
        Me.gbButton.BackColor = System.Drawing.Color.DarkBlue
        Me.gbButton.Controls.Add(Me.btnPreview)
        Me.gbButton.Controls.Add(Me.btnExit)
        Me.gbButton.Controls.Add(Me.btnClear)
        Me.gbButton.Controls.Add(Me.btnBookPackage)
        Me.gbButton.Controls.Add(Me.btnCalc)
        Me.gbButton.Location = New System.Drawing.Point(318, 515)
        Me.gbButton.Name = "gbButton"
        Me.gbButton.Size = New System.Drawing.Size(345, 190)
        Me.gbButton.TabIndex = 58
        Me.gbButton.TabStop = False
        '
        'btnPreview
        '
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(180, 151)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(136, 53)
        Me.btnPreview.TabIndex = 63
        Me.btnPreview.Text = "&Print Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(180, 95)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 53)
        Me.btnExit.TabIndex = 61
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(32, 95)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(136, 53)
        Me.btnClear.TabIndex = 60
        Me.btnClear.Text = "&Clear All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBookPackage
        '
        Me.btnBookPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookPackage.Location = New System.Drawing.Point(180, 31)
        Me.btnBookPackage.Name = "btnBookPackage"
        Me.btnBookPackage.Size = New System.Drawing.Size(136, 53)
        Me.btnBookPackage.TabIndex = 59
        Me.btnBookPackage.Text = "&Book The Package"
        Me.btnBookPackage.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(32, 31)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(136, 53)
        Me.btnCalc.TabIndex = 58
        Me.btnCalc.Text = "Calculate &Quote"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(350, 669)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(136, 53)
        Me.btnPrint.TabIndex = 62
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'WonderlandThemePark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(683, 786)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.gbButton)
        Me.Controls.Add(Me.gbRefNo)
        Me.Controls.Add(Me.gbCosts)
        Me.Controls.Add(Me.gbFoodMenu)
        Me.Controls.Add(Me.gbShows)
        Me.Controls.Add(Me.gbBoatAndTrainRide)
        Me.Controls.Add(Me.gbTicketTypes)
        Me.Controls.Add(Me.gbCustomerDetails)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "WonderlandThemePark"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wonderland Theme Park Online Ticketing and Booking"
        Me.gbCustomerDetails.ResumeLayout(False)
        Me.gbCustomerDetails.PerformLayout()
        Me.gbTicketTypes.ResumeLayout(False)
        Me.gbTicketTypes.PerformLayout()
        Me.gbBoatAndTrainRide.ResumeLayout(False)
        Me.gbBoatAndTrainRide.PerformLayout()
        Me.gbShows.ResumeLayout(False)
        Me.gbShows.PerformLayout()
        Me.gbFoodMenu.ResumeLayout(False)
        Me.gbFoodMenu.PerformLayout()
        Me.gbCosts.ResumeLayout(False)
        Me.gbCosts.PerformLayout()
        Me.gbRefNo.ResumeLayout(False)
        Me.gbRefNo.PerformLayout()
        Me.gbButton.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblThemePark As System.Windows.Forms.Label
    Friend WithEvents cbThemePark As System.Windows.Forms.ComboBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerNumber As System.Windows.Forms.Label
    Friend WithEvents txtAdults As System.Windows.Forms.TextBox
    Friend WithEvents lblAdults As System.Windows.Forms.Label
    Friend WithEvents txtSeniorCitizen As System.Windows.Forms.TextBox
    Friend WithEvents lblSeniorCitizen As System.Windows.Forms.Label
    Friend WithEvents txtChildren As System.Windows.Forms.TextBox
    Friend WithEvents lblChildren As System.Windows.Forms.Label
    Friend WithEvents gbCustomerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents rbRegular As System.Windows.Forms.RadioButton
    Friend WithEvents rbExpress As System.Windows.Forms.RadioButton
    Friend WithEvents rbVVIP As System.Windows.Forms.RadioButton
    Friend WithEvents rbExpressUnlimited As System.Windows.Forms.RadioButton
    Friend WithEvents gbTicketTypes As System.Windows.Forms.GroupBox
    Friend WithEvents chkCruise As System.Windows.Forms.CheckBox
    Friend WithEvents chkBananaBoat As System.Windows.Forms.CheckBox
    Friend WithEvents chkDuckBoat As System.Windows.Forms.CheckBox
    Friend WithEvents chkCoupleTrain As System.Windows.Forms.CheckBox
    Friend WithEvents chkElectricTrain As System.Windows.Forms.CheckBox
    Friend WithEvents chkLocomotiveTrain As System.Windows.Forms.CheckBox
    Friend WithEvents gbBoatAndTrainRide As System.Windows.Forms.GroupBox
    Friend WithEvents gbShows As System.Windows.Forms.GroupBox
    Friend WithEvents chkNightFirework As System.Windows.Forms.CheckBox
    Friend WithEvents chkDayFirework As System.Windows.Forms.CheckBox
    Friend WithEvents chkDolphinShow As System.Windows.Forms.CheckBox
    Friend WithEvents chkMagicalShow As System.Windows.Forms.CheckBox
    Friend WithEvents gbFoodMenu As System.Windows.Forms.GroupBox
    Friend WithEvents chkJapeneseMenu As System.Windows.Forms.CheckBox
    Friend WithEvents chkMalayMenu As System.Windows.Forms.CheckBox
    Friend WithEvents chkChineseMenu As System.Windows.Forms.CheckBox
    Friend WithEvents chkWesternMenu As System.Windows.Forms.CheckBox
    Friend WithEvents lblTickets As System.Windows.Forms.Label
    Friend WithEvents lblAnsTickets As System.Windows.Forms.Label
    Friend WithEvents lblAnsTypes As System.Windows.Forms.Label
    Friend WithEvents lblTypes As System.Windows.Forms.Label
    Friend WithEvents lblAnsBoatAndTrainRide As System.Windows.Forms.Label
    Friend WithEvents lblBoatAndTrainRide As System.Windows.Forms.Label
    Friend WithEvents lblAnsShows As System.Windows.Forms.Label
    Friend WithEvents lblShows As System.Windows.Forms.Label
    Friend WithEvents lblAnsFoodMenu As System.Windows.Forms.Label
    Friend WithEvents lblFoodMenu As System.Windows.Forms.Label
    Friend WithEvents lblAnsSubTotal1 As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal1 As System.Windows.Forms.Label
    Friend WithEvents lblAnsDiscount As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblAnsSubTotal2 As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal2 As System.Windows.Forms.Label
    Friend WithEvents lblAnsGST As System.Windows.Forms.Label
    Friend WithEvents lblGST As System.Windows.Forms.Label
    Friend WithEvents lblAnsTotalPackage As System.Windows.Forms.Label
    Friend WithEvents lblTotalPackage As System.Windows.Forms.Label
    Friend WithEvents gbCosts As System.Windows.Forms.GroupBox
    Friend WithEvents lblAnsRefNo As System.Windows.Forms.Label
    Friend WithEvents lblRefNo As System.Windows.Forms.Label
    Friend WithEvents lblAnsQuoteDate As System.Windows.Forms.Label
    Friend WithEvents lblQuoteDate As System.Windows.Forms.Label
    Friend WithEvents lblAnsValidTo As System.Windows.Forms.Label
    Friend WithEvents lblValidto As System.Windows.Forms.Label
    Friend WithEvents gbRefNo As System.Windows.Forms.GroupBox
    Friend WithEvents gbButton As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBookPackage As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

End Class
