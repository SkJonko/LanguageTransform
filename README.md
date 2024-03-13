# Language Transformation

<details>
    <summary>Version</summary>

# [1.0.0] - 13/03/2024

**Features**

* Add functionality to Transform Greeklish to Greek. 

</details>

# LanguageTransform

This static service is used to implement the functionality of transformation from each language.

## GreekToGreeklish
This function Returns you the Greek string of Greeklish value.

```
_GreekToGreeklish_(string source, bool firstLetterUpper)
```

**Explanation of Parameters**

- source = The source string that you want to convert.
- firstLetterUpper = [NULL] The boolean that indicates if you want the first letter in Upper Case.

**Example**

```
var expected = LanguageTransform.LanguageTransform.GreekToGreeklish("Αντώνης", true);

//Assert
Assert.AreEqual(expected, "Antonis");
```
