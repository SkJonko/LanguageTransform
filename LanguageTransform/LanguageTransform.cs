using System.Collections.Generic;

namespace LanguageTransform
{
    /// <summary>
    /// 
    /// </summary>
    public class LanguageTransform
    {
        //
        // When we upgrade it in newer version we must use the  Frozen Set
        //
        // .ΝΕΤ 8,9 
        // .ToFrozenSet();
        // 
        //
        private static readonly IDictionary<string, string> binocularWords = new Dictionary<string, string>()
        {
            {"Υγ", "Vg"},
            {"υγ", "vg"},
            {"αι", "ai" },
            {"αί", "ai"},
            {"οι", "oi"},
            {"οί", "oi"},
            {"ου", "ou"},
            {"ού", "ou"},
            {"ει", "ei"},
            {"εί", "ei"},
            {"ντ", "nt"},
            {"τσ", "ts"},
            {"τζ", "tz"},
            {"γγ", "ng"},
            {"γκ", "gk"},
            {"γχ", "nch"},
            {"γξ", "nx"},
            {"αυ", "af"},
            {"αύ", "af"},
            {"εύ", "ef"},
            {"ευ", "ef"},
            {"ηυ", "if"},
            {"ηύ", "if"},
            {"Εύ", "Ef"},
            {"Ευ", "Ef"},
            {"Αύ", "Af"},
            {"Αυ", "Af"},
            {"Αι", "Ai"},
            {"Αί", "Ai"},
            {"Οι", "Oi"},
            {"Οί", "Oi"},
            {"Ου", "Ou"},
            {"Ού", "Ou"},
            {"Ει", "Ei"},
            {"Εί", "Ei"},
            {"Ντ", "Nt"},
            {"Τσ", "Ts"},
            {"Τζ", "Tz"},
            {"Γγ", "Ng"},
            {"Γκ", "Gk"},
            {"Γχ", "Nch"},
            {"Γξ", "Nx"},
            {"Φρ", "Fr"},
            {"φρ", "fr"}
        };

        private static readonly IDictionary<string, string> Vocabulary = new Dictionary<string, string>()
        {
            {"Α", "A" },
            {"Ά", "A"},
            {"Β", "V"},
            {"Γ", "G"},
            {"Δ", "D"},
            {"Ε", "E"},
            {"Έ", "E"},
            {"Ζ", "Z"},
            {"Η", "I"},
            {"Ή", "I"},
            {"Θ", "Th"},
            {"Ι", "I"},
            {"Ί", "I"},
            {"Ϊ", "I"},
            {"Κ", "K"},
            {"Λ", "L"},
            {"Μ", "M"},
            {"Ν", "N"},
            {"Ξ", "X"},
            {"Ο", "O"},
            {"Ό", "O"},
            {"Π", "P"},
            {"Ρ", "R"},
            {"Σ", "S"},
            {"Τ", "T"},
            {"Υ", "Y"},
            {"Ύ", "Y"},
            {"Ϋ", "Y"},
            {"Φ", "F"},
            {"Χ", "Ch"},
            {"Ψ", "Ps"},
            {"Ω", "O"},
            {"Ώ", "O"},
            {"α", "a" },
            {"ά", "a"},
            {"β", "v"},
            {"γ", "g"},
            {"δ", "d"},
            {"ε", "e"},
            {"έ", "e"},
            {"ζ", "z"},
            {"η", "i"},
            {"ή", "i"},
            {"θ", "th"},
            {"ι", "i"},
            {"ί", "i"},
            {"ϊ", "i"},
            {"ΐ", "i"},
            {"κ", "k"},
            {"λ", "l"},
            {"μ", "m"},
            {"ν", "n"},
            {"ξ", "x"},
            {"ο", "o"},
            {"ό", "o"},
            {"π", "p"},
            {"ρ", "r"},
            {"σ", "s"},
            {"ς", "s"},
            {"τ", "t"},
            {"υ", "y"},
            {"ύ", "y"},
            {"ϋ", "y"},
            {"ΰ", "y"},
            {"φ", "f"},
            {"χ", "ch"},
            {"ψ", "ps"},
            {"ω", "o"},
            {"ώ", "o"}
        };

        private static readonly char[] afefifWords = { 'g', 'G', 'a', 'A', 'i', 'I', 'e', 'E', 'r', 'R', 'o', 'O', 'd', 'D', 'l', 'L', 'z', 'Z', 'v', 'V', 'n', 'N', 'm', 'M' };


        /// <summary>
        /// Method to convert string from Greeklish To Greek based on ELOT 743
        /// </summary>
        /// <param name="source"></param>
        /// <param name="firstLetterUpper">If you want the first letter in Upper Case you must pass the value as true</param>
        /// <returns></returns>
        public static string GreekToGreeklish(string source, bool firstLetterUpper = false) =>
            TransformGreekToGreeklishFunctionality(source, firstLetterUpper);

        #region Private Methods

        private static string TransformGreekToGreeklishFunctionality(string stringSource, bool firstLetterUpper)
        {
            string source = stringSource.ToLower();

            foreach (KeyValuePair<string, string> pair in binocularWords)
            {
                source = source.Replace(pair.Key, pair.Value);
            }
            foreach (KeyValuePair<string, string> pair in Vocabulary)
            {
                source = source.Replace(pair.Key, pair.Value);
            }

            #region Replace the Last characters of mp -> b

            if (source[^2..] == "mp")
                source = source.Remove(source.Length - 2) + "b";

            #endregion Replace the Last characters of mp -> b

            #region Replace the First character mp -> b

            if (source[..2] == "mp")
                source = "b" + source[2..];

            #endregion Replace the First character mp -> b

            #region Comment Out

            //#region Replace and switch af/av
            //char[] sourceToCharacter = source.ToCharArray();
            //if (source.Contains("af") || source.Contains("Af"))
            //{
            //    i = source.IndexOf("af");

            //    while (i != -1)
            //    {
            //        if (i + 2 != sourceToCharacter.Length)
            //        {
            //            //searching in character array

            //            if (afefifWords.Contains(sourceToCharacter[i + 2]))
            //            {
            //                source = source.Remove(i, 2).Insert(i, "av");
            //            }

            //            i = source.IndexOf("af");

            //        }
            //    }
            //}

            //#endregion Replace and switch af/av

            //#region Replace and switch with ef/ev

            //if (source.Contains("ef") || source.Contains("Ef"))
            //{
            //    i = source.IndexOf("ef");

            //    while (i != -1)
            //    {
            //        if (i + 2 != sourceToCharacter.Length)
            //        {
            //            //searching in character array

            //            if (afefifWords.Contains(sourceToCharacter[i + 2]))
            //            {
            //                source = source.Remove(i, 2).Insert(i, "ev");
            //            }

            //            i = source.IndexOf("ef");

            //        }
            //    }
            //}

            //#endregion Replace and switch with ef/ev

            //#region Replace and switch with if/iv

            //if (source.Contains("if") || source.Contains("If"))
            //{
            //    i = source.IndexOf("if");

            //    while (i != -1)
            //    {
            //        if (i + 2 != sourceToCharacter.Length)
            //        {
            //            //searching in character array

            //            if (afefifWords.Contains(sourceToCharacter[i + 2]))
            //            {
            //                source = source.Remove(i, 2).Insert(i, "iv");
            //            }

            //            i = source.IndexOf("if");

            //        }
            //    }
            //}

            //#endregion Replace and switch with if/iv

            #endregion

            if (firstLetterUpper)
                //Do the First letter in Uppercase and return the data 
                source = char.ToUpper(source[0]) + source[1..];

            return source;
        }

        #endregion Private Methods

    }
}