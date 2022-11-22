Imports Microsoft.Office.Interop

Module Exportar
    Function GridAExcel(ByVal Datagridview1 As DataGridView) As Boolean
        Dim exapp As New Excel.Application
        Dim exlibro As Excel.Workbook
        Dim exhoja As Excel.Worksheet
        Try
            exlibro = exapp.Workbooks.Add
            exhoja = exlibro.Worksheets.Add()
            'Numero de Filas y columnas
            Dim ncol As Integer = Datagridview1.ColumnCount
            Dim nrow As Integer = Datagridview1.RowCount
            For i As Integer = 1 To ncol
                exhoja.Cells.Item(1, i) = Datagridview1.Columns(i - 1).Name.ToString
                exhoja.Cells.Item(1, i).horizontalalignment = 3
            Next
            For fila As Integer = 0 To nrow - 1
                For col As Integer = 0 To ncol - 1
                    exhoja.Cells.Item(fila + 2, col + 1) = Datagridview1.Rows(fila).Cells(col).Value
                Next
            Next
            'Titulo en negrita alineado al centro y que el tamaño de la columna se ajuste al texto
            exhoja.Rows.Item(1).font.bold = 1
            exhoja.Rows.Item(1).horizontalalignment = 3
            exhoja.Columns.AutoFit()
            'Aplicacion visible
            exapp.Application.Visible = True
            exhoja = Nothing
            exlibro = Nothing
            exapp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al Exportar a Excel")
            Return False
        End Try
        Return True
    End Function

End Module
