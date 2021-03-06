﻿using AllReady.ViewModels;
using MediatR;

namespace AllReady.Features.Volunteers
{
    public class GetMyEventsQuery : IAsyncRequest<MyEventsListerViewModel>
    {
        public string UserId { get; set; }
    }
}
