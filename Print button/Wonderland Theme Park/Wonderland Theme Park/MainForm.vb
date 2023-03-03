Public Class WonderlandThemePark

    'Create array structure for the WonderlandThemePark Tickets
    Private Structure ThemeTicketsMenu
        Dim strTicket As String
        Dim dblPriceAdults, dblPriceCitizen, dblPriceChildren As Double
    End Structure

    'Create array structure for the WonderlandThemePark Tickets
    Private Structure TicketsTypeMenu
        Dim strTicketCode As String
        Dim intMaxAvailability, intTicketCost As Integer
    End Structure

    'Declare array and variables
    Private ThemeTicket_Menu(2) As ThemeTicketsMenu
    Private TicketType_Menu(3) As TicketsTypeMenu

    Private TextToPrint As String = ""

    Private Sub WonderlandThemePark_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Displays the price assocuiated with WonderLand Theme Park Ticket
        ThemeTicket_Menu(0).strTicket = "WonderLAND"
        ThemeTicket_Menu(0).dblPriceAdults = 55.0
        ThemeTicket_Menu(0).dblPriceCitizen = 35.0
        ThemeTicket_Menu(0).dblPriceChildren = 20.0

        ThemeTicket_Menu(1).strTicket = "WonderSEA"
        ThemeTicket_Menu(1).dblPriceAdults = 65.0
        ThemeTicket_Menu(1).dblPriceCitizen = 45.0
        ThemeTicket_Menu(1).dblPriceChildren = 30.0

        ThemeTicket_Menu(2).strTicket = "Both Theme Parks"
        ThemeTicket_Menu(2).dblPriceAdults = 110.0
        ThemeTicket_Menu(2).dblPriceCitizen = 90.0
        ThemeTicket_Menu(2).dblPriceChildren = 40.0

        'Display WonderLand Theme Park Tickets into combo box
        For A As Integer = 0 To 2
            cbThemePark.Items.Add(ThemeTicket_Menu(A).strTicket)
            cbThemePark.SelectedIndex = 0
        Next

        'Use sub procedure to diaplay the price associated with the WonderLand Theme Park
        Call LoadTicketTypes()


    End Sub

    Private Sub Mainform_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult

        dlgButton = MessageBox.Show(" Do you want to Exit?", "Harvey Industries", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

        ' to verify that the user want to close the application
        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub LoadTicketTypes()
        'Display the price associated with WonderLand Theme Park Tickets Type
        TicketType_Menu(0).strTicketCode = "1"
        TicketType_Menu(0).intTicketCost = 0
        TicketType_Menu(0).intMaxAvailability = 100

        TicketType_Menu(1).strTicketCode = "2"
        TicketType_Menu(1).intTicketCost = 100
        TicketType_Menu(1).intMaxAvailability = 20

        TicketType_Menu(2).strTicketCode = "3"
        TicketType_Menu(2).intTicketCost = 200
        TicketType_Menu(2).intMaxAvailability = 10

        TicketType_Menu(3).strTicketCode = "4"
        TicketType_Menu(3).intTicketCost = 500
        TicketType_Menu(3).intMaxAvailability = 5
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'To close the form
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim dlgButton As DialogResult

        dlgButton = MessageBox.Show("Are you sure want to clear all the data?", "Clear Screen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = Windows.Forms.DialogResult.Yes Then
            Call ClearLabels()
        End If
    End Sub

    Private Sub ClearLabels()
        'Prepare the screen for the next order
        txtAdults.Text = ""
        txtChildren.Text = ""
        txtCustomerName.Text = ""
        txtCustomerNumber.Text = ""
        txtSeniorCitizen.Text = ""
        cbThemePark.SelectedIndex = 0
        rbRegular.Checked = False
        rbExpress.Checked = False
        rbExpressUnlimited.Checked = False
        rbVVIP.Checked = False
        lblAnsTickets.Text = ""
        lblAnsTypes.Text = ""
        lblAnsBoatAndTrainRide.Text = ""
        lblAnsShows.Text = ""
        lblAnsFoodMenu.Text = ""
        lblAnsSubTotal1.Text = ""
        lblAnsDiscount.Text = ""
        lblAnsSubTotal2.Text = ""
        lblAnsGST.Text = ""
        lblAnsTotalPackage.Text = ""
        chkCruise.Checked = False
        chkBananaBoat.Checked = False
        chkDuckBoat.Checked = False
        chkLocomotiveTrain.Checked = False
        chkElectricTrain.Checked = False
        chkCoupleTrain.Checked = False
        chkMagicalShow.Checked = False
        chkDolphinShow.Checked = False
        chkDayFirework.Checked = False
        chkNightFirework.Checked = False
        chkWesternMenu.Checked = False
        chkChineseMenu.Checked = False
        chkMalayMenu.Checked = False
        chkJapeneseMenu.Checked = False
        lblAnsRefNo.Text = ""
        lblAnsQuoteDate.Text = ""
        lblAnsValidTo.Text = ""

        'Send focus to the Customer Name textbox
        txtCustomerName.Focus()
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim strCustomerName, strCustNumber, strCustChoice As String
        Dim strErrorMsg As String = String.Empty
        Dim blnChecker As Boolean = True
        Dim blnrbChecker As Boolean = rbRegular.Checked OrElse rbExpress.Checked OrElse rbExpressUnlimited.Checked OrElse rbVVIP.Checked
        Dim intNoAdults, NoAdults, intNoCitizen, NoCitizen, intNoChildren, NoChildren, intCounter, NoCounter As Integer
        Dim intMaxAvailability, intTicketsPrice, intTicketTypePrice, intBoatAndTrainRidePrice, intShowsPrice, intFoodPrice As Integer
        Dim dblSubTotal1, dblDiscount, dblSubTotal2, dblGST, dblTotalPackage As Double

        Integer.TryParse(txtAdults.Text, NoAdults)
        Integer.TryParse(txtSeniorCitizen.Text, NoCitizen)
        Integer.TryParse(txtChildren.Text, NoChildren)

        strCustChoice = cbThemePark.Text

        strCustomerName = ValidateCustomerName(txtCustomerName.Text)
        strCustNumber = ValidateContactNumber(txtCustomerNumber.Text)
        intNoAdults = ValidateNoOfAdults(NoAdults)
        intNoCitizen = ValidateNoOfSeniorCitizen(NoCitizen)
        intNoChildren = ValidateNoOfChildren(NoChildren)

        'Invalid Customer Name
        If strCustomerName = "" Then
            strErrorMsg += "Invalid Customer Name" + ControlChars.NewLine
            blnChecker = False
        End If

        'Invalid Customer Number
        If strCustNumber = "" Then
            strErrorMsg += "Invalid Contact Number" + ControlChars.NewLine
            blnChecker = False
        End If

        'Invalid number of adults
        If intNoAdults = -1 Then
            strErrorMsg += "Invalid No of Adults" + ControlChars.NewLine
            blnChecker = False
        End If

        'Invalid number of senior citizen
        If intNoCitizen = -1 Then
            strErrorMsg += "Invalid No of Senior Citizen" + ControlChars.NewLine
            blnChecker = False
        End If

        'Invalid number of children
        If intNoChildren = -1 Then
            strErrorMsg += "Invalid No of Children"
            blnChecker = False
        End If

        'Display the error messages
        If blnChecker = False Then
            MessageBox.Show(strErrorMsg, "Error Message")
            Exit Sub
        End If

        'The ticket type is not selected, so diaplay an error messages
        If blnrbChecker = False Then
            MessageBox.Show("Please select a ticket type.", "Error Message")
            Exit Sub
        End If

        intMaxAvailability = ValidateTicketTypeAvailability(intNoAdults, intNoCitizen, intNoChildren)

        'if the number of customer is exceed the maximum availability of ticket type, then display an error message
        If intMaxAvailability = False Then
            MessageBox.Show("Ticket Type Availability Exceed. Please make separate bookings", "Error Message")
            Exit Sub
        End If

        intTicketsPrice = CalculateTickets(intNoAdults, intNoCitizen, intNoChildren, strCustChoice)
        lblAnsTickets.Text = intTicketsPrice.ToString("C2")

        intTicketTypePrice = CalculateTicketTypes()
        lblAnsTypes.Text = intTicketTypePrice.ToString("C2")

        intBoatAndTrainRidePrice = CalculateBoatAndTrainRide(intNoAdults, intNoCitizen, intNoChildren)
        lblAnsBoatAndTrainRide.Text = intBoatAndTrainRidePrice.ToString("C2")

        intShowsPrice = CalculateShows(intNoAdults, intNoCitizen, intNoChildren)
        lblAnsShows.Text = intShowsPrice.ToString("C2")

        intFoodPrice = CalculateFoodMenu(intNoAdults, intNoCitizen, intNoChildren)
        lblAnsFoodMenu.Text = intFoodPrice.ToString("C2")

        dblSubTotal1 = CalculateSubTotalOne(intTicketsPrice, intTicketTypePrice, intBoatAndTrainRidePrice, intShowsPrice, intFoodPrice)
        lblAnsSubTotal1.Text = dblSubTotal1.ToString("C2")

        dblDiscount = CalculateDiscount(dblSubTotal1, intNoAdults, intNoCitizen, intNoChildren)
        lblAnsDiscount.Text = dblDiscount.ToString("C2")

        dblSubTotal2 = CalculateSubTotalTwo(dblSubTotal1, dblDiscount)
        lblAnsSubTotal2.Text = dblSubTotal2.ToString("C2")

        dblGST = CalculateGST(dblSubTotal2)
        lblAnsGST.Text = dblGST.ToString("C2")

        dblTotalPackage = dblSubTotal2 + dblGST
        lblAnsTotalPackage.Text = dblTotalPackage.ToString("C2")

        'Display current date
        lblAnsQuoteDate.Text = Date.Now.ToString("d")

        'Display a quote is valid for 30 days
        lblAnsValidTo.Text = Date.Now.AddDays(30).ToString("d")
    End Sub

    Private Function ValidateCustomerName(ByVal CustName As String) As String
        Dim Position As Integer

        Position = CustName.IndexOf(" ")
        If Position > 0 Then
            Return CustName 'Valid Customer Name is entered
        Else
            Return "" 'Invalid Customer Name is entered
        End If
    End Function

    Private Function ValidateContactNumber(ByVal CustNumber As String)
        If CustNumber = "" OrElse Not IsNumeric(txtCustomerNumber.Text) Then
            Return "" 'Invalid Customer Number is entered
        Else
            Return CustNumber 'Valid Customer Number is entered
        End If
    End Function

    Private Function ValidateNoOfAdults(ByVal NumNoAdults As Integer) As Integer
        If NumNoAdults <= -1 OrElse Not IsNumeric(txtAdults.Text) OrElse txtAdults.Text = "" OrElse NumNoAdults > 1000 Then
            Return -1 'Invalid Number of Adults is entered 
        Else
            Return NumNoAdults 'Valid Number of Adults is entered
        End If
    End Function

    Private Function ValidateNoOfSeniorCitizen(ByVal NumNoCitizen As Integer) As Integer
        If NumNoCitizen <= -1 OrElse Not IsNumeric(txtSeniorCitizen.Text) OrElse txtSeniorCitizen.Text = "" OrElse NumNoCitizen > 1000 Then
            Return -1 'Invalid Number of Senior Citizen is entered 
        Else
            Return NumNoCitizen  'Valid Number of Senior Citizen is entered
        End If
    End Function

    Private Function ValidateNoOfChildren(ByVal NumNoChildren As Integer) As Integer
        If NumNoChildren <= -1 OrElse Not IsNumeric(txtChildren.Text) OrElse txtChildren.Text = "" OrElse NumNoChildren > 1000 Then
            Return -1 'Invalid Number of Children is entered 
        Else
            Return NumNoChildren 'Valid Number of Children is entered
        End If
    End Function

    Private Function CalculateTicketTypes() As Integer
        Dim intTicketTypePrice As Integer

        If rbRegular.Checked Then
            intTicketTypePrice = 0
        ElseIf rbExpress.Checked Then
            intTicketTypePrice = 100
        ElseIf rbExpressUnlimited.Checked Then
            intTicketTypePrice = 200
        Else
            intTicketTypePrice = 500
        End If

        Return intTicketTypePrice
    End Function

    Private Function ValidateTicketTypeAvailability(ByVal NumOfAdults As Integer, ByVal NumOfCitizen As Integer, ByVal NumOfChildren As Integer) As Integer
        Dim intCount, intMaxAvailability As Integer

        intCount = NumOfAdults + NumOfCitizen + NumOfChildren

        If rbRegular.Checked AndAlso intCount <= TicketType_Menu(0).intMaxAvailability Then
            intMaxAvailability = intCount
        ElseIf rbExpress.Checked AndAlso intCount <= TicketType_Menu(1).intMaxAvailability Then
            intMaxAvailability = intCount
        ElseIf rbExpressUnlimited.Checked AndAlso intCount <= TicketType_Menu(2).intMaxAvailability Then
            intMaxAvailability = intCount
        ElseIf rbVVIP.Checked AndAlso intCount <= TicketType_Menu(3).intMaxAvailability Then
            intMaxAvailability = intCount
        Else
            intMaxAvailability = False
        End If
        Return intMaxAvailability
    End Function

    Private Function CalculateBoatAndTrainRide(ByVal NumNoAdults As Integer, ByVal NumNoCitizens As Integer, ByVal NumNoChildren As Integer) As Integer
        Dim intBoatTrainRidePrice, intAdultsPrice, intCitizensPrice, intChildrenPrice As Integer

        If chkCruise.Checked Then
            intAdultsPrice = 30 * NumNoAdults
            intCitizensPrice = 25 * NumNoCitizens
            intChildrenPrice = 15 * NumNoChildren
            intBoatTrainRidePrice += intAdultsPrice + intChildrenPrice + intCitizensPrice
        End If

        If chkBananaBoat.Checked Then
            intAdultsPrice = 20 * NumNoAdults
            intCitizensPrice = 15 * NumNoCitizens
            intChildrenPrice = 10 * NumNoChildren
            intBoatTrainRidePrice += intAdultsPrice + intChildrenPrice + intCitizensPrice
        End If

        If chkDuckBoat.Checked Then
            intAdultsPrice = 20 * NumNoAdults
            intCitizensPrice = 15 * NumNoCitizens
            intChildrenPrice = 10 * NumNoChildren
            intBoatTrainRidePrice += intAdultsPrice + intChildrenPrice + intCitizensPrice
        End If

        If chkLocomotiveTrain.Checked Then
            intAdultsPrice = 25 * NumNoAdults
            intCitizensPrice = 20 * NumNoCitizens
            intChildrenPrice = 10 * NumNoChildren
            intBoatTrainRidePrice += intAdultsPrice + intChildrenPrice + intCitizensPrice
        End If

        If chkElectricTrain.Checked Then
            intAdultsPrice = 20 * NumNoAdults
            intCitizensPrice = 15 * NumNoCitizens
            intChildrenPrice = 10 * NumNoChildren
            intBoatTrainRidePrice += intAdultsPrice + intChildrenPrice + intCitizensPrice
        End If

        If chkCoupleTrain.Checked Then
            If NumNoAdults <= 0 Then
                MessageBox.Show("Couple Train Ride only for adults", "Couple Train Ride")
            Else
                intAdultsPrice = 40 * (NumNoAdults / 2)
                intBoatTrainRidePrice += intAdultsPrice
            End If
        End If
        Return intBoatTrainRidePrice
    End Function

    Private Function CalculateShows(ByVal NumNoAdults As Integer, ByVal NumNoCitizens As Integer, ByVal NumNoChildren As Integer) As Integer
        Dim intShowsPrice, intAdultsPrice, intCitizensPrice, intChildrenPrice As Integer

        If chkMagicalShow.Checked Then
            intAdultsPrice = 15 * NumNoAdults
            intCitizensPrice = 10 * NumNoCitizens
            intChildrenPrice = 5 * NumNoChildren
            intShowsPrice += intAdultsPrice + intCitizensPrice + intChildrenPrice
        End If

        If chkDolphinShow.Checked Then
            intAdultsPrice = 15 * NumNoAdults
            intCitizensPrice = 10 * NumNoCitizens
            intChildrenPrice = 5 * NumNoChildren
            intShowsPrice += intAdultsPrice + intCitizensPrice + intChildrenPrice
        End If

        If chkDayFirework.Checked Then
            intAdultsPrice = 20 * NumNoAdults
            intCitizensPrice = 15 * NumNoCitizens
            intChildrenPrice = 10 * NumNoChildren
            intShowsPrice += intAdultsPrice + intCitizensPrice + intChildrenPrice
        End If

        If chkNightFirework.Checked Then
            intAdultsPrice = 25 * NumNoAdults
            intCitizensPrice = 20 * NumNoCitizens
            intChildrenPrice = 10 * NumNoChildren
            intShowsPrice += intAdultsPrice + intCitizensPrice + intChildrenPrice
        End If
        Return intShowsPrice
    End Function

    Private Function CalculateFoodMenu(ByVal NumNoAdults As Integer, ByVal NumNoCitizens As Integer, ByVal NumNoChildren As Integer) As Integer
        Dim intFoodPrice, intMenuCounter, intAdultsPrice, intCitizensAndChildrenPrice As Integer

        intMenuCounter = 0

        If chkWesternMenu.Checked Then
            intMenuCounter += 1
        End If

        If chkChineseMenu.Checked Then
            intMenuCounter += 1
        End If

        If chkMalayMenu.Checked Then
            intMenuCounter += 1
        End If

        If chkJapeneseMenu.Checked Then
            intMenuCounter += 1
        End If

        Select Case intMenuCounter
            Case Is = 1
                intAdultsPrice = 20 * NumNoAdults
                intCitizensAndChildrenPrice = 10 * (NumNoCitizens + NumNoChildren)
                intFoodPrice = intAdultsPrice + intCitizensAndChildrenPrice
            Case Is = 2
                intAdultsPrice = 35 * NumNoAdults
                intCitizensAndChildrenPrice = 25 * (NumNoCitizens + NumNoChildren)
                intFoodPrice = intAdultsPrice + intCitizensAndChildrenPrice
            Case Is = 3
                intAdultsPrice = 55 * NumNoAdults
                intCitizensAndChildrenPrice = 40 * (NumNoCitizens + NumNoChildren)
                intFoodPrice = intAdultsPrice + intCitizensAndChildrenPrice
            Case Is = 4
                intAdultsPrice = 70 * NumNoAdults
                intCitizensAndChildrenPrice = 55 * (NumNoCitizens + NumNoChildren)
                intFoodPrice = intAdultsPrice + intCitizensAndChildrenPrice
        End Select

        Return intFoodPrice
    End Function

    Private Function CalculateTickets(ByVal NumNoAdults As Integer, ByVal NumNoCitizens As Integer, ByVal NumNoChildren As Integer, ByVal strCustChoice As String) As Integer
        Dim intTicketsPrice, intAdultsPrice, intCitizensPrice, intChildrenPrice As Integer

        For c As Integer = 0 To 2
            If strCustChoice = ThemeTicket_Menu(c).strTicket Then
                intAdultsPrice = NumNoAdults * ThemeTicket_Menu(c).dblPriceAdults
                intCitizensPrice = NumNoCitizens * ThemeTicket_Menu(c).dblPriceCitizen
                intChildrenPrice = NumNoChildren * ThemeTicket_Menu(c).dblPriceChildren
                intTicketsPrice = intAdultsPrice + intCitizensPrice + intChildrenPrice
            End If
        Next

        Return intTicketsPrice
    End Function

    Private Function CalculateSubTotalOne(ByVal TicketsPrice As Integer, ByVal TicketsTypePrice As Integer, ByVal BoatAndTrainPrice As Integer, ByVal ShowsPrice As Integer, ByVal FoodPrice As Integer) As Double
        Dim dblSubTotal1 As Double

        dblSubTotal1 = TicketsPrice + TicketsTypePrice + BoatAndTrainPrice + ShowsPrice + FoodPrice

        Return dblSubTotal1
    End Function

    Private Function CalculateDiscount(ByVal SubTotal1 As Double, ByVal NumNoAdults As Integer, ByVal NumNoCitizens As Integer, ByVal NumNoChildren As Integer) As Double
        Dim dblDiscount As Double
        Dim NoCounter As Integer

        NoCounter = NumNoAdults + NumNoCitizens + NumNoChildren

        If NoCounter > 10 Then
            dblDiscount = SubTotal1 * 0.05
        ElseIf NoCounter > 20 Then
            dblDiscount = SubTotal1 * 0.1
        End If

        Return dblDiscount
    End Function

    Private Function CalculateSubTotalTwo(ByVal SubTotal1 As Double, ByVal Discount As Double) As Double
        Dim dblSubTotal2 As Double

        dblSubTotal2 = SubTotal1 - Discount

        Return dblSubTotal2
    End Function

    Private Function CalculateGST(ByVal SubTotal2 As Double) As Double
        Dim dblGST As Double

        dblGST = SubTotal2 * 0.06

        Return dblGST
    End Function

    Private Sub btnBookPackage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookPackage.Click
        Dim DRefNo, DCustName, DCustContact, DNumNoAdults, DNumNoCitizens, DNumNoChildren, DRides, DShows, DFoodMenu, DThemePark, DTicketsType, DTotalCost As String
        Dim path As String = "...\Record.txt"
        Dim dlgButtons As DialogResult

        dlgButtons = MessageBox.Show("Do you confirm to save the package booking?", "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButtons = DialogResult.Yes Then
            If lblAnsTotalPackage.Text = "" Then
                MessageBox.Show("The booking is not successful. Please try again later!", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Static intNO As Integer
                Dim intRefNo As Integer
                intNO += 1
                intRefNo = intNO + 1000
                lblAnsRefNo.Text = intRefNo.ToString

                DRefNo = lblAnsRefNo.Text
                DCustName = txtCustomerName.Text
                DCustContact = txtCustomerNumber.Text
                DNumNoAdults = txtAdults.Text
                DNumNoCitizens = txtSeniorCitizen.Text
                DNumNoChildren = txtChildren.Text
                DRides = AddOnRides()
                DShows = AddOnShows()
                DFoodMenu = AddOnFood()
                DThemePark = cbThemePark.SelectedItem.ToString
                DTicketsType = AddOnTicketsType()
                DTotalCost = lblAnsTotalPackage.Text

                My.Computer.FileSystem.WriteAllText(path,
                                                    "Reference No.: " & DRefNo & ControlChars.NewLine &
                                                    "Customer Name: " & DCustName & ControlChars.NewLine &
                                                    "Customer Number: " & DCustContact & ControlChars.NewLine &
                                                    "Number of Adults: " & DNumNoAdults & ControlChars.NewLine &
                                                    "Number of Senior Citizens: " & DNumNoCitizens & ControlChars.NewLine &
                                                    "Number of Children: " & DNumNoChildren & ControlChars.NewLine &
                                                    "Boat and Train Rides: " & DRides & ControlChars.NewLine &
                                                    "Shows: " & DShows & ControlChars.NewLine &
                                                    "Food Menu: " & DFoodMenu & ControlChars.NewLine &
                                                    "Theme Park: " & DThemePark & ControlChars.NewLine &
                                                    "Ticket Type: " & DTicketsType & ControlChars.NewLine &
                                                    "Total Cost: " & DTotalCost & ControlChars.NewLine &
                                                    ControlChars.NewLine, True)
                MessageBox.Show("The booking is successful.", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim dlgButtonPrint As DialogResult
                dlgButtonPrint = MessageBox.Show("Do You want to print a receipt?", "Printing", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If dlgButtonPrint = Windows.Forms.DialogResult.Yes Then
                    btnPrint_Click(sender, e)
                End If
                Call ClearLabels()
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Function AddOnRides() As String
        Dim AddOnRidesDisplay As String = String.Empty

        If chkCruise.Checked Then
            AddOnRidesDisplay += "Cruise Ride "
        End If
        If chkBananaBoat.Checked Then
            AddOnRidesDisplay += "Banana Boat Ride "
        End If
        If chkDuckBoat.Checked Then
            AddOnRidesDisplay += "Duck Boat Ride "
        End If
        If chkLocomotiveTrain.Checked Then
            AddOnRidesDisplay += "Locomotive Train Ride "
        End If
        If chkElectricTrain.Checked Then
            AddOnRidesDisplay += "Electric Train Ride "
        End If
        If chkCoupleTrain.Checked Then
            AddOnRidesDisplay += "Couple Train Ride "
        End If
        Return AddOnRidesDisplay
    End Function

    Private Function AddOnShows() As String
        Dim AddOnShowsDisplay As String = String.Empty

        If chkMagicalShow.Checked Then
            AddOnShowsDisplay += "Magical Show "
        End If
        If chkDolphinShow.Checked Then
            AddOnShowsDisplay += "Dolphin Show "
        End If
        If chkDayFirework.Checked Then
            AddOnShowsDisplay += "Day-Firework Show "
        End If
        If chkNightFirework.Checked Then
            AddOnShowsDisplay += "Night-Firework Show "
        End If
        Return AddOnShowsDisplay
    End Function

    Private Function AddOnFood() As String
        Dim AddOnFoodDisplay As String = String.Empty

        If chkWesternMenu.Checked Then
            AddOnFoodDisplay += "Western Menu "
        End If
        If chkChineseMenu.Checked Then
            AddOnFoodDisplay += "Chinese Menu "
        End If
        If chkMalayMenu.Checked Then
            AddOnFoodDisplay += "Malay Menu "
        End If
        If chkJapeneseMenu.Checked Then
            AddOnFoodDisplay += "Japanese Menu "
        End If
        Return AddOnFoodDisplay
    End Function

    Private Function AddOnTicketsType() As String
        Dim AddOnTicketsTypeDisplay As String = String.Empty

        If rbRegular.Checked Then
            AddOnTicketsTypeDisplay = "Regular "
        ElseIf rbExpress.Checked Then
            AddOnTicketsTypeDisplay = "Express "
        ElseIf rbExpressUnlimited.Checked Then
            AddOnTicketsTypeDisplay = "Express Unlimited "
        ElseIf rbVVIP.Checked Then
            AddOnTicketsTypeDisplay = "VVIP "
        End If

        Return AddOnTicketsTypeDisplay
    End Function

    Private Sub Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbThemePark.SelectedIndexChanged, txtAdults.TextChanged, txtSeniorCitizen.TextChanged, txtChildren.TextChanged, rbExpress.CheckedChanged, rbExpressUnlimited.CheckedChanged, rbRegular.CheckedChanged, rbVVIP.CheckedChanged
        lblAnsTickets.Text = ""
        lblAnsTypes.Text = ""
        lblAnsBoatAndTrainRide.Text = ""
        lblAnsShows.Text = ""
        lblAnsFoodMenu.Text = ""
        lblAnsSubTotal1.Text = ""
        lblAnsDiscount.Text = ""
        lblAnsSubTotal2.Text = ""
        lblAnsGST.Text = ""
        lblAnsTotalPackage.Text = ""
    End Sub

    Private Sub SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerName.Click, txtCustomerName.Enter, txtCustomerNumber.Click, txtCustomerNumber.Enter, txtAdults.Click, txtAdults.Enter, txtSeniorCitizen.Click, txtSeniorCitizen.Enter, txtChildren.Click, txtChildren.Enter
        txtCustomerName.SelectAll()
        txtCustomerNumber.SelectAll()
        txtAdults.SelectAll()
        txtSeniorCitizen.SelectAll()
        txtChildren.SelectAll()
    End Sub

    Public Sub PrintHeader()
        TextToPrint = ""
        Dim globalLengt As Integer = 0

        'send Business Name
        Dim StringToPrint As String = "WonderLand Theme Park"
        Dim LineLen As Integer = StringToPrint.Length
        Dim spcLen1 As New String(" "c, Math.Round((64 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine

        'send address name
        StringToPrint = "Lot PT17178, Lebuh Ayer Keroh, "
        LineLen = StringToPrint.Length
        Dim spcLen2 As New String(" "c, Math.Round((64 - LineLen) / 2))
        TextToPrint &= spcLen2 & StringToPrint & Environment.NewLine

        StringToPrint = "Hang Tuah Jaya, "
        LineLen = StringToPrint.Length
        Dim spcLen3 As New String(" "c, Math.Round((64 - LineLen) / 2))
        TextToPrint &= spcLen3 & StringToPrint & Environment.NewLine

        ' send city, state, zip
        StringToPrint = "Ayer Keroh, Malacca, 75450."
        LineLen = StringToPrint.Length
        Dim spcLen4 As New String(" "c, Math.Round((64 - LineLen) / 2))
        TextToPrint &= spcLen4 & StringToPrint & Environment.NewLine

        ' send phone number
        StringToPrint = "+606-231 3333"
        LineLen = StringToPrint.Length
        Dim spcLen5 As New String(" "c, Math.Round((64 - LineLen) / 2))
        TextToPrint &= spcLen5 & StringToPrint & Environment.NewLine

        'send website
        StringToPrint = "www.melakawonderland.com.my/"
        LineLen = StringToPrint.Length
        Dim spcLen6 As New String(" "c, Math.Round((64 - LineLen) / 2))
        TextToPrint &= spcLen6 & StringToPrint & Environment.NewLine
    End Sub

    Public Sub ItemsToBePrinted()
        Dim StringToPrint As String = "Ref No. : " & lblAnsRefNo.Text
        Dim LineLen As String = StringToPrint.Length
        Dim spcLen7 As New String(" "c, Math.Round((64 - LineLen) / 2))
        TextToPrint &= spcLen7 & StringToPrint & Environment.NewLine & Environment.NewLine

        StringToPrint = "Details"
        LineLen = StringToPrint.Length
        TextToPrint &= spcLen7 & StringToPrint & Environment.NewLine

        StringToPrint = "Theme Park           : " & cbThemePark.SelectedItem.ToString
        LineLen = StringToPrint.Length
        Dim spcLen7a As New String("")
        TextToPrint &= spcLen7a & StringToPrint & Environment.NewLine

        StringToPrint = "Ticket Type          : " & AddOnTicketsType()
        LineLen = StringToPrint.Length
        TextToPrint &= spcLen7a & StringToPrint & Environment.NewLine

        StringToPrint = "Customer Name        : " & txtCustomerName.Text
        LineLen = StringToPrint.Length
        TextToPrint &= spcLen7a & StringToPrint & Environment.NewLine

        StringToPrint = "Customer Number      : " & txtCustomerNumber.Text
        LineLen = StringToPrint.Length
        TextToPrint &= spcLen7a & StringToPrint & Environment.NewLine

        If txtAdults.Text <> 0 Then
            StringToPrint = "Number of Adults     : " & txtAdults.Text
            LineLen = StringToPrint.Length
            TextToPrint &= spcLen7a & StringToPrint & Environment.NewLine
        End If

        If txtSeniorCitizen.Text <> 0 Then
            StringToPrint = "Number of Citizen    : " & txtSeniorCitizen.Text
            LineLen = StringToPrint.Length
            TextToPrint &= spcLen7a & StringToPrint & Environment.NewLine
        End If

        If txtChildren.Text <> 0 Then
            StringToPrint = "Number of Children   : " & txtChildren.Text
            LineLen = StringToPrint.Length
            TextToPrint &= spcLen7a & StringToPrint & Environment.NewLine
        End If

        StringToPrint = "Boat and Train Ride  : " & AddOnRides()
        LineLen = StringToPrint.Length
        TextToPrint &= spcLen7a & StringToPrint & Environment.NewLine

        StringToPrint = "Shows                : " & AddOnShows()
        LineLen = StringToPrint.Length
        TextToPrint &= spcLen7a & StringToPrint & Environment.NewLine

        StringToPrint = "Food Menu            : " & AddOnFood()
        LineLen = StringToPrint.Length
        TextToPrint &= spcLen7a & StringToPrint & Environment.NewLine


    End Sub

    Public Sub printFooter()
        TextToPrint &= Environment.NewLine
        Dim globalLengt As Integer = 0

        'SubTotal Amount
        Dim StringToPrint As String = "Sub Total       " & lblAnsSubTotal2.Text
        Dim LineLen As String = StringToPrint.Length
        globalLengt = StringToPrint.Length
        Dim spcLen8 As New String(" ", Math.Round((25 - LineLen)))
        TextToPrint &= Environment.NewLine & spcLen8 & StringToPrint & Environment.NewLine

        'GST Amount
        StringToPrint = "GST(6%)          " & lblAnsGST.Text
        LineLen = globalLengt
        Dim spcLen9 As New String(" ", Math.Round((25 - LineLen)))
        TextToPrint &= spcLen9 & StringToPrint & Environment.NewLine


        'Total Amount
        StringToPrint = "Total Package   " & lblAnsTotalPackage.Text
        LineLen = globalLengt
        Dim spcLen10 As New String(" "c, Math.Round((25 - LineLen)))
        TextToPrint &= spcLen10 & StringToPrint & Environment.NewLine & Environment.NewLine

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static currentChar As Integer
        Dim textfont As Font = New Font("Courier New", 15, FontStyle.Bold)

        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = 0
            w = 0
            left = 0
            top = 0
        End With


        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer


        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Courier New", 15, FontStyle.Bold), Brushes.Black, b, format)


        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim PrintDialog1 As New PrintDialog()
        PrintDialog1.Document = PrintDocument1
        Dim result As DialogResult = PrintDialog1.ShowDialog()

        If (result = DialogResult.OK) Then
            PrintHeader()
            ItemsToBePrinted()
            printFooter()
            Dim printControl = New Printing.StandardPrintController
            PrintDocument1.PrintController = printControl
            Dim dlgButtonPreview As DialogResult
            dlgButtonPreview = MessageBox.Show("Do you want to preview before print?", "Print Preview", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dlgButtonPreview = Windows.Forms.DialogResult.Yes Then
                PrintHeader()
                ItemsToBePrinted()
                printFooter()
                PrintPreviewDialog1.Document = PrintDocument1
                PrintPreviewDialog1.ShowDialog()
            End If

            Try
                PrintDocument1.Print()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        PrintHeader()
        ItemsToBePrinted()
        printFooter()
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class
