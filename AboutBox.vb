Public NotInheritable Class AboutBox

	Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		' Set the title of the form.
		Dim ApplicationTitle As String
		If My.Application.Info.Title <> vbNullString Then
			ApplicationTitle = My.Application.Info.Title
		Else
			ApplicationTitle = IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
		End If
		Text = String.Format("About {0}", ApplicationTitle)
		' Initialize all of the text displayed on the About Box.
		' TODO: Customize the application's assembly information in the "Application" pane of the project 
		'    properties dialog (under the "Project" menu).
		LabelProductName.Text = My.Application.Info.ProductName
		LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
		LabelCopyright.Text = My.Application.Info.Copyright
		LabelCompanyName.Text = My.Application.Info.CompanyName
		TextBoxDescription.Text = My.Application.Info.Description
	End Sub

	Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
		Close()
	End Sub

End Class
