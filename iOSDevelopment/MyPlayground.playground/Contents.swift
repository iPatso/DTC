//: Playground - noun: a place where people can play

import UIKit

//Strings

var str = "Hello, playground"

var name = "Patrick"

print ("Hello " + name + ".")

//Integers

var i:Int = 9
i *= 2
i /= 4

var anotherNum:Int = 7

print(i + anotherNum)

print("Value of num is: \(i)")

//Doubles

var d:Double = 8.4

print(d * 7)
print(d * Double(i)) //Need to have the same type in order to do arithmetic!

//Boolean

var isMale:Bool = true

//Practice: Create a double and int. Multiply and output to string.

var int:Int = 2
var double:Double = 3.5
var string:String = "\(int) x \(double) = \(double * Double(int))"
print(string)

//Arrays

var array0 = [1,2,3,4, "Rob"] //Don't NEED to have same type in array... but probably should
var array = [72,67,38,19]
print(array[0])

print(array.count)

array.append(100)
array.removeAtIndex(2)

array.sort()

//Practice: Array of 3 numbers. remove middle. add item at end (sum of two remaining numbers)
var arr:Array = [3,5,8]
arr.removeAtIndex(1)
arr.append(arr[0]+arr[1])

//Dictionaries

var dic = ["Computer": "Something to code one",
			"Toilet" : "Something to poop in",
	   "Smart Phone" : "Makes people dumber"]

print (dic ["Toilet"]!) //'!' = force unwrap; Without it, message says "optional" b/c swift doesn't know if Toilet exists in dic
print (dic.count)

dic["Cup"] = "Store liquids or solids in"

dic.removeValueForKey("Computer")

print(dic)

//Practice: Create dictionary that stores three items and price on food menu. Calculate total and print
var items:Dictionary = ["Ramen" : 12.5, "KBBQ" : 20.99, "Super Fries" : 9.63]
var totalCost = items["Ramen"]! + items["KBBQ"]! + items["Super Fries"]!

print("Hi, I want all items for $\(totalCost)")

//If Statements

var age = 13

if age >= 18 {
	print("You can play!")
} else {
	print ("Ask your Mom...")
}

var fName = "Pat"

if fName == "Pat" {
	print ("Hi Master")
} else {
	print ("Sorry \(fName), you can't play")
}

if name == "Janelle" && age >= 18 {
	print ("You can play")
}

var isFemale = false
if isFemale {
	print ("Ehh")
}

//Practice: Create username and password variables. Check with specific ones
var username = "iPatso"
var password = "shabalabaDingDong5"

if username == "xNINJAx" && password == "hingaDinga4" {
	print ("Access granted")
} else {
	print ("Incorrect username and password")
}

//

































