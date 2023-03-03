Public Class Form1
    Dim TextToPrint As String = ""

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintDocument1.PrinterSettings.PrinterName = "student_printing_release on MYPHAROS1"
    End Sub

    Public Sub PrintHeader()

        TextToPrint = ""

        'send Business Name
        Dim StringToPrint As String = "Business Name"
        Dim LineLen As Integer = StringToPrint.Length
        Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine

        'send address name
        StringToPrint = "12345 Street Avenue"
        LineLen = StringToPrint.Length
        Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen2 & StringToPrint & Environment.NewLine

        ' send city, state, zip
        StringToPrint = "City, State, Zip code"
        LineLen = StringToPrint.Length
        Dim spcLen3 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen3 & StringToPrint & Environment.NewLine

        ' send phone number
        StringToPrint = "999-999-9999"
        LineLen = StringToPrint.Length
        Dim spcLen4 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen4 & StringToPrint & Environment.NewLine

        'send website
        StringToPrint = "website.com"
        LineLen = StringToPrint.Length
        Dim spcLen4b As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen4b & StringToPrint & Environment.NewLine

    End Sub

    Public Sub ItemsToBePrinted()


        Dim StringToPrint As String = "    " & "1" & " @ " & "3.99" & "         " & "3.99"
        Dim LineLen As String = StringToPrint.Length
        Dim spcLen5 As New String(" "c, Math.Round((30 - LineLen)))


        TextToPrint &= "Description" & Environment.NewLine
        TextToPrint &= StringToPrint & Environment.NewLine

    End Sub

    Public Sub printFooter()
        TextToPrint &= Environment.NewLine & Environment.NewLine
        Dim globalLengt As Integer = 0

        'SubTotal Amount
        Dim StringToPrint As String = "Sub Total   " & FormatCurrency("3.99", , , TriState.True, TriState.True)  'Change here to subtotal
        Dim LineLen As String = StringToPrint.Length
        globalLengt = StringToPrint.Length
        Dim spcLen5 As New String(" "c, Math.Round((26 - LineLen)))
        TextToPrint &= Environment.NewLine & spcLen5 & StringToPrint & Environment.NewLine

        'Tax Amount
        StringToPrint = "Tax         " & FormatCurrency("0.05", , , TriState.True, TriState.True) 'Change to tax amount
        LineLen = globalLengt
        Dim spcLen6 As New String(" "c, Math.Round((26 - LineLen)))
        If Not StringToPrint = "Tax         $0.00" Then
            TextToPrint &= spcLen6 & StringToPrint & Environment.NewLine
        End If

        'Total Amount
        StringToPrint = "Total       " & "$4.04"
        LineLen = globalLengt
        Dim spcLen8 As New String(" "c, Math.Round((26 - LineLen)))
        TextToPrint &= spcLen8 & StringToPrint & Environment.NewLine & Environment.NewLine

        'Cash Entered Amount
        StringToPrint = "Cash        " & FormatCurrency("5.00", , , TriState.True, TriState.True)
        LineLen = globalLengt
        Dim spcLen9 As New String(" "c, Math.Round((26 - LineLen)))
        If Not StringToPrint = "Cash        $0.00" Then
            TextToPrint &= spcLen9 & StringToPrint & Environment.NewLine
        End If

        'Change Amount
        StringToPrint = "Change      " & FormatCurrency("0.96", , , TriState.True, TriState.True)
        LineLen = globalLengt
        Dim spcLen10 As New String(" "c, Math.Round((26 - LineLen)))
        TextToPrint &= Environment.NewLine & spcLen10 & StringToPrint & Environment.NewLine
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static currentChar As Integer
        Dim textfont As Font = New Font("Courier New", 10, FontStyle.Bold)

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
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, b, format)


        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub


    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click
        PrintHeader()
        ItemsToBePrinted()
        printFooter()
        Dim printControl = New Printing.StandardPrintController
        PrintDocument1.PrintController = printControl
        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
