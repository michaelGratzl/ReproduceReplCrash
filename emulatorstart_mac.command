#! /bin/bash

cd /Users/micgra/Library/Developer/Xamarin/android-sdk-macosx/emulator

/Users/micgra/Library/Developer/Xamarin/android-sdk-macosx/emulator/emulator -avd "my_device" -wipe-data &
/Users/micgra/Library/Developer/Xamarin/android-sdk-macosx/platform-tools/adb wait-for-device