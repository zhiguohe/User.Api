﻿using MediatR;
using Project.Domain.AggregatesModel;

namespace Project.Domain.Events
{
    public class ProjectViewedEvent : INotification
    {
        public ProjectViewer ProjectViewer { get; set; }
        public string Company { get; set; }
        public string Introduction { get; set; }
    }
}