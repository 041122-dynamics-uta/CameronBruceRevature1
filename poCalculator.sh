#!bin/bash

echo "Greetings User, Please Enter Your Name"
read userName

echo "Greetings $userName, Would You Like To Do Some Math Problems Today?"

read answer1

if [ $answer1 == y || Y || yes || Yes || YES ]
then
        echo "Great Lets Get Some Information."
elif [ $answer1 == n || N || no || No || NO ]
then
        echo "It's less than 100"
else
        echo "It's exactly 100"