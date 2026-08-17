<div align="center">

# 🌐 Fratak Translator

**A cross-platform translation application built with C# and .NET MAUI, focused on multilingual translation, RTL/LTR-aware text input, and a simple mobile-first user experience.**

[![.NET 8](https://img.shields.io/badge/.NET-8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![.NET MAUI](https://img.shields.io/badge/.NET%20MAUI-8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://learn.microsoft.com/dotnet/maui/)
[![C#](https://img.shields.io/badge/C%23-12-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)

**[🇬🇧 English](#english) · [🇮🇷 فارسی](#فارسی)**

</div>

---

<a id="english"></a>

## 🇬🇧 English

### 📖 Overview

**Fratak Translator** is a compact cross-platform translation application built with **C#**, **.NET 8**, and **.NET MAUI**. It provides a focused workflow for entering text, selecting source and target languages, translating through an online service, and copying or sharing the result.

The project is intentionally small and practical. Its current implementation favors a straightforward UI-driven design rather than a large enterprise architecture.

### ✨ Features

- 🌍 Translation between a large predefined set of languages
- 🔄 One-click source/target language switching
- 📝 RTL/LTR-aware text alignment for supported languages
- 🌐 Online translation through `api.codebazan.ir`
- 📋 Copy translated text to the native clipboard
- 📤 Share translated text through the platform sharing API
- 🎞️ Scale and fade animations for the main interaction flow
- 🔤 Custom fonts, icons, images, splash screen, and XAML resources
- 📱 .NET MAUI Single Project structure
- 🖥️ Android, iOS, MacCatalyst, and Windows targets
- ℹ️ Dedicated About page

### 🧭 Translation Flow

```text
Enter text
   ↓
Select source language
   ↓
Select target language
   ↓
Optionally swap languages
   ↓
Check network connectivity
   ↓
Send translation request
   ↓
Deserialize JSON response
   ↓
Display translation
   ↓
Copy or share result
```

### 🏗️ Architecture

The project uses the **.NET MAUI Single Project** model. Shared application code is located in `TransletaApp`, while platform-specific configuration lives under `Platforms/`.

The current codebase should **not** be described as Clean Architecture, Onion Architecture, Hexagonal Architecture, CQRS, or a formal MVVM application. The current implementation is a compact UI-driven application where `MainPage.xaml.cs` coordinates much of the user interaction.

| Area | Responsibility |
| --- | --- |
| `MainPage.xaml` | Main translation UI and layout |
| `MainPage.xaml.cs` | UI events, language selection, RTL/LTR behavior, validation, animations, copy and sharing |
| `translateClass.cs` | Translation HTTP request and JSON response handling |
| `MauiProgram.cs` | Application bootstrap, fonts, and logging |
| `App.xaml` / `AppShell.xaml` | Application resources and navigation |
| `Platforms/` | Android, iOS, MacCatalyst, and Windows integration |
| `Resources/` | Fonts, images, icons, splash screen, and styles |

### 🔧 Implementation Notes

The current source has several deliberate technical characteristics worth documenting:

- Translation integration is implemented as a static helper.
- `HttpClient` is currently created inside the translation helper.
- The translation request currently blocks on `.Result` instead of using a fully asynchronous HTTP flow.
- Translation state is stored in a static property.
- Language names and language codes are maintained in `MainPage.xaml.cs`.
- A dedicated dependency-injection abstraction for translation is not currently present.
- No dedicated unit-test or integration-test project is currently included.

These points describe the current state of the repository and are not presented as enterprise-grade patterns.

### 🧰 Technology Stack

- **C# 12**
- **.NET 8**
- **.NET MAUI 8**
- **XAML**
- **Newtonsoft.Json 13.0.3**
- **Microsoft.Extensions.Logging.Debug 8.0.0**
- Custom fonts including Open Sans and Shabnam
- Remote translation endpoint: `api.codebazan.ir`

### 📱 Supported Platforms

Active target frameworks:

- Android — `net8.0-android`
- iOS — `net8.0-ios`
- MacCatalyst — `net8.0-maccatalyst`
- Windows — `net8.0-windows10.0.19041.0`

Tizen files exist in the repository, but the Tizen target is commented out and is therefore not an active build target.

### 📂 Project Structure

```text
TransletaApp-Maui/
├── TransletaApp.sln
├── TransletaApp/
│   ├── App.xaml
│   ├── App.xaml.cs
│   ├── AppShell.xaml
│   ├── AppShell.xaml.cs
│   ├── MainPage.xaml
│   ├── MainPage.xaml.cs
│   ├── About.xaml
│   ├── About.xaml.cs
│   ├── MauiProgram.cs
│   ├── translateClass.cs
│   ├── TransletaApp.csproj
│   ├── Platforms/
│   │   ├── Android/
│   │   ├── iOS/
│   │   ├── MacCatalyst/
│   │   ├── Windows/
│   │   └── Tizen/
│   └── Resources/
│       ├── AppIcon/
│       ├── Fonts/
│       ├── Images/
│       ├── Raw/
│       ├── Splash/
│       └── Styles/
├── Translate.keystore
├── .gitignore
└── README.md
```

### 🚀 Getting Started

#### Prerequisites

Install:

- Visual Studio with the **.NET MAUI** workload, or an equivalent .NET 8 MAUI development environment
- .NET 8 SDK
- The platform SDKs/emulators required by your target platform

#### Clone

```bash
git clone https://github.com/Mohammad-Amin-Nazeri/TransletaApp-Maui.git
cd TransletaApp-Maui
```

Open `TransletaApp.sln` in Visual Studio, restore dependencies, select a supported MAUI target, and run the application.

For example, an Android build can be started with:

```bash
dotnet restore
dotnet build TransletaApp/TransletaApp.csproj -f net8.0-android
```

The exact command can vary according to the installed MAUI workloads and operating system.

### 🔐 Security Notice

The repository currently contains an Android signing keystore and signing configuration in source control. This should **not** be considered a secure production signing setup.

Before a real release:

1. Remove signing credentials from source-controlled project configuration.
2. Treat exposed signing credentials as compromised and rotate/regenerate them where applicable.
3. Store signing material through secure local configuration or CI/CD secrets.
4. Keep keystores and credentials out of normal source control.

The credentials themselves are intentionally not documented here.

### ⚠️ Current Limitations

For a production-oriented application, the following areas should be addressed:

- Replace the static translation helper with an injectable service.
- Replace blocking `.Result` calls with `async/await`.
- Reuse `HttpClient` through dependency injection.
- Move language metadata out of the page code-behind.
- Introduce MVVM if the UI continues to grow.
- Add explicit error handling and meaningful API failure states.
- Add request timeout and cancellation support.
- Move the API endpoint into appropriate configuration.
- Add unit and integration tests.
- Improve accessibility and localization.
- Establish a secure release and signing process.

### 🗺️ Roadmap

#### Stability

- [ ] Fully asynchronous translation requests
- [ ] HTTP timeout and cancellation
- [ ] Structured error handling
- [ ] Reusable `HttpClient`

#### Architecture

- [ ] Introduce `ITranslationService`
- [ ] Extract translation models
- [ ] Extract language metadata
- [ ] Reduce logic in `MainPage.xaml.cs`
- [ ] Introduce MVVM when justified by UI complexity

#### Quality

- [ ] Unit tests for language mapping
- [ ] Unit tests for request/response handling
- [ ] Integration tests around the translation abstraction
- [ ] CI build validation with GitHub Actions
- [ ] Static analysis and formatting rules

#### Production

- [ ] Secure Android signing
- [ ] Configuration and environment separation
- [ ] Versioning and release strategy
- [ ] Accessibility and localization improvements
- [ ] API failure and availability documentation

### 🧪 Testing

There is currently **no dedicated test project** in the repository.

The first tests should cover:

- Language name → language code mapping
- RTL/LTR behavior
- Translation request construction
- JSON response deserialization
- Network/API failures
- Timeout and cancellation
- Empty or invalid input

### 🤝 Contributing

Technical feedback and focused contributions are welcome. Changes should remain scoped, explain their purpose, and preserve buildability for the intended MAUI targets.

### 📄 License

No license file is currently present in the repository. Until a license is explicitly added, the source code should not be assumed to be freely reusable, modified, or redistributed.

### 👨‍💻 Author

**Mohammad Amin Nazeri**

<p>
<a href="https://github.com/Mohammad-Amin-Nazeri"><img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub"></a>
<a href="https://www.linkedin.com/in/mohammad-amin-nazeri"><img src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white" alt="LinkedIn"></a>
<a href="https://t.me/Aminn02"><img src="https://img.shields.io/badge/Telegram-2CA5E2?style=for-the-badge&logo=telegram&logoColor=white" alt="Telegram"></a>
<a href="https://www.instagram.com/mohammad_amin_nazeri/"><img src="https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white" alt="Instagram"></a>
</p>

---

<a id="فارسی"></a>

<div dir="rtl">

## 🇮🇷 فارسی

### 📖 معرفی

**Fratak Translator** یک اپلیکیشن ترجمه چندسکویی است که با **C#، .NET 8 و .NET MAUI** توسعه داده شده است. برنامه یک جریان ساده برای ورود متن، انتخاب زبان مبدأ و مقصد، دریافت ترجمه آنلاین و سپس کپی یا اشتراک‌گذاری نتیجه فراهم می‌کند.

پروژه در وضعیت فعلی عمداً کوچک و عملی است و به جای معماری پیچیده Enterprise، از یک ساختار مستقیم و UI-driven استفاده می‌کند.

### ✨ قابلیت‌ها

- 🌍 ترجمه میان مجموعه بزرگی از زبان‌های تعریف‌شده
- 🔄 جابه‌جایی زبان مبدأ و مقصد
- 📝 پشتیبانی از جهت متن RTL/LTR
- 🌐 اتصال به `api.codebazan.ir`
- 📋 کپی ترجمه در Clipboard
- 📤 اشتراک‌گذاری ترجمه با API بومی پلتفرم
- 🎞️ انیمیشن‌های Scale و Fade
- 🔤 Font، Icon، Image، Splash و XAML Resourceهای اختصاصی
- 📱 استفاده از .NET MAUI Single Project
- 🖥️ پشتیبانی از Android، iOS، MacCatalyst و Windows
- ℹ️ صفحه About

### 🧭 جریان ترجمه

```text
ورود متن
   ↓
انتخاب زبان مبدأ
   ↓
انتخاب زبان مقصد
   ↓
جابه‌جایی اختیاری زبان‌ها
   ↓
بررسی اتصال اینترنت
   ↓
ارسال درخواست ترجمه
   ↓
Deserialize پاسخ JSON
   ↓
نمایش ترجمه
   ↓
کپی یا اشتراک‌گذاری
```

### 🏗️ معماری

پروژه از مدل **.NET MAUI Single Project** استفاده می‌کند. کد مشترک در پروژه `TransletaApp` قرار دارد و فایل‌های اختصاصی پلتفرم در `Platforms/` نگهداری می‌شوند.

Codebase فعلی را نباید **Clean Architecture، Onion Architecture، Hexagonal Architecture، CQRS یا MVVM رسمی** معرفی کرد. در وضعیت فعلی بخش قابل توجهی از رفتار برنامه در `MainPage.xaml.cs` مدیریت می‌شود.

| بخش | مسئولیت |
| --- | --- |
| `MainPage.xaml` | رابط کاربری اصلی ترجمه |
| `MainPage.xaml.cs` | Eventها، انتخاب زبان، RTL/LTR، Validation، Animation، Copy و Sharing |
| `translateClass.cs` | درخواست HTTP ترجمه و Deserialize پاسخ JSON |
| `MauiProgram.cs` | Bootstrap برنامه، Fontها و Logging |
| `App.xaml` / `AppShell.xaml` | Resourceها و Navigation |
| `Platforms/` | Integration اختصاصی پلتفرم‌ها |
| `Resources/` | Font، Image، Icon، Splash و Style |

### 🔧 وضعیت پیاده‌سازی فعلی

بررسی Source Code نشان می‌دهد:

- Translation Integration به صورت Static Helper پیاده‌سازی شده است.
- `HttpClient` داخل Translation Helper ساخته می‌شود.
- درخواست HTTP با `.Result` به صورت Blocking اجرا می‌شود.
- نتیجه ترجمه در یک Property استاتیک نگهداری می‌شود.
- Language Codeها داخل `MainPage.xaml.cs` قرار دارند.
- Abstraction اختصاصی و قابل تزریق برای Translation Service وجود ندارد.
- پروژه تست مستقل Unit/Integration ندارد.

این موارد صرفاً توصیف وضعیت فعلی پروژه هستند و ادعای معماری Enterprise محسوب نمی‌شوند.

### 🧰 تکنولوژی‌ها

- **C# 12**
- **.NET 8**
- **.NET MAUI 8**
- **XAML**
- **Newtonsoft.Json 13.0.3**
- **Microsoft.Extensions.Logging.Debug 8.0.0**
- Fontهای اختصاصی از جمله Open Sans و Shabnam
- Translation Endpoint: `api.codebazan.ir`

### 📱 پلتفرم‌ها

Targetهای فعال پروژه:

- Android — `net8.0-android`
- iOS — `net8.0-ios`
- MacCatalyst — `net8.0-maccatalyst`
- Windows — `net8.0-windows10.0.19041.0`

فایل‌های Tizen در Repository وجود دارند، اما Target مربوط به آن Comment شده و در Build فعلی فعال نیست.

### 📂 ساختار پروژه

```text
TransletaApp-Maui/
├── TransletaApp.sln
├── TransletaApp/
│   ├── App.xaml
│   ├── App.xaml.cs
│   ├── AppShell.xaml
│   ├── AppShell.xaml.cs
│   ├── MainPage.xaml
│   ├── MainPage.xaml.cs
│   ├── About.xaml
│   ├── About.xaml.cs
│   ├── MauiProgram.cs
│   ├── translateClass.cs
│   ├── TransletaApp.csproj
│   ├── Platforms/
│   │   ├── Android/
│   │   ├── iOS/
│   │   ├── MacCatalyst/
│   │   ├── Windows/
│   │   └── Tizen/
│   └── Resources/
│       ├── AppIcon/
│       ├── Fonts/
│       ├── Images/
│       ├── Raw/
│       ├── Splash/
│       └── Styles/
├── Translate.keystore
├── .gitignore
└── README.md
```

### 🚀 راه‌اندازی

#### پیش‌نیازها

- Visual Studio با Workload مربوط به **.NET MAUI** یا محیط سازگار با .NET 8 و MAUI
- .NET 8 SDK
- SDK/Emulator موردنیاز برای پلتفرم هدف

#### Clone

```bash
git clone https://github.com/Mohammad-Amin-Nazeri/TransletaApp-Maui.git
cd TransletaApp-Maui
```

فایل `TransletaApp.sln` را در Visual Studio باز کنید، Dependencyها را Restore کرده و Target موردنظر را اجرا کنید.

نمونه Build برای Android:

```bash
dotnet restore
dotnet build TransletaApp/TransletaApp.csproj -f net8.0-android
```

دستور دقیق Build می‌تواند بر اساس سیستم‌عامل و Workloadهای نصب‌شده متفاوت باشد.

### 🔐 هشدار امنیتی

Repository در حال حاضر شامل Android Keystore و تنظیمات Signing در Source Control است. این وضعیت برای Production امن محسوب نمی‌شود.

پیش از Release واقعی باید:

1. Credentialهای Signing از Configuration موجود در Source Control حذف شوند.
2. Credentialهای افشاشده در صورت استفاده واقعی، Compromised در نظر گرفته شده و Rotate/Regenerate شوند.
3. Keystore و Secretها از طریق Secret Management محلی یا CI/CD نگهداری شوند.
4. فایل‌های حساس از Source Control خارج شوند.

Credentialها عمداً در این README نمایش داده نشده‌اند.

### ⚠️ محدودیت‌های فعلی

برای Production شدن پروژه، این موارد پیشنهاد می‌شوند:

- جایگزینی Static Helper با Translation Service قابل تزریق
- حذف `.Result` و استفاده کامل از `async/await`
- مدیریت صحیح و Reuse کردن `HttpClient`
- انتقال Language Metadata خارج از Code-behind
- استفاده از MVVM در صورت افزایش پیچیدگی UI
- Error Handling ساختاریافته
- Timeout و Cancellation برای درخواست‌های شبکه
- انتقال API Endpoint به Configuration مناسب
- اضافه کردن Unit و Integration Test
- بهبود Accessibility و Localization
- ایجاد Release و Signing Strategy امن

### 🗺️ Roadmap

#### پایداری

- [ ] درخواست‌های کاملاً Async
- [ ] Timeout و Cancellation
- [ ] Error Handling ساختاریافته
- [ ] Reuse کردن `HttpClient`

#### معماری

- [ ] ایجاد `ITranslationService`
- [ ] استخراج Translation Modelها
- [ ] استخراج Language Metadata
- [ ] کاهش Logic در `MainPage.xaml.cs`
- [ ] اضافه کردن MVVM در صورت نیاز

#### کیفیت

- [ ] Unit Test برای Language Mapping
- [ ] Unit Test برای Request/Response
- [ ] Integration Test برای Translation Abstraction
- [ ] GitHub Actions برای Build Validation
- [ ] Static Analysis و Formatting Rules

#### Production

- [ ] امن‌سازی Android Signing
- [ ] جداسازی Configuration محیط‌ها
- [ ] Versioning و Release Strategy
- [ ] بهبود Accessibility و Localization
- [ ] مستندسازی Failure Caseهای API

### 🧪 تست

در حال حاضر **پروژه تست مستقلی در Repository وجود ندارد**.

تست‌های اولیه پیشنهادی:

- Mapping نام زبان به Language Code
- رفتار RTL/LTR
- ساخت Translation Request
- Deserialize پاسخ JSON
- مدیریت Network/API Failure
- Timeout و Cancellation
- Input خالی یا نامعتبر

### 🤝 مشارکت

Contribution و بازخورد فنی قابل استقبال است. بهتر است تغییرات Scope مشخص داشته باشند، دلیل آن‌ها توضیح داده شود و Build برای Target موردنظر حفظ شود.

### 📄 License

در حال حاضر فایل License در Repository وجود ندارد. تا زمانی که License مشخصی اضافه نشده، نباید فرض کرد Source Code آزادانه قابل استفاده، تغییر یا بازتوزیع است.

### 👨‍💻 توسعه‌دهنده

**Mohammad Amin Nazeri**

<p>
<a href="https://github.com/Mohammad-Amin-Nazeri"><img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub"></a>
<a href="https://www.linkedin.com/in/mohammad-amin-nazeri"><img src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white" alt="LinkedIn"></a>
<a href="https://t.me/Aminn02"><img src="https://img.shields.io/badge/Telegram-2CA5E2?style=for-the-badge&logo=telegram&logoColor=white" alt="Telegram"></a>
<a href="https://www.instagram.com/mohammad_amin_nazeri/"><img src="https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white" alt="Instagram"></a>
</p>

</div>
