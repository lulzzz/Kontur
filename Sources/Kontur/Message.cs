﻿using System;
using System.Collections.Generic;

namespace Kontur
{
    internal class Message<T> : IMessage
    {
        private readonly T payload;

        public Message(T payload, IDictionary<string, string> headers)
        {
            this.RouteKey = typeof(T);
            this.payload = payload;
            this.Headers = (IReadOnlyDictionary<string, string>) headers;
        }

        public Type RouteKey { get; }

        public IReadOnlyDictionary<string, string> Headers { get; }

        public object Payload => this.payload;
    }
}
