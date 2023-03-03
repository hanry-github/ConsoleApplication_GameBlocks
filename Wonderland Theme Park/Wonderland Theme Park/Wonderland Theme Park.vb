Public Class Form1
    'Create array structure for the WonderlandThemePark Tickets Menu
    Private Structure WonderlandThemeParkTicketsMenu
        Dim strTicketMenu As String
        Dim dblAdultsPrice, dblSeniorCitizenPrice, dblChildrenPrice As Double

    End Structure
    'Declare array and variables
    Private T_Menu(2) As WonderlandThemeParkTicketsMenu

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Display WonderLand Theme Park Tickets Price respectively
        T_Menu(0).strTicketMenu = "WonderLAND"
        T_Menu(0).dblAdultsPrice = 55.0
        T_Menu(0).dblSeniorCitizenPrice = 35.0
        T_Menu(0).dblChildrenPrice = 20.0

        T_Menu(1).strTicketMenu = "WonderSEA"
        T_Menu(1).dblAdultsPrice = 65.0
        T_Menu(1).dblSeniorCitizenPrice = 45.0
        T_Menu(1).dblChildrenPrice = 30.0

        T_Menu(2).strTicketMenu = "Both Theme Parks"
        T_Menu(2).dblAdultsPrice = 110.0
        T_Menu(2).dblSeniorCitizenPrice = 90.0
        T_Menu(2).dblChildrenPrice = 40.0

        'Add WonderLand Theme Park Tickets into combo box
        For THEMEPARKMENU As Integer = 0 To 2
            cboThemePark.Items.Add(T_Menu(THEMEPARKMENU).strTicketMenu)
        Next
        'Call procedure from private sub LoadTicketTypes()
        Call LoadTicketTypes()

    End Sub
    'Create array structure for the WonderlandThemePark TicketTypes
    Private Structure TicketTypes
        Dim strTicketType As String
        Dim dblCost, dblMaxAvailability As Double
    End Structure
    'Declare array and variables
    Private T_Type(3) As TicketTypes
    Private Sub LoadTicketTypes()
        'Display WonderLandThemePark TicketsType prices respectively
        T_Type(0).strTicketType = "Regular"
        T_Type(0).dblCost = 0
        T_Type(0).dblMaxAvailability = 100
        T_Type(1).strTicketType = "Express"
        T_Type(1).dblCost = 100
        T_Type(1).dblMaxAvailability = 20
        T_Type(2).strTicketType = "Express Unlimited"
        T_Type(2).dblCost = 200
        T_Type(2).dblMaxAvailability = 10
        T_Type(3).strTicketType = "VVIP"
        T_Type(3).dblCost = 500
        T_Type(3).dblMaxAvailability = 5

    End Sub

    Private Sub CalculateTickets(ByVal intNumberOfAdults, ByVal intNumberOfSeniorCitizen, ByVal intNumberOfChildren, ByRef dblTicketPrices)
        Dim dblAdultsPrice, dblSeniorCitizenPrice, dblChildrenPrice As Double
        dblTicketPrices = (dblAdultsPrice * intNumberOfAdults) + (dblSeniorCitizenPrice * intNumberOfSeniorCitizen) +
                          (dblChildrenPrice * intNumberOfChildren)

        If cboThemePark.SelectedItem = "WonderLAND" Then
            dblAdultsPrice = 55
            dblSeniorCitizenPrice = 35
            dblChildrenPrice = 20
            dblTicketPrices = (dblAdultsPrice * intNumberOfAdults) + (dblSeniorCitizenPrice * intNumberOfSeniorCitizen) +
                              (dblChildrenPrice * intNumberOfChildren)

        ElseIf cboThemePark.SelectedItem = "WonderSEA" Then
            dblAdultsPrice = 65
            dblSeniorCitizenPrice = 45
            dblChildrenPrice = 30
            dblTicketPrices = (dblAdultsPrice * intNumberOfAdults) + (dblSeniorCitizenPrice * intNumberOfSeniorCitizen) +
                              (dblChildrenPrice * intNumberOfChildren)
        Else
            dblAdultsPrice = 110
            dblSeniorCitizenPrice = 90
            dblChildrenPrice = 40
            dblTicketPrices = (dblAdultsPrice * intNumberOfAdults) + (dblSeniorCitizenPrice * intNumberOfSeniorCitizen) +
                              (dblChildrenPrice * intNumberOfChildren)
        End If
    End Sub
    Private Function CalculateBoatAndTrainRide(ByVal intNumberOfAdults, ByVal intNumberOfSeniorCitizen, ByVal intNumberOfChildren) As Double
        Dim intAdultsPrice, intSeniorCitizenPrice, intChildrenPrice As Integer
        Dim BTRidePrices As Double
        'Calculate different price for different ride
        If cbCruiseRide.Checked = True Then
            intAdultsPrice = 30 * intNumberOfAdults
            intSeniorCitizenPrice = 25 * intNumberOfSeniorCitizen
            intChildrenPrice = 15 * intNumberOfChildren
            BTRidePrices += intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
        End If

        If cbBananaBoatRide.Checked = True Then
            intAdultsPrice = 20 * intNumberOfAdults
            intSeniorCitizenPrice = 15 * intNumberOfSeniorCitizen
            intChildrenPrice = 10 * intNumberOfChildren
            BTRidePrices += intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
        End If

        If cbDuckBoatRide.Checked = True Then
            intAdultsPrice = 20 * intNumberOfAdults
            intSeniorCitizenPrice = 15 * intNumberOfSeniorCitizen
            intChildrenPrice = 10 * intNumberOfChildren
            BTRidePrices += intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
        End If

        If cbLocomotiveRide.Checked = True Then
            intAdultsPrice = 25 * intNumberOfAdults
            intSeniorCitizenPrice = 20 * intNumberOfSeniorCitizen
            intChildrenPrice = 10 * intNumberOfChildren
            BTRidePrices += intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
        End If

        If cbElectricTrainRide.Checked = True Then
            intAdultsPrice = 20 * intNumberOfAdults
            intSeniorCitizenPrice = 15 * intNumberOfSeniorCitizen
            intChildrenPrice = 10 * intNumberOfChildren
            BTRidePrices += intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
        End If

        If cbCoupleTrainRide.Checked = True Then
            intAdultsPrice = 40 * intNumberOfAdults
            intSeniorCitizenPrice = 0
            intChildrenPrice = 0
            BTRidePrices += intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
        End If
        If intNumberOfAdults < 2 AndAlso cbCoupleTrainRide.Checked = True Then
            MessageBox.Show("Couple Train Ride is available for adults only.Make sure number of adults is at least 2 people.", "Caution")
        End If

        Return BTRidePrices
    End Function
    Private Function CalculateShows(ByVal NumberOfAdults As Integer, ByVal NumberOfSeniorCitizen As Integer, ByVal NumberOfchildren As Integer) As Double
        Dim intAdultsPrice, intSeniorCitizenPrice, intChildrenPrice As Integer
        Dim ShowPrices As Double

        If cbMagicalShow.Checked = True Then
            intAdultsPrice = 15 * NumberOfAdults
            intSeniorCitizenPrice = 10 * NumberOfSeniorCitizen
            intChildrenPrice = 5 * NumberOfchildren
            ShowPrices += intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
        End If

        If cbDolphinShow.Checked = True Then
            intAdultsPrice = 15 * NumberOfAdults
            intSeniorCitizenPrice = 10 * NumberOfSeniorCitizen
            intChildrenPrice = 5 * NumberOfchildren
            ShowPrices += intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
        End If

        If cbDayFireWorkShow.Checked = True Then
            intAdultsPrice = 20 * NumberOfAdults
            intSeniorCitizenPrice = 15 * NumberOfSeniorCitizen
            intChildrenPrice = 10 * NumberOfchildren
            ShowPrices += intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
        End If

        If cbNightFireworkShow.Checked = True Then
            intAdultsPrice = 25 * NumberOfAdults
            intSeniorCitizenPrice = 20 * NumberOfSeniorCitizen
            intChildrenPrice = 10 * NumberOfchildren
            ShowPrices += intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
        End If

        Return ShowPrices
    End Function

    Private Function CalculateFoodMenu(ByVal NumberOfAdults As Integer, ByVal NumberOfSeniorCitizen As Integer, ByVal NumberOfChildren As Integer) As Double
        Dim intCounter, intAdultsPrice, intSeniorCitizenPrice, intChildrenPrice As Integer
        Dim FoodMenuPrices As Double

        intCounter = 0

        If cbWesternMenu.Checked = True Then
            intCounter += 1
        End If

        If cbMalayMenu.Checked = True Then
            intCounter += 1
        End If

        If cbChineseMenu.Checked = True Then
            intCounter += 1
        End If

        If cbJapaneseMenu.Checked = True Then
            intCounter += 1
        End If
        'Calculate only 1 menu price
        If intCounter = 1 Then
            intAdultsPrice = 20 * NumberOfAdults
            intSeniorCitizenPrice = 10 * NumberOfSeniorCitizen
            intChildrenPrice = 10 * NumberOfChildren
            FoodMenuPrices = intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
            'Calculate any 2 mixed menu price
        ElseIf intCounter = 2 Then
            intAdultsPrice = 35 * NumberOfAdults
            intSeniorCitizenPrice = 25 * NumberOfSeniorCitizen
            intChildrenPrice = 25 * NumberOfChildren
            FoodMenuPrices = intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
            'Calculate any 3 mixed menu price
        ElseIf intCounter = 3 Then
            intAdultsPrice = 55 * NumberOfAdults
            intSeniorCitizenPrice = 40 * NumberOfSeniorCitizen
            intChildrenPrice = 40 * NumberOfChildren
            FoodMenuPrices = intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
            'Calculate all of the menu price
        ElseIf intCounter = 4 Then
            intAdultsPrice = 70 * NumberOfAdults
            intSeniorCitizenPrice = 55 * NumberOfSeniorCitizen
            intChildrenPrice = 55 * NumberOfChildren
            FoodMenuPrices = intAdultsPrice + intSeniorCitizenPrice + intChildrenPrice
        End If

        Return FoodMenuPrices
    End Function

    Private Sub CalculateTicketTypes(ByRef dblTicketTypesCost As Double)
        'Ticket types charge per booking
        If rbRegular.Checked = True Then
            dblTicketTypesCost = 0
        ElseIf rbExpress.Checked = True Then
            dblTicketTypesCost = 100
        ElseIf rbExpressUnlimited.Checked = True Then
            dblTicketTypesCost = 200
        Else
            dblTicketTypesCost = 500
        End If
    End Sub
    Private Function CalculateSubTotalOne(ByVal dblFoodMenuCost, ByVal dblBTRideCost, ByVal dblShowCost, ByVal dblTicketTypesCost, ByVal dblTicketPrices) As Double
        Dim dblST1 As Double
        dblST1 = dblFoodMenuCost + dblBTRideCost + dblShowCost + dblTicketTypesCost + dblTicketPrices
        Return dblST1
    End Function
    Private Function CalculateDiscount(ByVal ST1 As Double, ByVal NumberOfAdults As Integer, ByVal NumberOfSeniorCitizens As Integer, ByVal NumberOfChildren As Integer) As Integer
        Dim decDiscount As Decimal
        Dim intNoPeople As Integer

        intNoPeople = NumberOfAdults + NumberOfSeniorCitizens + NumberOfChildren

        Select Case (intNoPeople)
            Case 0 To 10                    'Number of people less than or equal to 10
                decDiscount = 0             'No discount
            Case 11 To 20                   'Number of people more than 10
                decDiscount = ST1 * 0.05    'Discount 5%
            Case Is > 20                    'Number of people more than 20
                decDiscount = ST1 * 0.1     'Discount 10%
        End Select

        Return decDiscount
    End Function
    Private Function CalculateSubTotalTwo(ByVal ST1 As Double, ByVal Discount As Decimal) As Double
        Dim dblST2 As Double
        'Calculate SubTotal(2) cost
        dblST2 = ST1 - Discount

        Return dblST2
    End Function
    Private Function CalculateGST(ByVal ST2 As Double) As Double
        Dim decGST As Decimal
        'Calculate Government Service Tax
        decGST = ST2 * 0.06

        Return decGST
    End Function

    Private Function ValidateTicketTypesAvailability(ByVal NumberOfAdults As Integer, ByVal NumberOfSeniorCitizen As Integer, ByVal NumberOfChildren As Integer) As Integer

        'intMax = Maximum Availability per booking
        Dim intMax, intCount As Integer

        'Total number of customer
        intCount = NumberOfAdults + NumberOfSeniorCitizen + NumberOfChildren

        If rbRegular.Checked Then
            intMax = 100
        ElseIf rbExpress.Checked Then
            intMax = 20
        ElseIf rbExpressUnlimited.Checked Then
            intMax = 10
        ElseIf rbVVIP.Checked Then
            intMax = 5
        End If
        If intCount > intMax Then 'if total number of customer > maximum availability per booking
            intMax = False 'ticket type cannot accommodate to the number of customer
        Else
            Return intMax
        End If

        Return intMax
    End Function

    Private Function ValidateCustomerName(ByVal CustomerName As String) As String
        Dim Position As Integer

        Position = CustomerName.IndexOf(" ") 'to check anything inside ("") for validation
        If Position > 0 Then
            Return CustomerName 'Valid name is entered
        Else
            Return "" 'Invalid name is entered
        End If

        If String.Empty Then 'Customer name is not present
            Return "" 'Invalid name is entered
        End If

    End Function
    Private Function ValidateContactNumber(ByVal ContactNumberOfCustomer As String) As String

        If ContactNumberOfCustomer = String.Empty OrElse Not IsNumeric(txtCustomerNumber.Text) Then
            Return ""  'Invalid number is entered
        Else
            Return ContactNumberOfCustomer  'Valid number is entered
        End If

    End Function
    Private Function ValidateNoOfAdults(ByVal NoAdults As Integer) As Integer
        Dim NumberOfAdults As Integer

        Integer.TryParse(txtAdults.Text, NumberOfAdults)

        If NumberOfAdults < 0 OrElse NumberOfAdults >= 1000 OrElse txtAdults.Text = "" Then
            Return -1  'Invalid number is entered
        Else
            Return NumberOfAdults  'Valid number is entered
        End If

    End Function
    Private Function ValidateNoOfSeniorcitizen(ByVal NoSeniorCitizen As Integer) As Integer
        Dim NumberOfSeniorCitizen As Integer

        Integer.TryParse(txtSeniorCitizen.Text, NumberOfSeniorCitizen)

        If NumberOfSeniorCitizen < 0 OrElse NumberOfSeniorCitizen >= 1000 OrElse txtSeniorCitizen.Text = "" Then
            Return -1  'Invalid number is entered
        Else
            Return NumberOfSeniorCitizen  'Valid number is entered
        End If

    End Function
    Private Function ValidateNoOfChildren(ByVal NoChildren As Integer) As Integer
        Dim NumberOfChildren As Integer

        Integer.TryParse(txtChildren.Text, NumberOfChildren)

        If NumberOfChildren < 0 OrElse NumberOfChildren >= 1000 OrElse txtChildren.Text = "" Then
            Return -1  'Invalid number is entered
        Else
            Return NumberOfChildren  'Valid number is entered
        End If

    End Function
    Private Sub btnCalculateQuote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateQuote.Click
        Dim strCustomerName, strCustomerNumber As String
        Dim strErrorMessage As String = String.Empty
        Dim blnChecker As Boolean = True
        Dim blnTicketTypesChecker As Boolean = (rbRegular.Checked OrElse rbExpress.Checked OrElse rbExpressUnlimited.Checked OrElse rbVVIP.Checked) = True
        Dim intNumberOfAdults, intNoAdults, intNumberOfSeniorCitizen, intNoSeniorCitizen, intNumberOfChildren, intNoChildren, intNoPeople, intMax As Integer
        Dim dblFoodMenucost, dblBTRideCost, dblShowCost, dblST1, dblST2, dblTotal, dblTicketTypesCost, dblTicketPrices As Double
        Dim decDiscount, decGST As Decimal

        Integer.TryParse(txtAdults.Text, intNumberOfAdults)
        Integer.TryParse(txtSeniorCitizen.Text, intNumberOfSeniorCitizen)
        Integer.TryParse(txtChildren.Text, intNumberOfChildren)

        'use a Sub Procedure to calculate the TicketTypesCost and ThemeParkTicketPrices
        Call CalculateTicketTypes(dblTicketTypesCost)
        Call CalculateTickets(intNumberOfAdults, intNumberOfSeniorCitizen, intNumberOfChildren, dblTicketPrices)

        'Validation
        strCustomerName = ValidateCustomerName(txtCustomerName.Text)
        strCustomerNumber = ValidateContactNumber(txtCustomerNumber.Text)
        intNumberOfAdults = ValidateNoOfAdults(intNoAdults)
        intNumberOfSeniorCitizen = ValidateNoOfSeniorcitizen(intNoSeniorCitizen)
        intNumberOfChildren = ValidateNoOfChildren(intNoChildren)
        intMax = ValidateTicketTypesAvailability(intNumberOfAdults, intNumberOfSeniorCitizen, intNumberOfChildren)

        'Use a Fucntion Procedure to calculate BoatAndTrainRideCost,ShowCost,FoodMenuCost,Subtotal(1),Discount,Subtotal(2),GST
        dblBTRideCost = CalculateBoatAndTrainRide(intNumberOfAdults, intNumberOfSeniorCitizen, intNumberOfChildren)
        dblShowCost = CalculateShows(intNumberOfAdults, intNumberOfSeniorCitizen, intNumberOfChildren)
        dblFoodMenucost = CalculateFoodMenu(intNumberOfAdults, intNumberOfSeniorCitizen, intNumberOfChildren)
        dblST1 = CalculateSubTotalOne(dblFoodMenucost, dblBTRideCost, dblShowCost, dblTicketTypesCost, dblTicketPrices)
        decDiscount = CalculateDiscount(dblST1, intNumberOfAdults, intNumberOfSeniorCitizen, intNumberOfChildren)
        dblST2 = CalculateSubTotalTwo(dblST1, decDiscount)
        decGST = CalculateGST(dblST2)

        dblTotal = dblST2 + decGST
        intNoPeople = intNumberOfAdults + intNumberOfSeniorCitizen + intNumberOfChildren

        If strCustomerName = "" Then
            strErrorMessage += "Invalid Customer Name" + ControlChars.NewLine
            blnChecker = False ' input data fail the validation test
        End If

        If strCustomerNumber = "" Then
            strErrorMessage += "Invalid Contact Number" + ControlChars.NewLine
            blnChecker = False ' input data fail the validation test
        End If

        If intNumberOfAdults = -1 Then
            strErrorMessage += "Invalid No of Adults" + ControlChars.NewLine
            blnChecker = False ' input data fail the validation test
        End If
        If intNumberOfSeniorCitizen = -1 Then
            strErrorMessage += "Invalid No of Senior Citizen" + ControlChars.NewLine
            blnChecker = False ' input data fail the validation test
        End If
        If intNumberOfChildren = -1 Then
            strErrorMessage += "Invalid No of Children" + ControlChars.NewLine
            blnChecker = False ' input data fail the validation test
        End If

        If blnTicketTypesChecker = False Then 'Ticket types radio button is unchecked
            strErrorMessage += "Invalid Ticket Types." & " Make sure the ticket type is selected" + ControlChars.NewLine
            blnChecker = False

        End If

        If blnChecker = False Then ' input data fail the validation test
            MessageBox.Show(strErrorMessage, "Error Message")
            Exit Sub
        End If

        If intMax = False Then 'number of people exceed maximum availability per booking
            MessageBox.Show("Ticket Type Availability Exceed. Please make separate booking", "Error Message")
            Exit Sub
        End If

        'Display answer of calculation
        lblAnsTickets.Text = dblTicketPrices.ToString("C2")
        lblAnsTypes.Text = dblTicketTypesCost.ToString("C2")
        lblAnsBoatandTrainRide.Text = dblBTRideCost.ToString("C2")
        lblAnsShows.Text = dblShowCost.ToString("C2")
        lblAnsFoodMenu.Text = dblFoodMenucost.ToString("C2")
        lblST1.Text = dblST1.ToString("C2")
        lblAnsDiscount.Text = decDiscount.ToString("C2")
        lblST2.Text = dblST2.ToString("C2")
        lblAnsGST.Text = decGST.ToString("C2")
        lblAnsTotalPackage.Text = dblTotal.ToString("C2")

        'Display time
        lblAnsQuoteDate.Text = DateTime.Now.ToString
        lblAnsValidto.Text = DateTime.Now.AddDays(30).ToString
    End Sub
    Private Sub CancelKeys(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustomerNumber.KeyPress, txtAdults.KeyPress, txtSeniorCitizen.KeyPress, txtChildren.KeyPress
        'accept numeric input and backspace only
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub
    Private Sub btnBookThePackage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookThePackage.Click
        Dim DisplayThemeParkMenu, DisplayRefNo, DisplayName, DisplayCustomerNumber, DisplayAdults, DisplaySeniorCitizen,
            DisplayChildren, DisplayTicketTypes, DisplayRides, DisplayShows, DisplayFoodMenu, DisplayTotalCost As String

        Dim intNumRef As Integer

        Static intCount As Integer
        

        If lblAnsTotalPackage.Text = "" Then
            MessageBox.Show("Wonderland Theme Park Ticket has fail to be booked. Please booking again!", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            intCount += 1
            intNumRef = intNumRef + intCount
            lblAnsRefNo.Text = intNumRef.ToString

            DisplayRefNo = lblAnsRefNo.Text
            DisplayName = txtCustomerName.Text
            DisplayCustomerNumber = txtCustomerNumber.Text
            DisplayAdults = txtAdults.Text
            DisplaySeniorCitizen = txtSeniorCitizen.Text
            DisplayChildren = txtChildren.Text
            DisplayThemeParkMenu = cboThemePark.Text
            DisplayTicketTypes = lblAnsTypes.Text
            DisplayRides = lblAnsBoatandTrainRide.Text
            DisplayShows = lblAnsShows.Text
            DisplayFoodMenu = lblAnsFoodMenu.Text
            DisplayTotalCost = lblAnsTotalPackage.Text


            'Save the records into specific path
            My.Computer.FileSystem.WriteAllText("C:\Users\100067416\AppData\Local\Microsoft\Windows\Burn\Burn\WTP assignment\Wonderland Theme Park\Record.txt", "Reference No: " & DisplayRefNo & ControlChars.NewLine &
                                                "Customer Name: " & DisplayName & ControlChars.NewLine & "Customer Number: " & DisplayCustomerNumber & ControlChars.NewLine &
                                                "No of Adults: " & DisplayAdults & ControlChars.NewLine & "No of SeniorCitizen: " & DisplaySeniorCitizen & ControlChars.NewLine &
                                                "No of Children: " & DisplayChildren & ControlChars.NewLine & "ThemePark: " & DisplayThemeParkMenu & ControlChars.NewLine &
                                                "Rides: " & DisplayRides & ControlChars.NewLine & "Shows: " & DisplayShows & ControlChars.NewLine &
                                                "Food Menu: " & DisplayFoodMenu & ControlChars.NewLine & "Total Cost: " & DisplayTotalCost & ControlChars.NewLine & ControlChars.NewLine, True)

            MessageBox.Show("Wonderland Theme Park ticket has successfully booked !", "Wonderland Theme Park", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        'clear all the data
        txtCustomerName.Clear()
        txtCustomerNumber.Clear()
        txtAdults.Clear()
        txtSeniorCitizen.Clear()
        txtChildren.Clear()
        lblAnsBoatandTrainRide.Text = ""
        lblAnsDiscount.Text = ""
        lblAnsFoodMenu.Text = ""
        lblST1.Text = ""
        lblST2.Text = ""
        lblAnsGST.Text = ""
        lblAnsQuoteDate.Text = ""
        lblAnsRefNo.Text = ""
        lblAnsShows.Text = ""
        lblAnsTickets.Text = ""
        lblAnsTotalPackage.Text = ""
        lblAnsTypes.Text = ""
        lblAnsValidto.Text = ""
        rbRegular.Checked = False
        rbExpress.Checked = False
        rbExpressUnlimited.Checked = False
        rbVVIP.Checked = False
        cbCruiseRide.Checked = False
        cbDuckBoatRide.Checked = False
        cbBananaBoatRide.Checked = False
        cbCoupleTrainRide.Checked = False
        cbElectricTrainRide.Checked = False
        cbLocomotiveRide.Checked = False
        cbDolphinShow.Checked = False
        cbDayFireWorkShow.Checked = False
        cbMagicalShow.Checked = False
        cbNightFireworkShow.Checked = False
        cbWesternMenu.Checked = False
        cbChineseMenu.Checked = False
        cbMalayMenu.Checked = False
        cbJapaneseMenu.Checked = False

        'Send focus to Customer Name textbox
        txtCustomerName.Focus()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close() 'Close the application
    End Sub

    Private Sub Mainform_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show(" Do you want to Exit?", "Wonderland Theme Park", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ' to verify that the user want to close the application
        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnBahasaMelayu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBahasaMelayu.Click
        'Switch to different form for different language version
        Me.Hide()
        TamanTemaWonderlandOnlineTiketdanTempahan.Show()
    End Sub

    Private Sub btnBC1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBC1.Click
        'Switch to different form for different language version
        Me.Hide()
        仙境主题公园线上门票预购.Show()
    End Sub
End Class
