'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Imports System
Imports System.Data
Imports System.Data.OleDb

Module modFunction
    Public Function GetFieldValue(ByVal srcSQL As String, ByVal strField As String)
        'create connection
        Dim cnHotel As OleDbConnection

        cnHotel = New OleDbConnection

        With cnHotel
            If .State = ConnectionState.Open Then .Close()

            .ConnectionString = cnString
            .Open()
        End With

        Try
            Dim cmd As OleDbCommand = New OleDbCommand(srcSQL, cnHotel)
            'create data reader
            Dim rdr As OleDbDataReader = cmd.ExecuteReader

            'loop through result set
            While (rdr.Read)
                GetFieldValue = rdr(strField).ToString()
            End While

            'close data reader
            rdr.Close()
        Catch e As Exception
            Console.WriteLine("Error Occurred:" & e.ToString)
        Finally
            ' Close connection
            cnHotel.Close()
        End Try
    End Function

    Public Function GetIndex(ByVal srcTable As String) As Long
        Dim cnHotel As OleDbConnection
        'create connection
        cnHotel = New OleDbConnection

        With cnHotel
            If .State = ConnectionState.Open Then .Close()

            .ConnectionString = cnString
            .Open()
        End With

        Dim sqlQRY As String = "SELECT * FROM [KEY_GENERATOR] WHERE TableName = '" & srcTable & "'"

        'create commands
        Dim cmd As OleDbCommand = New OleDbCommand(sqlQRY, cnHotel)

        Try
            'create data reader
            Dim rdr As OleDbDataReader = cmd.ExecuteReader
            Dim intNextNo As Integer

            'loop through result set
            While (rdr.Read)
                intNextNo = rdr("NextNo").ToString()
            End While

            intNextNo = intNextNo + 1
            'define update statement
            Dim sqlUpdate As String = "UPDATE [Key_Generator] SET [Key_Generator].NextNo = " & intNextNo & " WHERE TableName='" & srcTable & "'"

            Dim cmdUpdate As OleDbCommand = New OleDbCommand(sqlUpdate, cnHotel)

            'execute nonquery to update an index
            cmdUpdate.ExecuteNonQuery()

            GetIndex = intNextNo
        Catch ex As OleDbException
            Console.WriteLine(ex)
        Finally
            ' Close connection
            cnHotel.Close()
            Console.WriteLine("Connection closed.")
        End Try
    End Function

    'Function that will format return a generated id
    Public Function GenerateID(ByVal srcNo As String, ByVal src1stStr As String, ByVal src2ndStr As String) As String
        If Len(src2ndStr) <= Len(srcNo) Then
            GenerateID = src1stStr & srcNo
        Else
            GenerateID = src1stStr & Left(src2ndStr, Len(src2ndStr) - Len(srcNo)) & srcNo
        End If
    End Function

    'Function that will return a currency format
    Public Function toMoney(ByVal srcCurr As String) As String
        toMoney = Format(IIf(Trim(srcCurr) = "", 0, CSng(srcCurr)), "#,##0.00")
    End Function

    Public Function toNumber(ByVal srcCurrency As String, Optional ByRef RetZeroIfNegative As Boolean = False) As Double
        Dim retValue As Double
        If srcCurrency = "" Then
            toNumber = 0
        Else
            If InStr(1, srcCurrency, ",") > 0 Then
                retValue = Val(Replace(srcCurrency, ",", "", , , CompareMethod.Text))
            Else
                retValue = Val(srcCurrency)
            End If
            If RetZeroIfNegative = True Then
                If retValue < 1 Then retValue = 0
            End If
            toNumber = retValue
            retValue = 0
        End If
    End Function

    Public Function CountRows(ByVal sSQL As String)
        Dim cnHotel As OleDbConnection
        cnHotel = New OleDbConnection

        With cnHotel
            If .State = ConnectionState.Open Then .Close()

            .ConnectionString = cnString
            .Open()
        End With

        Dim cmdCount As OleDbCommand = New OleDbCommand(sSQL, cnHotel)

        CountRows = cmdCount.ExecuteScalar()
    End Function

    Public Function GetData(ByVal sSQL As String)
        Dim CN As OleDbConnection
        Dim sqlCmd As OleDbCommand = New OleDbCommand(sSQL)
        Dim myData As OleDbDataReader

        CN = New OleDbConnection(cnString)

        Try
            CN.Open()

            sqlCmd.Connection = CN

            myData = sqlCmd.ExecuteReader

            Return myData
        Catch ex As Exception
            Return ex
        End Try
    End Function

    'Execute Non Query
    Public Function ExecNonQuery(ByVal strSQL As String)
        Dim cnHotel As OleDbConnection
        cnHotel = New OleDbConnection

        Try
            With cnHotel
                If .State = ConnectionState.Open Then .Close()

                .ConnectionString = cnString
                .Open()
            End With

            Dim cmd As OleDbCommand = New OleDbCommand(strSQL, cnHotel)

            cmd.ExecuteNonQuery()

            Return True
        Catch ex As OleDbException
            Return ex
        Finally
            cnHotel.Close()
        End Try
    End Function

    'Function used to change the yes/no value
    Public Function changeYNValue(ByVal srcStr As String) As String
        Select Case srcStr
            Case "Y" : changeYNValue = "1"
            Case "N" : changeYNValue = "0"
            Case "1" : changeYNValue = "Y"
            Case "0" : changeYNValue = "N"
        End Select
    End Function
End Module
