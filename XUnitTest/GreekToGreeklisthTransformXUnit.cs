namespace XUnitTest
{
    public class GreekToGreeklisthTransformXUnit
    {

        #region Success Statements

        [Fact]
        public void AntonisUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Αντώνης", true);

            //Assert
            Assert.True(expected == "Antonis");
        }

        [Fact]
        public void BampibUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Μπάμπημπ", true);

            //Assert
            Assert.True(expected == "Bampib");
        }

        [Fact]
        public void MarilizaUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Μαριλιζα", true);

            //Assert
            Assert.True(expected == "Mariliza");
        }

        [Fact]
        public void KostasUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Κώστας", true);

            //Assert
            Assert.True(expected == "Kostas");
        }

        [Fact]
        public void AfroxylanthiUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Αφροξυλάνθη", true);

            //Assert
            Assert.True(expected == "Afroxylanthi");
        }

        [Fact]
        public void IfigeneiaUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Ιφιγένεια", true);

            //Assert
            Assert.True(expected == "Ifigeneia");
        }

        [Fact]
        public void EvgeneiosUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Ευγένειος", true);

            //Assert
            Assert.True(expected == "Evgeneios");
        }

        [Fact]
        public void EfeteioUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Εφετείο", true);

            //Assert
            Assert.True(expected == "Efeteio");
        }

        [Fact]
        public void OgkolithosUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("ογκόλιθος", true);

            //Assert
            Assert.True(expected == "Ogkolithos");
        }

        [Fact]
        public void AfganistanUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Αφγανιστάν", true);

            //Assert
            Assert.True(expected == "Afganistan");
        }

        #endregion

        #region False Statements

        [Fact]
        public void AntonisLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Αντώνης");

            //Assert
            Assert.False(expected == "Antonis");
        }

        [Fact]
        public void BampibLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Μπάμπημπ");

            //Assert
            Assert.False(expected == "Bampib");
        }

        [Fact]
        public void MarilizaLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Μαριλιζα");

            //Assert
            Assert.False(expected == "Mariliza");
        }

        [Fact]
        public void KostasLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Κώστας");

            //Assert
            Assert.False(expected == "Kostas");
        }

        [Fact]
        public void AfroxylanthiLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Αφροξυλάνθη");

            //Assert
            Assert.False(expected == "Afroxylanthi");
        }

        [Fact]
        public void IfigeneiaLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Ιφιγένεια");

            //Assert
            Assert.False(expected == "Ifigeneia");
        }

        [Fact]
        public void EvgeneiosLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Ευγένειος");

            //Assert
            Assert.False(expected == "Evgeneios");
        }

        [Fact]
        public void EfeteioLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Εφετείο");

            //Assert
            Assert.False(expected == "Efeteio");
        }

        [Fact]
        public void OgkolithosLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("ογκόλιθος");

            //Assert
            Assert.False(expected == "Ogkolithos");
        }

        [Fact]
        public void AfganistanLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Αφγανιστάν");

            //Assert
            Assert.False(expected == "Afganistan");
        }

        #endregion
    }
}