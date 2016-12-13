﻿using System;
using Weapsy.Infrastructure.Dispatcher;
using Weapsy.Infrastructure.Domain;

namespace Weapsy.Domain.Sites.Commands
{
    public class CreateSite : ICommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
