@echo off

SET exePath=AutoKeystrokes\AutoKeystrokes\bin\Debug

SET KeyWait=250

SET Process=NotePad

SET Keys=123456789

cd %exePath%

AutoKeystrokes Process=%Process% Keys=%Keys% KeyWait=%KeyWait%