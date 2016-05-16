# Auto Keystrokes

Auto Keystrokes automates a series of keystrokes to eliminate annoying typing rituals. I created this because I attend regular meetings in a joinme conference room, and I have to enter the same 9 digit meeting password every time I join the meeting. This script enters those keys for me now.

You must have Visual Studio to build the project, and you must know the name of the process that you want to enter the keys into. Also, that process will need to be running before you execute Auto Keystrokes. An exception will be thrown if the process cannot be found.

See the `sample-script.bat` file for example usage.

## Future Plans

This project is still very young, this is what I would like to incorporate in the future.

* The ability to enter special characters such as `enter` or `F4`.
* The ability to entering variably sized pauses between keystrokes.
* Better error handling if the process is not found, (maybe run the process in that case).