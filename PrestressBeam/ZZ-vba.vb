Function interp(a, b, c, d, x)
    interp = (b - d) / (a - c) * (x - a) + b
End Function

Function dc(ro_c, n, x, alpha_c)
    If x <= 1 Then
        dc = 1 - (ro_c * n) / (n - 1 + x ^ n)
    Else
        dc = 1 - ro_c / (alpha_c * (x - 1) ^ 2 + x)
	End If
        
End Function
