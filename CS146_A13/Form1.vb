'NAME: Nathan Emmrich
'COURSE: CS  01 WI24
'INSTRUCTOR: Beyers
'DATE:04/14/2024
'SUMMARY: This program is designed to display the information of Dow stock options from 2019 in a specified format

'Import system utilities
Imports System.IO
Imports System.Linq

Public Class frmA13
    'Declare constants for indexes
    Const SymbolIdx = 0
    Const CompanyIdx = 1
    Const Price2018Idx = 2
    Const Price2019Idx = 3

    Private Sub frmA13_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Declare array variable
        Dim readArray() As String = File.ReadAllLines("DOW2019.txt")

        'Declare LINQ query
        Dim query = From lines In readArray
                    Let fields = lines.Split(","c)
                    Let symbol = fields(SymbolIdx)
                    Let company = fields(CompanyIdx)
                    Let price2018 = Double.Parse(fields(Price2018Idx))
                    Let price2019 = Double.Parse(fields(Price2019Idx))
                    Let priceDiff = price2019 - price2018
                    Let pricePercent = (priceDiff / price2018) * 100
                    Select New With
                        {
                            .symbol = symbol,
                            .company = company,
                            .price2018 = price2018,
                            .price2019 = price2019,
                            .pricePercent = pricePercent.ToString("0.00") & "%"
                        }

        'Declare display templates
        Dim lineTemplate As String = "{0,-10}|{1,-20}|{2,15}|{3,15}|{4,15}|"
        Dim separatorTemplate As String = "{0,-10} {1,-20} {2,15} {3,15} {4,15}"

        'Display header line
        lstDisplay.Items.Add(String.Format(lineTemplate, "Symbol", "Company", "Price 2018", "Price 2019", "Change %"))
        lstDisplay.Items.Add(String.Format(separatorTemplate, StrDup(10, "-"), StrDup(20, "-"), StrDup(15, "-"), StrDup(15, "-"), StrDup(15, "-")))

        'Loop to display data with separator lines
        For Each item In query
            lstDisplay.Items.Add(String.Format(lineTemplate, item.symbol, item.company,
                                               item.price2018, item.price2019, item.pricePercent))
            lstDisplay.Items.Add(String.Format(separatorTemplate, StrDup(10, "-"), StrDup(20, "-"), StrDup(15, "-"), StrDup(15, "-"), StrDup(15, "-")))
        Next
    End Sub
End Class
