Namespace Algorithm
    Class Alphabetizor

        ''' <summary>
        ''' Convert the number as a string texts.
        ''' </summary>
        ''' <param name="UnconvertedText">The input text</param>
        ''' <param name="AlphabetDelimiter">The Word delimiter</param>
        ''' <returns>A Converted normal string.</returns>
        ''' <remarks></remarks>
        ''' '3.8.7.39 6.4.2.4.2.3.5.2
        Shared Function Convert(ByVal UnconvertedText As String, _
                                Optional AlphabetDelimiter As String = ".") As String
            Dim Teks As String() = UnconvertedText.Split(AlphabetDelimiter)
            Dim Hasil As String = ""
            For Each Kalimat As String In Teks
                If Kalimat = " " Then
                    Hasil = Hasil + Kalimat
                    Continue For
                End If

                Try
                    Hasil = Hasil & Chr((Int(Kalimat) Mod (Asc("z") + 1)) + Asc("a"))
                Catch ex As Exception

                End Try
            Next
            Return Hasil
        End Function
    End Class
    Class Dealphabetizor

        ''' <summary>
        ''' Convert the number as a string texts.
        ''' </summary>
        ''' <param name="UnconvertedText">The input text</param>
        ''' <param name="AlphabetDelimiter">The Word delimiter</param>
        ''' <returns>A Converted normal string.</returns>
        ''' <remarks></remarks>
        ''' '3.8.7.39 6.4.2.4.2.3.5.2
        Shared Function Convert(ByVal UnconvertedText As String, _
                                Optional AlphabetDelimiter As String = ".") As String
            Dim Hasil As String = ""
            For Each Ca As Char In UnconvertedText.ToLower.ToCharArray()
                If Ca = " " Then
                    Hasil = Hasil.Trim(AlphabetDelimiter) + " "
                    Continue For
                End If

                Hasil = Hasil & (Asc(Ca.ToString) - Asc("a") + 1) & AlphabetDelimiter
            Next

            Return Hasil.Trim(AlphabetDelimiter)
        End Function
    End Class
End Namespace
