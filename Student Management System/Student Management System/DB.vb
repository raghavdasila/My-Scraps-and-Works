Public Class DB
    Private Sub DB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AttendanceDataSet.attendance' table. You can move, or remove it, as needed.
        Me.AttendanceTableAdapter.Fill(Me.AttendanceDataSet.attendance)
        'TODO: This line of code loads data into the 'MrksDataSet.Marks' table. You can move, or remove it, as needed.
        Me.MarksTableAdapter.Fill(Me.MrksDataSet.Marks)
        'TODO: This line of code loads data into the 'Database2DataSet.Student_Details' table. You can move, or remove it, as needed.
        Me.Student_DetailsTableAdapter.Fill(Me.Database2DataSet.Student_Details)

    End Sub
    Private Sub meLoad(sender As Object, e As EventArgs) Handles Me.Load
        Database2DataSet.Student_Details.ReadXml("SDetails.xml")
        AttendanceDataSet.attendance.ReadXml("SAttendance.xml")
        MrksDataSet.Marks.ReadXml("SMarks.xml")
    End Sub
End Class