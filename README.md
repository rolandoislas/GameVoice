GameVoice
=================

GameVoice provides customizable voice activated macros.

## Usage

### Default Commands

#### Smite

GameVoice comes with commands used to activate the Smite Voice Guided System (VGS).

Examples:

- smite execute attack (VAA)
- smite execute defend (VDD)
- smite execute good game (VVGG)

#### Team Fortress 2

GameVoice can be used to activate Team Fortress 2's in-game vocal emotes.

Examples:

- tf2 execute medic (z1)
- tf2 execute thanks (z2)

### Settings

Application settings can be modified by editing `settings.json`. This can be found in the roaming application data `GameVoice` folder, or by navigating to the `Edit Configuration` menu item.

A restart of the application is required to load the new settings.

#### confidenceThreshold

Value: A float between 0.0 and 1.0

This specifies how confident the recognizer must be before a command will be executed.

#### disableLanguageCultureNotification

Value: Boolean

By default GameVoice checks if the language culture en-US is installed. If it is not found, a message will be displayed informing the user which alternative has been used.

If this value is set to `true`, the message will not be displayed.

### Editing Commands

Vocal commands can be modified by editing `commands.json`. This can be found in the roaming application data `GameVoice` folder, or by navigating to the `Edit Commands` menu item.

A restart of the application is required to load the new commands.

#### mainCommand

Value: String

This defines what phrase will prefix all of the commands. This can be left blank.

#### Example Command

The following example will create a command that outputs `vaa` when `*mainCommand* attack` is recognized.

```
...
{
  "text": "attack",
  "command": "vaa"
}
...
```

See [INPUTS.md](INPUTS.md)  for a list of non-alphanumeric inputs.

## License

GameVoice
Copyright (C) 2014 Rolando Islas

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation; either version 2 of the License, or
(at your option) any later version.