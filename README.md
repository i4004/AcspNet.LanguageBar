AcspNet.LanguageBar
===

[AcspNet web-framework](https://github.com/i4004/AcspNet) language bar control

## Package status

| Latest version | [![Nuget version](http://img.shields.io/badge/nuget-v1-blue.png)](https://www.nuget.org/packages/AcspNet.LanguageBar.Sources/) |
| :------ | :------: |
| **Dependencies** | [![NuGet Status](http://nugetstatus.com/AcspNet.LanguageBar.png)](http://nugetstatus.com/packages/AcspNet.LanguageBar) |

## Issues status

| Ready issues |
| :------ |
| [![Stories in Ready](https://badge.waffle.io/i4004/acspnet.languagebar.png?label=ready&title=Ready)](https://waffle.io/i4004/acspnet.languagebar) |

## Build status

| Platform | Status of last build |
| :------ | :------: |
| **.NET (4.5)** | [![AppVeyor build status](https://ci.appveyor.com/api/projects/status/bauvg7g0rkiw6exh/branch/master?svg=true)](https://ci.appveyor.com/project/i4004/acspnet-languagebar) |
| **Mono (3.8.0)** | [![Travis build status](https://travis-ci.org/i4004/AcspNet.LanguageBar.png?branch=master)](https://travis-ci.org/i4004/AcspNet.LanguageBar) |

## Usage

To use language bar simply install it from Nuget and in your template, in most cases in `Master.Tpl` add `{LanguageBar}` variable where language bar should be inserted;

*  In `App_Data/App_Packages/AcspNet.LanguageBar/Languages.en.xml` you can add additional languages;

* In `Templates/App_Packages/AcspNet.LanguageBar/LanguageBar.tpl` you can change language bar template.
