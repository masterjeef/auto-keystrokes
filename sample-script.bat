@echo off

SET exePath=AutoKeystrokes\AutoKeystrokes\bin\Debug

SET KeyWait=1000

SET Process=NotePad

SET Keys=12345

cd %exePath%

AutoKeystrokes Process=%Process% Keys=%Keys% KeyWait=%KeyWait%