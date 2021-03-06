// ***********************************************************************
// Copyright (c) 2011 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using System;

namespace NUnit.Framework.Constraints
{
    /// <summary>
    /// ExceptionTypeConstraint is a special version of ExactTypeConstraint
    /// used to provided detailed info about the exception thrown in
    /// an error message.
    /// </summary>
    public class ExceptionTypeConstraint : ExactTypeConstraint
    {
        /// <summary>
        /// Constructs an ExceptionTypeConstraint
        /// </summary>
        public ExceptionTypeConstraint(Type type) : base(type) { }

        // TODO: This needs tests. May need a special result type.
        ///// <summary>
        ///// Write the actual value for a failing constraint test to a
        ///// MessageWriter. Overriden to write additional information 
        ///// in the case of an Exception.
        ///// </summary>
        ///// <param name="writer">The MessageWriter to use</param>
        //public override void WriteActualValueTo(MessageWriter writer)
        //{
        //    Exception ex = actual as Exception;
        //    base.WriteActualValueTo(writer);

        //    if (ex != null)
        //    {
        //        writer.WriteLine(" ({0})", ex.Message);
        //        writer.Write(ex.StackTrace);
        //    }
        //}
    }
}

