# Emojiscribe
A Node module to describe text using emoji.

The aim of this project is to produce a 'smarter' tool for converting a string of text into an emoji represenation that conveys the same intent as the original.

## Status
Currently in very early stages, this projects consists of nothing more than a basic Node module that returns very little.

Future plans include:
- Emoji keyword direct comparison from input word
- Matching using similar or related words to the input word
- Matching groups of words
- Matching to groups of emoji

## Installation
```console
$ npm install --save emojiscribe
```

## Usage
```javascript
var emojiscribe = require('emojiscribe');
var guardiansEmoji = emojiscribe.describeWithEmoji('Guardians of the Galaxy');
```