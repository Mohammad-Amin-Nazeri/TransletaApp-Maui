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

### Overview

**Fratak Translator** is a .NET MAUI application for translating text between a broad set of supported languages through an online translation endpoint.

The application combines a shared .NET MAUI UI with platform-specific project infrastructure and provides language selection, language swapping, RTL/LTR-aware text alignment, translation results, copy, sharing, and UI animations.

### Key Features

- 🌍 Source and target language selection with a built-in language-code map
- 🔄 One-click source/target language switching
- 📝 Text input with RTL/LTR alignment based on the selected language
- 🌐 Online translation through the `api.codebazan.ir` translation endpoint
- 📋 Copy translated text to the clipboard
- 📤 Share translated text through the platform sharing API
- 🎞️ Scale and fade animations for the main interaction flow
- 🔤 Custom fonts and MAUI image, icon, splash, and style resources
- 📱 Shared application code with platform-specific MAUI startup and manifest files

### Architecture

The repository uses the **.NET MAUI Single Project** model. Shared UI and application logic live in the main `TransletaApp` project, while platform-specific files are kept under `Platforms/`.

This is **not** a Clean Architecture, layered architecture, MVVM, or multi-project domain/application/infrastructure solution. The current codebase is a relatively compact UI-driven application in which event handlers in `MainPage.xaml.cs` coordinate the translation workflow and UI state.

The main technical boundaries are:

- **Presentation / UI:** XAML views and code-behind in `MainPage.xaml` and `MainPage.xaml.cs`
- **Translation integration:** the static `translateClass` helper, which builds the translation request, calls the remote endpoint, and deserializes the JSON response
- **Application bootstrap:** `MauiProgram.cs`, responsible for creating the MAUI application, registering fonts, and enabling debug logging
- **Platform layer:** Android, iOS, MacCatalyst, and Windows platform files under `Platforms/`
- **Resources:** fonts, images, SVG assets, splash resources, and shared XAML styles

### Technical Patterns & Practices

Only patterns and practices that are directly visible in the codebase are listed here:

| Area | Implementation |
| --- | --- |
| Cross-platform UI | .NET MAUI Single Project with shared XAML/C# |
| Event-driven UI | XAML control events handled in `MainPage.xaml.cs` |
| Platform integration | MAUI platform folders for Android, iOS, MacCatalyst, and Windows |
| Resource-based styling | MAUI `Resources` with XAML styles, fonts, images, icons, and splash assets |
| JSON serialization | `Newtonsoft.Json` for translation response deserialization |
| Connectivity check | `Connectivity.Current.NetworkAccess` before translation |
| Async UI operations | MAUI animation, clipboard, sharing, and navigation APIs |

There is **no dedicated dependency-injection abstraction for the translation service**, repository layer, unit-of-work, CQRS/Mediator pipeline, or formal MVVM layer in the current implementation.

### Technology Stack

- **C#**
- **.NET 8**
- **.NET MAUI**
- **XAML**
- **Newtonsoft.Json 13.0.3**
- **Microsoft.Extensions.Logging.Debug 8.0.0**
- Custom fonts including Open Sans and Shabnam
- Platform targets configured for Android, iOS, MacCatalyst, and Windows

Tizen-specific platform files are present in the repository, but the Tizen target is currently commented out in the project file, so it is not part of the active target framework list.

### Project Structure

```text
TransletaApp-Maui/
├── TransletaApp.sln
├── TransletaApp/
│   ├── App.xaml / App.xaml.cs
│   ├── AppShell.xaml / AppShell.xaml.cs
│   ├── MainPage.xaml / MainPage.xaml.cs
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
└── README.md
```

### Engineering Notes

The codebase demonstrates practical cross-platform UI development, but it is intentionally small and currently has a direct application-to-translation-endpoint flow rather than a heavily abstracted architecture.

A notable repository-level concern is that the project currently contains an Android signing keystore and signing credentials in the project configuration. This is a security issue that should be addressed separately from the documentation. The README does not document or reproduce those credentials.

No unit-test or integration-test project is present in the repository at the time of this documentation update.

### ⭐ Support

If this project is useful or interesting, consider giving the repository a **⭐ Star**.

### Author

**Mohammad Amin Nazeri**

<p>
<a href="https://www.linkedin.com/in/mohammad-amin-nazeri"><img src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white" alt="LinkedIn"></a>
<a href="https://github.com/Mohammad-Amin-Nazeri"><img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub"></a>
<a href="https://t.me/Aminn02"><img src="https://img.shields.io/badge/Telegram-2CA5E2?style=for-the-badge&logo=telegram&logoColor=white" alt="Telegram"></a>
<a href="https://www.instagram.com/mohammad_amin_nazeri/"><img src="https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white" alt="Instagram"></a>
</p>

---

<a id="فارسی"></a>

<div dir="rtl">

## 🇮🇷 فارسی

### معرفی

**Fratak Translator** یک اپلیکیشن ترجمه مبتنی بر **.NET MAUI** است که برای ترجمه متن میان مجموعه گسترده‌ای از زبان‌های پشتیبانی‌شده از طریق یک سرویس ترجمه آنلاین توسعه داده شده است.

برنامه یک رابط کاربری مشترک در .NET MAUI را با زیرساخت‌های اختصاصی پلتفرم ترکیب می‌کند و قابلیت‌هایی مانند انتخاب زبان، جابه‌جایی زبان‌ها، تشخیص جهت متن RTL/LTR، نمایش نتیجه ترجمه، کپی، اشتراک‌گذاری و انیمیشن‌های رابط کاربری را ارائه می‌دهد.

### قابلیت‌های اصلی

- 🌍 انتخاب زبان مبدأ و مقصد با نگاشت داخلی نام زبان به کد زبان
- 🔄 جابه‌جایی سریع زبان مبدأ و مقصد
- 📝 ورود متن با تنظیم جهت و تراز RTL/LTR بر اساس زبان انتخاب‌شده
- 🌐 اتصال به سرویس ترجمه آنلاین `api.codebazan.ir`
- 📋 کپی متن ترجمه‌شده در Clipboard
- 📤 اشتراک‌گذاری متن ترجمه‌شده با API اشتراک‌گذاری پلتفرم
- 🎞️ استفاده از انیمیشن‌های Scale و Fade در جریان اصلی رابط کاربری
- 🔤 استفاده از Fontهای اختصاصی و Resourceهای مربوط به تصویر، آیکون، Splash و Style
- 📱 کد مشترک برنامه در کنار فایل‌های اختصاصی پلتفرم در ساختار MAUI

### معماری

Repository از مدل **.NET MAUI Single Project** استفاده می‌کند. رابط کاربری و منطق اصلی برنامه در پروژه `TransletaApp` قرار دارند و فایل‌های اختصاصی پلتفرم‌ها در پوشه `Platforms/` نگهداری می‌شوند.

این پروژه در وضعیت فعلی **Clean Architecture، معماری لایه‌ای، MVVM یا ساختار چندپروژه‌ای Domain/Application/Infrastructure** ندارد. معماری فعلی یک برنامه نسبتاً کوچک و UI-driven است که در آن Event Handlerهای `MainPage.xaml.cs` جریان ترجمه و وضعیت رابط کاربری را مدیریت می‌کنند.

مرزبندی‌های فنی اصلی پروژه عبارت‌اند از:

- **Presentation / UI:** فایل‌های XAML و Code-behind در `MainPage.xaml` و `MainPage.xaml.cs`
- **Translation Integration:** کلاس static با نام `translateClass` که درخواست ترجمه را می‌سازد، Endpoint آنلاین را فراخوانی می‌کند و پاسخ JSON را Deserialize می‌کند
- **Application Bootstrap:** فایل `MauiProgram.cs` برای ساخت برنامه MAUI، ثبت Fontها و فعال‌سازی Debug Logging
- **Platform Layer:** فایل‌های اختصاصی Android، iOS، MacCatalyst و Windows در `Platforms/`
- **Resources:** Font، Image، SVG، Splash و Styleهای XAML در پوشه `Resources/`

### الگوها و شیوه‌های فنی

در این بخش فقط مواردی معرفی شده‌اند که مستقیماً در Codebase قابل مشاهده هستند:

| حوزه | پیاده‌سازی |
| --- | --- |
| رابط کاربری Cross-platform | .NET MAUI Single Project با XAML و C# مشترک |
| رابط کاربری Event-driven | مدیریت رویدادهای کنترل‌ها در `MainPage.xaml.cs` |
| Platform Integration | ساختار Platform-specific برای Android، iOS، MacCatalyst و Windows |
| Resource-based Styling | استفاده از `Resources` برای Style، Font، Image، Icon و Splash |
| JSON Serialization | استفاده از `Newtonsoft.Json` برای Deserialize پاسخ ترجمه |
| بررسی اتصال | استفاده از `Connectivity.Current.NetworkAccess` پیش از ترجمه |
| عملیات UI غیرهمزمان | استفاده از APIهای MAUI برای Animation، Clipboard، Sharing و Navigation |

در پیاده‌سازی فعلی **Abstraction اختصاصی برای سرویس ترجمه، Repository، Unit of Work، CQRS/Mediator یا لایه رسمی MVVM** وجود ندارد.

### تکنولوژی‌ها

- **C#**
- **.NET 8**
- **.NET MAUI**
- **XAML**
- **Newtonsoft.Json 13.0.3**
- **Microsoft.Extensions.Logging.Debug 8.0.0**
- Fontهای اختصاصی از جمله Open Sans و Shabnam
- Targetهای فعال برای Android، iOS، MacCatalyst و Windows

فایل‌های اختصاصی Tizen در Repository وجود دارند، اما Target مربوط به Tizen در فایل پروژه Comment شده است؛ بنابراین در Target Frameworkهای فعال پروژه قرار ندارد.

### ساختار پروژه

```text
TransletaApp-Maui/
├── TransletaApp.sln
├── TransletaApp/
│   ├── App.xaml / App.xaml.cs
│   ├── AppShell.xaml / AppShell.xaml.cs
│   ├── MainPage.xaml / MainPage.xaml.cs
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
└── README.md
```

### نکات مهندسی

این Codebase نمونه‌ای عملی از توسعه Cross-platform با .NET MAUI و ساخت یک رابط کاربری ترجمه را ارائه می‌کند، اما ساختار فعلی عمداً کوچک است و جریان ترجمه مستقیماً از برنامه به Endpoint ترجمه متصل می‌شود و Abstractionهای سنگین ندارد.

یک نکته مهم در سطح Repository این است که فایل Keystore اندروید و اطلاعات مربوط به Signing در پروژه قرار گرفته‌اند. این موضوع یک مشکل امنیتی محسوب می‌شود و باید جداگانه اصلاح شود. در این README هیچ Credential یا اطلاعات حساس Signing بازنویسی نشده است.

در زمان این به‌روزرسانی، پروژه جداگانه‌ای برای Unit Test یا Integration Test در Repository وجود ندارد.

### ⭐ حمایت از پروژه

اگر پروژه برایتان مفید یا جالب بود، با دادن یک **⭐ Star** از Repository حمایت کنید.

### نویسنده

**Mohammad Amin Nazeri**

<p>
<a href="https://www.linkedin.com/in/mohammad-amin-nazeri"><img src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white" alt="LinkedIn"></a>
<a href="https://github.com/Mohammad-Amin-Nazeri"><img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub"></a>
<a href="https://t.me/Aminn02"><img src="https://img.shields.io/badge/Telegram-2CA5E2?style=for-the-badge&logo=telegram&logoColor=white" alt="Telegram"></a>
<a href="https://www.instagram.com/mohammad_amin_nazeri/"><img src="https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white" alt="Instagram"></a>
</p>

</div>

---

<div align="center">

⭐ **If you find the project useful or interesting, consider starring the repository.**

</div>
