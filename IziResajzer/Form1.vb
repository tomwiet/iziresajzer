Public Class Form1

    Private Sub btnAddFiles_Click(sender As Object, e As EventArgs) Handles btnAddFiles.Click
        Dim dt As New DataTable 'obiekt typu DataTable do przechowywania ściezki i nazwy pliku
        dt.Columns.Add(New DataColumn("FilePath")) 'columna przechowująca ściezkę
        dt.Columns.Add(New DataColumn("FileName")) 'kolumna przechowująca nazw pliku

        Dim strFileName As String
        Dim strFileNames() As String
        'dodaj zaznaczone pliki do dgvListFiles
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            strFileNames = OpenFileDialog1.FileNames
            For Each strFileName In strFileNames
                Dim dr As DataRow = dt.NewRow 'tworzenie nowego wiersza dla dt
                dr(0) = strFileName 'pierwsza kolumna - ścieżka dostępu
                Dim tmp() As String = Split(strFileName, "\") 'podziel
                dr(1) = tmp(tmp.Length - 1) 'druga kolumna - nazwa pliku
                dt.Rows.Add(dr) 'dodaj wiersz do dt
            Next
            dgvListFiles.DataSource = dt 'ustaw dt jako źródło danych dla dgv
            dgvListFiles.Columns(0).Visible = False 'ukryj pierwszą kolumne
        End If
        txtTargetPath.Text = System.IO.Path.GetDirectoryName(OpenFileDialog1.FileName) & "\resized" 'sciezka do katalogu z którego były wybierane pliki
        'lblTest.Text = dgvListFiles.Rows.Count.ToString() 'kod techniczny, wypisuje liczbe wybranych plików
    End Sub

    'wyswietl plik zaznaczony w lstFiles przy pomocy PictureBox
    Private Sub lbxFileList_SelectedIndexChanged(sender As Object, e As EventArgs)
        If lbxFileList.SelectedItems.Count > 0 Then 'jesli zaznnaczono minimum jeden plik

            Try
                PictureBox.Image = Image.FromFile(lbxFileList.SelectedItem)
            Catch ex As Exception
                MessageBox.Show("Nie udało się otworzyć pliku", "Błąd oczytu pliku", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub
    'usuwanie plików z listy
    Private Sub btnRemoveFiles_Click(sender As Object, e As EventArgs) Handles btnRemoveFiles.Click
        Dim dr As DataGridViewRow
        For Each dr In dgvListFiles.SelectedRows
            dgvListFiles.Rows.Remove(dr)
        Next
    End Sub

    Private Sub btnZastosuj_Click(sender As Object, e As EventArgs) Handles btnZastosuj.Click
        Dim ResizedImage As Image
        Dim NewSize As New Size
        Dim strFileName As String
        Dim strResizedName As String
        If dgvListFiles.Rows.Count < 1 Then
            MessageBox.Show("Nie wybrano plików", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If cbxSizes.SelectedIndex < 0 Then
            MessageBox.Show("Nie wybrano rozmiaru", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Dim strNewSize() As String = Split(cbxSizes.Text, "x") 'rozdziel na szerokośc i wysokość
        NewSize.Width = strNewSize(0)
        NewSize.Height = strNewSize(1)
       
        'stwórz katalog na zmniejszone pliki
        If (Not System.IO.Directory.Exists(txtTargetPath.Text)) Then
            Try
                System.IO.Directory.CreateDirectory(txtTargetPath.Text)
            Catch ex As Exception
                MessageBox.Show("ZNie udało się utworzyć katalogu na zmniejszane pliki", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        PictureBox.Image = Nothing
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = dgvListFiles.Rows.Count
        ProgressBar.Value = 0
        ProgressBar.Visible = True
        Try

            For Each row As DataGridViewRow In dgvListFiles.Rows
                ResizedImage = New Bitmap(Image.FromFile(row.Cells(0).Value), NewSize)
                strFileName = row.Cells(1).Value
                If cbxResized.Checked = True Then 'jesli zaznaczono opcje "dodaj resized do nazwy pliku"
                    Dim tmp() As String = Split(row.Cells(1).Value, ".")
                    strFileName = tmp(0) & "_resized." & tmp(1)
                End If
                'strResizedName = strPicture.Substring(0, strPicture.LastIndexOf(".")) + "_resized" + ".jpg"
                strResizedName = txtTargetPath.Text & "\" & strFileName
                ResizedImage.Save(strResizedName, System.Drawing.Imaging.ImageFormat.Jpeg)
                ProgressBar.Value = ProgressBar.Value + 1
                ResizedImage.Dispose()
            Next
            'lbxFileList.Items.Clear()
        Catch ex As Exception
            MessageBox.Show("Zapis jednego lub więcej plików nie powiódł się", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dgvListFiles.DataSource = Nothing
        dgvListFiles.Rows.Clear()
        dgvListFiles.Columns.Clear()
        MessageBox.Show("Zapisano pomyślnie wszystkie pliki", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.None)
        ProgressBar.Visible = False
        lblProgress.Visible = False
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtTargetPath.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub

    Private Sub dgvListFiles_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListFiles.SelectionChanged
        If dgvListFiles.SelectedRows.Count > 0 Then
            Try
                PictureBox.Image = Image.FromFile(dgvListFiles.SelectedRows.Item(0).Cells(0).Value)
            Catch ex As Exception
                MessageBox.Show("Nie udało się otworzyć pliku", "Błąd oczytu pliku", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class

