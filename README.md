## C# Fundamentals Exercises

The objective of this set of exercises is to demonstrate the following fundamental programming concepts in C#:
<ul>
    <li>Fundamentals of C# Value Types</li>
    <li>For loops</li>
    <li>Debugging C# Code in Visual Studio or Visual Studio Code IDE</li>
    <li>Logical thinking & general problem solving abilities via code</li>
</ul>

Therefore, it is important for this exercise to not use existing helper libraries where possible.

There will be a code review session following, where the code will be walked through line-by-line.

<b>Quick Tip:</b> As these Exercises cannot be solved using straightforward solutions, it would be helpful to plan step-by-step first (maybe comment different sections?) before jumping into writing code.

<br />

#### Setting Up The Exercise

This Exercise should be done in a C# Console App.

<br />

#### Exercise 1: Working with Texts (Strings/Characters)

##### 1.1 Input Validation

Write a Validation method to "clean" a string input, to return a string output containing only alphabets.

<Details>
    <Summary>Examples of <u>valid outputs</u>:</Summary>
    <ul>
        <li>"helloworld"</li>
        <li>"aksuzdycbfv"</li>
    </ul>
</Details>

<Details>
    <Summary>Examples of <u>invalid outputs</u>:</Summary>
    <ul>
        <li>"hello world 123"</li>
        <li>"Mr. Owl says hi"</li>
    </ul>
</Details>

<br />

##### 1.2 Working With Palindromes

Palindromes are words & phrases that are spelled the same backward & forward.

Write a check to determine if an input string is a Palindrome.

<b>Note: <u>DO NOT</u> use the existing ".Reverse()" method.</b>

<Details>
    <Summary>Examples of <u>valid Palindromes</u>:</Summary>
    <ul>
        <li>"civic"</li>
        <li>"level"</li>
        <li>"radar"</li>
        <li>"taco cat"</li>
        <li>"Mr. Owl ate my metal worm"</li>
    </ul>
</Details>

<Details>
    <Summary>Examples of <u>invalid Palindromes</u>:</Summary>
    <ul>
        <li>"Never gonna give you up"</li>
        <li>"Never Gonna Let You Down"</li>
        <li>"NeverGonnaRunAroundAndDesertYou"</li>
        <li>"rickAstley"</li>
    </ul>
</Details>

<br />




#### Exercise 2: Working with Numbers

##### 2.1 Input Validation

Write a Validation method to accept only an array of integers, without spaces. NULL is not a valid input either.

<Details>
    <Summary>Examples of <u>valid inputs</u>:</Summary>
    <ul>
        <li>{1,2,3,4}</li>
        <li>{12,34,56}</li>
    </ul>
</Details>

<Details>
    <Summary>Examples of <u>invalid inputs</u>:</Summary>
    <ul>
        <li>{1}</li>
        <li>{1234}</li>
        <li>{,1,2,3,4}</li>
        <li>{a,b,c}</li>
        <li>{".","."}</li>
        <li>{o.0,lol}</li>
        <li>{"(ノ^_^)ノ ┻━┻", "┬─┬ ノ( ^_^ノ)"}</li>
    </ul>
</Details>

<br />

##### 2.2 Fun With Numbers

For any input, if it is a valid array of integers, return an array of the cumulative sum of the input array.

For example, input array { 1,2,3,4 } returns the array { 1,3,6,10 }.