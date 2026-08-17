<div align="center">

# Fratak Translator

**A cross-platform .NET MAUI translation application with multi-language selection, RTL/LTR support, copy/share actions, and adaptive mobile UI.**

[![.NET MAUI](https://img.shields.io/badge/.NET%20MAUI-8-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/apps/maui)
[![Android](https://img.shields.io/badge/Android-Supported-3DDC84?logo=android&logoColor=white)](https://developer.android.com/)
[![Windows](https://img.shields.io/badge/Windows-Supported-0078D4?logo=windows&logoColor=white)](https://www.microsoft.com/windows)

<a href="#english"><strong>🇬🇧 English</strong></a> &nbsp;•&nbsp; <a href="#فارسی"><strong>🇮🇷 فارسی</strong></a>

</div>

---

<a id="english"></a>

# 🇬🇧 English

## Overview

Fratak Translator is a .NET MAUI application built around a simple translation workflow: select a source and target language, enter text, translate it, then copy or share the result.

The application is designed for multilingual use and pays particular attention to languages that require right-to-left text presentation. The UI dynamically adjusts text alignment and supports a large language catalogue through language-code mapping.

## User Experience

```text
Select Source Language
        │
        ▼
   Enter Text
        │
        ▼
     Translate
        │
        ▼
 Show Translated Text
      /       \
    Copy     Share
```

The application also adapts its typography to the device font scale on Android and includes dedicated visual assets and fonts for the Persian-oriented interface.

## Key Features

- Multi-language source/target selection
- Language-code mapping for translation requests
- Source/target language switching
- RTL support for Persian, Arabic, Hebrew, Urdu, and Pashto
- Online connectivity detection before translation
- Copy translated text
- Share translated text
- Adaptive font sizing on Android
- About/application information screen
- Custom branding and Persian UI typography

## Platform Architecture

The project uses the standard .NET MAUI single-project structure:

```text
TransletaApp/
├── App.xaml / App.xaml.cs
├── AppShell.xaml / AppShell.xaml.cs
├── MainPage.xaml
├── MainPage.xaml.cs
├── MauiProgram.cs
├── Resources/
└── Platforms/
    ├── Android/
    ├── iOS/
    ├── MacCatalyst/
    ├── Windows/
    └── Tizen/
```

The application targets Android, iOS, MacCatalyst, and Windows, with Tizen support represented in the project configuration.

## Localization & RTL Design

One of the defining characteristics of the application is its explicit treatment of multilingual UI behavior. The language catalogue maps display names to language codes, while the UI switches text alignment when a right-to-left language is selected.

This keeps the translation experience usable for both Latin-script and RTL languages rather than assuming a single writing direction.

## Technology Stack

- C#
- .NET 8
- .NET MAUI
- XAML
- Newtonsoft.Json
- Custom fonts and MAUI resources
- Platform-specific Android, iOS, MacCatalyst, Windows, and Tizen components

## Engineering Value

The project demonstrates how a single .NET codebase can combine a shared cross-platform UI with platform-specific integrations while still handling a multilingual user experience.

Its strongest engineering aspects are the single-project MAUI structure, explicit language mapping, RTL/LTR behavior, adaptive typography, and platform-aware application setup.

## Author

**Mohammad Amin Nazeri**

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/mohammad-amin-nazeri)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/Mohammad-Amin-Nazeri)
[![Telegram](https://img.shields.io/badge/Telegram-2CA5E2?style=for-the-badge&logo=telegram&logoColor=white)](https://t.me/Aminn02)
[![Instagram](https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white)](https://www.instagram.com/mohammad_amin_nazeri/)

---

<a id="فارسی"></a>

# 🇮🇷 فارسی

## معرفی

Fratak Translator یک اپلیکیشن ترجمه مبتنی بر .NET MAUI است که فرآیند انتخاب زبان مبدأ و مقصد، ورود متن، ترجمه، کپی و اشتراک‌گذاری نتیجه را در یک رابط کاربری یکپارچه ارائه می‌کند.

پروژه برای استفاده چندزبانه طراحی شده و توجه ویژه‌ای به زبان‌های راست‌به‌چپ دارد. فهرست زبان‌ها از طریق Mapping نام زبان به Language Code مدیریت می‌شود و رابط کاربری بر اساس زبان انتخاب‌شده جهت متن را تغییر می‌دهد.

## جریان اصلی برنامه

```text
انتخاب زبان مبدأ
        │
        ▼
     ورود متن
        │
        ▼
       ترجمه
        │
        ▼
   نمایش نتیجه
     /       \
   کپی      اشتراک‌گذاری
```

در Android اندازه فونت بر اساس Font Scale دستگاه نیز تطبیق داده می‌شود و پروژه از Font و Assetهای اختصاصی برای رابط فارسی استفاده می‌کند.

## قابلیت‌ها

- انتخاب زبان مبدأ و مقصد
- Mapping زبان‌ها به Language Code
- جابه‌جایی زبان مبدأ و مقصد
- پشتیبانی RTL برای فارسی، عربی، عبری، اردو و پشتو
- بررسی اتصال اینترنت قبل از ترجمه
- Copy متن ترجمه‌شده
- Share نتیجه ترجمه
- تطبیق اندازه فونت در Android
- صفحه About
- Branding و Typography فارسی

## ساختار

```text
TransletaApp/
├── App.xaml / App.xaml.cs
├── AppShell.xaml / AppShell.xaml.cs
├── MainPage.xaml
├── MainPage.xaml.cs
├── MauiProgram.cs
├── Resources/
└── Platforms/
    ├── Android/
    ├── iOS/
    ├── MacCatalyst/
    ├── Windows/
    └── Tizen/
```

پروژه از ساختار Single Project در .NET MAUI استفاده می‌کند و Targetهای Android، iOS، MacCatalyst و Windows را دارد و پشتیبانی Tizen نیز در Configuration پروژه دیده می‌شود.

## Localization و RTL

یکی از ویژگی‌های شاخص برنامه، مدیریت صریح رفتار UI برای زبان‌های مختلف است. نام قابل نمایش زبان‌ها به Language Code تبدیل می‌شود و در زمان انتخاب زبان‌های RTL، Text Alignment رابط تغییر می‌کند.

به این ترتیب UI به یک جهت نوشتاری محدود نیست و تجربه ترجمه برای زبان‌های لاتین و راست‌به‌چپ را پوشش می‌دهد.

## تکنولوژی‌ها

- C#
- .NET 8
- .NET MAUI
- XAML
- Newtonsoft.Json
- Custom Fonts و MAUI Resources
- Componentهای اختصاصی Android، iOS، MacCatalyst، Windows و Tizen

## ارزش فنی پروژه

این پروژه نشان می‌دهد چگونه می‌توان با یک Codebase مشترک .NET، رابط کاربری Cross-platform ساخت و در عین حال رفتارهای Platform-specific و نیازهای یک تجربه چندزبانه را مدیریت کرد.

نقاط قوت اصلی آن Single Project Architecture در MAUI، Language Mapping، مدیریت RTL/LTR، Typography تطبیقی و ساختار Platform-aware برنامه است.

## توسعه‌دهنده

**Mohammad Amin Nazeri**

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/mohammad-amin-nazeri)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/Mohammad-Amin-Nazeri)
[![Telegram](https://img.shields.io/badge/Telegram-2CA5E2?style=for-the-badge&logo=telegram&logoColor=white)](https://t.me/Aminn02)
[![Instagram](https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white)](https://www.instagram.com/mohammad_amin_nazeri/)
