Public Class attendance
    Dim Iter As Integer
    Private Sub MeLoad(sender As Object, e As EventArgs) Handles Me.Load
        Database2DataSet.Student_Details.ReadXml("SDetails.xml")
        '   AttendanceDataSet.attendance.ReadXml("SAttendance.xml")
        regnooooo.Text = "Enter attendance for Reg No." + Database2DataSet.Student_Details.Columns(3).Table.Rows.Item(Iter).Item(3).ToString
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AttendanceDataSet.attendance.AddattendanceRow(Database2DataSet.Student_Details.Columns(3).Table.Rows.Item(Iter).Item(3), CInt(Phys.Text), CInt(chem.Text), CInt(mathh.Text), CInt(Bio.Text), CInt(SSC.Text), CInt(geoo.Text), CInt(cse.Text))
        AttendanceDataSet.attendance.AcceptChanges()
        AttendanceDataSet.attendance.WriteXml("SAttendance.xml")
        If Iter < Database2DataSet.Student_Details.Rows.Count - 1 Then
            Iter = Iter + 1
            regnooooo.Text = "Enter attendance for Reg No." + Database2DataSet.Student_Details.Columns(3).Table.Rows.Item(Iter).Item(3).ToString
        Else
            regnooooo.Text = "All Entries Entered"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rkey As DataColumn
        Dim rg As Int32
        rg = regn.Text
        rkey = AttendanceDataSet.attendance.Columns(0)
        Dim k As Int32
        For x = 0 To AttendanceDataSet.attendance.Rows.Count - 1
            If rkey.Table.Rows(x).Item(0).ToString = rg.ToString Then
                k = x
            End If
        Next
        DPhys.Text = "Physics " + AttendanceDataSet.attendance.Item(k).Physics.ToString
        dchem.Text = "Chemistry " + AttendanceDataSet.attendance.Item(k).Chemistry.ToString
        dbio.Text = "Biology " + AttendanceDataSet.attendance.Item(k).Biology.ToString
        dssc.Text = "Social Studies " + AttendanceDataSet.attendance.Item(k).Social_Science.ToString
        dcse.Text = "Computer Science " + AttendanceDataSet.attendance.Item(k).Computer_Science.ToString
        dgeo.Text = "Geography " + AttendanceDataSet.attendance.Item(k).Geography.ToString
        dmath.Text = "Maths " + AttendanceDataSet.attendance.Item(k).Maths.ToString
        Grade.Text = "Average Attendance " + ((AttendanceDataSet.attendance.Item(k).Physics + AttendanceDataSet.attendance.Item(k).Chemistry + AttendanceDataSet.attendance.Item(k).Biology + AttendanceDataSet.attendance.Item(k).Computer_Science + AttendanceDataSet.attendance.Item(k).Maths + AttendanceDataSet.attendance.Item(k).Social_Science + AttendanceDataSet.attendance.Item(k).Geography) / 7).ToString
    End Sub
End Class