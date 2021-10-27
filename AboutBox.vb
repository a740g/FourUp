Public NotInheritable Class AboutBox

	Private Sub AboutBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Set the title of the form.
		Text = String.Format("About {0}", If(My.Application.Info.Title <> vbNullString, My.Application.Info.Title, IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)))
		' Initialize all of the text displayed on the About Box.
		' TODO: Customize the application's assembly information in the "Application" pane of the project 
		'    properties dialog (under the "Project" menu).
		LabelProductName.Text = My.Application.Info.ProductName
		LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
		LabelCopyright.Text = My.Application.Info.Copyright
		LabelCompanyName.Text = My.Application.Info.CompanyName
		TextBoxDescription.Text = My.Application.Info.Description
	End Sub

	Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
		Close()
	End Sub

End Class
