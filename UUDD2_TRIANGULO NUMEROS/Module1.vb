Module Module1

    Sub Main()
        Dim filas As Integer
        Dim i, j, x As Integer

        Console.Write("Introduce el numero de filas: ")
        filas = Console.ReadLine()
        Console.WriteLine()

        For i = 1 To filas
            For x = filas - i To 1 Step -1
                Console.Write(" ")
            Next
            For j = 1 To i Step +1
                If j > 9 Then
                    Console.Write(Chr(55 + j))
                Else
                    Console.Write(j)
                End If
            Next
            For j = i - 1 To 1 Step -1
                If j > 9 Then
                    Console.Write(Chr(55 + j))
                Else
                    Console.Write(j)
                End If
            Next

            Console.WriteLine()
        Next




        Console.ReadLine()

    End Sub

End Module
