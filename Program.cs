// number 1
// Console.WriteLine("input two number to exchange their values if the first one is greater than the second");
// Console.WriteLine("input first number");
// int first=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number");
// int second=Convert.ToInt32(Console.ReadLine());
// int exchange=0;
// if(first>second)
// {
//     exchange=first;
//     first=second;
//     second=exchange;
//     exchange=first;
    
//     Console.WriteLine($"the numbers are {first}\n{second}");
// }
// else
// {
//     Console.WriteLine($"{first}\n{second}");
// }
// number 2
// Console.WriteLine("input three number ");
// Console.WriteLine("input the first number");
// int firstDigit = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input the second number");
// int secondDigit = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input the third number");
// int thirdDigit = Convert.ToInt32(Console.ReadLine());
// if (firstDigit < 0 && secondDigit < 0 && thirdDigit < 0)
// {
//     Console.WriteLine("Their product will be negative ");
// }
// else  if (firstDigit > 0 && secondDigit > 0 && thirdDigit < 0)
// {
//     Console.WriteLine("Their product will be negative ");
// }
// else  if (firstDigit > 0 && secondDigit < 0 && thirdDigit > 0)
// {
//     Console.WriteLine("Their product will be negative ");
// }
//  else if (firstDigit < 0 && secondDigit > 0 && thirdDigit > 0)
// {
//     Console.WriteLine("Their product will be negative ");
// }
// else 
// {
//     Console.WriteLine("Their product will be positive ");
// }

// number3
// Console.WriteLine("input three numbers to print the biggest of them");
// Console.WriteLine("input the first number");
// int firstNumber=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input the second number");
// int secondNumber=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input the third number");
// int thirdNumber=Convert.ToInt32(Console.ReadLine());
// if(firstNumber > secondNumber)
// {
//     if (firstNumber > thirdNumber)
//     {
//         Console.WriteLine($"The biggest number is {firstNumber}" );
//     }
//     else
//     {
//         Console.WriteLine($"The biggest number is {thirdNumber}");
//     }
// }
// else if(secondNumber > firstNumber)
// {
//     if (secondNumber > thirdNumber)
//     {
//         Console.WriteLine($"The biggest number is {secondNumber}");
//     }
//     else
//     {
//         Console.WriteLine($"The biggest number is {thirdNumber}");
//     }
// }
// else
// {
//     if (firstNumber > thirdNumber)
//     {
//         Console.WriteLine($"The biggest number is {firstNumber}");
//     }
//     else
//     {
//         Console.WriteLine($"The biggest number is {thirdNumber}");
//     }
// }
// Number 4
// Console.WriteLine("Enter a number");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter a number");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter a number");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());
// int biggest =0;
// if(firstNumber > secondNumber)
// {
//     if (firstNumber > thirdNumber)
//     {
//         biggest =firstNumber;
//         if (secondNumber > thirdNumber)
//         {
//             Console.WriteLine($"The numbers in desending order is {biggest}, {secondNumber}, {thirdNumber}");
//         }
//         else
//         {
//             Console.WriteLine($"The numbers in desending order is {biggest}, {thirdNumber}, {secondNumber}");
//         }
//     }
//     else
//     {
//        biggest = thirdNumber;
//        if (secondNumber > firstNumber)
//         {
//             Console.WriteLine($"The numbers in desending order is {biggest}, {secondNumber}, {firstNumber}");
//         }
//         else
//         {
//             Console.WriteLine($"The numbers in desending order is {biggest}, {firstNumber}, {secondNumber}");
//         }
//     }
// }
// else if(secondNumber > firstNumber)
// {
//     if (secondNumber > thirdNumber)
//     {
//         biggest = secondNumber;
//         if (firstNumber > thirdNumber)
//         {
//             Console.WriteLine($"The numbers in desending order is {biggest}, {firstNumber}, {thirdNumber}");
//         }
//         else
//         {
//             Console.WriteLine($"The numbers in desending order is {biggest}, {thirdNumber}, {firstNumber}");
//         }
//     }
//     else
//     {
//        biggest=thirdNumber;
//        if (secondNumber > firstNumber)
//         {
//             Console.WriteLine($"The numbers in desending order is {biggest}, {secondNumber}, {firstNumber}");
//         }
//         else
//         {
//             Console.WriteLine($"The numbers in desending order is {biggest}, {firstNumber}, {secondNumber}");
//         }
//     }
// }
// else
// {
//     if (firstNumber > thirdNumber)
//     {
//         biggest = firstNumber;
//         if (secondNumber > thirdNumber)
//         {
//             Console.WriteLine($"The numbers in desending order is {biggest}, {secondNumber}, {thirdNumber}");
//         }
//         else
//         {
//             Console.WriteLine($"The numbers in desending order is {biggest}, {thirdNumber}, {secondNumber}");
//         }
//     }
//     else
//     {
//         biggest =thirdNumber;
//         if (secondNumber > firstNumber)
//         {
//             Console.WriteLine($"The numbers in desending order is {biggest}, {secondNumber}, {firstNumber}");
//         }
//         else
//         {
//             Console.WriteLine($"The numbers in desending order is {biggest}, {firstNumber}, {secondNumber}");
//         }
//     }
// }


// number5
//  Console.WriteLine("input a number from 0 to 9 to print in words");
//  Console.WriteLine("input you number ");
//  int number=Convert.ToInt32(Console.ReadLine());
//  switch (number)
//     { 
//        case 0:
//        Console.WriteLine("Zero"); break;
//        case 1:
//        Console.WriteLine("One"); break;
//        case 2:
//        Console.WriteLine("Two"); break;
//        case 3:
//        Console.WriteLine("Three"); break;
//        case 4:
//        Console.WriteLine("Four"); break;
//        case 5:
//        Console.WriteLine("Five"); break;
//        case 6:
//        Console.WriteLine("Six"); break;
    
//        case 7:
//        Console.WriteLine("Seven"); break;
//        case 8:
//        Console.WriteLine("Eight"); break;
//        case 9:
//        Console.WriteLine("Nine"); break;
        
//        default:
//        Console.WriteLine("invalid Input"); break;
//   }

// number 6
/* Console.WriteLine("lets find the roots of a quadreatic equation give a,b,c only if they are real");
Console.WriteLine("input the value of a");
int avalue=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input the value of b");
int bvalue=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input the value of c");
int cvalue=Convert.ToInt32(Console.ReadLine());
int D=((bvalue*bvalue)-(4*avalue*cvalue));
if(D<0)
    {
        int root1=((-bvalue)+(D))/(2*avalue);
        Console.WriteLine("The roots are not real");
    }
if(D>=0)
{
        double root1=((0-bvalue)+(Math.Sqrt(D)))/(2*avalue);
        double root2=((0-bvalue)-(Math.Sqrt(D)))/(2*avalue);
        Console.WriteLine($"The roots are real and they are {root1} and {root2}");
    }*/
// number7
// Console.WriteLine("input 5 numbers to print the greatest of them");
// Console.Write("input the first number: ");
// int numberone=Convert.ToInt32(Console.ReadLine());
// Console.Write("input the second number: ");
// int numbertwo=Convert.ToInt32(Console.ReadLine());
// Console.Write("input the third number: ");
// int numberthree=Convert.ToInt32(Console.ReadLine());
// Console.Write("input the fourth number: ");
// int numberfour=Convert.ToInt32(Console.ReadLine());
// Console.Write("input the fifth number: ");
// int numberfive=Convert.ToInt32(Console.ReadLine());
// int thegreatest=0;
// if(numberone>numbertwo)
// {
//     thegreatest=numberone;
// }

//  else if(numbertwo>numberone)
//    {
//     thegreatest=numbertwo;
//    } 
        

//   if(numberthree>thegreatest)
// {
//     thegreatest=numberthree;

// }
//   if(numberfour>thegreatest)
// {
//     thegreatest=numberfour;

// }
//   if(numberfive>thegreatest)
// {
//     thegreatest=numberfive;

// }


// Console.WriteLine($"The greatest is {thegreatest}");



// number 8

// Console.WriteLine("pick your choice of input\nEnter a for an integer, b for a double or c for word(s)");
// char decide=Convert.ToChar(Console.ReadLine());

// switch (decide)
// {

//     case 'a':
//     case 'A':
//     Console.WriteLine ("input your interger to have it increased by \"1\""); 
//     int integerInput=Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Your new integer is {integerInput+1}");
//     break;
//     case 'b':
//     case 'B':
//     Console.WriteLine("input your Double to have it increased by \"1\"");
//     double doubleInput=Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine($"Your new double is {doubleInput+1}");
//     break;
//     case 'c':
//     case 'C':
//     Console.WriteLine("inputv your word to have \"*\" attached to the end"); 
//     string stringInput=Console.ReadLine();
//     Console.WriteLine($"{stringInput}*");
//     break;
//     default:
//     Console.WriteLine("Invalid Input\nTry again");
//     break;
// }

// Number 10
// Console.WriteLine("lets assign bonus mark to scores from 1 to 9");
// Console.WriteLine("input you score ");
// int score=Convert.ToInt32(Console.ReadLine());
// switch (score)
// {
//     case 1:
//     case 2:
//     case 3:
//     Console.WriteLine($"{score*10}"); break;

//     case 4:
//     case 5:
//     case 6:
//     Console.WriteLine($"{score*100}"); break;
//     case 7:
//     case 8:
//     case 9:

//     Console.WriteLine($"{score*1000}"); break;
    
//     default:
//     Console.WriteLine("invalid Input"); break;
// }
