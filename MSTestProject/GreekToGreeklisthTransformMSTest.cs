namespace MSTestProject
{
    [TestClass]
    public class GreekToGreeklisthTransformMSTest
    {

        #region Success Statements

        [TestMethod]
        public void AntonisUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Αντώνης", true);

            //Assert
            Assert.AreEqual(expected, "Antonis");
        }

        [TestMethod]
        public void BampibUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Μπάμπημπ", true);

            //Assert
            Assert.AreEqual(expected, "Bampib");
        }

        [TestMethod]
        public void MarilizaUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Μαριλιζα", true);

            //Assert
            Assert.AreEqual(expected, "Mariliza");
        }

        [TestMethod]
        public void KostasUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Κώστας", true);

            //Assert
            Assert.AreEqual(expected, "Kostas");
        }

        [TestMethod]
        public void AfroxylanthiUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Αφροξυλάνθη", true);

            //Assert
            Assert.AreEqual(expected, "Afroxylanthi");
        }

        [TestMethod]
        public void IfigeneiaUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Ιφιγένεια", true);

            //Assert
            Assert.AreEqual(expected, "Ifigeneia");
        }

        [TestMethod]
        public void EvgeneiosUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Ευγένειος", true);

            //Assert
            Assert.AreEqual(expected, "Evgeneios");
        }

        [TestMethod]
        public void EfeteioUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Εφετείο", true);

            //Assert
            Assert.AreEqual(expected, "Efeteio");
        }

        [TestMethod]
        public void OgkolithosUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("ογκόλιθοσ", true);

            //Assert
            Assert.AreEqual(expected, "Ogkolithos");
        }

        [TestMethod]
        public void AfganistanUpperCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Αφγανιστάν", true);

            //Assert
            Assert.AreEqual(expected, "Afganistan");
        }

        #endregion


        #region False Statements

        [TestMethod]
        public void AntonisLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Αντώνης");

            //Assert
            Assert.IsFalse(expected == "Antonis");
        }

        [TestMethod]
        public void BampibLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Μπάμπημπ");

            //Assert
            Assert.IsFalse(expected == "Bampib");
        }

        [TestMethod]
        public void MarilizaLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Μαριλιζα");

            //Assert
            Assert.IsFalse(expected == "Mariliza");
        }

        [TestMethod]
        public void KostasLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Κώστας");

            //Assert
            Assert.IsFalse(expected == "Kostas");
        }

        [TestMethod]
        public void AfroxylanthiLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Αφροξυλάνθη");

            //Assert
            Assert.IsFalse(expected == "Afroxylanthi");
        }

        [TestMethod]
        public void IfigeneiaLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Ιφιγένεια");

            //Assert
            Assert.IsFalse(expected == "Ifigeneia");
        }

        [TestMethod]
        public void EvgeneiosLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Ευγένειος");

            //Assert
            Assert.IsFalse(expected == "Evgeneios");
        }

        [TestMethod]
        public void EfeteioLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Εφετείο");

            //Assert
            Assert.IsFalse(expected == "Efeteio");
        }

        [TestMethod]
        public void OgkolithosLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("ογκόλιθοσ");

            //Assert
            Assert.IsFalse(expected == "Ogkolithos");
        }

        [TestMethod]
        public void AfganistanLowerCaseFirstLetter()
        {
            var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Αφγανιστάν");

            //Assert
            Assert.IsFalse(expected == "Afganistan");
        }

        #endregion
    }
}