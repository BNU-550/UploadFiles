# Upload Files
This is a Razor Pages example of a service to upload files or images

Based on the YouTube video below by Sameer Saini

[File Upload In Asp.net Core - How To Save A File In C# and ASP.NET Core Razor Pages](https://www.youtube.com/watch?v=hcoKLORWbjY&ab_channel=SameerSaini)

# To use this in your project you need:-
1. Services.IImageUploadService.cs
2. Services.ImageUploadService.cs
3. Index.cshtml
4. A folder in wwwroot called images

You also need to register this service in program.cs
~~~c#
builder.Services.AddRazorPages();
builder.Services.AddScoped<IImageUploadService, ImageUploadService>();
~~~

