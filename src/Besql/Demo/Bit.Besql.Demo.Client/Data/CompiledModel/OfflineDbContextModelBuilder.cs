﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Bit.Besql.Demo.Client.Data.CompiledModel
{
    public partial class OfflineDbContextModel
    {
        private OfflineDbContextModel()
            : base(skipDetectChanges: false, modelId: new Guid("ac96847b-e3a9-46a3-82cf-7605a37f26af"), entityTypeCount: 1)
        {
        }

        partial void Initialize()
        {
            var weatherForecast = WeatherForecastEntityType.Create(this);

            WeatherForecastEntityType.CreateAnnotations(weatherForecast);

            AddAnnotation("ProductVersion", "9.0.0");
        }
    }
}