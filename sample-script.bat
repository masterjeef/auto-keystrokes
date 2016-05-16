:: To run this script you will need to do the following first :
:: 	
::	1. Build the AutoKeystrokes project
:: 	2. Open NotePad
::	

@echo off

:: Path the directory where the AutoKeystrokes.exe file is located
SET exePath=AutoKeystrokes\AutoKeystrokes\bin\Debug

:: The number of milliseconds the wait between entering keys.
SET KeyWait=250

:: The name of the process that the keystrokes should be entered into
:: If you don't know the name of the process then click cntrl + shift+ esc and find the process
SET Process=NotePad

:: The keystrokes to enter
SET Keys=123456789

:: If you have a space in the string, this will also work
:: SET Keys="1234 4567"

cd %exePath%

AutoKeystrokes Process=%Process% Keys=%Keys% KeyWait=%KeyWait%