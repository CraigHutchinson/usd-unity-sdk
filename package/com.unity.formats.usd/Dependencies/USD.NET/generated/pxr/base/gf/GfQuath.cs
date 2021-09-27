//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr
{
    public class GfQuath : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal GfQuath(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfQuath obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~GfQuath()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this) {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        UsdCsPINVOKE.delete_GfQuath(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public static bool Equals(GfQuath lhs, GfQuath rhs)
        {
            bool ret = UsdCsPINVOKE.GfQuath_Equals(GfQuath.getCPtr(lhs), GfQuath.getCPtr(rhs));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        override public int GetHashCode()
        {
            int ret = UsdCsPINVOKE.GfQuath_GetHashCode(swigCPtr);
            return ret;
        }

        public static bool operator==(GfQuath lhs, GfQuath rhs)
        {
            // The Swig binding glue will re-enter this operator comparing to null, so
            // that case must be handled explicitly to avoid an infinite loop. This is still
            // not great, since it crosses the C#/C++ barrier twice. A better approache might
            // be to return a simple value from C++ that can be compared in C#.
            bool lnull = lhs as object == null;
            bool rnull = rhs as object == null;
            return (lnull == rnull) && ((lnull && rnull) || GfQuath.Equals(lhs, rhs));
        }

        public static bool operator!=(GfQuath lhs, GfQuath rhs)
        {
            return !(lhs == rhs);
        }

        override public bool Equals(object rhs)
        {
            return GfQuath.Equals(this, rhs as GfQuath);
        }

        public GfQuath() : this(UsdCsPINVOKE.new_GfQuath(), true)
        {
        }
    }
}