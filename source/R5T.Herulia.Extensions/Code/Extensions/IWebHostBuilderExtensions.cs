﻿using System;
using System.IO;

using Microsoft.AspNetCore.Hosting;


namespace R5T.Herulia.Extensions
{
    public static class IWebHostBuilderExtensions
    {
        public static IWebHostBuilder UseDefaultContentRoot(this IWebHostBuilder webHostBuilder)
        {
            var currentDirectory = Directory.GetCurrentDirectory();

            webHostBuilder.UseContentRoot(currentDirectory);
            return webHostBuilder;
        }
    }
}
