#! /bin/bash

for (( ; ; ))
do

echo "Exercise 1"

echo "I have read the material"

sleep 5
echo ""

echo "Exercise 2"

echo "mkdir tools"

sleep 5
echo ""

echo "Exercise 3"

echo "To save without closing, press CTRL + O."

echo "To copy and paste in nano, select a line, press CTRL + K, then CTRL + U twice."

sleep 5
echo ""

echo "Exercise 4"

echo "Insert mode in vim is to write. Command mode is to give commands."
echo "To insert press i. To switch press ESC. To exit write for example :q"

sleep 5
echo ""

echo "Exercise 5"

echo "mkdir school"
echo "mkdir school/CS1"
echo "mkdir school/CS2"
echo "mkdir school/lapio (or school/tools, there is a mixup between the picture and the text)"
echo "touch school/lapio/cmd-line.txt" 
echo "touch school/CS1/lecture1.txt" 
echo "touch school/CS2/lecture2.txt"
echo "touch school/CS2/java.txt" 
 
sleep 5
echo ""

echo "Exercise 6"

echo "mv school/lapio/cmd-line.txt school/lapio/command-line.txt"
echo "mv school/CS1/lecture1.txt school/CS1/intro.txt"
echo "mv school/CS2/java.txt school/CS1/lecture2.txt"

sleep 5
echo ""

echo "Exercise 7"

echo "cd .."
echo "rm -rf school"

sleep 5
echo ""

echo "Exercise 8"

echo "mkdir pictures"
echo "Download some pictures the way you want"
echo "touch i_am_a_text_file.txt"
sleep 2
echo "mkdir pictures/subfolder"
echo "mv *.jpg *.png pictures/subfolder/"


sleep 5
echo ""

echo "Exercise 9"

echo "Unix
Linux
macOS
UNiX
unique-unix
unIX
Operating system unix
UNIX
unix
unisport" > file.txt

cat file.txt

echo ""
echo "grep ^L file.txt"

grep ^L file.txt

sleep 5
echo ""

echo "Exercise 10"

echo "monday intro to cs: Hello world
monday cafeteria: Fish shoup
tuesday intro to cs: A class can implement an interface
tuesday intro to cs: Turing tests are hard to pass
tuesday cafeteria: Chicken and noodles
wednesday intro to cs: A cs program has to have a main method
wednesday intro to cs: The internet is a big place
wednesday cafeteria: beans and rice
thursday cafeteria: Potatos and gravy
thursday console: The command line is a black box
friday cafeteria: Pizza" > notes.txt

cat notes.txt

echo ""
echo "grep cafeteria notes.txt > cafeteria.txt"
grep cafeteria notes.txt > cafeteria.txt

sleep 5
echo ""

echo "Exercise 11 CANNOT BE DONE"

echo ""
echo "Exercise 12 CANNOT BE DONE"
echo ""

sleep 5
echo ""

echo "Exercise 13"

echo "touch permission.txt"
echo "chmod u+x permission.txt"
echo "chmod u-x permission.txt"
echo "chmod go-r permission.txt"
echo "..."

sleep 5
echo ""

echo "Exercise 14"

echo "nano script.sh"
echo "write"
echo "echo \"Hello World\""
echo "press CTRL + O to save"
echo "press CTRL + X to exit"
echo "chmod u+x script.sh"
echo "./script.sh"
echo "Hello World"

sleep 10
echo ""

done
