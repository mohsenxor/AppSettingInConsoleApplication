# App Settings in .NET Console Application

This project contains four package references:
  1. Microsoft.Extensions.Configuration: Provides the base configuration framework.
  2. Microsoft.Extensions.Configuration.Binder: Allows binding configuration settings to strongly-typed objects.
  3. Microsoft.Extensions.Configuration.Json: Enables reading configuration settings from JSON files.
  4. Microsoft.Extensions.DependencyInjection: Facilitates dependency injection, making it easier to manage dependencies.

In a .NET application, settings are used to store and retrieve configuration data that can be used across different parts of the application.:

## Types of Settings
1. [**Application-Scoped Settings**]:
These settings are read-only at runtime and are typically used for configuration data that does not change, such as connection strings or URLs.
They are stored in the `app.config` file under the `<applicationSettings>` tag.


3. [**User-Scoped Settings**]:
These settings can be read and written at runtime, allowing users to customize their experience.
They are stored in the `user.config` file and can include preferences like window size, theme, or other user-specific data.


## Creating and Managing Settings
•  [**Design Time**]:
We can create and manage settings using the Settings page in the Project Designer in Visual Studio.
Settings can also be bound to properties of forms or controls, allowing for easy access and modification.


•  [**Runtime**]:
We can access and modify settings programmatically using the `Properties.Settings.Default` object in C#.
