namespace BOR12
{
    public class KalkulackaTest
    {
        [Fact]
        public void Secti_SprávnyVýsledok()
        {
            double a = 5.0;
            double b = 3.0;
            double expected = 8.0;

            
            double result = Kalkulacka.Secti(a, b);
            

            
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Vydel_SprávnyKvocient()
        {
            
            double a = 6.0;
            double b = 2.0;
            double expected = 3.0;

            
            double result = Kalkulacka.Vydel(a, b);

            
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Vydel_VynimkaPriDeleni()
        {
            
            double a = 6.0;
            double b = 0.0;

           
            Assert.Throws<DivideByZeroException>(() => Kalkulacka.Vydel(a, b));
        }
    }
}