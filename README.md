# PhoneGap DevExtremeAddon plugin

This plugin setups the CordovaView in the WindowPhone application.

This plug-in adds the following features:

1. Set up the orientation for the application because in 'config.xml' is not working for the WindowsPhone application.
 
2. Set up the 'SystemTray.IsVisble' property.
 
3. Add the ExitApp dispatcher for our JS framework (for support cordova-3.3.0 where there was an issue with closing an application).

## Using the plugin ##
The plugin creates the object `window/devextremeaddon` with the method `setup()`. 

A full example could be:
```
   window.devextremeaddon.setup();
```

## Licence ##

[The MIT License (MIT)](http://www.opensource.org/licenses/mit-license.html)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
