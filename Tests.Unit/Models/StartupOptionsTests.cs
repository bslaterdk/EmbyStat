﻿using System;
using System.Collections.Generic;
using System.Text;
using EmbyStat.Web;
using FluentAssertions;
using Xunit;
using CommandLine;

namespace Tests.Unit.Models
{
    public class StartupOptionsTests
    {
        [Fact]
        public void Properties_Should_Be_Decorated_With_Option_Attribute()
        {
            typeof(StartupOptions)
                .Properties()
                .Should()
                .BeDecoratedWith<OptionAttribute>();
        }
    }
}
