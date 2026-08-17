<div align="center">

# 🌐 Fratak Translator

**A cross-platform translation application built with .NET MAUI, focused on multilingual UX, RTL/LTR support, and platform-aware mobile design.**

[![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![.NET MAUI](https://img.shields.io/badge/.NET%20MAUI-Cross--Platform-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/apps/maui)
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![XAML](https://img.shields.io/badge/XAML-UI-0C54C2?style=for-the-badge)](https://learn.microsoft.com/dotnet/maui/)

**[🇬🇧 English](#-english) · [🇮🇷 فارسی](#-فارسی)**

</div>

---

<a id="-english"></a>

# 🇬🇧 English

## Overview

**Fratak Translator** is a cross-platform translation application developed with **.NET MAUI** and **C#**.

The project goes beyond a basic translation screen by combining a shared cross-platform codebase with multilingual language mapping, RTL/LTR-aware UI behavior, adaptive typography, native platform integration, and a focused mobile-first experience.

The goal is simple: provide a clean translation workflow while demonstrating how a real-world .NET MAUI application can handle different languages, writing directions, device characteristics, and platform-specific requirements from a single project.

---

## ✨ What Makes This Project Valuable

This project is particularly focused on the engineering details that become important when a multilingual application moves beyond a simple prototype.

- 🌍 **Multilingual experience** with source and target language selection
- ↔️ **RTL/LTR support** for languages with different writing directions
- 🧩 **Single Project architecture** provided by .NET MAUI
- 📱 **Cross-platform application model** targeting Android, iOS, MacCatalyst, and Windows
- 🎨 **Custom UI resources** including fonts, icons, images, and branding
- 🔤 **Adaptive typography** with device-aware font scaling on Android
- 🔄 **Source/target language switching** for a smoother translation workflow
- 📋 **Copy and share actions** for translated content
- 🌐 **Connectivity-aware translation flow** before making online translation requests
- 🧱 **Platform-specific integration** while keeping the core application inside a shared codebase

---

## 🧭 Translation Flow

```text
┌──────────────────────┐
│ Select Source        │
│ Language             │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│ Enter Text           │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│ Translate            │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│ Display Result       │
└──────────┬───────────┘
           │
      ┌────┴────┐
      ▼         ▼
   Copy       Share
```

The application keeps the primary user journey intentionally compact: **choose languages → enter text → translate → use the result**.

---

## 🏗️ Architecture & Project Structure

The application uses the **.NET MAUI Single Project architecture**, allowing shared application code and UI resources to coexist with platform-specific implementations.

```text
TransletaApp-Maui/
│
├── TransletaApp.sln
├── TransletaApp/
│   ├── App.xaml
│   ├── AppShell.xaml
│   ├── MainPage.xaml
│   ├── MainPage.xaml.cs
│   ├── MauiProgram.cs
│   ├── translateClass.cs
│   │
│   ├── Platforms/
│   │   ├── Android/
│   │   ├── iOS/
│   │   ├── MacCatalyst/
│   │   └── Windows/
│   │
│   ├── Resources/
│   │   ├── AppIcon/
│   │   ├── Fonts/
│   │   ├── Images/
│   │   └── Splash/
│   │
│   └── Properties/
│
└── README.md
```

### Architectural Approach

The project is intentionally built around the capabilities of **.NET MAUI Single Project** rather than introducing unnecessary architectural layers for a focused application of this size.

Key architectural ideas include:

- **Shared UI and application code** through .NET MAUI
- **XAML-based presentation** for the application interface
- **Platform-specific folders** for native platform concerns
- **Central application bootstrapping** through `MauiProgram.cs`
- **Dedicated translation integration** separated from the main UI implementation
- **Resource-based visual design** for fonts, images, icons, and splash assets

This makes the repository a practical example of structuring a cross-platform .NET application without pretending every small application needs seventeen layers of enterprise ceremony. Humanity has suffered enough from that particular hobby.

---

## 🌍 Multilingual & RTL/LTR Design

Multilingual behavior is one of the central engineering concerns of the application.

The language catalogue maps user-facing language names to language codes used by the translation service. When an RTL language is selected, the interface adapts its text alignment and presentation accordingly.

RTL support is implemented for languages including:

- 🇮🇷 Persian
- 🇸🇦 Arabic
- 🇮🇱 Hebrew
- 🇵🇰 Urdu
- 🇦🇫 Pashto

This allows the same application to support both **left-to-right** and **right-to-left** reading experiences without forcing the UI into a single writing direction.

---

## 🛠️ Technology Stack

| Technology | Purpose |
|---|---|
| **C#** | Application and platform logic |
| **.NET 8** | Application runtime and framework |
| **.NET MAUI** | Cross-platform application and UI framework |
| **XAML** | Declarative UI development |
| **Newtonsoft.Json** | JSON serialization and deserialization |
| **MAUI Resources** | Fonts, images, icons, and visual assets |
| **Android / iOS / MacCatalyst / Windows** | Platform targets and native integration |

---

## 📱 Platform Targets

The project is configured for:

- Android
- iOS
- MacCatalyst
- Windows

The project configuration also contains the standard path for enabling Tizen support when the required tooling is installed.

---

## 🎯 Engineering Highlights

### Single Codebase, Multiple Platforms

.NET MAUI allows the application to share its main UI and application logic across multiple operating systems while still providing dedicated platform integration where required.

### RTL-Aware UI

Supporting RTL languages is treated as a first-class UI concern rather than an afterthought. Text alignment and language-dependent presentation are adjusted according to the selected language.

### Adaptive Typography

The application takes Android font scaling into account, helping the interface remain usable across devices with different accessibility and display settings.

### Resource-Driven UI

Custom fonts, icons, images, splash assets, and application branding are integrated through the MAUI resource system, keeping visual assets organized within the Single Project structure.

### Translation Service Integration

Translation requests are handled through a dedicated translation component and serialized JSON responses, keeping the external translation interaction distinct from the visual presentation layer.

---

## ⭐ Support the Project

If you find this project useful, interesting, or helpful as a reference for **.NET MAUI**, consider giving the repository a **⭐ Star**.

A star is a small thing, but apparently developers still use them as a measurable unit of affection. It helps the project get noticed and motivates continued improvement.

---

## 👨‍💻 Author

**Mohammad Amin Nazeri**  
.NET Developer & Software Engineer

This project was designed and developed by **Mohammad Amin Nazeri** as a practical exploration of cross-platform application development with .NET MAUI, multilingual UX, and platform-aware engineering.

<div align="center">

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/mohammad-amin-nazeri)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/Mohammad-Amin-Nazeri)
[![Telegram](https://img.shields.io/badge/Telegram-2CA5E2?style=for-the-badge&logo=telegram&logoColor=white)](https://t.me/Aminn02)
[![Instagram](https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white)](https://www.instagram.com/mohammad_amin_nazeri/)

</div>

---

<a id="-فارسی"></a>

<div dir="rtl">

# 🇮🇷 فارسی

## معرفی پروژه

**Fratak Translator** یک اپلیکیشن ترجمه چندسکویی است که با استفاده از **C#** و **.NET MAUI** توسعه داده شده است.

این پروژه فقط یک صفحه ساده برای ترجمه متن نیست؛ بلکه تلاش می‌کند یک تجربه واقعی از توسعه اپلیکیشن چندزبانه را نشان دهد. انتخاب زبان مبدأ و مقصد، مدیریت زبان‌های مختلف، پشتیبانی از رابط‌های **RTL/LTR**، Typography تطبیقی، منابع گرافیکی اختصاصی و قابلیت اجرای برنامه روی چند پلتفرم، بخش مهمی از ارزش فنی پروژه هستند.

هدف پروژه ساده است: ساخت یک تجربه ترجمه تمیز و کاربردی، در حالی که نشان دهد چگونه می‌توان با یک Codebase مشترک .NET، نیازهای مختلف زبان، دستگاه و پلتفرم را مدیریت کرد.

---

## ✨ ارزش‌های اصلی پروژه

مهم‌ترین بخش پروژه، جزئیاتی است که هنگام تبدیل یک نمونه ساده به یک اپلیکیشن چندزبانه واقعی اهمیت پیدا می‌کنند:

- 🌍 **تجربه چندزبانه** با انتخاب زبان مبدأ و مقصد
- ↔️ **پشتیبانی از RTL/LTR** برای زبان‌هایی با جهت نوشتاری متفاوت
- 🧩 استفاده از **Single Project Architecture** در .NET MAUI
- 📱 اجرای Cross-platform روی Android، iOS، MacCatalyst و Windows
- 🎨 استفاده از **Custom Resources** شامل Font، Icon، Image و Branding
- 🔤 **Typography تطبیقی** و توجه به Font Scale در Android
- 🔄 امکان جابه‌جایی زبان مبدأ و مقصد
- 📋 قابلیت Copy کردن متن ترجمه‌شده
- 📤 قابلیت Share کردن نتیجه ترجمه
- 🌐 بررسی وضعیت اتصال اینترنت پیش از ارسال درخواست ترجمه
- 🧱 استفاده از قابلیت‌های Platform-specific در کنار Codebase مشترک

---

## 🧭 جریان اصلی ترجمه

```text
┌──────────────────────┐
│ انتخاب زبان مبدأ     │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│ ورود متن              │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│ ترجمه                 │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│ نمایش نتیجه           │
└──────────┬───────────┘
           │
      ┌────┴────┐
      ▼         ▼
     کپی      اشتراک‌گذاری
```

مسیر اصلی کاربر عمداً ساده نگه داشته شده است:

**انتخاب زبان ← ورود متن ← ترجمه ← استفاده از نتیجه**

---

## 🏗️ معماری و ساختار پروژه

پروژه از **.NET MAUI Single Project Architecture** استفاده می‌کند. این رویکرد اجازه می‌دهد کدهای مشترک برنامه و رابط کاربری در کنار قابلیت‌های اختصاصی هر پلتفرم مدیریت شوند.

```text
TransletaApp-Maui/
│
├── TransletaApp.sln
├── TransletaApp/
│   ├── App.xaml
│   ├── AppShell.xaml
│   ├── MainPage.xaml
│   ├── MainPage.xaml.cs
│   ├── MauiProgram.cs
│   ├── translateClass.cs
│   │
│   ├── Platforms/
│   │   ├── Android/
│   │   ├── iOS/
│   │   ├── MacCatalyst/
│   │   └── Windows/
│   │
│   ├── Resources/
│   │   ├── AppIcon/
│   │   ├── Fonts/
│   │   ├── Images/
│   │   └── Splash/
│   │
│   └── Properties/
│
└── README.md
```

### رویکرد معماری

برای پروژه‌ای با این اندازه، معماری بر پایه قابلیت‌های **.NET MAUI Single Project** شکل گرفته و از اضافه کردن لایه‌های غیرضروری پرهیز شده است.

مفاهیم اصلی معماری پروژه عبارت‌اند از:

- **Shared UI و Application Code** برای استفاده مجدد در پلتفرم‌های مختلف
- استفاده از **XAML** برای ساخت رابط کاربری
- جداسازی بخش‌های **Platform-specific** در پوشه `Platforms`
- مدیریت راه‌اندازی برنامه از طریق `MauiProgram.cs`
- جدا کردن منطق ارتباط با سرویس ترجمه از رابط کاربری
- مدیریت Font، Image، Icon و Splash از طریق **MAUI Resources**

این ساختار یک نمونه عملی از طراحی یک اپلیکیشن Cross-platform است، بدون اینکه برای یک پروژه کوچک، لایه‌های بی‌پایان و نمودارهای معماری لازم باشد. انسان‌ها واقعاً عاشق این هستند که برای یک صفحه ترجمه، Enterprise Architecture بسازند.

---

## 🌍 طراحی چندزبانه و RTL/LTR

مدیریت رفتار چندزبانه یکی از بخش‌های اصلی پروژه است.

فهرست زبان‌ها، نام قابل نمایش هر زبان را به **Language Code** مربوط به سرویس ترجمه متصل می‌کند. هنگام انتخاب زبان‌های راست‌به‌چپ، رابط کاربری نیز بر اساس جهت نوشتار زبان انتخاب‌شده تغییر می‌کند.

زبان‌های RTL مورد توجه پروژه شامل موارد زیر هستند:

- 🇮🇷 فارسی
- 🇸🇦 عربی
- 🇮🇱 عبری
- 🇵🇰 اردو
- 🇦🇫 پشتو

به این ترتیب یک UI واحد می‌تواند هم برای زبان‌های **LTR** و هم برای زبان‌های **RTL** تجربه مناسبی ارائه کند.

---

## 🛠️ تکنولوژی‌های استفاده‌شده

| تکنولوژی | کاربرد |
|---|---|
| **C#** | منطق برنامه و تعامل با پلتفرم |
| **.NET 8** | Runtime و Framework اصلی |
| **.NET MAUI** | توسعه Cross-platform و رابط کاربری |
| **XAML** | طراحی Declarative رابط کاربری |
| **Newtonsoft.Json** | Serialization و Deserialization داده‌های JSON |
| **MAUI Resources** | Font، Image، Icon و Assetهای گرافیکی |
| **Android / iOS / MacCatalyst / Windows** | Target و Integration پلتفرم‌ها |

---

## 📱 پلتفرم‌های هدف

پروژه برای پلتفرم‌های زیر پیکربندی شده است:

- Android
- iOS
- MacCatalyst
- Windows

همچنین مسیر فعال‌سازی پشتیبانی از **Tizen** نیز در Configuration پروژه وجود دارد و با نصب Tooling موردنیاز قابل فعال‌سازی است.

---

## 🎯 نکات فنی مهم

### یک Codebase برای چند پلتفرم

با استفاده از .NET MAUI، بخش عمده UI و منطق برنامه میان پلتفرم‌های مختلف به صورت مشترک استفاده می‌شود و در صورت نیاز، قابلیت‌های اختصاصی هر پلتفرم نیز در ساختار جداگانه خود قرار می‌گیرند.

### رابط کاربری RTL-Aware

پشتیبانی از زبان‌های راست‌به‌چپ به عنوان بخشی از طراحی UI در نظر گرفته شده و صرفاً یک قابلیت جانبی نیست. Alignment و نحوه نمایش متن بر اساس زبان انتخاب‌شده تغییر می‌کند.

### Typography تطبیقی

پروژه در Android به Font Scale دستگاه توجه می‌کند تا رابط کاربری در شرایط مختلف نمایش و تنظیمات دسترسی‌پذیری، تجربه مناسب‌تری داشته باشد.

### مدیریت منابع بصری

Fontها، Iconها، Imageها، Splash و سایر Assetهای بصری از طریق سیستم Resource در .NET MAUI مدیریت می‌شوند و در ساختار Single Project قرار دارند.

### اتصال به سرویس ترجمه

ارتباط با سرویس ترجمه در یک بخش اختصاصی مدیریت شده و پاسخ‌های JSON نیز به صورت جداگانه Deserialize می‌شوند تا تعامل با سرویس خارجی از بخش نمایش UI تفکیک شود.

---

## ⭐ حمایت از پروژه

اگر این پروژه برایتان جالب، مفید یا آموزشی بود، با دادن یک **⭐ Star** از Repository حمایت کنید.

یک Star کوچک است، اما در دنیای Open Source هنوز یکی از ساده‌ترین راه‌ها برای دیده‌شدن یک پروژه و نشان دادن حمایت از ادامه توسعه آن است.

---

## 👨‍💻 توسعه‌دهنده

**Mohammad Amin Nazeri**  
.NET Developer & Software Engineer

این پروژه توسط **Mohammad Amin Nazeri** با هدف تجربه عملی توسعه Cross-platform با .NET MAUI، طراحی تجربه کاربری چندزبانه و پیاده‌سازی قابلیت‌های Platform-aware توسعه داده شده است.

<div align="center">

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/mohammad-amin-nazeri)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/Mohammad-Amin-Nazeri)
[![Telegram](https://img.shields.io/badge/Telegram-2CA5E2?style=for-the-badge&logo=telegram&logoColor=white)](https://t.me/Aminn02)
[![Instagram](https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white)](https://www.instagram.com/mohammad_amin_nazeri/)

</div>

</div>

---

<div align="center">

**Built with ❤️ and .NET MAUI by Mohammad Amin Nazeri**

⭐ If this project helped you, consider starring the repository.

</div>
