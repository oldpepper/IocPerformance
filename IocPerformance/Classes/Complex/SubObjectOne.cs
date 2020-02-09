﻿using System;
using System.ComponentModel.Composition;
using MEF2Attr = System.Composition;

namespace IocPerformance.Classes.Complex
{
    public interface ISubObjectOne
    {
    }

    [Export(typeof(ISubObjectOne)), PartCreationPolicy(CreationPolicy.NonShared)]
    [MEF2Attr.Export(typeof(ISubObjectOne))]
    public class SubObjectOne : ISubObjectOne
    {
        [ImportingConstructor]
        [System.Composition.ImportingConstructor]
        [Stiletto.Inject]
        public SubObjectOne(IFirstService firstService)
        {
            if (firstService == null)
            {
                throw new ArgumentNullException(nameof(firstService));
            }
        }

        protected SubObjectOne()
        {
        }
    }
}
