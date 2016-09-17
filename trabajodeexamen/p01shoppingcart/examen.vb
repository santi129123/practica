Public Class examen

    Private PanelH As Boolean = True
    Private PanelM As Boolean = False
    Private PanelC As Boolean = False
    Private PanelA As Boolean = False

    Private CantHL1 As Integer = 0
    Private CantHL2 As Integer = 0
    Private CantHL3 As Integer = 0
    Private CantHL4 As Integer = 0

    Private CantML1 As Integer = 0
    Private CantML2 As Integer = 0
    Private CantML3 As Integer = 0
    Private CantML4 As Integer = 0

    Private CantCL1 As Integer = 0
    Private CantCL2 As Integer = 0
    Private CantCL3 As Integer = 0
    Private CantCL4 As Integer = 0

    Private CantAL1 As Integer = 0
    Private CantAL2 As Integer = 0
    Private CantAL3 As Integer = 0
    Private CantAL4 As Integer = 0

    Private Total As Integer = 0

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Estableciendo Imagen y Etiquetas Producto Inicial
        pbProdTitulo.Image = ilProductosH.Images.Item(0)
        lblProdTitulo.Text = "CAMISA DE ALGODON"
        lblPrecioTitulo.Text = "$120"

    End Sub

    Private Sub btnHombres_Click(sender As Object, e As EventArgs) Handles btnHombres.Click

        ' Estado Paneles
        PanelH = True
        PanelM = False
        PanelC = False
        PanelA = False

        ' Modificando Color de Botones 
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black

        ' Camisa de Algodon
        lblProdL1.Text = "Camisa de Algodon"
        lblPrecioL1.Text = "$120"

        ' Blazer Mezcla de Lana
        lblProdL2.Text = "Blazer Mezcla de Lana"
        lblPrecioL2.Text = "$240"

        ' Jersey Cuello Pico
        lblProdL3.Text = "Jersey Cuello Pico"
        lblPrecioL3.Text = "$160"

        ' Polo Cuello Redondo
        lblProdL4.Text = "Polo Cuello Redondo"
        lblPrecioL4.Text = "$70"

        ' Estableciendo Etiquetas Cantidades
        lblCantL1.Text = CantHL1.ToString()
        lblCantL2.Text = CantHL2.ToString()
        lblCantL3.Text = CantHL3.ToString()
        lblCantL4.Text = CantHL4.ToString()

        ' Estableciendo Imagen y Etiquetas de Titulo y Talla
        pbProdTitulo.Image = ilProductosH.Images.Item(0)
        lblProdTitulo.Text = "CAMISA DE ALGODON"
        lblPrecioTitulo.Text = "$120"

        ' Talla XS
        lblTallaP1.Text = "XS"
        lblTallaP1.ForeColor = Color.Black

        ' Talla S
        lblTallaP2.Text = "S"
        lblTallaP2.ForeColor = Color.Black

        ' Talla M
        lblTallaP3.Text = "M"
        lblTallaP3.ForeColor = Color.Black

        ' Talla L
        lblTallaP4.Text = "L"
        lblTallaP4.ForeColor = Color.Black

        ' Talla XL
        lblTallaP5.Text = "XL"
        lblTallaP5.ForeColor = Color.Black

    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click

        ' Estado Paneles
        PanelH = False
        PanelM = True
        PanelC = False
        PanelA = False

        ' Modificando Color de Botones 
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.SteelBlue
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black

        ' Modificando Titulos y Precios de Productos

        ' Polo Rayas Cuello Redondo
        lblProdL1.Text = "Polo Rayas Cuello Redondo"
        lblPrecioL1.Text = "$80"

        ' Chompa Lana Cuello Redondo
        lblProdL2.Text = "Chompa Lana Cuello Redondo"
        lblPrecioL2.Text = "$150"

        ' Casaca de Jean
        lblProdL3.Text = "Casaca de Jean"
        lblPrecioL3.Text = "$220"

        ' Abrigo Mezcla Lana
        lblProdL4.Text = "Abrigo Mezcla Lana"
        lblPrecioL4.Text = "$270"

        ' Estableciendo Etiquetas Cantidades
        lblCantL1.Text = CantML1.ToString()
        lblCantL2.Text = CantML2.ToString()
        lblCantL3.Text = CantML3.ToString()
        lblCantL4.Text = CantML4.ToString()

        ' Estableciendo Imagen y Etiquetas de Titulo
        pbProdTitulo.Image = ilProductosM.Images.Item(0)
        lblProdTitulo.Text = "POLO RAYAS CUELLO REDONDO"
        lblPrecioTitulo.Text = "$80"

        ' Talla XS
        lblTallaP1.Text = "XS"
        lblTallaP1.ForeColor = Color.Silver

        ' Talla S
        lblTallaP2.Text = "S"
        lblTallaP2.ForeColor = Color.Black

        ' Talla M
        lblTallaP3.Text = "M"
        lblTallaP3.ForeColor = Color.Black

        ' Talla L
        lblTallaP4.Text = "L"
        lblTallaP4.ForeColor = Color.Black

        ' Talla XL
        lblTallaP5.Text = "XL"
        lblTallaP5.ForeColor = Color.Silver

    End Sub

    Private Sub btnCalzado_Click(sender As Object, e As EventArgs) Handles btnCalzado.Click

        ' Estado Paneles
        PanelH = False
        PanelM = False
        PanelC = True
        PanelA = False

        ' Modificando Color de Botones 
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.SteelBlue
        btnAccesorios.ForeColor = Color.Black

        ' Modificando Titulos y Precios de Productos

        ' Zapatos Oxfords
        lblProdL1.Text = "Zapatos Oxfords"
        lblPrecioL1.Text = "$120"

        ' Zapatos Derby
        lblProdL2.Text = "Zapatos Derby"
        lblPrecioL2.Text = "$140"

        ' Botines
        lblProdL3.Text = "Botines"
        lblPrecioL3.Text = "$160"

        ' Loafers
        lblProdL4.Text = "Loafers"
        lblPrecioL4.Text = "$80"

        ' Estableciendo Etiquetas Cantidades
        lblCantL1.Text = CantCL1.ToString()
        lblCantL2.Text = CantCL2.ToString()
        lblCantL3.Text = CantCL3.ToString()
        lblCantL4.Text = CantCL4.ToString()

        ' Estableciendo Imagen y Etiquetas de Titulo
        pbProdTitulo.Image = ilProductosC.Images.Item(0)
        lblProdTitulo.Text = "ZAPATOS OXFORDS"
        lblPrecioTitulo.Text = "$120"

        ' Talla 37
        lblTallaP1.Text = "37"
        lblTallaP1.ForeColor = Color.Silver

        ' Talla 38
        lblTallaP2.Text = "38"
        lblTallaP2.ForeColor = Color.Black

        ' Talla 40
        lblTallaP3.Text = "40"
        lblTallaP3.ForeColor = Color.Black

        ' Talla 42
        lblTallaP4.Text = "42"
        lblTallaP4.ForeColor = Color.Black

        ' Talla 44
        lblTallaP5.Text = "44"
        lblTallaP5.ForeColor = Color.Silver

    End Sub

    Private Sub btnAccesorios_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click

        ' Estado Paneles
        PanelH = False
        PanelM = False
        PanelC = False
        PanelA = True

        ' Modificando Color de Botones 
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.SteelBlue

        ' Modificando Titulos y Precios de Productos

        ' Reloj de Acero
        lblProdL1.Text = "Reloj de Acero"
        lblPrecioL1.Text = "$380"

        ' Cinturon de Cuero
        lblProdL2.Text = "Cinturon de Cuero"
        lblPrecioL2.Text = "$70"

        ' Billetera de Cuero
        lblProdL3.Text = "Billetera de Cuero"
        lblPrecioL3.Text = "$190"

        ' Gorra
        lblProdL4.Text = "Gorra"
        lblPrecioL4.Text = "$50"

        ' Estableciendo Etiquetas Cantidades
        lblCantL1.Text = CantAL1.ToString()
        lblCantL2.Text = CantAL2.ToString()
        lblCantL3.Text = CantAL3.ToString()
        lblCantL4.Text = CantAL4.ToString()

        ' Estableciendo Imagen y Etiquetas de Titulo
        pbProdTitulo.Image = ilProductosA.Images.Item(0)
        lblProdTitulo.Text = "RELOJ DE ACERO"
        lblPrecioTitulo.Text = "$380"

        ' Talla XS
        lblTallaP1.Text = "XS"
        lblTallaP1.ForeColor = Color.Silver

        ' Talla S
        lblTallaP2.Text = "S"
        lblTallaP2.ForeColor = Color.Silver

        ' Talla M
        lblTallaP3.Text = "M"
        lblTallaP3.ForeColor = Color.Silver

        ' Talla L
        lblTallaP4.Text = "L"
        lblTallaP4.ForeColor = Color.Silver

        ' Talla XL
        lblTallaP5.Text = "XL"
        lblTallaP5.ForeColor = Color.Silver

    End Sub

    Private Sub lblVerProdL1_Click(sender As Object, e As EventArgs) Handles lblVerProdL1.Click

        ' Verificando Panel Activo 

        If PanelH Then ' Panel Hombres Activo

            ' Camisa de Algodon
            ' Estableciendo Imagen y Etiquetas de Titulo y Talla
            pbProdTitulo.Image = ilProductosH.Images.Item(0)
            lblProdTitulo.Text = "CAMISA DE ALGODON"
            lblPrecioTitulo.Text = "$120"

        ElseIf PanelM Then ' Panel Mujeres Activo

            ' Polo Rayas Cuello Redondo
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosM.Images.Item(0)
            lblProdTitulo.Text = "POLO RAYAS CUELLO REDONDO"
            lblPrecioTitulo.Text = "$80"

        ElseIf PanelC Then ' Panel Calzado Activo

            ' Zapatos Oxfords
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosC.Images.Item(0)
            lblProdTitulo.Text = "ZAPATOS OXFORDS"
            lblPrecioTitulo.Text = "$120"

        ElseIf PanelA Then ' Panel Accesorios Activado

            ' Reloj de Acero
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosA.Images.Item(0)
            lblProdTitulo.Text = "RELOJ DE ACERO"
            lblPrecioTitulo.Text = "$380"

        End If

    End Sub

    Private Sub btnVerProdL2_Click(sender As Object, e As EventArgs) Handles btnVerProdL2.Click

        ' Verificando Panel Activo 

        If PanelH Then ' Panel Hombres Activo

            ' Blazer Mezcla de Lana
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosH.Images.Item(1)
            lblProdTitulo.Text = "BLAZER MEZCLA DE LANA"
            lblPrecioTitulo.Text = "$240"

        ElseIf PanelM Then ' Panel Mujeres Activo

            ' Chompa Lana Cuello Redondo
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosM.Images.Item(1)
            lblProdTitulo.Text = "CHOMPA LANA CUELLO REDONDO"
            lblPrecioTitulo.Text = "$150"

        ElseIf PanelC Then ' Panel Calzado Activo

            ' Zapatos Derby
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosC.Images.Item(1)
            lblProdTitulo.Text = "ZAPATOS DERBY"
            lblPrecioTitulo.Text = "$140"

        ElseIf PanelA Then ' Panel Accesorios Activado

            ' Cinturon de Cuero
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosA.Images.Item(1)
            lblProdTitulo.Text = "CINTURON DE CUERO"
            lblPrecioTitulo.Text = "$70"

        End If

    End Sub

    Private Sub btnVerProdL3_Click(sender As Object, e As EventArgs) Handles btnVerProdL3.Click

        ' Verificando Panel Activo 

        If PanelH Then ' Panel Hombres Activo

            ' Jersey Cuello Pico
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosH.Images.Item(2)
            lblProdTitulo.Text = "JERSEY CUELLO PICO"
            lblPrecioTitulo.Text = "$160"

        ElseIf PanelM Then ' Panel Mujeres Activo

            ' Casaca de Jean
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosM.Images.Item(2)
            lblProdTitulo.Text = "CASACA DE JEAN"
            lblPrecioTitulo.Text = "$220"

        ElseIf PanelC Then ' Panel Calzado Activo

            ' Botines
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosC.Images.Item(2)
            lblProdTitulo.Text = "BOTINES"
            lblPrecioTitulo.Text = "$160"

        ElseIf PanelA Then ' Panel Accesorios Activado

            ' Billetera de Cuero
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosA.Images.Item(2)
            lblProdTitulo.Text = "BILLETERA DE CUERO"
            lblPrecioTitulo.Text = "$190"

        End If

    End Sub

    Private Sub btnVerProdL4_Click(sender As Object, e As EventArgs) Handles btnVerProdL4.Click

        ' Verificando Panel Activo 

        If PanelH Then ' Panel Hombres Activo

            ' Polo Cuello Redondo
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosH.Images.Item(3)
            lblProdTitulo.Text = "POLO CUELLO REDONDO"
            lblPrecioTitulo.Text = "$70"

        ElseIf PanelM Then ' Panel Mujeres Activo

            ' Abrigo Mezcla Lana
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosM.Images.Item(3)
            lblProdTitulo.Text = "ABRIGO MEZCLA LANA"
            lblPrecioTitulo.Text = "$270"

        ElseIf PanelC Then ' Panel Calzado Activo

            ' Loafers
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosC.Images.Item(3)
            lblProdTitulo.Text = "LOAFERS"
            lblPrecioTitulo.Text = "$80"

        ElseIf PanelA Then ' Panel Accesorios Activado

            ' Gorra
            ' Estableciendo Imagen y Etiquetas de Titulo
            pbProdTitulo.Image = ilProductosA.Images.Item(3)
            lblProdTitulo.Text = "GORRA"
            lblPrecioTitulo.Text = "$50"

        End If

    End Sub

    Private Sub lblArribaL1_Click(sender As Object, e As EventArgs) Handles lblArribaL1.Click

        ' Obteniendo Cantidad L1
        Dim CantL1 As Integer = CInt(lblCantL1.Text)

        ' Verificando si la cantidad actual es nueve (suponiendo cantidad maxima: 9)
        If CantL1 = 9 Then Exit Sub

        ' Estableciendo nueva cantidad 
        CantL1 = CantL1 + 1

        ' Actualizando cantidad panel activo
        If PanelH Then CantHL1 = CantL1
        If PanelM Then CantML1 = CantL1
        If PanelC Then CantCL1 = CantL1
        If PanelA Then CantAL1 = CantL1

        ' Modificando Etiqueta Cantidad L1
        lblCantL1.Text = CantL1.ToString()

        ' Obteniendo Precio Producto L1
        Dim PrecioL1 As Integer = CInt(lblPrecioL1.Text.Substring(1))

        ' Modificando Total Actual 
        Total = Total + PrecioL1

        ' Modificando Etiqueta Total
        lblTotal.Text = String.Format("${0:0}", Total)

    End Sub

    Private Sub btnAbajoL1_Click(sender As Object, e As EventArgs) Handles btnAbajoL1.Click

        ' Obteniendo Cantidad L1
        Dim CantL1 As Integer = CInt(lblCantL1.Text)

        ' Verificando si la cantidad actual es cero 
        If CantL1 = 0 Then Exit Sub

        ' Estableciendo nueva cantidad 
        CantL1 = CantL1 - 1

        ' Actualizando cantidad panel activo
        If PanelH Then CantHL1 = CantL1
        If PanelM Then CantML1 = CantL1
        If PanelC Then CantCL1 = CantL1
        If PanelA Then CantAL1 = CantL1


        ' Modificando Etiqueta Cantidad L1
        lblCantL1.Text = CantL1.ToString()

        ' Obteniendo Precio Producto L1
        Dim PrecioL1 As Integer = CInt(lblPrecioL1.Text.Substring(1))

        ' Modificando Total Actual 
        Total = Total - PrecioL1

        ' Modificando Etiqueta Total
        lblTotal.Text = String.Format("${0:0}", Total)

    End Sub

    Private Sub lblArribaL2_Click(sender As Object, e As EventArgs) Handles lblArribaL2.Click

        ' Obteniendo Cantidad L2
        Dim CantL2 As Integer = CInt(lblCantL2.Text)

        ' Verificando si la cantidad actual es nueve (suponiendo cantidad maxima: 9)
        If CantL2 = 9 Then Exit Sub

        ' Estableciendo nueva cantidad 
        CantL2 = CantL2 + 1

        ' Actualizando cantidad panel activo
        If PanelH Then CantHL2 = CantL2
        If PanelM Then CantML2 = CantL2
        If PanelC Then CantCL2 = CantL2
        If PanelA Then CantAL2 = CantL2

        ' Modificando Etiqueta Cantidad L2
        lblCantL2.Text = CantL2.ToString()

        ' Obteniendo Precio Producto L2
        Dim PrecioL2 As Integer = CInt(lblPrecioL2.Text.Substring(1))

        ' Modificando Total Actual 
        Total = Total + PrecioL2

        ' Modificando Etiqueta Total
        lblTotal.Text = String.Format("${0:0}", Total)

    End Sub

    Private Sub lblAbajoL2_Click(sender As Object, e As EventArgs) Handles lblAbajoL2.Click

        ' Obteniendo Cantidad L2
        Dim CantL2 As Integer = CInt(lblCantL2.Text)

        ' Verificando si la cantidad actual es cero 
        If CantL2 = 0 Then Exit Sub

        ' Estableciendo nueva cantidad 
        CantL2 = CantL2 - 1

        ' Actualizando cantidad panel activo
        If PanelH Then CantHL2 = CantL2
        If PanelM Then CantML2 = CantL2
        If PanelC Then CantCL2 = CantL2
        If PanelA Then CantAL2 = CantL2

        ' Modificando Etiqueta Cantidad L2
        lblCantL2.Text = CantL2.ToString()

        ' Obteniendo Precio Producto L2
        Dim PrecioL2 As Integer = CInt(lblPrecioL2.Text.Substring(1))

        ' Modificando Total Actual 
        Total = Total - PrecioL2

        ' Modificando Etiqueta Total
        lblTotal.Text = String.Format("${0:0}", Total)

    End Sub

    Private Sub lblArribaL3_Click(sender As Object, e As EventArgs) Handles lblArribaL3.Click

        ' Obteniendo Cantidad L3
        Dim CantL3 As Integer = CInt(lblCantL3.Text)

        ' Verificando si la cantidad actual es nueve (suponiendo cantidad maxima: 9)
        If CantL3 = 9 Then Exit Sub

        ' Estableciendo nueva cantidad 
        CantL3 = CantL3 + 1

        ' Actualizando cantidad panel activo
        If PanelH Then CantHL3 = CantL3
        If PanelM Then CantML3 = CantL3
        If PanelC Then CantCL3 = CantL3
        If PanelA Then CantAL3 = CantL3

        ' Modificando Etiqueta Cantidad L3
        lblCantL3.Text = CantL3.ToString()

        ' Obteniendo Precio Producto L3
        Dim PrecioL3 As Integer = CInt(lblPrecioL3.Text.Substring(1))

        ' Modificando Total Actual 
        Total = Total + PrecioL3

        ' Modificando Etiqueta Total
        lblTotal.Text = String.Format("${0:0}", Total)

    End Sub

    Private Sub lblAbajoL3_Click(sender As Object, e As EventArgs) Handles lblAbajoL3.Click

        ' Obteniendo Cantidad L3
        Dim CantL3 As Integer = CInt(lblCantL3.Text)

        ' Verificando si la cantidad actual es cero 
        If CantL3 = 0 Then Exit Sub

        ' Estableciendo nueva cantidad 
        CantL3 = CantL3 - 1

        ' Actualizando cantidad panel activo
        If PanelH Then CantHL3 = CantL3
        If PanelM Then CantML3 = CantL3
        If PanelC Then CantCL3 = CantL3
        If PanelA Then CantAL3 = CantL3

        ' Modificando Etiqueta Cantidad L3
        lblCantL3.Text = CantL3.ToString()

        ' Obteniendo Precio Producto L3
        Dim PrecioL3 As Integer = CInt(lblPrecioL3.Text.Substring(1))

        ' Modificando Total Actual 
        Total = Total - PrecioL3

        ' Modificando Etiqueta Total
        lblTotal.Text = String.Format("${0:0}", Total)

    End Sub

    Private Sub lblArribaL4_Click(sender As Object, e As EventArgs) Handles lblArribaL4.Click

        ' Obteniendo Cantidad L4
        Dim CantL4 As Integer = CInt(lblCantL4.Text)

        ' Verificando si la cantidad actual es nueve (suponiendo cantidad maxima: 9)
        If CantL4 = 9 Then Exit Sub

        ' Estableciendo nueva cantidad 
        CantL4 = CantL4 + 1

        ' Actualizando cantidad panel activo
        If PanelH Then CantHL4 = CantL4
        If PanelM Then CantML4 = CantL4
        If PanelC Then CantCL4 = CantL4
        If PanelA Then CantAL4 = CantL4

        ' Modificando Etiqueta Cantidad L4
        lblCantL4.Text = CantL4.ToString()

        ' Obteniendo Precio Producto L4
        Dim PrecioL4 As Integer = CInt(lblPrecioL4.Text.Substring(1))

        ' Modificando Total Actual 
        Total = Total + PrecioL4

        ' Modificando Etiqueta Total
        lblTotal.Text = String.Format("${0:0}", Total)

    End Sub

    Private Sub lblAbajoL4_Click(sender As Object, e As EventArgs) Handles lblAbajoL4.Click

        ' Obteniendo Cantidad L4
        Dim CantL4 As Integer = CInt(lblCantL4.Text)

        ' Verificando si la cantidad actual es cero 
        If CantL4 = 0 Then Exit Sub

        ' Estableciendo nueva cantidad 
        CantL4 = CantL4 - 1

        ' Actualizando cantidad panel activo
        If PanelH Then CantHL4 = CantL4
        If PanelM Then CantML4 = CantL4
        If PanelC Then CantCL4 = CantL4
        If PanelA Then CantAL4 = CantL4

        ' Modificando Etiqueta Cantidad L4
        lblCantL4.Text = CantL4.ToString()

        ' Obteniendo Precio Producto L4
        Dim PrecioL4 As Integer = CInt(lblPrecioL4.Text.Substring(1))

        ' Modificando Total Actual 
        Total = Total - PrecioL4

        ' Modificando Etiqueta Total
        lblTotal.Text = String.Format("${0:0}", Total)

    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        MsgBox("GRACIAS POR SU COMPRA", MsgBoxStyle.Information, "Tommy Hilfiger")
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class