interface IBasicAlgorithmExercises
{
    //1. Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum. 
    //Sample Input:
    //1, 2
    //3, 2
    //2, 2
    //Expected Output:
    //3
    //5
    //12   
    void Exercise1();

    //2. Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference. 
    //Sample Input:
    //53
    //30
    //51
    //Expected Output:
    //6
    //21
    //0
    void Exercise2();

    //3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30. 
    //Sample Input:
    //30, 0
    //25, 5
    //20, 30
    //20, 25
    //Expected Output:
    //True
    //True
    //True
    //False
    void Exercise3();

    //4. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200. 
    //Sample Input:
    //103
    //90
    //89
    //Expected Output:
    //True
    //True
    //False
    void Exercise4();

    //5. Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged. 
    //Sample Input:
    //"if else"
    //"else"
    //Expected Output:
    //if else
    //if else
    void Exercise5();

    //6. Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0.. string length -1 inclusive. 
    //Sample Input:
    //"Python", 1
    //"Python", o
    //"Python", 4
    //Expected Output:
    //Pthon
    //ython
    //Pythn
    void Exercise6();

    //7. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string. 
    //Sample Input:
    //"abcd"
    //"a"
    //"xy"
    //Expected Output:
    //dbca
    //a
    //yx
    void Exercise7();

    //8. Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string. 
    //Sample Input:
    //"C Sharp"
    //"JS"
    //"a"
    //Expected Output:
    //C C C C 
    //JSJSJSJS
    //a
    void Exercise8();

    //9. Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more. 
    //Sample Input:
    //"Red"
    //"Green"
    //"1"
    //Expected Output:
    //dRedd
    //nGreenn
    //111
    void Exercise9();

    //10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7. 
    //Sample Input:
    //3
    //14
    //12
    //37
    //Expected Output:
    //True
    //True
    //True
    //False
    void Exercise10();

    //11. Write a C# Sharp program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there. 
    //Sample Input:
    //"Python"
    //"JS"
    //"Code"
    //Expected Output:
    //PytPythonPyt
    //JSJSJS
    //CodCodeCod
    void Exercise11();

    //12. Write a C# Sharp program to check if a given string starts with 'C#' or not. 
    //Sample Input:
    //"C# Sharp"
    //"C#"
    //"C++"
    //Expected Output:
    //True
    //True
    //False
    void Exercise12();

    //13. Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100. 
    //Sample Input:
    //120, -1
    //-1, 120
    //2, 120
    //Expected Output:
    //True
    //True
    //False
    void Exercise13();

    //14. Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive. 
    //Sample Input:
    //100, 199
    //250, 300
    //105, 190
    //Expected Output:
    //True
    //False
    //True
    void Exercise14();

    //15. Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. Return true if 1 or more of them are in the said range otherwise false. 
    //Sample Input:
    //11, 20, 12
    //30, 30, 17
    //25, 35, 50
    //15, 12, 8
    //Expected Output:
    //True
    //True
    //True
    //False
    void Exercise15();

    //16. Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. Return true if 1 or other is in the said range otherwise false. 
    //Sample Input:
    //20, 84
    //14, 50
    //11, 45
    //25, 40
    //Expected Output:
    //True
    //True
    //True
    //False
    void Exercise16();

    //17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. If it appears return a string without 'yt' otherwise return the original string. 
    //Sample Input:
    //"Python"
    //"ytade"
    //"jsues"
    //Expected Output:
    //Phon
    //ytade
    //jsues
    void Exercise17();

    //18. Write a C# Sharp program to check the largest number among three given integers. 
    //Sample Input:
    //1,2,3
    //1,3,2
    //1,1,1
    //1,2,2
    //Expected Output:
    //3
    //3
    //1
    //2
    void Exercise18();

    //19. Write a C# Sharp program to check which number nearest to the value 100 among two given integers. Return 0 if the two numbers are equal. 
    //Sample Input:
    //78, 95
    //95, 95
    //99, 70
    //Expected Output:
    //95
    //0
    //99
    void Exercise19();

    //20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive. 
    //Sample Input:
    //78, 95
    //25, 35
    //40, 50
    //55, 60
    //Expected Output:
    //False
    //False
    //True
    //True
    void Exercise20();

    //21. Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive, or return 0 if neither is in that range. 
    //Sample Input:
    //78, 95
    //20, 30
    //21, 25
    //28, 28
    //Expected Output:
    //0
    //30
    //25
    //28
    void Exercise21();

    //22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character. 
    //Sample Input:
    //"frizz"
    //"zane"
    //"Zazz"
    //"false"
    //Expected Output:
    //True
    //False
    //True
    //False
    void Exercise22();

    //23. Write a C# Sharp program to check if two given non-negative integers have the same last digit. 
    //Sample Input:
    //123, 456
    //12, 512
    //7, 87
    //12, 45
    //Expected Output:
    //False
    //True
    //True
    //False
    void Exercise23();

    //24. Write a C# Sharp program to convert the last 3 characters of a given string in upper case. If the length of the string has less than 3 then uppercase all the characters. 
    //Sample Input:
    //"Python"
    //"Javascript"
    //"js"
    //"PHP"
    //Expected Output:
    //PytHON
    //JavascrIPT
    //JS
    //PHP
    void Exercise24();

    //25. Write a C# Sharp program to create a new string which is n (non-negative integer) copies of a given string. 
    //Sample Input:
    //"JS", 2
    //"JS", 3
    //"JS", 1
    //Expected Output:
    //JSJS
    //JSJSJS
    //JS
    void Exercise25();

    //26. Write a C# Sharp program to create a new string which is n (non-negative integer) copies of the the first 3 characters of a given string. 
    //If the length of the given string is less than 3 then return n copies of the string. 
    //Sample Input:
    //"Python", 2
    //"Python", 3
    //"JS", 3
    //Expected Output:
    //PytPyt
    //PytPytPyt
    //JSJSJS
    void Exercise26();

    //27. Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa". 
    //Sample Input:
    //"bbaaccaag"
    //"jjkiaaasew"
    //"JSaaakoiaa"
    //Expected Output:
    //2
    //2
    //3
    void Exercise27();

    //28. Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a". 
    //Sample Input:
    //"caabb"
    //"babaaba"
    //"aaaaa"
    //Expected Output:
    //True
    //False
    //True
    void Exercise28();

    //29. Write a C# Sharp program to create a new string made of every other character starting with the first from a given string. 
    //Sample Input:
    //"Python"
    //"PHP"
    //"JS"
    //Expected Output:
    //Pto
    //PP
    //J
    void Exercise29();

    //30. Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd". 
    //Sample Input:
    //"abcd"
    //"abc"
    //"a"
    //Expected Output:
    //aababcabcd
    //aababc
    //a
    void Exercise30();

    //31. Write a C# Sharp program to count a substring of length 2 appears in a given string and also as the last 2 characters of the string. Do not count the end substring. 
    //Sample Input:
    //"abcdsab"
    //"abcdabab"
    //"abcabdabab"
    //"abcabd"
    //Expected Output:
    //1
    //2
    //3
    //0
    void Exercise31();

    //32. Write a C# Sharp program to check a specified number is present in a given array of integers. 
    //Sample Input:
    //{1,2,9,3}, 3
    //{1,2,2,3}, 2
    //{1,2,2,3}, 9
    //Expected Output:
    //True
    //True
    //False
    void Exercise32();

    //33. Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element. 
    //Sample Input:
    //{1,2,9,3}, 3
    //{1,2,3,4,5,6}, 2
    //{1,2,2,3}, 9
    //Expected Output:
    //True
    //True
    //False
    void Exercise33();

    //34. Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere. 
    //Sample Input:
    //{1,1,2,3,1}
    //{1,1,2,4,1}
    //{1,1,2,1,2,3}
    //Expected Output:
    //True
    //False
    //True
    void Exercise34();

    //35. Write a C# Sharp program to compare two given strings and return the number of the positions where they contain the same length 2 substring. 
    //Sample Input:
    //"abcdefgh", "abijsklm"
    //"abcde", "osuefrcd"
    //"pqrstuvwx", "pqkdiewx"
    //Expected Output:
    //1
    //1
    //2
    void Exercise35();

    //36. Write a C# Sharp program to create a new string from a give string where a specified character have been removed except starting and ending position of the given string. 
    //Sample Input:
    //"xxHxix", "x"
    //"abxdddca", "a"
    //"xabjbhtrb", "b"
    //Expected Output:
    //xHix
    //abxdddca
    //xajhtrb
    void Exercise36();

    //37. Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string. 
    //Sample Input:
    //"Python"
    //"JavaScript"
    //"HTML"
    //Expected Output:
    //Pyon
    //JaScpt
    //HT
    void Exercise37();

    //38. Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers. Also count the situation where the second 5 is actually a 6. 
    //Sample Input:
    //{ 5, 5, 2 }
    //{ 5, 5, 2, 5, 5 }
    //{ 5, 6, 2, 9}
    //Expected Output:
    //1
    //2
    //1
    void Exercise38();

    //39. Write a C# Sharp program to check if a triple is presents in an array of integers or not. If a value appears three times in a row in an array it is called a triple. 
    //Sample Input:
    //{ 1, 1, 2, 2, 1 }
    //{ 1, 1, 2, 1, 2, 3 }
    //{ 1, 1, 1, 2, 2, 2, 1 }
    //Expected Output:
    //False
    //False
    //True
    void Exercise39();

    //40. Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30. 
    //Sample Input:
    //12, 17
    //2, 17
    //22, 17
    //20, 0
    //Expected Output:
    //29
    //30
    //39
    //30
    void Exercise40();

    //41. Write a C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5. 
    //Sample Input:
    //5, 4
    //4, 3
    //1, 4
    //Expected Output:
    //True
    //False
    //True
    void Exercise41();

    //42. Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13. 
    //Sample Input:
    //13
    //14
    //27
    //41
    //Expected Output:
    //True
    //True
    //True
    //False
    void Exercise42();

    //43. Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both. 
    //Sample Input:
    //3
    //7
    //21
    //Expected Output:
    //True
    //True
    //False
    void Exercise43();

    //44. Write a C# Sharp program to check if a given number is within 2 of a multiple of 10. 
    //Sample Input:
    //3
    //7
    //8
    //21
    //Expected Output:
    //False
    //False
    //True
    //True
    void Exercise44();

    //45. Write a C# Sharp program to compute the sum of the two given integers. If one of the given integer value is in the range 10..20 inclusive return 18. 
    //Sample Input:
    //3, 7
    //10, 11
    //10, 20
    //21, 220
    //Expected Output:
    //10
    //18
    //18
    //241
    void Exercise45();

    //46. Write a C# Sharp program to check whether a given string starts with "F" or ends with "B". 
    //If the string starts with "F" return "Fizz" and return "Buzz" if it ends with "B" If the string starts with "F" and ends with "B" return "FizzBuzz". 
    //In other cases return the original string. 
    //Sample Input:
    //"FizzBuzz"
    //"Fizz"
    //"Buzz"
    //"Founder"
    //Expected Output:
    //Fizz
    //Fizz
    //Buzz
    //Fizz
    void Exercise46();

    //47. Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers. 
    //Sample Input:
    //1, 2, 3
    //4, 5, 6
    //-1, 1, 0
    //Expected Output:
    //True
    //False
    //True
    void Exercise47();

    //48. Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z. 
    //Sample Input:
    //1, 2, 3
    //4, 5, 6
    //-1, 1, 0
    //Expected Output:
    //True
    //True
    //False
    void Exercise48();

    //49. Write a C# Sharp program to check if three given numbers are in strict increasing order, such as 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8.
    //However,if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7. 
    //Sample Input:
    //1, 2, 3, false
    //1, 2, 3, true
    //10, 2, 30, false
    //10, 10, 30, true
    //Expected Output:
    //True
    //True
    //False
    //True
    void Exercise49();

    //50. Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit. 
    //Sample Input:
    //11, 21, 31
    //11, 22, 31
    //11, 22, 33
    //Expected Output:
    //True
    //True
    //False
    void Exercise50();

    //51. Write a C# Sharp program to check three given integers and return true if one of them is 20 or more less than one of the others. 
    //Sample Input:
    //11, 21, 31
    //11, 22, 31
    //10, 20, 15
    //Expected Output:
    //True
    //True
    //False
    void Exercise51();

    //52. Write a C# Sharp program to find the larger from two given integers. 
    //However if the two integers have the same remainder when divided by 7, then the return the smaller integer. If the two integers are the same, return 0. 
    //Sample Input:
    //11, 21
    //11, 20
    //10, 10
    //Expected Output:
    //21
    //20
    //0
    void Exercise52();

    //53. Write a C# Sharp program to check two given integers, each in the range 10..99. Return true if a digit appears in both numbers, such as the 3 in 13 and 33. 
    //Sample Input:
    //11, 21
    //11, 20
    //10, 10
    //Expected Output:
    //True
    //False
    //True
    void Exercise53();

    //54. Write a C# Sharp program to compute the sum of two given non-negative integers x and y as long as the sum has the same number of digits as x. 
    //If the sum has more digits than x then return x without y. 
    //Sample Input:
    //4, 5
    //7, 4
    //10, 10
    //Expected Output:
    //9
    //7
    //20
    void Exercise54();

    //55. Write a C# Sharp program to compute the sum of three given integers. If the two values are same return the third value. 
    //Sample Input:
    //4, 5, 7
    //7, 4, 12
    //10, 10, 12
    //12, 12, 18
    //Expected Output:
    //16
    //23
    //12
    //18
    void Exercise55();

    //56. Write a C# Sharp program to compute the sum of the three integers. If one of the values is 13 then do not count it and its right towards the sum. 
    //Sample Input:
    //4, 5, 7
    //7, 4, 12
    //10, 13, 12
    //13, 12, 18
    //Expected Output:
    //16
    //23
    //10
    //0
    void Exercise56();

    //57. Write a C# Sharp program to compute the sum of the three given integers. 
    // However, if any of the values is in the range 10..20 inclusive then that value counts as 0, except 13 and 17. 
    //Sample Input:
    //4, 5, 7
    //7, 4, 12
    //10, 13, 12
    //17, 12, 18
    //Expected Output:
    //16
    //11
    //13
    //17
    void Exercise57();

    //58. Write a C# Sharp program to check two given integers and return the value whichever value is nearest to 13 without going over.
    //Return 0 if both numbers go over. 
    //Sample Input:
    //4, 5
    //7, 12
    //10, 13
    //17, 33
    //Expected Output:
    //5
    //12
    //13
    //0
    void Exercise58();

    //59. Write a C# Sharp program to check three given integers (small, medium and large) and
    //return true if the difference between small and medium and the difference between medium and large is same. 
    //Sample Input:
    //4, 5, 6
    //7, 12, 13
    //-1, 0, 1
    //Expected Output:
    //True
    //False
    //True
    void Exercise59();

    //60. Write a C# Sharp program to create a new string using two given strings s1, s2, the format of the new string will be s1s2s2s1. 
    //Sample Input:
    //"Hi", "Hello"
    //"whats", "app"
    //Expected Output:
    //HiHelloHelloHi
    //whatsappappwhats
    void Exercise60();

    //61. Write a C# Sharp program to insert a given string into middle of the another given string of length 4. 
    //Sample Input:
    //"[[]]","Hello"
    //"(())", "Hi"
    //Expected Output:
    //[[Hello]]
    //((Hi))
    void Exercise61();

    //62. Write a C# Sharp program to create a new string using three copies of the last two character of a given string of length atleast two. 
    //Sample Input:
    //"Hello"
    //"Hi"
    //Expected Output:
    //lololo
    //HiHiHi
    void Exercise62();

    //63. Write a C# Sharp program to create a new string using first two characters of a given string.
    // If the string length is less than 2 then return the original string.. 
    //Sample Input:
    //"Hello"
    //"Hi"
    //"H"
    //" "
    //Expected Output:
    //He
    //Hi
    //H
    void Exercise63();

    //64. Write a C# Sharp program to create a new string of the first half of a given string of even length. 
    //Sample Input:
    //"Hello"
    //"Hi"
    //Expected Output:
    //He
    //H
    void Exercise64();

    //65. Write a C# Sharp program to create a new string without the first and last character of a given string of length atleast two. 
    //Sample Input:
    //"Hello"
    //"Hi"
    //"Python"
    //Expected Output:
    //ell
    //ytho
    void Exercise65();

    //66. Write a C# Sharp program to create a new string from two given string one is shorter and another is longer. 
    //The format of the new string will be long string + short string + long string. 
    //Sample Input:
    //"Hello", "Hi"
    //"JS", "Python"
    //Expected Output:
    //HelloHiHello
    //PythonJSPython
    void Exercise66();

    //67. Write a C# Sharp program to concat two given string of length atleast 1, after removing their first character. 
    //Sample Input:
    //"Hello", "Hi"
    //"JS", "Python"
    //Expected Output:
    //elloi
    //Sython
    void Exercise67();

    //68. Write a C# Sharp program to move the first two characters to the end of a given string of length at least two. 
    //Sample Input:
    //"Hello"
    //"JS"
    //Expected Output:
    //lloHe
    //JS
    void Exercise68();

    //69. Write a C# Sharp program to move the last two characters to the start of a given string of length at least two. 
    //Sample Input:
    //"Hello"
    //"JS"
    //Expected Output:
    //loHel
    //JS
    void Exercise69();

    //70. Write a C# Sharp program to create a new string without the first and last character of a given string of any length. 
    //Sample Input:
    //"Hello"
    //"JS"
    //""
    //Expected Output:
    //ell
    void Exercise70();

    //71. Write a C# Sharp program to create a new string using the two middle characters of a given string of even length (at least 2).
    //Sample Input:
    //"Hell"
    //"JS"
    //Expected Output:
    //el
    //JS
    void Exercise71();

    //72. Write a C# Sharp program to check if a given string ends with "on". 
    //Sample Input:
    //"Hello"
    //"Python"
    //"on"
    //"o"
    //Expected Output:
    //False
    //True
    //True
    //False
    void Exercise72();

    //73. Write a C# Sharp program to create a new string using the first and last n characters from a given string of length at least n. 
    //Sample Input:
    //"Hello", 1
    //"Python", 2
    //"on", 1
    //"o", 1
    //Expected Output:
    //Ho
    //Pyon
    //on
    //oo
    void Exercise73();

    //74. Write a C# Sharp program to create a new string of length 2 starting at the given index of a given string. 
    //Sample Input:
    //"Hello", 1
    //"Python", 2
    //"on", 1
    //Expected Output:
    //el
    //th
    //on
    void Exercise74();

    //75. Write a C# Sharp program to create a new string taking 3 characters from the middle of a given string at least 3. 
    //Sample Input:
    //"Hello"
    //"Python"
    //"abc"
    //Expected Output:
    //ell
    //yth
    //abc
    void Exercise75();

    //76. Write a C# Sharp program to create a new string of length 2, using first two characters of a given string. 
    //If the given string length is less than 2 use '#' as missing characters. 
    //Sample Input:
    //"Hello"
    //"Python"
    //"a"
    //""
    //Expected Output:
    //He
    //Py
    //a#
    //##
    void Exercise76();

    //77. Write a C# Sharp program to create a new string taking the first character from a given string and the last character from another given string. 
    //If the length of any given string is 0, use '#' as its missing character. 
    //Sample Input:
    //"Hello", "Hi"
    //"Python", "PHP"
    //"JS", "JS"
    //"Csharp", ""
    //Expected Output:
    //Hi
    //PP
    //JS
    //C#
    void Exercise77();

    //78. Write a C# Sharp program to concat two given strings (lowercase). If there are any double character in new string then omit one character. 
    //Sample Input:
    //"abc", "cat"
    //"python", "php"
    //"php", "php"
    //Expected Output:
    //abcat
    //pythonphp
    //phphp
    void Exercise78();

    //79. Write a C# Sharp program to create a new string from a given string after swapping last two characters. 
    //Sample Input:
    //"Hello"
    //"Python"
    //"PHP"
    //"JS"
    //"C"
    //Expected Output:
    //Helol
    //Pythno
    //PPH
    //SJ
    //C
    void Exercise79();

    //80. Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'.
    // If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz' otherwise return the empty string. 
    //Sample Input:
    //"abc"
    //"abcdef"
    //"C"
    //"xyz"
    //"xyzsder"
    //Expected Output:
    //abc
    //abc
    //xyz
    //xyz
    void Exercise80();

    //81. Write a C# Sharp program to check whether the first two characters and last two characters of a given string are same. 
    //Sample Input:
    //"abab"
    //"abcdef"
    //"xyzsderxy"
    //Expected Output:
    //True
    //False
    //True
    void Exercise81();

    //82. Write a C# Sharp program to concat two given strings. If the given strings have different length remove the characters from the longer string. 
    //Sample Input:
    //"abc", "abcd"
    //"Python", "Python"
    //"JS", "Python"
    //Expected Output:
    //abcbcd
    //PythonPython
    //JSon
    void Exercise82();

    //83. Write a C# Sharp program to create a new string using 3 copies of the first 2 characters of a given string. 
    //If the length of the given string is less than 2 use the whole string. 
    //Sample Input:
    //"abc"
    //"Python"
    //"J"
    //Expected Output:
    //ababab
    //PyPyPy
    //JJJ
    void Exercise83();

    //84. Write a C# Sharp program to create a new string from a given string.
    //If the two characters of the given string from its beginning and end are same return  the given string without the first two characters otherwise return the original string. 
    //Sample Input:
    //"abcab"
    //"Python"
    //Expected Output:
    //cab
    //Python
    void Exercise84();

    //85. Write a C# Sharp program to create a new string from a given string without the first two characters. 
    // Keep the first character if it is "p" and keep the second character if it is "y". 
    //Sample Input:
    //"abcab"
    //"python"
    //"press"
    //"jython"
    //Expected Output:
    //cab
    //python
    //pess
    //ython
    void Exercise85();

    //86. Write a C# Sharp program to create a new string from a given string without the first and last character 
    //if the first or last characters are 'a' otherwise return the original given string. 
    //Sample Input:
    //"abcab"
    //"python"
    //"abcda"
    //"jython"
    //Expected Output:
    //bcab
    //python
    //bcd
    //jython
    void Exercise86();

    //87. Write a C# Sharp program to create a new string from a given string. 
    //If the first or first two characters is 'a', return the string without those 'a' characters otherwise return the original given string.
    //Sample Input:
    //"abcab"
    //"python"
    //"aacda"
    //"jython"
    //Expected Output:
    //bcab
    //python
    //cda
    //jython
    void Exercise87();

    //88. Write a C# Sharp program to check a given array of integers of length 1 or more and return true if 10 appears as either first or last element in the given array. 
    //Sample Input:
    //{ 10, 20, 40, 50 }
    //{ 5, 20, 40, 10 }
    //{ 10, 20, 40, 10 }
    //{ 12, 24, 35, 55 }
    //Expected Output:
    //True
    //True
    //True
    //False
    void Exercise88();

    //89. Write a C# Sharp program to check a given array of integers of length 1 or more and return true if the first element and the last element are equal in the given array. 
    //Sample Input:
    //{ 10, 20, 40, 50 }
    //{ 10, 20, 40, 10 }
    //{ 12, 24, 35, 55 }
    //Expected Output:
    //False
    //True
    //False
    void Exercise89();

    //90. Write a C# Sharp program to check two given arrays of integers of length 1 or more and return true if they have the same first element or they have the same last element. 
    //Sample Input:
    //{ 10, 20, 40, 50 }, { 10, 20, 40, 50 }
    //{ 10, 20, 40, 50 }, { 10, 20, 40, 5 }
    //{ 10, 20, 40, 50 }, { 1, 20, 40, 5 }
    //Expected Output:
    //True
    //True
    //False
    void Exercise90();

    //91. Write a C# Sharp program to compute the sum of the elements of an given array of integers. 
    //Sample Input:
    //{ 10, 20, 30, 40, 50 }
    //{ 10, 20, -30, -40, 50 }
    //Expected Output:
    //150
    //10
    void Exercise91();

    //92. Write a C# Sharp program to rotate the elements of a given array of integers (length 4 ) in left direction and return the new array. 
    //Sample Input:
    //{ 10, 20, -30, -40 }
    //Expected Output:
    //Rotated array: 20 -30 -40 10
    void Exercise92();

    //93. Write a C# Sharp program to reverse a given array of integers and length 5. 
    //Sample Input:
    //{ 10, 20, -30, -40, 50 }
    //Expected Output:
    //Reverse array: 50 -40 -30 20 10
    void Exercise93();

    //94. Write a C# Sharp program to find out the maximum element between the first or last element in a given array of integers ( length 4), 
    // replace all elements with maximum element. 
    //Sample Input:
    //{ 10, 20, -30, -40 }
    //Expected Output:
    //New array: 20 20 20 20
    void Exercise94();

    //95. Write a C# Sharp program to create a new array containing the middle elements from the two given arrays of integers, each length 5. 
    //Sample Input:
    //{ 10, 20, -30, -40, 30 }, { 10, 20, 30, 40, 30 }
    //Expected Output:
    //New array: -30 30
    void Exercise95();

    //96. Write a C# Sharp program to create a new array taking  the first and last elements of a given array of integers and length 1 or more. 
    //Sample Input:
    //{ 10, 20, -30, -40, 30 }
    //Expected Output :
    //New array: 10 30
    void Exercise96();

    //97. Write a C# Sharp program to check if a given array of integers and length 2, contains 15 or 20. 
    //Sample Input:
    //{ 12, 20 }
    //{ 14, 15 }
    //{ 11, 21 }
    //Expected Output :
    //True
    //True
    //False
    void Exercise97();

    //98. Write a C# Sharp program to check if a given array of integers and length 2, does not contain 15 or 20. 
    //Sample Input:
    //{ 12, 20 }
    //{ 14, 15 }
    //{ 11, 21 }
    //Expected Output :
    //False
    //False
    //True
    void Exercise98();

    //99. Write a C# Sharp program to create a new array of integers and length 1 or more.
    //The length of the new array will be double length of the given array and all the elements are 1 except the first element which is equal to the given array. 
    //Sample Input:
    //{ 10, 20, -30, -40, 30 }
    //Expected Output :
    //New array: 10 0 0 0 0 0 0 0 0 0
    void Exercise99();

    //100. Write a C# Sharp program to check a given array of integers and return true if the array contains 10 or 20 twice. The length of the array will be 0, 1, or 2. 
    //Sample Input:
    //{ 12, 20 }
    //{ 20, 20 }
    //{ 10, 10 }
    //{ 10 }
    //Expected Output :
    //False
    //True
    //True
    //False
    void Exercise100();

    //101. Write a C# Sharp program to check a given array of integers, length 3 and create a new array. 
    //If there is a 5 in the given array immediately followed by a 7 then set 7 to 1. 
    //Sample Input:
    //{ 1, 5, 7 }
    //Expected Output :
    //Original array:  1, 5, 7
    //New array: 1 5 1
    void Exercise101();

    //102. Write a C# Sharp program to compute the sum of the two given arrays of integers, length 3 and find the array which has the largest sum. 
    //Sample Input:
    //{ 10, 20, -30 }, { 10, 20, 30 }
    //Expected Output :
    //Original array:  1, 5, 7
    //Larger array: 10 20 30
    void Exercise102();

    //103. Write a C# Sharp program to create an array taking two middle elements from a given array of integers of length even.
    //Sample Input:
    //{ 1, 5, 7, 9, 11, 13 }
    //Expected Output:
    //Original array: 1, 5, 7, 9, 11, 13
    //New array: 7 9
    void Exercise103();

    //104. Write a C# Sharp program to create a new array from two give array of integers, each length 3.
    //Sample Input:
    //{ 10, 20, 30 }, { 40, 50, 60 }
    //Expected Output :
    //Array 1: 10, 20, 30
    //Array 2: 40, 50, 60
    //New array: 10 20 30 40 50 60
    void Exercise104();

    //105. Write a C# Sharp program to create a new array swapping the first and last elements of a given array of integers and length will be least 1. 
    //Sample Input:
    //{ 1, 5, 7, 9, 11, 13 }
    //Expected Output :
    //Original array: 1, 5, 7, 9, 11, 13
    //After swapping first and last elements: 13 5 7 9 11 1
    void Exercise105();

    //106. Write a C# Sharp program to create a new array length 3 from a given array (length atleast 3) using the elements from the middle of the array. 
    //Sample Input:
    //{ 1, 5, 7, 9, 11, 13 }
    //Expected Output :
    //Original array: 1, 5, 7, 9, 11, 13
    //New array: 7 9 11
    void Exercise106();

    //107. Write a C# Sharp program to find the largest value from first, last, and middle elements of a given array of integers of odd length (atleast 1). 
    //Sample Input:
    //{1}
    //{1,2,9}
    //{1,2,9,3,3}
    //{1,2,3,4,5,6,7}
    //{1,2,2,3,7,8,9,10,6,5,4}
    //Expected Output :
    //1
    //9
    //9
    //7
    //8
    void Exercise107();

    //108. Write a C# Sharp program to create a new array taking the first two elements from a given array.
    //If the length of the given array is less than 2 then return the give array. 
    //Sample Input:
    //{ 1, 5, 7, 9, 11, 13 }
    //Expected Output :
    //New array: 1 5
    void Exercise108();

    //109. Write a C# Sharp program to count even number of elements in a given array of integers. 
    //Sample Input:
    //{ 1, 5, 7, 9, 10, 12 }
    //Expected Output :
    //Original array: 1, 5, 7, 9, 10, 12
    //2
    void Exercise109();

    //110. Write a C# Sharp program to compute the difference between the largest and smallest values in a given array of integers and length one or more. 
    //Sample Input:
    //{ 1, 5, 7, 9, 10, 12 }
    //Expected Output:
    //Original array: 1, 5, 7, 9, 10, 12 
    //Difference between the largest and smallest values: 
    //11
    void Exercise110();

    //111. Write a C# Sharp program to compute the sum of values in a given array of integers except the number 17. Return 0 if the given array has no integer. 
    //Sample Input:
    //{ 1, 5, 7, 9, 10, 17 }
    //Expected Output :
    //Original array: 1, 5, 7, 9, 10, 17
    //Sum of values in the array of integers except the number 17: 
    //32
    void Exercise111();

    //112. Write a C# Sharp program to compute the sum of the numbers in a given array except those numbers starting with 5 followed by atleast one 6.
    //Return 0 if the given array has no integer. 
    //Sample Input:
    //{ 5, 6, 1, 5, 6, 9, 10, 17, 5, 6 }
    //{ 5, 6, 1, 5, 6, 9, 10, 17 }
    //{ 1, 5, 6, 9, 10, 17, 5, 6 }
    //{ 1, 5, 9, 10, 17, 5, 6 }
    //{ 1, 5, 9, 10, 17, 5}
    //Expected Output :
    //Sum of the numbers of the said array except those numbers starting with 5 followed by atleast one 6: 
    //37
    //37
    //37
    //42
    //47
    void Exercise112();

    //113. Write a C# Sharp program to check if a given array of integers contains 5 next to a 5 somewhere. 
    //Sample Input:
    //{ 1, 5, 6, 9, 10, 17 }
    //{ 1, 5, 5, 9, 10, 17 }
    //{ 1, 5, 5, 9, 10, 17, 5, 5 }
    //Expected Output :
    //False
    //True
    //True
    void Exercise113();

    //114. Write a C# Sharp program to check whether a given array of integers contains 5's and 7's. 
    //Sample Input:
    //{ 1, 5, 6, 9, 10, 17 }
    //{ 1, 4, 7, 9, 10, 17 }
    //{ 1, 1, 2, 9, 10, 17}
    //Expected Output :
    //True
    //True
    //False
    void Exercise114();

    //115. Write a C# Sharp program to check if the sum of all 5' in the array exactly 15 in a given array of integers. 
    //Sample Input:
    //{ 1, 5, 6, 9, 10, 17 }
    //{ 1, 5, 5, 5, 10, 17 }
    //{ 1, 1, 5, 5, 5, 5}
    //Expected Output :
    //False
    //True
    //False
    void Exercise115();

    //116. Write a C# Sharp program to check if the number of 3's is greater than the number of 5's. 
    //Sample Input:
    //{ 1, 5, 6, 9, 3, 3 }
    //{ 1, 5, 5, 5, 10, 17 }
    //{ 1, 3, 3, 5, 5, 5}
    //Expected Output :
    //True
    //False
    //False
    void Exercise116();

    //117. Write a C# Sharp program to check if a given array of integers contains a 3 or a 5. 
    //Sample Input:
    //{ 5, 5, 5, 5, 5 }
    //{ 3, 3, 3, 3 }
    //{ 3, 3, 3, 5, 5, 5}
    //{ 1, 6, 8, 10}
    //Expected Output :
    //True
    //True
    //True
    //False
    void Exercise117();

    //118. Write a C# Sharp program to check if a given array of integers contains no 3 or a 5. 
    //Sample Input:
    //{ 5, 5, 5, 5, 5 }
    //{ 3, 3, 3, 3 }
    //{ 3, 3, 3, 5, 5, 5}
    //{ 1, 6, 8, 10}
    //Expected Output :
    //True
    //True
    //False
    //True
    void Exercise118();

    //119. Write a C# Sharp program to check if an array of integers contains a 3 next to a 3 or a 5 next to a 5 or both. 
    //Sample Input:
    //{ 5, 5, 5, 5, 5 }
    //{ 1, 2, 3, 4 }
    //{ 3, 3, 5, 5, 5, 5}
    //{ 1, 5, 5, 7, 8, 10}
    //Expected Output :
    //True
    //False
    //True
    //True
    void Exercise119();

    //120. Write a C# Sharp program to check a given array of integers and return true if the given array contains two 5's next to each other, 
    //or two  5 separated by one element. 
    //Sample Input:
    //{ 5, 5, 1, 5, 5 }
    //{ 1, 2, 3, 4 }
    //{ 3, 3, 5, 5, 5, 5}
    //{ 1, 5, 5, 7, 8, 10}
    //Expected Output :
    //True
    //False
    //True
    //True
    void Exercise120();

    //121. Write a C# Sharp program to check a given array of integers and return true if there is a 3 with a 5 somewhere later in the given array. 
    //Sample Input:
    //{ 3, 5, 1, 3, 7 }
    //{ 1, 2, 3, 4 }
    //{ 3, 3, 5, 5, 5, 5}
    //{ 2, 5, 5, 7, 8, 10}
    //Expected Output :
    //True
    //False
    //True
    //False
    void Exercise121();

    //122. Write a C# Sharp program to check a given array of integers and return true if the given array contains either 
    //2 even or 2 odd values all next to each other. 
    //Sample Input:
    //{ 3, 5, 1, 3, 7 }
    //{ 1, 2, 3, 4 }
    //{ 3, 3, 5, 5, 5, 5}
    //{ 2, 4, 5, 6}
    //Expected Output :
    //True
    //False
    //True
    //True
    void Exercise122();

    //123. Write a C# Sharp program to check a given array of integers and return true if the value 5 appears 5 times and 
    //there are no 5 next to each other. 
    //Sample Input:
    //{ 3, 5, 1, 5, 3, 5, 7, 5, 1, 5 }
    //{ 3, 5, 5, 5, 5, 5, 5}
    //{ 3, 5, 2, 5, 4, 5, 7, 5, 8, 5}
    //{ 2, 4, 5, 5, 5, 5}
    //Expected Output :
    //True
    //False
    //True
    //False
    void Exercise123();

    //124. Write a C# Sharp program to check a given array of integers and 
    //return true if every 5 that appears in the given array is next to another 5. 
    //Sample Input:
    //{ 3, 5, 5, 3, 7 }
    //{ 3, 5, 5, 4, 1, 5, 7}
    //{ 3, 5, 5, 5, 5, 5}
    //{ 2, 4, 5, 5, 6, 7, 5}
    //Expected Output :
    //True
    //False
    //True
    //False
    void Exercise124();

    //125. Write a C# Sharp program to check a given array of integers and 
    //return true if the specified number of same elements appears at the start and end of the given array. 
    //Sample Input:
    //{ 3, 7, 5, 5, 3, 7 }, 2
    //{ 3, 7, 5, 5, 3, 7 }, 3
    //{ 3, 7, 5, 5, 3, 7, 5 }, 3
    //Expected Output :
    //True
    //False
    //True
    void Exercise125();

    //126. Write a C# Sharp program to check a given array of integers and return true if the array contains three increasing adjacent numbers. 
    //Sample Input:
    //{ 1, 2, 3, 5, 3, 7 }
    //{ 3, 7, 5, 5, 3, 7 }
    //{ 3, 7, 5, 5, 6, 7, 5 }
    //Expected Output :
    //True
    //False
    //True
    void Exercise126();

    //127. Write a C# Sharp program to shift an element in left direction and return a new array. 
    //Sample Input:
    //{ 10, 20, -30, -40, 50 }
    //Expected Output :
    //New array: 20 -30 -40 50 10
    void Exercise127();

    //128. Write a C# Sharp program to create a new array taking the elements before the element value 5 from a given array of integers. 
    //Sample Input:
    //{ 1, 2, 3, 5, 7 }
    //Expected Output :
    //New array: 1 2 3
    void Exercise128();

    //129. Write a C# Sharp program to create a new array taking the elements after the element value 5 from a given array of integers. 
    //Sample Input:
    //{ 1, 2, 3, 5, 7, 9, 11 }
    //Expected Output :
    //New array: 7 9 11
    void Exercise129();

    //130. Write a C# Sharp program to create a new array from a given array of integers shifting all zeros to left direction. 
    //Sample Input:
    //{ 1, 2, 0, 3, 5, 7, 0, 9, 11 }
    //Expected Output :
    //New array: 0 0 1 3 5 7 2 9 11
    void Exercise130();

    //131. Write a C# Sharp program to create a new array after replacing all the values 5 with 0 shifting all zeros to right direction. 
    //Sample Input:
    //{ 1, 2, 5, 3, 5, 7, 5, 9, 11 }
    //Expected Output :
    //New array: 1 2 3 7 9 11 0 0 0
    void Exercise131();

    //132. Write a C# Sharp program to create new array from a given array of integers shifting all even numbers before all odd numbers. 
    //Sample Input:
    //{ 1, 2, 5, 3, 5, 4, 6, 9, 11 }
    //Expected Output :
    //New array: 2 4 6 3 5 1 5 9 11
    void Exercise132();

    //133. Write a C# Sharp program to check if the value of each element is equal or 
    //greater than the value of previous element of a given array of integers. 
    //Sample Input:
    //{ 5, 5, 1, 5, 5 }
    //{ 1, 2, 3, 4 }
    //{ 3, 3, 5, 5, 5, 5}
    //{ 1, 5, 5, 7, 8, 10}
    //Expected Output:
    //False
    //True
    //True
    //True
    void Exercise133();

    //134. Write a C# Sharp program to check a given array (length will be atleast 2) of 
    // integers and return true if there are two values 15, 15 next to each other. 
    //Sample Input:
    //{ 5, 5, 1, 15, 15 }
    //{ 15, 2, 3, 4, 15 }
    //{ 3, 3, 15, 15, 5, 5}
    //{ 1, 5, 15, 7, 8, 15}
    //Expected Output :
    //True
    //False
    //True
    //False
    void Exercise134();

    //135. Write a C# Sharp program to find the larger average value between the first 
    //and the second half of a given array of integers and minimum length is atleast 2. Assume that the second half begins at index (array length)/2. 
    //Sample Input:
    //{ 1, 2, 3, 4, 6, 8 }
    //{ 15, 2, 3, 4, 15, 11 }
    //Expected Output:
    //6
    //10
    void Exercise135();

    //136. Write a C# Sharp program to count the number of strings with given length in given array of strings. 
    //Sample Input:
    //{"a", "b", "bb", "c", "ccc" }, 1
    //Expected Output:
    //Number of Strings: 
    //3
    void Exercise136();

    //137. Write a C# Sharp program to create a new array using the first n strings from a given array of strings.
    //(n>=1 and <=length of the array). 
    //Sample Input:
    //{"a", "b", "bb", "c", "ccc" }, 3
    //Expected Output :
    //New array: a b bb
    void Exercise137();

    //138. Write a C# Sharp program to create a new array from a given array of strings  
    // using all the strings whose length are matched with given string length. 
    //Sample Input:
    //{"a", "aaa", "b", "bbb", "c", "ccc" }, 3
    //Expected Output :
    //New array: aaa bbb ccc
    void Exercise138();

    //139. Write a C# Sharp program to check a positive integer and return true if it contains a number 2. 
    //Sample Input:
    //123
    //13
    //222
    //Expected Output:
    //True
    //False
    //True
    void Exercise139();

    //140. Write a C# Sharp program to create a new array of given length using the odd numbers from a given array of positive integers. 
    //Sample Input:
    //{1,2,3,5,7,9,10},3
    //Expected Output:
    //New array: 1 3 5
    void Exercise140();

    //141. Write a C# Sharp program to create a new list from a given list of integers where each element is multiplied by 3. 
    //Sample Input:
    //{ 1, 2, 3 , 4 }
    //Expected Output :
    //New array: 3 6 9 12
    void Exercise141();

    //142. Write a C# Sharp program to create a new list from a given list of integers where each integer multiplied by itself three times. 
    //Sample Input:
    //{ 1, 2, 3 , 4 }
    //Expected Output:
    //New array: 1 8 27 64
    void Exercise142();

    //143. Write a C# Sharp program to create a new list from a given list of strings where each element has 
    //"#" added at the beginning and end position. 
    //Sample Input:
    //{ "1", "2", "3" , "4" }
    //Expected Output :
    //#1# #2# #3# #4#
    void Exercise143();

    //144. Write a C# Sharp program to create a new list from a given list of strings
    //where each element is replaced by 4 copies of the string concatenated together. 
    //Sample Input:
    //{ "1", "2", "3" , "4" }
    //Expected Output :
    //1111 2222 3333 4444
    void Exercise144();

    //145. Write a C# Sharp program to create a new list from a given list of integers 
    // where each integer value is added to 2 and the result value is multiplied by 5. 
    //Sample Input:
    //{ 1, 2, 3 , 4 }
    //Expected Output :
    //15 20 25 30
    void Exercise145();

    //146. Write a C# Sharp program to create a new list of the rightmost digits from a given list of positive integers. 
    //Sample Input:
    //{ 10 , 22, 35 , 41 }
    //Expected Output:
    //0 2 5 1
    void Exercise146();

    //147. Write a C# Sharp program to create a new list from a given list of strings where strings will be in upper case in new string. 
    //Sample Input:
    //{ "Abc", "cdef", "js" , "php" }
    //Expected Output :
    //ABC CDEF JS PHP
    void Exercise147();

    //148. Write a C# Sharp program to remove all "a" in each string in given list of strings and return the new string. 
    //Sample Input:
    //{ "abc", "cdaef", "js" , "php" }
    //Expected Output :
    //bc cdef js php
    void Exercise148();

    //149. Write a C# Sharp program to create a new list from a given list of integers removing those values which are less than 4. 
    //Sample Input:
    //{ 0, -2, 1, 2, 3, 5 , 4, 7, 8 }
    //Expected Output :
    //0 -2 1 2 3
    void Exercise149();

    //150. Write a C# Sharp program to create a new list from a given list of integers removing those values end with 7. 
    //Sample Input:
    //{ 10, 22, 35 , 47, 53, 67 }
    //Expected Output :
    //10 22 35 53
    void Exercise150();
}