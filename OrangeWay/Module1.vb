Module Module1
    'Clears all textboxes
    Public Sub ClearTextBox(ByVal root As Control)

        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)

            If TypeOf ctrl Is TextBox Then

                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl

    End Sub
End Module
