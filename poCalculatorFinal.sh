#!/bin/bash

# Function Call
consoleMenu () {
    echo Press A Number: 1 For Addition, 2 For Subtraction, 3 For Multiplication and 4 For Division 5 For Exit: 
}

#Basic input and output
    echo Enter your name 
    read name
    echo Welcome $name

# Initiate the While Loop
    input="yes"
        while [[ $input = "yes" ]]
        do


#output Function Call
        consoleMenu
    
    #Call the Switch with the variables
            select math in Addition Subtraction Multiplication Division Exit
            do

            #The Case 
                case "$math" in
                Addition)

                #Enter Numbers
                    echo "Enter first Addend:"
                    read num1
                    echo "Enter second Addend:"
                    read num2

                    #Calculate numbers and output
                    result=$(( $num1 + $num2 ))
                    echo The Sum of Your Numbers Are: $result

                    #Exits the individual case statement
                    break


                ;; 
#Make all other case statements the same as first one and add the name in the select statement

                Subtraction)
                    echo "Enter the Minuend:"
                    read num1
                    echo "Enter the Subtrahend:"
                    read num2
                    result=$(( $num1 - $num2 ))
                    echo The Difference of Your Numbers Are: $result
                    break
                ;;
                Multiplication)
                    echo "Enter the Multiplier:"
                    read num1
                    echo "Enter the Multiplihend:"
                    read num2
                    result=$(( $num1 * $num2 )) 
                    echo The Product of Your Numbers Are: $result
                    break
                ;;
                Division)
                    echo "Enter the Dividend:"
                    read num1
                    echo "Enter the Divisor:"
                    read num2
                    result=$(( $num1 / $num2 ))
                    echo The Quotient of Your Numbers Are = $result
                    break
                ;;
                Exit)
                #Exits the Program
                    input="no"
                    break
                ;;
                *)
                #keeps the loop from throwing error if switch selection is greater than 5 or any other key stroke
                    echo Choose 1 to 5 only!!!!
                    break
                ;;
            esac
    done

done