﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Core.SharedKernel
{
    /// <summary>
    /// extend this class to every entity
    /// </summary>
    public abstract class Entity
    {
        public int Id { get; set; }
    }
}
