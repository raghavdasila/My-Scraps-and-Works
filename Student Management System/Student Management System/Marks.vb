Public Class Marks
    Public Iter As Integer
    ' Public regno As Integer
    Private Sub MeLoad(Sender As Object, e As EventArgs) Handles Me.Load
        Database2DataSet.Student_Details.ReadXml("SDetails.xml")
        '  MrksDataSet.Marks.ReadXml("SMarks.xml")
        regnooooo.Text = "Enter Marks for Reg No." + Database2DataSet.Student_Details.Columns(3).Table.Rows.Item(Iter).Item(3).ToString

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MrksDataSet.Marks.AddMarksRow(Database2DataSet.Student_Details.Columns(3).Table.Rows.Item(Iter).Item(3), CInt(mathh.Text), CInt(Phys.Text), CInt(chem.Text), CInt(Bio.Text), CInt(SSC.Text), CInt(geoo.Text), CInt(cse.Text))
        MrksDataSet.Marks.AcceptChanges()
        MrksDataSet.Marks.WriteXml("SMarks.xml")
        If Iter < Database2DataSet.Student_Details.Rows.Count - 1 Then
            Iter = Iter + 1
            regnooooo.Text = "Enter Marks for Reg No." + Database2DataSet.Student_Details.Columns(3).Table.Rows.Item(Iter).Item(3).ToString
        Else
            regnooooo.Text = "All Entries Entered"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rkey As DataColumn
        Dim rg As Int32
        rg = regn.Text
        rkey = MrksDataSet.Marks.Columns(0)
        Dim k As Int32
        For x = 0 To MrksDataSet.Marks.Rows.Count - 1
            If rkey.Table.Rows(x).Item(0).ToString = rg.ToString Then
                k = x
            End If
        Next
        DPhys.Text = "Physics " + MrksDataSet.Marks.Item(k).Physics.ToString
        dchem.Text = "Chemistry " + MrksDataSet.Marks.Item(k).Chemistry.ToString
        dbio.Text = "Biology " + MrksDataSet.Marks.Item(k).Biology.ToString
        dssc.Text = "Social Studies " + MrksDataSet.Marks.Item(k).Social_Studies.ToString
        dcse.Text = "Computer Science " + MrksDataSet.Marks.Item(k).Computer_Science.ToString
        dgeo.Text = "Geography " + MrksDataSet.Marks.Item(k).Geography.ToString
        dmath.Text = "Maths " + MrksDataSet.Marks.Item(k).Maths.ToString
        Grade.Text = "Grade Point " + ((MrksDataSet.Marks.Item(k).Physics + MrksDataSet.Marks.Item(k).Chemistry + MrksDataSet.Marks.Item(k).Biology + MrksDataSet.Marks.Item(k).Computer_Science + MrksDataSet.Marks.Item(k).Maths + MrksDataSet.Marks.Item(k).Social_Studies + MrksDataSet.Marks.Item(k).Geography) / 70).ToString
    End Sub
End Class