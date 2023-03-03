<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblWTPOTB = New System.Windows.Forms.Label()
        Me.gpCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.txtChildren = New System.Windows.Forms.TextBox()
        Me.txtSeniorCitizen = New System.Windows.Forms.TextBox()
        Me.txtAdults = New System.Windows.Forms.TextBox()
        Me.txtCustomerNumber = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.cboThemePark = New System.Windows.Forms.ComboBox()
        Me.lblThemePark = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblCustomerNumber = New System.Windows.Forms.Label()
        Me.lblAdults = New System.Windows.Forms.Label()
        Me.lblSeniorCitizen = New System.Windows.Forms.Label()
        Me.lblChildren = New System.Windows.Forms.Label()
        Me.gpBoatandTrainRide = New System.Windows.Forms.GroupBox()
        Me.cbCoupleTrainRide = New System.Windows.Forms.CheckBox()
        Me.cbElectricTrainRide = New System.Windows.Forms.CheckBox()
        Me.cbLocomotiveRide = New System.Windows.Forms.CheckBox()
        Me.cbDuckBoatRide = New System.Windows.Forms.CheckBox()
        Me.cbBananaBoatRide = New System.Windows.Forms.CheckBox()
        Me.cbCruiseRide = New System.Windows.Forms.CheckBox()
        Me.gpShows = New System.Windows.Forms.GroupBox()
        Me.cbMagicalShow = New System.Windows.Forms.CheckBox()
        Me.cbDayFireWorkShow = New System.Windows.Forms.CheckBox()
        Me.cbDolphinShow = New System.Windows.Forms.CheckBox()
        Me.cbNightFireworkShow = New System.Windows.Forms.CheckBox()
        Me.gpTicketTypes = New System.Windows.Forms.GroupBox()
        Me.rbVVIP = New System.Windows.Forms.RadioButton()
        Me.rbExpressUnlimited = New System.Windows.Forms.RadioButton()
        Me.rbExpress = New System.Windows.Forms.RadioButton()
        Me.rbRegular = New System.Windows.Forms.RadioButton()
        Me.gpFoodMenu = New System.Windows.Forms.GroupBox()
        Me.cbWesternMenu = New System.Windows.Forms.CheckBox()
        Me.cbMalayMenu = New System.Windows.Forms.CheckBox()
        Me.cbChineseMenu = New System.Windows.Forms.CheckBox()
        Me.cbJapaneseMenu = New System.Windows.Forms.CheckBox()
        Me.gpCosts = New System.Windows.Forms.GroupBox()
        Me.lblAnsTotalPackage = New System.Windows.Forms.Label()
        Me.lblAnsGST = New System.Windows.Forms.Label()
        Me.lblST2 = New System.Windows.Forms.Label()
        Me.lblAnsDiscount = New System.Windows.Forms.Label()
        Me.lblST1 = New System.Windows.Forms.Label()
        Me.lblAnsFoodMenu = New System.Windows.Forms.Label()
        Me.lblAnsShows = New System.Windows.Forms.Label()
        Me.lblAnsBoatandTrainRide = New System.Windows.Forms.Label()
        Me.lblAnsTypes = New System.Windows.Forms.Label()
        Me.lblAnsTickets = New System.Windows.Forms.Label()
        Me.lblTotalPackage = New System.Windows.Forms.Label()
        Me.lblGST = New System.Windows.Forms.Label()
        Me.lblSubTotal2 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblSubTotal1 = New System.Windows.Forms.Label()
        Me.lblFoodMenu = New System.Windows.Forms.Label()
        Me.lblShows = New System.Windows.Forms.Label()
        Me.lblBoatandTrainRide = New System.Windows.Forms.Label()
        Me.lblTypes = New System.Windows.Forms.Label()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAnsRefNo = New System.Windows.Forms.Label()
        Me.lblAnsQuoteDate = New System.Windows.Forms.Label()
        Me.lblAnsValidto = New System.Windows.Forms.Label()
        Me.lblValid = New System.Windows.Forms.Label()
        Me.lblQuoteDate = New System.Windows.Forms.Label()
        Me.lblRefNo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBahasaMelayu = New System.Windows.Forms.Button()
        Me.btnBC1 = New System.Windows.Forms.Button()
        Me.btnCalculateQuote = New System.Windows.Forms.Button()
        Me.btnBookThePackage = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gpCustomerDetails.SuspendLayout()
        Me.gpBoatandTrainRide.SuspendLayout()
        Me.gpShows.SuspendLayout()
        Me.gpTicketTypes.SuspendLayout()
        Me.gpFoodMenu.SuspendLayout()
        Me.gpCosts.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWTPOTB
        '
        Me.lblWTPOTB.AutoSize = True
        Me.lblWTPOTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWTPOTB.Location = New System.Drawing.Point(71, 9)
        Me.lblWTPOTB.Name = "lblWTPOTB"
        Me.lblWTPOTB.Size = New System.Drawing.Size(525, 24)
        Me.lblWTPOTB.TabIndex = 0
        Me.lblWTPOTB.Text = "Wonderland Theme Park Online Ticketing and Booking"
        '
        'gpCustomerDetails
        '
        Me.gpCustomerDetails.BackColor = System.Drawing.Color.DarkBlue
        Me.gpCustomerDetails.Controls.Add(Me.txtChildren)
        Me.gpCustomerDetails.Controls.Add(Me.txtSeniorCitizen)
        Me.gpCustomerDetails.Controls.Add(Me.txtAdults)
        Me.gpCustomerDetails.Controls.Add(Me.txtCustomerNumber)
        Me.gpCustomerDetails.Controls.Add(Me.txtCustomerName)
        Me.gpCustomerDetails.Controls.Add(Me.cboThemePark)
        Me.gpCustomerDetails.Controls.Add(Me.lblThemePark)
        Me.gpCustomerDetails.Controls.Add(Me.lblCustomerName)
        Me.gpCustomerDetails.Controls.Add(Me.lblCustomerNumber)
        Me.gpCustomerDetails.Controls.Add(Me.lblAdults)
        Me.gpCustomerDetails.Controls.Add(Me.lblSeniorCitizen)
        Me.gpCustomerDetails.Controls.Add(Me.lblChildren)
        Me.gpCustomerDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpCustomerDetails.ForeColor = System.Drawing.Color.DodgerBlue
        Me.gpCustomerDetails.Location = New System.Drawing.Point(12, 49)
        Me.gpCustomerDetails.Name = "gpCustomerDetails"
        Me.gpCustomerDetails.Size = New System.Drawing.Size(292, 230)
        Me.gpCustomerDetails.TabIndex = 1
        Me.gpCustomerDetails.TabStop = False
        Me.gpCustomerDetails.Text = "Customer Details"
        '
        'txtChildren
        '
        Me.txtChildren.Location = New System.Drawing.Point(152, 176)
        Me.txtChildren.Name = "txtChildren"
        Me.txtChildren.Size = New System.Drawing.Size(121, 22)
        Me.txtChildren.TabIndex = 13
        '
        'txtSeniorCitizen
        '
        Me.txtSeniorCitizen.Location = New System.Drawing.Point(152, 148)
        Me.txtSeniorCitizen.Name = "txtSeniorCitizen"
        Me.txtSeniorCitizen.Size = New System.Drawing.Size(121, 22)
        Me.txtSeniorCitizen.TabIndex = 12
        '
        'txtAdults
        '
        Me.txtAdults.Location = New System.Drawing.Point(152, 120)
        Me.txtAdults.Name = "txtAdults"
        Me.txtAdults.Size = New System.Drawing.Size(121, 22)
        Me.txtAdults.TabIndex = 11
        '
        'txtCustomerNumber
        '
        Me.txtCustomerNumber.Location = New System.Drawing.Point(152, 92)
        Me.txtCustomerNumber.Name = "txtCustomerNumber"
        Me.txtCustomerNumber.Size = New System.Drawing.Size(121, 22)
        Me.txtCustomerNumber.TabIndex = 10
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(152, 64)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(121, 22)
        Me.txtCustomerName.TabIndex = 9
        '
        'cboThemePark
        '
        Me.cboThemePark.FormattingEnabled = True
        Me.cboThemePark.Location = New System.Drawing.Point(152, 35)
        Me.cboThemePark.Name = "cboThemePark"
        Me.cboThemePark.Size = New System.Drawing.Size(121, 24)
        Me.cboThemePark.TabIndex = 8
        '
        'lblThemePark
        '
        Me.lblThemePark.AutoSize = True
        Me.lblThemePark.BackColor = System.Drawing.Color.DarkBlue
        Me.lblThemePark.ForeColor = System.Drawing.Color.White
        Me.lblThemePark.Location = New System.Drawing.Point(20, 35)
        Me.lblThemePark.Name = "lblThemePark"
        Me.lblThemePark.Size = New System.Drawing.Size(88, 16)
        Me.lblThemePark.TabIndex = 2
        Me.lblThemePark.Text = "Theme Park :"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.BackColor = System.Drawing.Color.DarkBlue
        Me.lblCustomerName.ForeColor = System.Drawing.Color.White
        Me.lblCustomerName.Location = New System.Drawing.Point(20, 64)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(111, 16)
        Me.lblCustomerName.TabIndex = 3
        Me.lblCustomerName.Text = "Customer Name :"
        '
        'lblCustomerNumber
        '
        Me.lblCustomerNumber.AutoSize = True
        Me.lblCustomerNumber.BackColor = System.Drawing.Color.DarkBlue
        Me.lblCustomerNumber.ForeColor = System.Drawing.Color.White
        Me.lblCustomerNumber.Location = New System.Drawing.Point(20, 92)
        Me.lblCustomerNumber.Name = "lblCustomerNumber"
        Me.lblCustomerNumber.Size = New System.Drawing.Size(122, 16)
        Me.lblCustomerNumber.TabIndex = 4
        Me.lblCustomerNumber.Text = "Customer Number :"
        '
        'lblAdults
        '
        Me.lblAdults.AutoSize = True
        Me.lblAdults.BackColor = System.Drawing.Color.DarkBlue
        Me.lblAdults.ForeColor = System.Drawing.Color.White
        Me.lblAdults.Location = New System.Drawing.Point(20, 120)
        Me.lblAdults.Name = "lblAdults"
        Me.lblAdults.Size = New System.Drawing.Size(51, 16)
        Me.lblAdults.TabIndex = 5
        Me.lblAdults.Text = "Adults :"
        '
        'lblSeniorCitizen
        '
        Me.lblSeniorCitizen.AutoSize = True
        Me.lblSeniorCitizen.BackColor = System.Drawing.Color.DarkBlue
        Me.lblSeniorCitizen.ForeColor = System.Drawing.Color.White
        Me.lblSeniorCitizen.Location = New System.Drawing.Point(20, 148)
        Me.lblSeniorCitizen.Name = "lblSeniorCitizen"
        Me.lblSeniorCitizen.Size = New System.Drawing.Size(95, 16)
        Me.lblSeniorCitizen.TabIndex = 6
        Me.lblSeniorCitizen.Text = "Senior Citizen :"
        '
        'lblChildren
        '
        Me.lblChildren.AutoSize = True
        Me.lblChildren.BackColor = System.Drawing.Color.DarkBlue
        Me.lblChildren.ForeColor = System.Drawing.Color.White
        Me.lblChildren.Location = New System.Drawing.Point(20, 176)
        Me.lblChildren.Name = "lblChildren"
        Me.lblChildren.Size = New System.Drawing.Size(63, 16)
        Me.lblChildren.TabIndex = 7
        Me.lblChildren.Text = "Children :"
        '
        'gpBoatandTrainRide
        '
        Me.gpBoatandTrainRide.BackColor = System.Drawing.Color.DarkBlue
        Me.gpBoatandTrainRide.Controls.Add(Me.cbCoupleTrainRide)
        Me.gpBoatandTrainRide.Controls.Add(Me.cbElectricTrainRide)
        Me.gpBoatandTrainRide.Controls.Add(Me.cbLocomotiveRide)
        Me.gpBoatandTrainRide.Controls.Add(Me.cbDuckBoatRide)
        Me.gpBoatandTrainRide.Controls.Add(Me.cbBananaBoatRide)
        Me.gpBoatandTrainRide.Controls.Add(Me.cbCruiseRide)
        Me.gpBoatandTrainRide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBoatandTrainRide.ForeColor = System.Drawing.Color.DodgerBlue
        Me.gpBoatandTrainRide.Location = New System.Drawing.Point(321, 49)
        Me.gpBoatandTrainRide.Name = "gpBoatandTrainRide"
        Me.gpBoatandTrainRide.Size = New System.Drawing.Size(327, 114)
        Me.gpBoatandTrainRide.TabIndex = 2
        Me.gpBoatandTrainRide.TabStop = False
        Me.gpBoatandTrainRide.Text = "Boat and Train Ride"
        '
        'cbCoupleTrainRide
        '
        Me.cbCoupleTrainRide.AutoSize = True
        Me.cbCoupleTrainRide.ForeColor = System.Drawing.Color.White
        Me.cbCoupleTrainRide.Location = New System.Drawing.Point(174, 79)
        Me.cbCoupleTrainRide.Name = "cbCoupleTrainRide"
        Me.cbCoupleTrainRide.Size = New System.Drawing.Size(136, 20)
        Me.cbCoupleTrainRide.TabIndex = 5
        Me.cbCoupleTrainRide.Text = "Couple Train Ride"
        Me.cbCoupleTrainRide.UseVisualStyleBackColor = True
        '
        'cbElectricTrainRide
        '
        Me.cbElectricTrainRide.AutoSize = True
        Me.cbElectricTrainRide.ForeColor = System.Drawing.Color.White
        Me.cbElectricTrainRide.Location = New System.Drawing.Point(174, 53)
        Me.cbElectricTrainRide.Name = "cbElectricTrainRide"
        Me.cbElectricTrainRide.Size = New System.Drawing.Size(137, 20)
        Me.cbElectricTrainRide.TabIndex = 4
        Me.cbElectricTrainRide.Text = "Electric Train Ride"
        Me.cbElectricTrainRide.UseVisualStyleBackColor = True
        '
        'cbLocomotiveRide
        '
        Me.cbLocomotiveRide.AutoSize = True
        Me.cbLocomotiveRide.ForeColor = System.Drawing.Color.White
        Me.cbLocomotiveRide.Location = New System.Drawing.Point(174, 27)
        Me.cbLocomotiveRide.Name = "cbLocomotiveRide"
        Me.cbLocomotiveRide.Size = New System.Drawing.Size(129, 20)
        Me.cbLocomotiveRide.TabIndex = 3
        Me.cbLocomotiveRide.Text = "Locomotive Ride"
        Me.cbLocomotiveRide.UseVisualStyleBackColor = True
        '
        'cbDuckBoatRide
        '
        Me.cbDuckBoatRide.AutoSize = True
        Me.cbDuckBoatRide.ForeColor = System.Drawing.Color.White
        Me.cbDuckBoatRide.Location = New System.Drawing.Point(23, 79)
        Me.cbDuckBoatRide.Name = "cbDuckBoatRide"
        Me.cbDuckBoatRide.Size = New System.Drawing.Size(121, 20)
        Me.cbDuckBoatRide.TabIndex = 2
        Me.cbDuckBoatRide.Text = "Duck Boat Ride"
        Me.cbDuckBoatRide.UseVisualStyleBackColor = True
        '
        'cbBananaBoatRide
        '
        Me.cbBananaBoatRide.AutoSize = True
        Me.cbBananaBoatRide.ForeColor = System.Drawing.Color.White
        Me.cbBananaBoatRide.Location = New System.Drawing.Point(23, 53)
        Me.cbBananaBoatRide.Name = "cbBananaBoatRide"
        Me.cbBananaBoatRide.Size = New System.Drawing.Size(137, 20)
        Me.cbBananaBoatRide.TabIndex = 1
        Me.cbBananaBoatRide.Text = "Banana Boat Ride"
        Me.cbBananaBoatRide.UseVisualStyleBackColor = True
        '
        'cbCruiseRide
        '
        Me.cbCruiseRide.AutoSize = True
        Me.cbCruiseRide.ForeColor = System.Drawing.Color.White
        Me.cbCruiseRide.Location = New System.Drawing.Point(23, 27)
        Me.cbCruiseRide.Name = "cbCruiseRide"
        Me.cbCruiseRide.Size = New System.Drawing.Size(97, 20)
        Me.cbCruiseRide.TabIndex = 0
        Me.cbCruiseRide.Text = "Cruise Ride"
        Me.cbCruiseRide.UseVisualStyleBackColor = True
        '
        'gpShows
        '
        Me.gpShows.BackColor = System.Drawing.Color.DarkBlue
        Me.gpShows.Controls.Add(Me.cbMagicalShow)
        Me.gpShows.Controls.Add(Me.cbDayFireWorkShow)
        Me.gpShows.Controls.Add(Me.cbDolphinShow)
        Me.gpShows.Controls.Add(Me.cbNightFireworkShow)
        Me.gpShows.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpShows.ForeColor = System.Drawing.Color.DodgerBlue
        Me.gpShows.Location = New System.Drawing.Point(321, 179)
        Me.gpShows.Name = "gpShows"
        Me.gpShows.Size = New System.Drawing.Size(327, 100)
        Me.gpShows.TabIndex = 3
        Me.gpShows.TabStop = False
        Me.gpShows.Text = "Shows"
        '
        'cbMagicalShow
        '
        Me.cbMagicalShow.AutoSize = True
        Me.cbMagicalShow.ForeColor = System.Drawing.Color.White
        Me.cbMagicalShow.Location = New System.Drawing.Point(23, 33)
        Me.cbMagicalShow.Name = "cbMagicalShow"
        Me.cbMagicalShow.Size = New System.Drawing.Size(111, 20)
        Me.cbMagicalShow.TabIndex = 5
        Me.cbMagicalShow.Text = "Magical Show"
        Me.cbMagicalShow.UseVisualStyleBackColor = True
        '
        'cbDayFireWorkShow
        '
        Me.cbDayFireWorkShow.AutoSize = True
        Me.cbDayFireWorkShow.ForeColor = System.Drawing.Color.White
        Me.cbDayFireWorkShow.Location = New System.Drawing.Point(167, 33)
        Me.cbDayFireWorkShow.Name = "cbDayFireWorkShow"
        Me.cbDayFireWorkShow.Size = New System.Drawing.Size(146, 20)
        Me.cbDayFireWorkShow.TabIndex = 4
        Me.cbDayFireWorkShow.Text = "Day-Firework Show "
        Me.cbDayFireWorkShow.UseVisualStyleBackColor = True
        '
        'cbDolphinShow
        '
        Me.cbDolphinShow.AutoSize = True
        Me.cbDolphinShow.ForeColor = System.Drawing.Color.White
        Me.cbDolphinShow.Location = New System.Drawing.Point(23, 59)
        Me.cbDolphinShow.Name = "cbDolphinShow"
        Me.cbDolphinShow.Size = New System.Drawing.Size(109, 20)
        Me.cbDolphinShow.TabIndex = 3
        Me.cbDolphinShow.Text = "Dolphin Show"
        Me.cbDolphinShow.UseVisualStyleBackColor = True
        '
        'cbNightFireworkShow
        '
        Me.cbNightFireworkShow.AutoSize = True
        Me.cbNightFireworkShow.ForeColor = System.Drawing.Color.White
        Me.cbNightFireworkShow.Location = New System.Drawing.Point(167, 59)
        Me.cbNightFireworkShow.Name = "cbNightFireworkShow"
        Me.cbNightFireworkShow.Size = New System.Drawing.Size(149, 20)
        Me.cbNightFireworkShow.TabIndex = 2
        Me.cbNightFireworkShow.Text = "Night-Firework Show"
        Me.cbNightFireworkShow.UseVisualStyleBackColor = True
        '
        'gpTicketTypes
        '
        Me.gpTicketTypes.BackColor = System.Drawing.Color.DarkBlue
        Me.gpTicketTypes.Controls.Add(Me.rbVVIP)
        Me.gpTicketTypes.Controls.Add(Me.rbExpressUnlimited)
        Me.gpTicketTypes.Controls.Add(Me.rbExpress)
        Me.gpTicketTypes.Controls.Add(Me.rbRegular)
        Me.gpTicketTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpTicketTypes.ForeColor = System.Drawing.Color.DodgerBlue
        Me.gpTicketTypes.Location = New System.Drawing.Point(12, 300)
        Me.gpTicketTypes.Name = "gpTicketTypes"
        Me.gpTicketTypes.Size = New System.Drawing.Size(292, 92)
        Me.gpTicketTypes.TabIndex = 4
        Me.gpTicketTypes.TabStop = False
        Me.gpTicketTypes.Text = "Ticket Types"
        '
        'rbVVIP
        '
        Me.rbVVIP.AutoSize = True
        Me.rbVVIP.ForeColor = System.Drawing.Color.White
        Me.rbVVIP.Location = New System.Drawing.Point(134, 54)
        Me.rbVVIP.Name = "rbVVIP"
        Me.rbVVIP.Size = New System.Drawing.Size(56, 20)
        Me.rbVVIP.TabIndex = 3
        Me.rbVVIP.TabStop = True
        Me.rbVVIP.Text = "VVIP"
        Me.rbVVIP.UseVisualStyleBackColor = True
        '
        'rbExpressUnlimited
        '
        Me.rbExpressUnlimited.AutoSize = True
        Me.rbExpressUnlimited.ForeColor = System.Drawing.Color.White
        Me.rbExpressUnlimited.Location = New System.Drawing.Point(134, 28)
        Me.rbExpressUnlimited.Name = "rbExpressUnlimited"
        Me.rbExpressUnlimited.Size = New System.Drawing.Size(134, 20)
        Me.rbExpressUnlimited.TabIndex = 2
        Me.rbExpressUnlimited.TabStop = True
        Me.rbExpressUnlimited.Text = "Express Unlimited"
        Me.rbExpressUnlimited.UseVisualStyleBackColor = True
        '
        'rbExpress
        '
        Me.rbExpress.AutoSize = True
        Me.rbExpress.ForeColor = System.Drawing.Color.White
        Me.rbExpress.Location = New System.Drawing.Point(22, 54)
        Me.rbExpress.Name = "rbExpress"
        Me.rbExpress.Size = New System.Drawing.Size(75, 20)
        Me.rbExpress.TabIndex = 1
        Me.rbExpress.TabStop = True
        Me.rbExpress.Text = "Express"
        Me.rbExpress.UseVisualStyleBackColor = True
        '
        'rbRegular
        '
        Me.rbRegular.AutoSize = True
        Me.rbRegular.ForeColor = System.Drawing.Color.White
        Me.rbRegular.Location = New System.Drawing.Point(23, 28)
        Me.rbRegular.Name = "rbRegular"
        Me.rbRegular.Size = New System.Drawing.Size(74, 20)
        Me.rbRegular.TabIndex = 0
        Me.rbRegular.TabStop = True
        Me.rbRegular.Text = "Regular"
        Me.rbRegular.UseVisualStyleBackColor = True
        '
        'gpFoodMenu
        '
        Me.gpFoodMenu.BackColor = System.Drawing.Color.DarkBlue
        Me.gpFoodMenu.Controls.Add(Me.cbWesternMenu)
        Me.gpFoodMenu.Controls.Add(Me.cbMalayMenu)
        Me.gpFoodMenu.Controls.Add(Me.cbChineseMenu)
        Me.gpFoodMenu.Controls.Add(Me.cbJapaneseMenu)
        Me.gpFoodMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpFoodMenu.ForeColor = System.Drawing.Color.DodgerBlue
        Me.gpFoodMenu.Location = New System.Drawing.Point(321, 300)
        Me.gpFoodMenu.Name = "gpFoodMenu"
        Me.gpFoodMenu.Size = New System.Drawing.Size(327, 92)
        Me.gpFoodMenu.TabIndex = 5
        Me.gpFoodMenu.TabStop = False
        Me.gpFoodMenu.Text = "Food Menu"
        '
        'cbWesternMenu
        '
        Me.cbWesternMenu.AutoSize = True
        Me.cbWesternMenu.ForeColor = System.Drawing.Color.White
        Me.cbWesternMenu.Location = New System.Drawing.Point(23, 33)
        Me.cbWesternMenu.Name = "cbWesternMenu"
        Me.cbWesternMenu.Size = New System.Drawing.Size(113, 20)
        Me.cbWesternMenu.TabIndex = 5
        Me.cbWesternMenu.Text = "Western Menu"
        Me.cbWesternMenu.UseVisualStyleBackColor = True
        '
        'cbMalayMenu
        '
        Me.cbMalayMenu.AutoSize = True
        Me.cbMalayMenu.ForeColor = System.Drawing.Color.White
        Me.cbMalayMenu.Location = New System.Drawing.Point(167, 33)
        Me.cbMalayMenu.Name = "cbMalayMenu"
        Me.cbMalayMenu.Size = New System.Drawing.Size(100, 20)
        Me.cbMalayMenu.TabIndex = 4
        Me.cbMalayMenu.Text = "Malay Menu"
        Me.cbMalayMenu.UseVisualStyleBackColor = True
        '
        'cbChineseMenu
        '
        Me.cbChineseMenu.AutoSize = True
        Me.cbChineseMenu.ForeColor = System.Drawing.Color.White
        Me.cbChineseMenu.Location = New System.Drawing.Point(23, 59)
        Me.cbChineseMenu.Name = "cbChineseMenu"
        Me.cbChineseMenu.Size = New System.Drawing.Size(112, 20)
        Me.cbChineseMenu.TabIndex = 3
        Me.cbChineseMenu.Text = "Chinese Menu"
        Me.cbChineseMenu.UseVisualStyleBackColor = True
        '
        'cbJapaneseMenu
        '
        Me.cbJapaneseMenu.AutoSize = True
        Me.cbJapaneseMenu.ForeColor = System.Drawing.Color.White
        Me.cbJapaneseMenu.Location = New System.Drawing.Point(167, 59)
        Me.cbJapaneseMenu.Name = "cbJapaneseMenu"
        Me.cbJapaneseMenu.Size = New System.Drawing.Size(124, 20)
        Me.cbJapaneseMenu.TabIndex = 2
        Me.cbJapaneseMenu.Text = "Japanese Menu"
        Me.cbJapaneseMenu.UseVisualStyleBackColor = True
        '
        'gpCosts
        '
        Me.gpCosts.BackColor = System.Drawing.Color.DarkBlue
        Me.gpCosts.Controls.Add(Me.lblAnsTotalPackage)
        Me.gpCosts.Controls.Add(Me.lblAnsGST)
        Me.gpCosts.Controls.Add(Me.lblST2)
        Me.gpCosts.Controls.Add(Me.lblAnsDiscount)
        Me.gpCosts.Controls.Add(Me.lblST1)
        Me.gpCosts.Controls.Add(Me.lblAnsFoodMenu)
        Me.gpCosts.Controls.Add(Me.lblAnsShows)
        Me.gpCosts.Controls.Add(Me.lblAnsBoatandTrainRide)
        Me.gpCosts.Controls.Add(Me.lblAnsTypes)
        Me.gpCosts.Controls.Add(Me.lblAnsTickets)
        Me.gpCosts.Controls.Add(Me.lblTotalPackage)
        Me.gpCosts.Controls.Add(Me.lblGST)
        Me.gpCosts.Controls.Add(Me.lblSubTotal2)
        Me.gpCosts.Controls.Add(Me.lblDiscount)
        Me.gpCosts.Controls.Add(Me.lblSubTotal1)
        Me.gpCosts.Controls.Add(Me.lblFoodMenu)
        Me.gpCosts.Controls.Add(Me.lblShows)
        Me.gpCosts.Controls.Add(Me.lblBoatandTrainRide)
        Me.gpCosts.Controls.Add(Me.lblTypes)
        Me.gpCosts.Controls.Add(Me.lblTickets)
        Me.gpCosts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpCosts.ForeColor = System.Drawing.Color.DodgerBlue
        Me.gpCosts.Location = New System.Drawing.Point(12, 407)
        Me.gpCosts.Name = "gpCosts"
        Me.gpCosts.Size = New System.Drawing.Size(292, 347)
        Me.gpCosts.TabIndex = 6
        Me.gpCosts.TabStop = False
        Me.gpCosts.Text = "Costs"
        '
        'lblAnsTotalPackage
        '
        Me.lblAnsTotalPackage.BackColor = System.Drawing.Color.Red
        Me.lblAnsTotalPackage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsTotalPackage.ForeColor = System.Drawing.Color.Black
        Me.lblAnsTotalPackage.Location = New System.Drawing.Point(186, 306)
        Me.lblAnsTotalPackage.Name = "lblAnsTotalPackage"
        Me.lblAnsTotalPackage.Size = New System.Drawing.Size(87, 16)
        Me.lblAnsTotalPackage.TabIndex = 19
        '
        'lblAnsGST
        '
        Me.lblAnsGST.BackColor = System.Drawing.Color.White
        Me.lblAnsGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsGST.ForeColor = System.Drawing.Color.Black
        Me.lblAnsGST.Location = New System.Drawing.Point(186, 274)
        Me.lblAnsGST.Name = "lblAnsGST"
        Me.lblAnsGST.Size = New System.Drawing.Size(87, 16)
        Me.lblAnsGST.TabIndex = 18
        '
        'lblST2
        '
        Me.lblST2.BackColor = System.Drawing.Color.White
        Me.lblST2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblST2.ForeColor = System.Drawing.Color.Black
        Me.lblST2.Location = New System.Drawing.Point(186, 241)
        Me.lblST2.Name = "lblST2"
        Me.lblST2.Size = New System.Drawing.Size(87, 16)
        Me.lblST2.TabIndex = 17
        '
        'lblAnsDiscount
        '
        Me.lblAnsDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAnsDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsDiscount.ForeColor = System.Drawing.Color.Black
        Me.lblAnsDiscount.Location = New System.Drawing.Point(186, 215)
        Me.lblAnsDiscount.Name = "lblAnsDiscount"
        Me.lblAnsDiscount.Size = New System.Drawing.Size(88, 16)
        Me.lblAnsDiscount.TabIndex = 16
        '
        'lblST1
        '
        Me.lblST1.BackColor = System.Drawing.Color.White
        Me.lblST1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblST1.ForeColor = System.Drawing.Color.Black
        Me.lblST1.Location = New System.Drawing.Point(186, 186)
        Me.lblST1.Name = "lblST1"
        Me.lblST1.Size = New System.Drawing.Size(87, 16)
        Me.lblST1.TabIndex = 15
        '
        'lblAnsFoodMenu
        '
        Me.lblAnsFoodMenu.BackColor = System.Drawing.Color.White
        Me.lblAnsFoodMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsFoodMenu.ForeColor = System.Drawing.Color.Black
        Me.lblAnsFoodMenu.Location = New System.Drawing.Point(186, 155)
        Me.lblAnsFoodMenu.Name = "lblAnsFoodMenu"
        Me.lblAnsFoodMenu.Size = New System.Drawing.Size(88, 16)
        Me.lblAnsFoodMenu.TabIndex = 14
        '
        'lblAnsShows
        '
        Me.lblAnsShows.BackColor = System.Drawing.Color.White
        Me.lblAnsShows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsShows.ForeColor = System.Drawing.Color.Black
        Me.lblAnsShows.Location = New System.Drawing.Point(186, 127)
        Me.lblAnsShows.Name = "lblAnsShows"
        Me.lblAnsShows.Size = New System.Drawing.Size(88, 16)
        Me.lblAnsShows.TabIndex = 13
        '
        'lblAnsBoatandTrainRide
        '
        Me.lblAnsBoatandTrainRide.BackColor = System.Drawing.Color.White
        Me.lblAnsBoatandTrainRide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsBoatandTrainRide.ForeColor = System.Drawing.Color.Black
        Me.lblAnsBoatandTrainRide.Location = New System.Drawing.Point(186, 97)
        Me.lblAnsBoatandTrainRide.Name = "lblAnsBoatandTrainRide"
        Me.lblAnsBoatandTrainRide.Size = New System.Drawing.Size(88, 16)
        Me.lblAnsBoatandTrainRide.TabIndex = 12
        '
        'lblAnsTypes
        '
        Me.lblAnsTypes.BackColor = System.Drawing.Color.White
        Me.lblAnsTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsTypes.ForeColor = System.Drawing.Color.Black
        Me.lblAnsTypes.Location = New System.Drawing.Point(186, 68)
        Me.lblAnsTypes.Name = "lblAnsTypes"
        Me.lblAnsTypes.Size = New System.Drawing.Size(88, 16)
        Me.lblAnsTypes.TabIndex = 11
        '
        'lblAnsTickets
        '
        Me.lblAnsTickets.BackColor = System.Drawing.Color.White
        Me.lblAnsTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsTickets.ForeColor = System.Drawing.Color.Black
        Me.lblAnsTickets.Location = New System.Drawing.Point(186, 38)
        Me.lblAnsTickets.Name = "lblAnsTickets"
        Me.lblAnsTickets.Size = New System.Drawing.Size(88, 16)
        Me.lblAnsTickets.TabIndex = 10
        '
        'lblTotalPackage
        '
        Me.lblTotalPackage.AutoSize = True
        Me.lblTotalPackage.ForeColor = System.Drawing.Color.Red
        Me.lblTotalPackage.Location = New System.Drawing.Point(20, 306)
        Me.lblTotalPackage.Name = "lblTotalPackage"
        Me.lblTotalPackage.Size = New System.Drawing.Size(103, 16)
        Me.lblTotalPackage.TabIndex = 9
        Me.lblTotalPackage.Text = "Total Package :"
        '
        'lblGST
        '
        Me.lblGST.AutoSize = True
        Me.lblGST.ForeColor = System.Drawing.Color.White
        Me.lblGST.Location = New System.Drawing.Point(19, 275)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(64, 16)
        Me.lblGST.TabIndex = 8
        Me.lblGST.Text = "GST 6% :"
        '
        'lblSubTotal2
        '
        Me.lblSubTotal2.AutoSize = True
        Me.lblSubTotal2.ForeColor = System.Drawing.Color.White
        Me.lblSubTotal2.Location = New System.Drawing.Point(19, 241)
        Me.lblSubTotal2.Name = "lblSubTotal2"
        Me.lblSubTotal2.Size = New System.Drawing.Size(90, 16)
        Me.lblSubTotal2.TabIndex = 7
        Me.lblSubTotal2.Text = "Sub Total (2) :"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(19, 215)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(66, 16)
        Me.lblDiscount.TabIndex = 6
        Me.lblDiscount.Text = "Discount :"
        '
        'lblSubTotal1
        '
        Me.lblSubTotal1.AutoSize = True
        Me.lblSubTotal1.ForeColor = System.Drawing.Color.White
        Me.lblSubTotal1.Location = New System.Drawing.Point(20, 187)
        Me.lblSubTotal1.Name = "lblSubTotal1"
        Me.lblSubTotal1.Size = New System.Drawing.Size(90, 16)
        Me.lblSubTotal1.TabIndex = 5
        Me.lblSubTotal1.Text = "Sub Total (1) :"
        '
        'lblFoodMenu
        '
        Me.lblFoodMenu.AutoSize = True
        Me.lblFoodMenu.ForeColor = System.Drawing.Color.White
        Me.lblFoodMenu.Location = New System.Drawing.Point(20, 155)
        Me.lblFoodMenu.Name = "lblFoodMenu"
        Me.lblFoodMenu.Size = New System.Drawing.Size(82, 16)
        Me.lblFoodMenu.TabIndex = 4
        Me.lblFoodMenu.Text = "Food Menu :"
        '
        'lblShows
        '
        Me.lblShows.AutoSize = True
        Me.lblShows.ForeColor = System.Drawing.Color.White
        Me.lblShows.Location = New System.Drawing.Point(19, 127)
        Me.lblShows.Name = "lblShows"
        Me.lblShows.Size = New System.Drawing.Size(54, 16)
        Me.lblShows.TabIndex = 3
        Me.lblShows.Text = "Shows :"
        '
        'lblBoatandTrainRide
        '
        Me.lblBoatandTrainRide.AutoSize = True
        Me.lblBoatandTrainRide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoatandTrainRide.ForeColor = System.Drawing.Color.White
        Me.lblBoatandTrainRide.Location = New System.Drawing.Point(19, 98)
        Me.lblBoatandTrainRide.Name = "lblBoatandTrainRide"
        Me.lblBoatandTrainRide.Size = New System.Drawing.Size(134, 16)
        Me.lblBoatandTrainRide.TabIndex = 2
        Me.lblBoatandTrainRide.Text = "Boat and Train Ride :"
        '
        'lblTypes
        '
        Me.lblTypes.AutoSize = True
        Me.lblTypes.ForeColor = System.Drawing.Color.White
        Me.lblTypes.Location = New System.Drawing.Point(19, 69)
        Me.lblTypes.Name = "lblTypes"
        Me.lblTypes.Size = New System.Drawing.Size(53, 16)
        Me.lblTypes.TabIndex = 1
        Me.lblTypes.Text = "Types :"
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.ForeColor = System.Drawing.Color.White
        Me.lblTickets.Location = New System.Drawing.Point(20, 38)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(58, 16)
        Me.lblTickets.TabIndex = 0
        Me.lblTickets.Text = "Tickets :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkBlue
        Me.GroupBox1.Controls.Add(Me.lblAnsRefNo)
        Me.GroupBox1.Controls.Add(Me.lblAnsQuoteDate)
        Me.GroupBox1.Controls.Add(Me.lblAnsValidto)
        Me.GroupBox1.Controls.Add(Me.lblValid)
        Me.GroupBox1.Controls.Add(Me.lblQuoteDate)
        Me.GroupBox1.Controls.Add(Me.lblRefNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(321, 407)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 132)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'lblAnsRefNo
        '
        Me.lblAnsRefNo.BackColor = System.Drawing.Color.White
        Me.lblAnsRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsRefNo.ForeColor = System.Drawing.Color.Black
        Me.lblAnsRefNo.Location = New System.Drawing.Point(134, 27)
        Me.lblAnsRefNo.Name = "lblAnsRefNo"
        Me.lblAnsRefNo.Size = New System.Drawing.Size(150, 16)
        Me.lblAnsRefNo.TabIndex = 20
        '
        'lblAnsQuoteDate
        '
        Me.lblAnsQuoteDate.BackColor = System.Drawing.Color.White
        Me.lblAnsQuoteDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsQuoteDate.ForeColor = System.Drawing.Color.Black
        Me.lblAnsQuoteDate.Location = New System.Drawing.Point(134, 58)
        Me.lblAnsQuoteDate.Name = "lblAnsQuoteDate"
        Me.lblAnsQuoteDate.Size = New System.Drawing.Size(150, 16)
        Me.lblAnsQuoteDate.TabIndex = 21
        '
        'lblAnsValidto
        '
        Me.lblAnsValidto.BackColor = System.Drawing.Color.White
        Me.lblAnsValidto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnsValidto.ForeColor = System.Drawing.Color.Black
        Me.lblAnsValidto.Location = New System.Drawing.Point(134, 87)
        Me.lblAnsValidto.Name = "lblAnsValidto"
        Me.lblAnsValidto.Size = New System.Drawing.Size(150, 16)
        Me.lblAnsValidto.TabIndex = 22
        '
        'lblValid
        '
        Me.lblValid.AutoSize = True
        Me.lblValid.ForeColor = System.Drawing.Color.White
        Me.lblValid.Location = New System.Drawing.Point(12, 87)
        Me.lblValid.Name = "lblValid"
        Me.lblValid.Size = New System.Drawing.Size(59, 16)
        Me.lblValid.TabIndex = 2
        Me.lblValid.Text = "Valid to :"
        '
        'lblQuoteDate
        '
        Me.lblQuoteDate.AutoSize = True
        Me.lblQuoteDate.ForeColor = System.Drawing.Color.White
        Me.lblQuoteDate.Location = New System.Drawing.Point(12, 58)
        Me.lblQuoteDate.Name = "lblQuoteDate"
        Me.lblQuoteDate.Size = New System.Drawing.Size(82, 16)
        Me.lblQuoteDate.TabIndex = 1
        Me.lblQuoteDate.Text = "Quote Date :"
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.ForeColor = System.Drawing.Color.White
        Me.lblRefNo.Location = New System.Drawing.Point(12, 27)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(56, 16)
        Me.lblRefNo.TabIndex = 0
        Me.lblRefNo.Text = "Ref No :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkBlue
        Me.GroupBox2.Controls.Add(Me.btnBahasaMelayu)
        Me.GroupBox2.Controls.Add(Me.btnBC1)
        Me.GroupBox2.Controls.Add(Me.btnCalculateQuote)
        Me.GroupBox2.Controls.Add(Me.btnBookThePackage)
        Me.GroupBox2.Controls.Add(Me.btnClearAll)
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox2.Location = New System.Drawing.Point(321, 562)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 192)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'btnBahasaMelayu
        '
        Me.btnBahasaMelayu.ForeColor = System.Drawing.Color.Black
        Me.btnBahasaMelayu.Location = New System.Drawing.Point(15, 127)
        Me.btnBahasaMelayu.Name = "btnBahasaMelayu"
        Me.btnBahasaMelayu.Size = New System.Drawing.Size(120, 40)
        Me.btnBahasaMelayu.TabIndex = 12
        Me.btnBahasaMelayu.Text = "Bahasa Melayu"
        Me.btnBahasaMelayu.UseVisualStyleBackColor = True
        '
        'btnBC1
        '
        Me.btnBC1.ForeColor = System.Drawing.Color.Black
        Me.btnBC1.Location = New System.Drawing.Point(163, 126)
        Me.btnBC1.Name = "btnBC1"
        Me.btnBC1.Size = New System.Drawing.Size(121, 41)
        Me.btnBC1.TabIndex = 8
        Me.btnBC1.Text = "中文"
        Me.btnBC1.UseVisualStyleBackColor = True
        '
        'btnCalculateQuote
        '
        Me.btnCalculateQuote.ForeColor = System.Drawing.Color.Black
        Me.btnCalculateQuote.Location = New System.Drawing.Point(15, 18)
        Me.btnCalculateQuote.Name = "btnCalculateQuote"
        Me.btnCalculateQuote.Size = New System.Drawing.Size(119, 45)
        Me.btnCalculateQuote.TabIndex = 8
        Me.btnCalculateQuote.Text = "Calculate Quote"
        Me.btnCalculateQuote.UseVisualStyleBackColor = True
        '
        'btnBookThePackage
        '
        Me.btnBookThePackage.ForeColor = System.Drawing.Color.Black
        Me.btnBookThePackage.Location = New System.Drawing.Point(163, 18)
        Me.btnBookThePackage.Name = "btnBookThePackage"
        Me.btnBookThePackage.Size = New System.Drawing.Size(121, 45)
        Me.btnBookThePackage.TabIndex = 9
        Me.btnBookThePackage.Text = "Book The Package"
        Me.btnBookThePackage.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.ForeColor = System.Drawing.Color.Black
        Me.btnClearAll.Location = New System.Drawing.Point(15, 72)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(121, 45)
        Me.btnClearAll.TabIndex = 10
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(163, 72)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 48)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(675, 827)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gpCosts)
        Me.Controls.Add(Me.gpFoodMenu)
        Me.Controls.Add(Me.gpTicketTypes)
        Me.Controls.Add(Me.gpShows)
        Me.Controls.Add(Me.gpBoatandTrainRide)
        Me.Controls.Add(Me.gpCustomerDetails)
        Me.Controls.Add(Me.lblWTPOTB)
        Me.Name = "Form1"
        Me.Text = "Wonderland Theme Park Online Ticketing and Booking"
        Me.gpCustomerDetails.ResumeLayout(False)
        Me.gpCustomerDetails.PerformLayout()
        Me.gpBoatandTrainRide.ResumeLayout(False)
        Me.gpBoatandTrainRide.PerformLayout()
        Me.gpShows.ResumeLayout(False)
        Me.gpShows.PerformLayout()
        Me.gpTicketTypes.ResumeLayout(False)
        Me.gpTicketTypes.PerformLayout()
        Me.gpFoodMenu.ResumeLayout(False)
        Me.gpFoodMenu.PerformLayout()
        Me.gpCosts.ResumeLayout(False)
        Me.gpCosts.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWTPOTB As System.Windows.Forms.Label
    Friend WithEvents gpCustomerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtChildren As System.Windows.Forms.TextBox
    Friend WithEvents txtSeniorCitizen As System.Windows.Forms.TextBox
    Friend WithEvents txtAdults As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents cboThemePark As System.Windows.Forms.ComboBox
    Friend WithEvents lblThemePark As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents lblCustomerNumber As System.Windows.Forms.Label
    Friend WithEvents lblAdults As System.Windows.Forms.Label
    Friend WithEvents lblSeniorCitizen As System.Windows.Forms.Label
    Friend WithEvents lblChildren As System.Windows.Forms.Label
    Friend WithEvents gpBoatandTrainRide As System.Windows.Forms.GroupBox
    Friend WithEvents cbCoupleTrainRide As System.Windows.Forms.CheckBox
    Friend WithEvents cbElectricTrainRide As System.Windows.Forms.CheckBox
    Friend WithEvents cbLocomotiveRide As System.Windows.Forms.CheckBox
    Friend WithEvents cbDuckBoatRide As System.Windows.Forms.CheckBox
    Friend WithEvents cbBananaBoatRide As System.Windows.Forms.CheckBox
    Friend WithEvents cbCruiseRide As System.Windows.Forms.CheckBox
    Friend WithEvents gpShows As System.Windows.Forms.GroupBox
    Friend WithEvents cbMagicalShow As System.Windows.Forms.CheckBox
    Friend WithEvents cbDayFireWorkShow As System.Windows.Forms.CheckBox
    Friend WithEvents cbDolphinShow As System.Windows.Forms.CheckBox
    Friend WithEvents cbNightFireworkShow As System.Windows.Forms.CheckBox
    Friend WithEvents gpTicketTypes As System.Windows.Forms.GroupBox
    Friend WithEvents rbVVIP As System.Windows.Forms.RadioButton
    Friend WithEvents rbExpressUnlimited As System.Windows.Forms.RadioButton
    Friend WithEvents rbExpress As System.Windows.Forms.RadioButton
    Friend WithEvents rbRegular As System.Windows.Forms.RadioButton
    Friend WithEvents gpFoodMenu As System.Windows.Forms.GroupBox
    Friend WithEvents cbWesternMenu As System.Windows.Forms.CheckBox
    Friend WithEvents cbMalayMenu As System.Windows.Forms.CheckBox
    Friend WithEvents cbChineseMenu As System.Windows.Forms.CheckBox
    Friend WithEvents cbJapaneseMenu As System.Windows.Forms.CheckBox
    Friend WithEvents gpCosts As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalPackage As System.Windows.Forms.Label
    Friend WithEvents lblGST As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal2 As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal1 As System.Windows.Forms.Label
    Friend WithEvents lblFoodMenu As System.Windows.Forms.Label
    Friend WithEvents lblShows As System.Windows.Forms.Label
    Friend WithEvents lblBoatandTrainRide As System.Windows.Forms.Label
    Friend WithEvents lblTypes As System.Windows.Forms.Label
    Friend WithEvents lblTickets As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblValid As System.Windows.Forms.Label
    Friend WithEvents lblQuoteDate As System.Windows.Forms.Label
    Friend WithEvents lblRefNo As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculateQuote As System.Windows.Forms.Button
    Friend WithEvents btnBookThePackage As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblAnsTotalPackage As System.Windows.Forms.Label
    Friend WithEvents lblAnsGST As System.Windows.Forms.Label
    Friend WithEvents lblST2 As System.Windows.Forms.Label
    Friend WithEvents lblAnsDiscount As System.Windows.Forms.Label
    Friend WithEvents lblST1 As System.Windows.Forms.Label
    Friend WithEvents lblAnsFoodMenu As System.Windows.Forms.Label
    Friend WithEvents lblAnsShows As System.Windows.Forms.Label
    Friend WithEvents lblAnsBoatandTrainRide As System.Windows.Forms.Label
    Friend WithEvents lblAnsTypes As System.Windows.Forms.Label
    Friend WithEvents lblAnsTickets As System.Windows.Forms.Label
    Friend WithEvents lblAnsRefNo As System.Windows.Forms.Label
    Friend WithEvents lblAnsQuoteDate As System.Windows.Forms.Label
    Friend WithEvents lblAnsValidto As System.Windows.Forms.Label
    Friend WithEvents btnBC1 As System.Windows.Forms.Button
    Friend WithEvents btnBahasaMelayu As System.Windows.Forms.Button

End Class
