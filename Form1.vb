Imports System
Imports Newtonsoft.Json

Public Class Form1
    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        list_jobs.Items.Clear()

        Dim url = "https://" & text_apiurl.Text & "/api/v2/jobs/"

        Try
            While Not String.IsNullOrEmpty(url)
                Dim myReq As Net.HttpWebRequest
                myReq = Net.HttpWebRequest.Create(url)
                myReq.Method = "GET"
                myReq.Accept = "application/json"
                myReq.Headers.Add("Authorization", "Token " & text_apikey.Text)

                Dim myResp As Net.HttpWebResponse
                Dim myReader As System.IO.StreamReader
                myResp = myReq.GetResponse()
                myReader = New System.IO.StreamReader(myResp.GetResponseStream)

                Dim myRespStr = myReader.ReadToEnd
                txt_output.Text = myRespStr

                Dim jobs = JsonConvert.DeserializeObject(Of RJobList)(myRespStr)

                For Each job In jobs.Jobs
                    list_jobs.Items.Add(job.ID)
                Next

                url = jobs.NextURL
            End While
        Catch ex As Exception
            txt_output.Text = ex.Message
        End Try
    End Sub

    Private Sub btn_jobinfo_Click(sender As Object, e As EventArgs) Handles btn_jobinfo.Click
        Try
            Dim id = list_jobs.SelectedItem
            txt_jobid.Text = id

            Dim myReq As Net.HttpWebRequest
            myReq = Net.HttpWebRequest.Create("https://" & text_apiurl.Text & "/api/v2/jobs/" & id & "/")
            myReq.Method = "GET"
            myReq.Accept = "application/json"
            myReq.Headers.Add("Authorization", "Token " & text_apikey.Text)

            Dim myResp As Net.HttpWebResponse
            Dim myReader As System.IO.StreamReader
            myResp = myReq.GetResponse()
            myReader = New System.IO.StreamReader(myResp.GetResponseStream)

            Dim myRespStr = myReader.ReadToEnd
            txt_output.Text = myRespStr

            Dim job = JsonConvert.DeserializeObject(Of RJob)(myRespStr)

            txt_jobname.Text = job.Name
            txt_jobowner.Text = job.Owner
        Catch ex As Exception
            txt_output.Text = ex.Message
        End Try
    End Sub

    Private Async Sub Upload(sender As Object, e As EventArgs) Handles upload_btn.Click
        If (Not (UploadDialog.ShowDialog() = DialogResult.OK)) Then
            Return
        End If
        txt_output.Text = UploadDialog.FileName
        txt_output.Text &= Environment.NewLine

        Dim filestream = System.IO.File.OpenRead(UploadDialog.FileName)
        Dim fileName = System.IO.Path.GetFileName(UploadDialog.FileName)
        txt_output.Text &= "filename = " & fileName
        txt_output.Text &= Environment.NewLine

        Dim content = New Net.Http.MultipartFormDataContent()
        content.Add(New Net.Http.StreamContent(filestream), "file", fileName)

        Dim client = New Net.Http.HttpClient()
        client.DefaultRequestHeaders.Add("Authorization", "Token " & text_apikey.Text)
        Dim resp = Await client.PostAsync("https://" & text_apiurl.Text & "/api/v2/files/contents/", content)
        Dim result = Await resp.Content.ReadAsStringAsync()

        txt_output.Text &= result
    End Sub
End Class

Public Class RJobList
    <JsonProperty("results")>
    Public Property Jobs As List(Of RJob)

    <JsonProperty("next")>
    Public Property NextURL As String
End Class

Public Class RJob
    <JsonProperty("id")>
    Public Property ID As String

    <JsonProperty("name")>
    Public Property Name As String

    <JsonProperty("owner")>
    Public Property Owner As String
End Class