# MckaysTriangles
Solution for the Triangle Challenge
By: Mckay Huber

Instructions:
Download repository and it can either be run with the "dotnet run" command for dotnet users
Or a copy of the .exe file can be found in path MckaysTriangles>bin>MckaysTriangles.exe

Notes:
This assumes user input should only be positive integer values. Because of this Only right triangles that are pythagerian triples will occure.
This also makes it impossible to enter an Isosceles right triangle.

Description:
    Purpose: Provides information about a triangle given the lengths of three sides
    Inputs:
        side length a: 3
        side length b: 4
        side length c: 5

    User Stories
    Scenario/Description 
    1. The application needs to validate user input and not allow for non-numbers
    to be entered.
    2. As soon as all three fields have valid data in them, it needs to run the
    calculations to generate the triangle information.
    3. We’ll need to know whether the given values produce a valid triangle
    A simple calculation for this is to know that no two sides added up can be
    less than the other side (EG 3+4 > 5, so the above triangle is valid)
    4. Classify the triangle into one of several triangles
         Right
         Equilateral
         Isosceles
         Triangle
    5. Generate a text message that provides the class of the triangle, and whether
    it is valid


Sources for Triangle Facts:
https://www.splashlearn.com/math-vocabulary/geometry/scalene-triangle#:~:text=All%20angles%20of%20a%20scalene,given%20scalene%20triangle%20are%20unequal.
https://en.wikipedia.org/wiki/Isosceles_triangle
https://www.google.com/search?q=facts+about+equilateral+triangles&rlz=1C1CHBF_enUS706US706&oq=facts+about+equi&aqs=chrome.0.0i20i263j0j69i57j0l6j0i457.10695j0j7&sourceid=chrome&ie=UTF-8
https://en.wikipedia.org/wiki/Right_triangle