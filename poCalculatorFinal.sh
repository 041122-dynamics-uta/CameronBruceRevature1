#!/bin/bash
input="yes"
while [[ $input = "yes" ]]
do
consoleMenu () {
    echo Press A Number: 1 For Addition, 2 For Subtraction, 3 For Multiplication and 4 For Division: 
}
consoleMenu
    #PS3="Press 1 for Addition, 2 for subtraction, 3 for multiplication and 4 for division: "
    select math in Addition Subtraction Multiplication Division
    do
        case "$math" in
        Addition)
            echo "Enter first no:"
            read num1
            echo "Enter second no:"
            read num2
            result=`expr $num1 + $num2`
            echo Answer: $result
            break
        ;;
        Subtraction)
            echo "Enter first no:"
            read num1
            echo "Enter second no:"
            read num2
            result=`expr $num1 - $num2`
            echo Answer: $result
            break
        ;;
        Multiplication)
            echo "Enter first no:"
            read num1
            echo "Enter second no:"
            read num2
            result=`expr $num1 * $num2`
            echo Answer: $result
            break
        ;;
        Division)
            echo "Enter first no:"
            read num1
            echo "Enter second no:"
            read num2
            result=$(expr "scale=2; $num1/$num2" | bc)
            echo Answer = $result
            break
        ;;
        #Exit)
        *)
            echo Choose 1 to 4 only!!!!
            break
        ;;
    esac
    done

done
#echo  Enter Numbers For Calculation 

             #read $a
           #  read $b
#Add() {  
       # var1=$(($a+$b))
   # echo $var1 

#}
#Add 
#Assigning the output of function Add to another variable 'var2'.
#var2=$var1
#echo $var2
#Subtract () { local result = $(($int1 - $int2)) echo "$result" }
#Multiply () { local result = $(($int1 \* $int2)) echo "$result" }
#Divide () { local result = $(($int1 / $int2)) echo "$result" } 


#result = Add $int1 $int2
#echo The sum is: $result
#echo Welcome User Would You Like To Preform Some Calculations 



    #while true

        #do

        # echo Select Calculation Type \n
        # echo 1	Add \n
        # echo 2	Subtract \n
        # echo 3	Multiply \n
        # echo 4	Divide \n 
        # echo 0  Exit 

        #read selectType

            # if [ $selectType -le 4 ];

            # then 

            # 

            # case $selectType in 

            # 1) echo  Press Enter For Result 
            #     read
            #     echo  The Sum of $int1 and $int2 is  Add
            #     ;;

            # 2) echo  Press Enter For Result
            #     read
            #     echo  The Difference of $int1 and $int2 is  Subtract
            #     ;;

            # 3) echo  Press Enter For Result 
            #     read
            #     echo  The Product of $int1 and $int2 is  Multiply
            #     ;;

            # 4) if [ $int2 -eq 0 ] 
            #     then
            #     echo  Unable to Preform Calculation Divisor cannot be 0 
            #     else 
            #     echo  Press Enter For Result 
            #     read
            #     echo  The Quotient of $int1 and $int2 is  Divide
            #     ;;

            #esac

#done
#fi