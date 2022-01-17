Imports System
Imports Nautilus
Module Program
    Sub Main(args As String())
        Dim lic As New DriverLicense()

        Dim cac_barcode_one As String = System.IO.File.ReadAllText(".\sample-data\cac_barcode_one.txt")
        Dim passport_mrz_one As String = System.IO.File.ReadAllText(".\sample-data\passport_mrz_one.txt")
        Dim passport_mrz_two As String = System.IO.File.ReadAllText(".\sample-data\passport_mrz_two.txt")
        Dim pdf417_barcode_one As String = System.IO.File.ReadAllText(".\sample-data\pdf417_barcode_one.txt")
        Dim pdf417_barcode_two As String = System.IO.File.ReadAllText(".\sample-data\pdf417_barcode_two.txt")
        Dim three_line_mrz_one As String = System.IO.File.ReadAllText(".\sample-data\three_line_mrz_one.txt")

        If (lic.ExtractInfo(cac_barcode_one)) Then
            Console.Out.WriteLine("CAC Card's Full Name: {0}", lic.LastName)
        End If

        If (lic.ExtractInfo(passport_mrz_one)) Then

            Console.WriteLine("Passport's Full Name: {0}", lic.LastName)
        End If


        If (lic.ExtractInfo(passport_mrz_two)) Then

            Console.WriteLine("Passport's Full Name: {0}", lic.LastName)
        End If


        If (lic.ExtractInfo(pdf417_barcode_one)) Then

            Console.WriteLine("Barcode's Full Name: {0}", lic.LastName)
        End If


        If (lic.ExtractInfo(pdf417_barcode_two)) Then

            Console.WriteLine("Passport's Full Name: {0}", lic.LastName)

        End If

        If (lic.ExtractInfo(three_line_mrz_one)) Then

            Console.WriteLine("MRZ's Full Name: {0}", lic.LastName)
        End If


        Console.In.ReadLine()
    End Sub
End Module
