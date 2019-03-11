Imports System.Data.SqlClient
Public Class _default
    Inherits System.Web.UI.Page
    Dim cmd As New SqlCommand
    Dim conn As New SqlConnection("Data Source=LAPTOP-GUIQPSQR\SQLEXPRESS;Initial Catalog=Farmacia;Integrated Security=True")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenaCombo()
        llenacombo2()

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Public Sub LlenaCombo()


        Try
            If conn.State = ConnectionState.Closed Then
                cmd.Connection = conn
                conn.Open()
            End If
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.CommandText = "sp_tres"

            Dim DS As New DataSet
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(DS)

            DropDownList1.DataSource = DS
            DropDownList1.DataTextField = "nom_dis"
            DropDownList1.DataValueField = "cod_dis"
            DropDownList1.DataBind()



        Catch ex As Exception

        Finally
            If conn.State = ConnectionState.Open Then
                cmd.Connection = conn
                conn.Close()
            End If

        End Try

    End Sub
    Private Sub llenacombo2()

        DropDownList2.Items.Add("M")
        DropDownList2.Items.Add("F")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If conn.State = ConnectionState.Closed Then
                cmd.Connection = conn
                conn.Open()
            End If
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.CommandText = "sp_guardar"

            cmd.Parameters.Add(New SqlParameter("@codigo", TextBox1.Text))
            cmd.Parameters.Add(New SqlParameter("@nombre", TextBox2.Text))
            cmd.Parameters.Add(New SqlParameter("@direccion", TextBox3.Text))
            cmd.Parameters.Add(New SqlParameter("@cod_distrito", DropDownList1.SelectedValue))
            cmd.Parameters.Add(New SqlParameter("@sexo", DropDownList2.SelectedValue))
            cmd.Parameters.Add(New SqlParameter("@dni", TextBox6.Text))
            cmd.Parameters.Add(New SqlParameter("@ruc", TextBox7.Text))
            cmd.Parameters.Add(New SqlParameter("@telefono", TextBox8.Text))
            cmd.Parameters.Add(New SqlParameter("@celular", TextBox9.Text))

            If cmd.ExecuteNonQuery() Then
                MsgBox("REGISTRO GUARADADO CORRECTAMENTE", vbExclamation)
            Else
                MsgBox("no se guardo el formulario deseado" + vbCritical)
            End If


        Catch ex As Exception




        Finally
            If conn.State = ConnectionState.Open Then
                cmd.Connection = conn
                conn.Close()
            End If

        End Try


    End Sub
End Class