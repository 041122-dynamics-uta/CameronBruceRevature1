#!/bin/bash

# Function Calls
getName () {
#Basic input and output
    echo Enter your name 
    read name
    echo Welcome $name
}
consoleMenu () {
#Gives The Question for Calculation Selection
    echo Press A Number: 1 For Addition, 2 For Subtraction, 3 For Multiplication and 4 For Division 5 For Exit: 
}

Addition () {
#Enter Numbers
    echo "Enter first Addend:"
    read num1
    echo "Enter second Addend:"
    read num2

#Calculate numbers and output
    result=$(( $num1 + $num2 ))
    echo The Sum of Your Numbers Are: $result
}

Subtraction () {
#Gets Inputs
    echo "Enter the Minuend:"
    read num1
    echo "Enter the Subtrahend:"
    read num2

#Calculates the Number
    result=$(( $num1 - $num2 ))
    echo The Difference of Your Numbers Are: $result
}

Multiplication () {
#Gets Inputs
    echo "Enter the Multiplier:"
    read num1
    echo "Enter the Multiplihend:"
    read num2

#Calculates the Numbers and outputs
    result=$(( $num1 * $num2 )) 
    echo The Product of Your Numbers Are: $result
}

Division () {
#Gets Inputs
    echo "Enter the Dividend:"
    read num1
    echo "Enter the Divisor:"
    read num2

#Calculates the Numbers and Outputs 
    result=$(( $num1 / $num2 ))
    echo The Quotient of Your Numbers Are = $result
}

getEscape () {
    echo Run Away
    input="no"
}
getCalculator () {
# Initiate the While Loop

    input="yes"
        while [[ $input = "yes" ]]
        do


#Call Function to call for Calculation Selection

    consoleMenu
    
#Call the Switch with the variables

            select math in Addition Subtraction Multiplication Division Exit
            do

#The Case

                case "$math" in
                Addition)

#Call Addition Function
#Make all other case statements the same as this one and add the selection in the Select command

                    Addition
                    break
                    ;; 

                Subtraction)

#Call Subtraction Function

                    Subtraction
                    break
                    ;;
                
                Multiplication)

#Call Multiplication Function

                    Multiplication
                    break
                    ;;
                Division)

#Call Division Function

                    Division
                    break
                    ;;
                Exit)
#Exits the Program

                    getEscape
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
}

getMainFunction () {
#Call Function to Get Name

    getName

#Call Function to Get Calculator
    getCalculator

}

#Final Call for Whole set
getMainFunction