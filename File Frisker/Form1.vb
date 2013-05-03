Public Class frmMain

    Public MyFiles() As String
    Public filepath As String
    Public fileReader As String

    Public srch(2000) As String
    Public size1 As Long
    Public size2 As Long

    Public ctr1 As Long
    Public ctr2 As Long
    Public ctr3 As Long

    Public ct_key As Integer
    Public ct_reg As Integer

    Public indx As Integer
    Public indx2 As Integer
    Public indx3 As Integer

    Public numberoffiles As Integer
    Public fileCount As Integer


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            loadDictionaries()
            rdbtnDictionary.Checked = True
            cmbDictionary.SelectedIndex = 0
            cmbDictionary.Enabled = True
            txtCustomString.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Loading Form")
        End Try
    End Sub

   
    Private Sub cmdFrisk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFrisk.Click
        Try
            filepath = txtFileName.Text
            fileReader = My.Computer.FileSystem.ReadAllText(filepath)
            fileCount = 1

            cleanup()
            loadSearchStrings()

            lstSearchStrings.Items.CopyTo(srch, 0)

            ctr1 = 0
            ctr2 = 0
            ctr3 = 0

            Do While (ctr3 < indx)
                size1 = Len(srch(ctr3))
                size2 = Len(fileReader)
                ctr1 = 1
                Do
                    ctr2 = InStr(ctr1, fileReader, srch(ctr3), CompareMethod.Text)
                    If (ctr2 > 0) Then
                        lstvwOutput.Items.Add("Keyword")
                        lstvwOutput.Items(lstvwOutput.Items.Count - 1).SubItems.Add(srch(ctr3))
                        lstvwOutput.Items(lstvwOutput.Items.Count - 1).SubItems.Add(Convert.ToString(ctr2))
                        lstvwOutput.Items(lstvwOutput.Items.Count - 1).SubItems.Add(filepath)
                        ctr1 = ctr2 + 1
                    ElseIf (ctr2 = 0) Then
                        ctr1 = size2
                    End If
                Loop Until (ctr1 = size2)
                ctr3 = ctr3 + 1
            Loop
            ct_key = lstvwOutput.Items.Count

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Frisking Error")
        End Try
    End Sub

    Public Sub loadDictionaries()
        Try
            Dim DIR As IO.DirectoryInfo
            DIR = New IO.DirectoryInfo(Environment.CurrentDirectory & "\Dictionaries\")
            Dim FI As IO.FileInfo

            For Each FI In DIR.GetFiles("*.txt", IO.SearchOption.TopDirectoryOnly)
                cmbDictionary.Items.Add(FI.Name)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Clean-up Error")
        End Try
    End Sub

    Public Sub cleanup()
        Try
            lstvwOutput.Items.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Clean-up Error")
        End Try
    End Sub



    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        Try
            cleanup()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ResetError")
        End Try
    End Sub

    Private Sub cmdSaveToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveToFile.Click
        Try
            Dim fileWriter As System.IO.StreamWriter
            Dim line As String
            Dim listviewcount As Integer
            Dim ctr As Integer

            ctr = 0
            listviewcount = lstvwOutput.Items.Count

            Dim saveFileDialog1 As New SaveFileDialog
            saveFileDialog1.Filter = "CSV File|*.csv"
            saveFileDialog1.Title = "Save a CSV File"
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory
            saveFileDialog1.FileName = "AST_File_Frisker_Output"

            If (saveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel) Then
                Exit Sub
            End If

            If (saveFileDialog1.FileName <> "") Then

                fileWriter = My.Computer.FileSystem.OpenTextFileWriter(saveFileDialog1.FileName, False)
                line = "Finding Type,Value,Character Location,File Location"
                fileWriter.WriteLine(line)

                While (ctr < listviewcount)
                    line = lstvwOutput.Items.Item(ctr).SubItems(0).Text & "," & lstvwOutput.Items.Item(ctr).SubItems(1).Text & "," & lstvwOutput.Items.Item(ctr).SubItems(2).Text & "," & lstvwOutput.Items.Item(ctr).SubItems(3).Text
                    fileWriter.WriteLine(line)
                    ctr = ctr + 1
                End While
                fileWriter.Close()
                MsgBox("File Saved", MsgBoxStyle.OkOnly, "File Saved")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "File Save Error")
        End Try
    End Sub

    Public Sub loadSearchStrings()
        Try
            lstSearchStrings.Items.Clear()

            If rdbtnDictionary.Checked = True Then
                Dim fileReader As System.IO.StreamReader
                fileReader = My.Computer.FileSystem.OpenTextFileReader(Environment.CurrentDirectory & "\Dictionaries\" & cmbDictionary.SelectedItem.ToString)

                Dim stringReader As String = String.Empty

                indx = 0
                Do While fileReader.Peek() >= 0
                    stringReader = fileReader.ReadLine()
                    lstSearchStrings.Items.Add(stringReader)
                Loop
                fileReader.Close()
                indx = lstSearchStrings.Items.Count
            Else
                lstSearchStrings.Items.Add(txtCustomString.Text)
            End If

            indx = lstSearchStrings.Items.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Loading Search Strings")
        End Try
    End Sub

    Private Sub rdbtnDictionary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnDictionary.CheckedChanged
        Try
            If rdbtnDictionary.Checked Then
                cmbDictionary.Enabled = True
                txtCustomString.Enabled = False
            Else
                cmbDictionary.Enabled = False
                txtCustomString.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "rdbtnDictionary_CheckedChanged Error")
        End Try
    End Sub
End Class
