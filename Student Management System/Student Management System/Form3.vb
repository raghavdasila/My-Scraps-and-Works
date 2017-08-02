Public Class StudDetails
    Dim regnoo As Integer
    Dim pnooo As Int64

    Private Sub StudDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.Student_Details' table. You can move, or remove it, as needed.
        Me.Student_DetailsTableAdapter.Fill(Me.Database2DataSet.Student_Details)

    End Sub
    Private Sub meclose(sender As Object, e As EventArgs) Handles Me.Closing
        Form1.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        regnoo = regno.Text
        pnooo = pno.Text
        Database2DataSet.Student_Details.AddStudent_DetailsRow(naam.Text, course.Text, Dept.Text, regnoo, address.Text, paddress.Text, dob.Value, bldgrp.Text, pnooo, dad.Text)
        Database2DataSet.AcceptChanges()
        Database2DataSet.Student_Details.WriteXml("SDetails.xml")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rkey As DataColumn
        Dim rg As Int32
        rg = regg.Text
        rkey = Database2DataSet.Student_Details.Columns(3)
        Dim k As Int32
        For x = 0 To Database2DataSet.Student_Details.Rows.Count - 1
            If rkey.Table.Rows(x).Item(3).ToString = rg.ToString Then
                k = x
            End If
        Next
        dname.Text = "Name: " + Database2DataSet.Student_Details.Item(k).Name
        dcourse.Text = "Course: " + Database2DataSet.Student_Details.Item(k).Course
        ddept.Text = "Dept: " + Database2DataSet.Student_Details.Item(k).Dept
        dregno.Text = "Course: " + Database2DataSet.Student_Details.Item(k).RegNo.ToString
        daddress.Text = "Address: " + Database2DataSet.Student_Details.Item(k).Address
        dperaddres.Text = "Perm. Address: " + Database2DataSet.Student_Details.Item(k).Per_Address
        ddob.Text = "DOB: " + Database2DataSet.Student_Details.Item(k).DOB.Date
        dbg.Text = "Blood Group: " + Database2DataSet.Student_Details.Item(k).BloodGroup
        dph.Text = "Phone NUmber: " + Database2DataSet.Student_Details.Item(k).Phone_Number.ToString
        dfat.Text = "Father's Name: " + Database2DataSet.Student_Details.Item(k).FatherName
    End Sub
End Class