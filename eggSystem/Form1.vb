Imports System.Data.SqlClient

Public Class Form1

    'Add Button------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SANo As String = txtno.Text
        Dim company As String = ComboCompany.Text
        Dim location As String = ComboLocation.Text
        Dim dateTime As String = DateTimePicker1.Text
        Dim remark As String = txtRemark.Text
        Dim category As String = ComboCategory.Text
        Dim qty As String = txtQty.Text

        Dim query As String = "Insert into Egg values (@SANo, @company, @location, @dateTime, @remark, @category, @qty)"
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-DCJ10BPM;Initial Catalog=Egg;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@SANo", SANo)
                cmd.Parameters.AddWithValue("@company", company)
                cmd.Parameters.AddWithValue("@location", location)
                cmd.Parameters.AddWithValue("@dateTime", dateTime)
                cmd.Parameters.AddWithValue("@remark", remark)
                cmd.Parameters.AddWithValue("@category", category)
                cmd.Parameters.AddWithValue("@qty", qty)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Successfully Added")

                BindData()

            End Using

        End Using
    End Sub

    Private Sub BindData()
        Dim query As String = "select * from Egg "
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-DCJ10BPM;Initial Catalog=Egg;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EggDataSet.egg' table. You can move, or remove it, as needed.
        Me.EggTableAdapter.Fill(Me.EggDataSet.egg)

    End Sub


    'New button-------
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SANo As String = txtno.Text
        Dim query As String = "select * from Egg where SANo = SANo"
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-DCJ10BPM;Initial Catalog=Egg;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@SANo", SANo)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            txtno.Text = dt.Rows(0)(1).ToString()
                            txtQty.Text = dt.Rows(0)(2).ToString()
                            txtRemark.Text = dt.Rows(0)(3).ToString()
                            ComboCompany.Text = dt.Rows(0)(4).ToString()
                            ComboLocation.Text = dt.Rows(0)(5).ToString()
                            ComboCategory.Text = dt.Rows(0)(6).ToString()

                        Else
                            txtno.Text = ""
                            txtQty.Text = ""
                            txtRemark.Text = ""
                            ComboCompany.Text = ""
                            ComboLocation.Text = ""
                            ComboCategory.Text = ""

                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class
