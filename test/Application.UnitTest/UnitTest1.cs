public class UnitTestApplication
{
    // PRUEBA 1: PERÍMETRO DEL RECTÁNGULO
    [Theory]
    [InlineData(4, 2, 12)]
    [InlineData(10, 5, 30)]
    [InlineData(1, 1, 4)]
    [InlineData(5, 5, 20)]
    [InlineData(6, 3, 18)]
    [InlineData(20, 10, 60)]
    [InlineData(15, 5, 40)]
    [InlineData(2, 8, 20)]
    [InlineData(100, 1, 202)]
    [InlineData(0.5, 0.5, 2)]
    [InlineData(2.5, 2.5, 10)]
    [InlineData(12, 4, 32)]
    [InlineData(7, 7, 28)]
    [InlineData(50, 50, 200)]
    [InlineData(3, 9, 24)]
    [InlineData(11, 2, 26)]
    [InlineData(1.2, 1.2, 4.8)]
    [InlineData(10, 0.1, 20.2)]
    [InlineData(8, 6, 28)]
    [InlineData(9, 3, 24)]
    public void CalcularPerimetroRectangulo_LadosValidos_Correcto(double lado_a, double lado_b, double expected)
    {
        // Act
        // Llamamos al método directamente usando el nombre de tu clase
        double actual = Rectangulo262E02.Perimetro(lado_a, lado_b);
        
        // Assert
        Assert.Equal(expected, actual,3);
    }

    // PRUEBA 2: ÁREA DEL RECTÁNGULO
    [Theory]
     [InlineData(4, 2, 8)]
     [InlineData(10, 5, 50)]
     [InlineData(1, 1, 1)]
     [InlineData(5, 5, 25)]
     [InlineData(6, 3, 18)]
     [InlineData(20, 10, 200)]
     [InlineData(15, 5, 75)]
     [InlineData(2, 8, 16)]
     [InlineData(100, 1, 100)]
     [InlineData(0.5, 0.5, 0.25)]
     [InlineData(2.5, 2.5, 6.25)]
     [InlineData(12, 4, 48)]
     [InlineData(7, 7, 49)]
     [InlineData(50, 50, 2500)]
     [InlineData(3, 9, 27)]
     [InlineData(11, 2, 22)]
     [InlineData(1.2, 1.2, 1.44)]
     [InlineData(10, 0.1, 1)]
     [InlineData(8, 6, 48)]
     [InlineData(9, 3, 27)]
    public void CalcularAreaRectangulo_LadosValidos_Correcto(double lado_a, double lado_b, double expected)
    {
        // Arrange

        // Act
        double actual = Rectangulo262E02.Area(lado_a, lado_b);
        
        // Assert
        Assert.Equal(expected, actual,3);
    }

    // PRUEBA 3: VOLUMEN (PRISMA RECTANGULAR)
    [Theory]
    [InlineData(8, 10, 80)]
    [InlineData(50, 2, 100)]
    [InlineData(1, 5, 5)]
    [InlineData(25, 4, 100)]
    [InlineData(18, 2, 36)]
    [InlineData(200, 1, 200)]
    [InlineData(75, 2, 150)]
    [InlineData(16, 5, 80)]
    [InlineData(100, 1, 100)]
    [InlineData(0.25, 10, 2.5)]
    [InlineData(6.25, 4, 25)]
    [InlineData(48, 2, 96)]
    [InlineData(49, 10, 490)]
    [InlineData(2500, 2, 5000)]
    [InlineData(27, 3, 81)]
    [InlineData(22, 5, 110)]
    [InlineData(1.44, 10, 14.4)]
    [InlineData(1, 50, 50)]
    [InlineData(48, 0.5, 24)]
    [InlineData(27, 10, 270)]
    public void CalcularVolumenRectangulo_AreaYAlturaValidas_Correcto(double area, double altura, double expected)
    {
        // Arrange

        // Act
        double actual = Rectangulo262E02.Volumen(area, altura);
        
        // Assert
        Assert.Equal(expected, actual,3);
    }
}