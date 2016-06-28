# Extension methods


## Overview
Extension methods allow you to add functionality to existing types by adding new methods without deriving a new subtype. 
The "this" modifier is applied to the first parameter. The type of the first parameter will be the type that is extended.e
LINQ is implemented with a number of extension methods like First() or FirstOrDefault or Last() etc. 

## Creating an Extension Method 

An extension method is created by declaring a public static class with a public static method.   

```javascript
 public static class MyExtensionMethod
    {
        public static string ToDelimitedString<T>(this IEnumerable<T> input, string delimiter)
        {
            var output = new StringBuilder();
            foreach (var itm in input) { if (output.Length > 0) output.Append(delimiter); output.Append(itm.ToString()); }
            return output.ToString();
        }
    }

```javascript

This method is designed to take an IEnumerable<T> and a string delimiter, and return a single string which is a delimited list of the items.  The definition looks like a pretty standard static method; the only difference is the this keyword before the first parameter. 


## Using an Extension Method

Using 2 ways :
*1. standard way:*

```javascript
			List<string> Names = GetNames();
            Console.WriteLine(MyExtensionMethod.ToDelimitedString(Names, ", "));
       

```

*2.Extension method:*

```javascript
		    List<string> Names = GetNames();
            Console.WriteLine(Names.ToDelimitedString("_ "));

```
## Rules or Guidelines :

1. Extension methods must be public static methods in a public static class.  The class name itself is unimportant.
2. Extension methods are declared by including the this keyword in front of the first parameter.  The this keyword can only be used with the first parameter. 
