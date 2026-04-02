public class UnitTestApplication
{
    // PRUEBA 1: PERÍMETRO DEL RECTÁNGULO
    [Theory]
    [InlineData(2, 3, 10)] 
    [InlineData(5, 7, 24)] 
    [InlineData(10, 5, 30)] 
    public void CalcularPerimetroRectangulo_LadosValidos_Correcto(double lado_a, double lado_b, double expected)
    {
        // Act
        // Llamamos al método directamente usando el nombre de tu clase
        double actual = Rectangulo262E02.Perimetro(lado_a, lado_b);
        
        // Assert
        Assert.Equal(expected, actual);
    }

    // PRUEBA 2: ÁREA DEL RECTÁNGULO
    [Theory]
    [InlineData(2, 3, 6)] 
    [InlineData(5, 7, 35)] 
    [InlineData(10, 5, 50)] 
    public void CalcularAreaRectangulo_LadosValidos_Correcto(double lado_a, double lado_b, double expected)
    {
        // Arrange

        // Act
        double actual = Rectangulo262E02.Area(lado_a, lado_b);
        
        // Assert
        Assert.Equal(expected, actual);
    }

    // PRUEBA 3: VOLUMEN (PRISMA RECTANGULAR)
    [Theory]
    [InlineData(6, 2, 12)] 
    [InlineData(35, 3, 105)] 
    [InlineData(50, 10, 500)] 
    public void CalcularVolumenRectangulo_AreaYAlturaValidas_Correcto(double area, double altura, double expected)
    {
        // Arrange

        // Act
        double actual = Rectangulo262E02.Volumen(area, altura);
        
        // Assert
        Assert.Equal(expected, actual);
    }
}