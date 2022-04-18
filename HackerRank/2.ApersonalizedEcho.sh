#...............Looping and Skipping
for n in {1..99..2}
 do 
 echo $n
done

#--------Personalized echo---------
read name

echo "Welcome $name"


#--------Loopgin with numbers---------
for i in {1..50}
do
    echo $i
done
#.........>>>>>>>>>>>>>>>>>>>>>>>>

seq 1 50


#--------the world of numbers---------

read x
read y

echo $((x + y))
echo $((x - y))
echo $((x * y))
echo $((x / y))

#--------comparing  numbers---------

#!/bin/bash
read X
read Y
if (( $X > $Y )); then
    printf "X is greater than Y"
elif (( $X == $Y )); then
    printf "X is equal to Y"
else
    printf "X is less than Y"
fi

#--------Getting started with conditionals--------


read x
if [[ $x == "y" || $x == "Y" ]]
then
echo "YES"
else
echo "NO"
fi