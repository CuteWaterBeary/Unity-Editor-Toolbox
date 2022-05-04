﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Toolbox.Editor.Internal
{
    public class TypesCachedCollection : IEnumerable<Type>
    {
        private readonly List<Type> values;


        public TypesCachedCollection() : this(new List<Type>()) 
        { }

        public TypesCachedCollection(List<Type> values)
        {
            this.values = values;
        }


        public int IndexOf(Type type)
        {
            return values.IndexOf(type);
        }

        public IEnumerator<Type> GetEnumerator()
        {
            return values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return values.GetEnumerator();
        }


        public IReadOnlyList<Type> Values => values;
    }
}