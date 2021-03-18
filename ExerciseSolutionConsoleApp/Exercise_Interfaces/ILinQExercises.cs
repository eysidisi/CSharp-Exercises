﻿
interface ILinQExerciseSet
{
    //1. Write a program in C# Sharp to shows how the three parts of a query operation execute. 
    //Expected Output:
    //The numbers which produce the remainder 0 after divided by 2 are :
    //0 2 4 6 8
    void Exercise1();

    //2. Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
    //Expected Output:
    //The numbers within the range of 1 to 11 are :
    //1 3 6 9 10
    void Exercise2();

    //3. Write a program in C# Sharp to find the number of an array and the square of each number. 
    //Expected Output :
    //{ Number = 9, SqrNo = 81 }
    //{ Number = 8, SqrNo = 64 }
    //{ Number = 6, SqrNo = 36 }
    //{ Number = 5, SqrNo = 25 }
    void Exercise3();

    //4. Write a program in C# Sharp to display the number and frequency of number from giving array. 
    //Expected Output :
    //The number and the Frequency are :
    //Number 5 appears 3 times
    //Number 9 appears 2 times
    //Number 1 appears 1 times
    //. . . .
    void Exercise4();

    //5. Write a program in C# Sharp to display the characters and frequency of character from giving string. 
    //Test Data:
    //Input the string: apple
    //Expected Output:
    //The frequency of the characters are :
    //Character a: 1 times
    //Character p: 2 times
    //Character l: 1 times
    //Character e: 1 times
    void Exercise5();

    //6. Write a program in C# Sharp to display the name of the days of a week. 
    //Expected Output:
    //Sunday
    //Monday
    //Tuesday
    //Wednesday
    //Thursday
    //Friday
    //Saturday
    void Exercise6();

    //7. Write a program in C# Sharp to display numbers, multiplication of number with frequency and frequency of a number of giving array. 
    //Test Data :
    //The numbers in the array are :
    //5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2
    //Expected Output :
    //Number Number*Frequency Frequency
    //------------------------------------------------
    //5 15 3
    //1 1 1
    //9 9 1
    //2 4 2
    //. . . . . . . .
    void Exercise7();

    //8. Write a program in C# Sharp to find the string which starts and ends with a specific character. 
    //Test Data :
    //The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
    //Input starting character for the string : A
    //Input ending character for the string : M
    //Expected Output :
    //The city starting with A and ending with M is : AMSTERDAM
    void Exercise8();

    //9. Write a program in C# Sharp to create a list of numbers and display the numbers greater than 80 as output. 
    //Test Data :
    //The members of the list are :
    //55 200 740 76 230 482 95
    //Expected Output :
    //The numbers greater than 80 are :
    //200
    //740
    //230
    //482
    //95
    void Exercise9();

    //10. Write a program in C# Sharp to Accept the members of a list through the keyboard and display the members more than a specific value. 
    //Test Data :
    //Input the number of members on the List : 5
    //Member 0 : 10
    //Member 1 : 48
    //Member 2 : 52
    //Member 3 : 94
    //Member 4 : 63
    //Input the value above you want to display the members of the List : 59
    //Expected Output :
    //The numbers greater than 59 are :
    //94
    //63
    void Exercise10();

    //11. Write a program in C# Sharp to display the top n-th records. 
    //Test Data :
    //The members of the list are :
    //5
    //7
    //13
    //24
    //6
    //9
    //8
    //7
    //How many records you want to display ? : 3
    //Expected Output :
    //The top 3 records from the list are :
    //24
    //13
    //9
    void Exercise11();

    //12. Write a program in C# Sharp to find the uppercase words in a string. 
    //Test Data :
    //Input the string : this IS a STRING
    //Expected Output :
    //The UPPER CASE words are :
    //IS
    //STRING
    void Exercise12();

    //13. Write a program in C# Sharp to convert a string array to a string. 
    //Test Data :
    //Input number of strings to store in the array :3
    //Input 3 strings for the array :
    //Element[0] : cat
    //Element[1] : dog
    //Element[2] : rat
    //Expected Output:
    //Here is the string below created with elements of the above array :
    //cat, dog, rat
    void Exercise13();

    //14. Write a program in C# Sharp to find the n-th Maximum grade point achieved by the students from the list of students. 
    //Test Data :
    //Which maximum grade point(1st, 2nd, 3rd, ...) you want to find : 3
    //Expected Output:
    //Id : 7, Name : David, achieved Grade Point : 750
    //Id : 10, Name : Jenny, achieved Grade Point : 750
    void Exercise14();

    //15. Write a program in C# Program to Count File Extensions and Group it using LINQ. 
    //Test Data :
    //The files are : aaa.frx, bbb.TXT, xyz.dbf,abc.pdf
    //aaaa.PDF,xyz.frt, abc.xml, ccc.txt, zzz.txt
    //Expected Output :
    //Here is the group of extension of the files :
    //1 File(s) with .frx Extension
    //3 File(s) with .txt Extension
    //1 File(s) with .dbf Extension
    //2 File(s) with .pdf Extension
    //1 File(s) with .frt Extension
    //1 File(s) with .xml Extension
    void Exercise15();

    //16. Write a program in C# Sharp to Calculate Size of File using LINQ. 
    //Expected Output :
    //The Average file size is 3.4 MB
    void Exercise16();

    //17. Write a program in C# Sharp to Remove Items from List using remove function by passing the object. 
    //Test Data :
    //Here is the list of items :
    //Char: m
    //Char: n
    //Char: o
    //Char: p
    //Char: q
    //Expected Output:
    //Here is the list after removing the item 'o' from the list :
    //Char: m
    //Char: n
    //Char: p
    //Char: q
    void Exercise17();

    //18. Write a program in C# Sharp to Remove Items from List by creating an object internally by filtering. 
    //Test Data :
    //Here is the list of items :
    //Char: m
    //Char: n
    //Char: o
    //Char: p
    //Char: q
    //Expected Output :
    //Here is the list after removing the item 'p' from the list :
    //Char: m
    //Char: n
    //Char: o
    //Char: q
    void Exercise18();

    //19. Write a program in C# Sharp to Remove Items from List by passing filters. 
    //Test Data :
    //Here is the list of items :
    //Char: m
    //Char: n
    //Char: o
    //Char: p
    //Char: q
    //Expected Output :
    //Here is the list after removing item 'q' from the list :
    //Char: m
    //Char: n
    //Char: o
    //Char: p
    void Exercise19();

    //20. Find the number and its square of an array which is more than 20. 
    //Test Data :
    //Here is the list of items :
    //Char: m
    //Char: n
    //Char: o
    //Char: p
    //Char: q
    //Expected Output:
    //Here is the list after removing item index 3 from the list :
    //Char: m
    //Char: n
    //Char: o
    //Char: q
    void Exercise20();

    //21. Write a program in C# Sharp to remove a range of items from a list by passing the start index and number of elements to remove. 
    //Test Data :
    //Here is the list of items :
    //Char: m
    //Char: n
    //Char: o
    //Char: p
    //Char: q
    //Expected Output:
    //Here is the list after removing the three items starting from the item index 1 from the list :
    //Char: m
    //Char: q
    void Exercise21();

    //22. Write a program in C# Sharp to find the strings for a specific minimum length. 
    //Test Data :
    //Input number of strings to store in the array :4
    //Input 4 strings for the array:
    //Element[0] : this
    //Element[1] : is
    //Element[2] : a
    //Element[3] : string
    //Input the minimum length of the item you want to find : 5
    //Expected Output:
    //The items of minimum 5 characters are :
    //Item: string
    void Exercise22();

    //23. Write a program in C# Sharp to generate a Cartesian Product of two sets. 
    //Expected Output :
    //The Cartesian Product are :
    //{ letterList = X, numberList = 1 }
    //{ letterList = X, numberList = 2 }
    //{ letterList = X, numberList = 3 }
    //{ letterList = X, numberList = 4 }
    //. . .
    void Exercise23();

    //24. Write a program in C# Sharp to generate a Cartesian Product of three sets. 
    //Expected Output :
    //The Cartesian Product are :
    //{ letter = X, number = 1, colour = Green }
    //{ letter = X, number = 1, colour = Orange }
    //{ letter = X, number = 2, colour = Green }
    //{ letter = X, number = 2, colour = Orange }
    //{ letter = X, number = 3, colour = Green }
    //{ letter = X, number = 3, colour = Orange }
    //{ letter = Y, number = 1, colour = Green }
    //{ letter = Y, number = 1, colour = Orange }
    //. . .
    void Exercise24();

    //25. Write a program in C# Sharp to generate an Inner Join between two data sets. 
    //Expected Output :
    //Item ID         Item Name       Purchase Quantity                                                             
    //-------------------------------------------------------                                                       
    //1               Biscuit                 458                                                                   
    //2               Chocolate               650                                                                   
    //3               Butter                  800                                                                   
    //3               Butter                  900                                                                   
    //3               Butter                  900                                                                   
    //4               Brade                   700                                                                   
    //4               Brade                   650
    void Exercise25();

    //26. Write a program in C# Sharp to generate a Left Join between two data sets. 
    //Expected Output :
    //Here is the list after joining  :                                                                             
    //                                                                                                              
    //Item ID         Item Name       Purchase Quantity                                                             
    //-------------------------------------------------------                                                       
    //1               Biscuit                 458                                                                   
    //2               Chocolate               650                                                                   
    //3               Butter                  800                                                                   
    //3               Butter                  900                                                                   
    //3               Butter                  900                                                                   
    //4               Brade                   700                                                                   
    //4               Brade                   650                                                                   
    //5               Honey                   0   
    void Exercise26();

    //27. Write a program in C# Sharp to generate a Right Outer Join between two data sets. 
    //Expected Output :
    //Here is the list after joining  :                                                                             
    //                                                                                                              
    //Item ID         Item Name       Purchase Quantity                                                             
    //-------------------------------------------------------                                                       
    //3               Butter                  800                                                                   
    //5               Honey                   650                                                                   
    //3               Butter                  900                                                                   
    //4               Brade                   700                                                                   
    //3               Butter                  900                                                                   
    //4               Brade                   650                                                                   
    //1               Biscuit                 458   
    void Exercise27();

    //28. Write a program in C# Sharp to display the list of items in the array according
    // to the length of the string then by name in ascending order. 
    //Expected Output :
    //Here is the arranged list :
    //ROME
    //PARIS
    //LONDON
    //ZURICH
    //NAIROBI
    //ABU DHABI
    //AMSTERDAM
    //NEW DELHI
    //CALIFORNIA
    void Exercise28();

    //29. Write a program in C# Sharp to split a collection of strings into some groups. 
    //Expected Output :
    //Here is the group of cities :
    //ROME; LONDON; NAIROBI
    //-- here is a group of cities --
    //CALIFORNIA; ZURICH; NEW DELHI
    //-- here is a group of cities --
    //AMSTERDAM; ABU DHABI; PARIS
    //-- here is a group of cities --
    //NEW YORK
    //-- here is a group of cities --
    void Exercise29();

    //30. Write a program in C# Sharp to arrange the
    // distinct elements in the list in ascending order. 
    //Expected Output :
    //Biscuit
    //Brade
    //Butter
    //Honey
    void Exercise30();


}
