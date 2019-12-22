﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimplePNML
{
    /// <summary>
    /// Marks the elements that have their graphics described by an annotation
    /// </summary>
    public interface IAnnotationElement
    {
        Annotation Graphics { get; set; }
    }
}
