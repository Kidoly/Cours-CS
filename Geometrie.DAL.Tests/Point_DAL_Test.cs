namespace Geometrie.DAL.Tests
{
    public class Point_DAL_Test
    {

        /*
         * Sur les tests unitaires, 3 �tapes :
         * SEA : Setup, Execution, Assert
         * ou AAA : Arrange, Act, Assert
         */

        [Fact]
        public void Point_DAL_Constructor_sans_id()
        {
            // Arrange
            int x = 1;
            int y = 2;

            // Act
            Point_DAL p = new Point_DAL(x, y);

            // Assert
            Assert.NotNull(p); // v�rifie que l'objet n'est pas null
            Assert.Null(p.Id); // v�rifie que l'Id est null
            Assert.Equal(x, p.X); // v�rifie que X est �gal � x
            Assert.Equal(y, p.Y); // v�rifie que Y est �gal � y

        }

        // on fait le m�me test avec une theory
        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 4)]
        [InlineData(5, 6)]
        public void Point_DAL_Constructor_sans_id_theory(int x, int y)
        {
            // Arrange

            // Act
            Point_DAL p = new Point_DAL(x, y);

            // Assert
            Assert.NotNull(p); // v�rifie que l'objet n'est pas null
            Assert.Null(p.Id); // v�rifie que l'Id est null
            Assert.Equal(x, p.X); // v�rifie que X est �gal � x
            Assert.Equal(y, p.Y); // v�rifie que Y est �gal � y

        }

        // on fait le test avec l'id
        [Fact]
        public void Point_DAL_Constructor_avec_id()
        {
            // Arrange
            int id = 1;
            int x = 1;
            int y = 2;

            // Act
            Point_DAL p = new Point_DAL(id, x, y);

            // Assert
            Assert.NotNull(p); // v�rifie que l'objet n'est pas null
            Assert.Equal(id, p.Id); // v�rifie que l'Id est �gal � id
            Assert.Equal(x, p.X); // v�rifie que X est �gal � x
            Assert.Equal(y, p.Y); // v�rifie que Y est �gal � y

        }
    }
}