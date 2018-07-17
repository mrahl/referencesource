// ==++==
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
// ==--==

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
    // ----------------------------------------------------------------------------
    // This file contains classes that create a new statement binding context
    // from the current one, but push on some new state.
    // ----------------------------------------------------------------------------

    internal class CheckedContext : BindingContext
    {
        public static CheckedContext CreateInstance(
            BindingContext parentCtx,
            bool checkedNormal,
            bool checkedConstant)
        {
            return new CheckedContext(parentCtx, checkedNormal, checkedConstant);
        }

        protected CheckedContext(
                BindingContext parentCtx,
                bool checkedNormal,
                bool checkedConstant
                )
            : base(parentCtx)
        {
            CheckedConstant = checkedConstant;
            CheckedNormal = checkedNormal;
        }
    }
}

