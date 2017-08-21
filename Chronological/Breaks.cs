﻿using Newtonsoft.Json.Linq;

namespace Chronological
{
    public class Breaks
    {
        private readonly string _size;

        private Breaks(string size)
        {
            _size = size;
        }

        public static Breaks InMinutes(int minutes)
        {
            var size = $"{minutes}m";
            return new Breaks(size);
        }

        internal JProperty ToJProperty()
        {
            return new JProperty("breaks", new JObject(
                new JProperty("size", _size)));
        }
    }
}