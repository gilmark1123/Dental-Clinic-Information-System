Public Class formTreatment
    Public Sub New(idToTreatment As Integer, Name As String)

        ' This call is required by the designer.
        InitializeComponent()
        lblname.Text = Name
        lblid.Text = idToTreatment


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim doctor As String = cmbDoctor.Text
        Dim dateTreat As DateTime = dateTreatment.Value
        Dim work1 As String = cmbWork1.Text
        Dim work2 As String = cmbWork2.Text
        Dim work3 As String = cmbWork3.Text
        Dim id As String = lblid.Text
        Dim names As String = lblname.Text
        Dim prescription As String = rtbPrescriptions.Text
        Dim teethCollect As New TeethCollection(id, names, doctor, dateTreat, work1, work2, work3, prescription)
        Me.Close()
        teethCollect.Show()

    End Sub





    Private Sub formTreatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbWork2.Visible = False
        cmbWork3.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbWork2.Visible = False Then
            cmbWork2.Visible = True
        ElseIf cmbWork2.Visible = True Then
            cmbWork3.Visible = True
        End If
    End Sub

    Private Sub btnChild_Click(sender As Object, e As EventArgs) Handles btnChild.Click
        Dim doctor As String = cmbDoctor.Text
        Dim dateTreat As DateTime = dateTreatment.Value
        Dim work1 As String = cmbWork1.Text
        Dim work2 As String = cmbWork2.Text
        Dim work3 As String = cmbWork3.Text
        Dim id As String = lblid.Text
        Dim names As String = lblname.Text
        Dim prescription As String = rtbPrescriptions.Text
        Dim teethChild As New formTeethChild(id, names, doctor, dateTreat, work1, work2, work3, prescription)
        Me.Close()
        teethChild.Show()
    End Sub
End Class