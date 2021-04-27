<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.lbl_apiurl = New System.Windows.Forms.Label()
        Me.text_apikey = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_apikey = New System.Windows.Forms.Label()
        Me.text_apiurl = New System.Windows.Forms.TextBox()
        Me.txt_output = New System.Windows.Forms.TextBox()
        Me.lbl_jobname = New System.Windows.Forms.Label()
        Me.txt_jobname = New System.Windows.Forms.TextBox()
        Me.list_jobs = New System.Windows.Forms.ListBox()
        Me.btn_jobinfo = New System.Windows.Forms.Button()
        Me.lbl_jobid = New System.Windows.Forms.Label()
        Me.txt_jobid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_jobowner = New System.Windows.Forms.TextBox()
        Me.upload_btn = New System.Windows.Forms.Button()
        Me.UploadDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btn_load
        '
        Me.btn_load.Location = New System.Drawing.Point(380, 12)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(248, 53)
        Me.btn_load.TabIndex = 0
        Me.btn_load.Text = "load jobs"
        Me.btn_load.UseVisualStyleBackColor = True
        '
        'lbl_apiurl
        '
        Me.lbl_apiurl.AutoSize = True
        Me.lbl_apiurl.Location = New System.Drawing.Point(12, 15)
        Me.lbl_apiurl.Name = "lbl_apiurl"
        Me.lbl_apiurl.Size = New System.Drawing.Size(49, 15)
        Me.lbl_apiurl.TabIndex = 1
        Me.lbl_apiurl.Text = "API URL"
        '
        'text_apikey
        '
        Me.text_apikey.Location = New System.Drawing.Point(77, 42)
        Me.text_apikey.Name = "text_apikey"
        Me.text_apikey.Size = New System.Drawing.Size(280, 23)
        Me.text_apikey.TabIndex = 3
        Me.text_apikey.Text = "abcd1234"
        '
        'lbl_apikey
        '
        Me.lbl_apikey.AutoSize = True
        Me.lbl_apikey.Location = New System.Drawing.Point(13, 42)
        Me.lbl_apikey.Name = "lbl_apikey"
        Me.lbl_apikey.Size = New System.Drawing.Size(47, 15)
        Me.lbl_apikey.TabIndex = 4
        Me.lbl_apikey.Text = "API Key"
        '
        'text_apiurl
        '
        Me.text_apiurl.Location = New System.Drawing.Point(77, 15)
        Me.text_apiurl.Name = "text_apiurl"
        Me.text_apiurl.Size = New System.Drawing.Size(280, 23)
        Me.text_apiurl.TabIndex = 6
        Me.text_apiurl.Text = "eu.rescale.com"
        '
        'txt_output
        '
        Me.txt_output.Location = New System.Drawing.Point(12, 352)
        Me.txt_output.Multiline = True
        Me.txt_output.Name = "txt_output"
        Me.txt_output.Size = New System.Drawing.Size(968, 226)
        Me.txt_output.TabIndex = 7
        '
        'lbl_jobname
        '
        Me.lbl_jobname.AutoSize = True
        Me.lbl_jobname.Location = New System.Drawing.Point(13, 315)
        Me.lbl_jobname.Name = "lbl_jobname"
        Me.lbl_jobname.Size = New System.Drawing.Size(60, 15)
        Me.lbl_jobname.TabIndex = 9
        Me.lbl_jobname.Text = "Job Name"
        '
        'txt_jobname
        '
        Me.txt_jobname.Location = New System.Drawing.Point(91, 312)
        Me.txt_jobname.Name = "txt_jobname"
        Me.txt_jobname.Size = New System.Drawing.Size(604, 23)
        Me.txt_jobname.TabIndex = 11
        '
        'list_jobs
        '
        Me.list_jobs.FormattingEnabled = True
        Me.list_jobs.ItemHeight = 15
        Me.list_jobs.Location = New System.Drawing.Point(12, 83)
        Me.list_jobs.MultiColumn = True
        Me.list_jobs.Name = "list_jobs"
        Me.list_jobs.Size = New System.Drawing.Size(711, 184)
        Me.list_jobs.TabIndex = 12
        '
        'btn_jobinfo
        '
        Me.btn_jobinfo.Location = New System.Drawing.Point(732, 214)
        Me.btn_jobinfo.Name = "btn_jobinfo"
        Me.btn_jobinfo.Size = New System.Drawing.Size(248, 53)
        Me.btn_jobinfo.TabIndex = 13
        Me.btn_jobinfo.Text = "job info"
        Me.btn_jobinfo.UseVisualStyleBackColor = True
        '
        'lbl_jobid
        '
        Me.lbl_jobid.AutoSize = True
        Me.lbl_jobid.Location = New System.Drawing.Point(13, 284)
        Me.lbl_jobid.Name = "lbl_jobid"
        Me.lbl_jobid.Size = New System.Drawing.Size(39, 15)
        Me.lbl_jobid.TabIndex = 14
        Me.lbl_jobid.Text = "Job ID"
        '
        'txt_jobid
        '
        Me.txt_jobid.Location = New System.Drawing.Point(91, 281)
        Me.txt_jobid.Name = "txt_jobid"
        Me.txt_jobid.Size = New System.Drawing.Size(128, 23)
        Me.txt_jobid.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(250, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Job Owner"
        '
        'txt_jobowner
        '
        Me.txt_jobowner.Location = New System.Drawing.Point(319, 281)
        Me.txt_jobowner.Name = "txt_jobowner"
        Me.txt_jobowner.Size = New System.Drawing.Size(376, 23)
        Me.txt_jobowner.TabIndex = 17
        '
        'upload_btn
        '
        Me.upload_btn.Location = New System.Drawing.Point(13, 607)
        Me.upload_btn.Name = "upload_btn"
        Me.upload_btn.Size = New System.Drawing.Size(248, 53)
        Me.upload_btn.TabIndex = 18
        Me.upload_btn.Text = "upload file"
        Me.upload_btn.UseVisualStyleBackColor = True
        '
        'UploadDialog
        '
        Me.UploadDialog.FileName = "UploadDialog"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 702)
        Me.Controls.Add(Me.upload_btn)
        Me.Controls.Add(Me.txt_jobowner)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_jobid)
        Me.Controls.Add(Me.lbl_jobid)
        Me.Controls.Add(Me.btn_jobinfo)
        Me.Controls.Add(Me.list_jobs)
        Me.Controls.Add(Me.txt_jobname)
        Me.Controls.Add(Me.lbl_jobname)
        Me.Controls.Add(Me.txt_output)
        Me.Controls.Add(Me.text_apiurl)
        Me.Controls.Add(Me.lbl_apikey)
        Me.Controls.Add(Me.text_apikey)
        Me.Controls.Add(Me.lbl_apiurl)
        Me.Controls.Add(Me.btn_load)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_load As Button
    Friend WithEvents lbl_apiurl As Label
    Friend WithEvents text_apikey As MaskedTextBox
    Friend WithEvents lbl_apikey As Label
    Friend WithEvents text_apiurl As TextBox
    Friend WithEvents txt_output As TextBox
    Friend WithEvents lbl_jobname As Label
    Friend WithEvents txt_jobname As TextBox
    Friend WithEvents list_jobs As ListBox
    Friend WithEvents btn_jobinfo As Button
    Friend WithEvents lbl_jobid As Label
    Friend WithEvents txt_jobid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_jobowner As TextBox
    Friend WithEvents upload_btn As Button
    Friend WithEvents UploadDialog As OpenFileDialog
End Class
