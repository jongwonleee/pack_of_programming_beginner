Module Main_module
    Public bgx, bgy, bglayout, xx, xy, cngnum, valn, obn, sndn, sz(6), bmpcnt, stuclr As Integer
    Public bgimgname As String
    Public bgcolor As Color
    Public bgimg As Image
    Public scr(2000, 200, 200) As String

    Public Structure value
        Dim nam As String
        Dim type As Integer
        Dim first As String
    End Structure
    Public Structure objects
        Dim nam As String
        Dim save As String
        Dim x, y As Integer
    End Structure
    Public Structure sounds
        Dim nam As String
        Dim save As String
        Dim vol As Integer
    End Structure

    Public Function gsp(ByVal n As Integer) As String
        Dim ret As String
        If n = -1 Then
            ret = ""
        Else
            ret = n
        End If
        Return ret
    End Function

    Public vall(100) As value
    Public obj(100) As objects
    Public snd(100) As sounds

End Module



