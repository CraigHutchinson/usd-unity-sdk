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
    public class UsdRiLightPortalAPI : UsdAPISchemaBase
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal UsdRiLightPortalAPI(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdRiLightPortalAPI_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdRiLightPortalAPI obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdRiLightPortalAPI()
        {
            Dispose();
        }

        public override void Dispose()
        {
            lock (this) {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        UsdCsPINVOKE.delete_UsdRiLightPortalAPI(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public UsdRiLightPortalAPI(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdRiLightPortalAPI__SWIG_0(UsdPrim.getCPtr(prim)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public UsdRiLightPortalAPI() : this(UsdCsPINVOKE.new_UsdRiLightPortalAPI__SWIG_1(), true)
        {
        }

        public UsdRiLightPortalAPI(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdRiLightPortalAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiLightPortalAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
            return ret;
        }

        public new static TfTokenVector GetSchemaAttributeNames()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiLightPortalAPI_GetSchemaAttributeNames__SWIG_1(), false);
            return ret;
        }

        public static UsdRiLightPortalAPI Get(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdRiLightPortalAPI ret = new UsdRiLightPortalAPI(UsdCsPINVOKE.UsdRiLightPortalAPI_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static UsdRiLightPortalAPI Apply(UsdPrim prim)
        {
            UsdRiLightPortalAPI ret = new UsdRiLightPortalAPI(UsdCsPINVOKE.UsdRiLightPortalAPI_Apply(UsdPrim.getCPtr(prim)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetRiPortalIntensityAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightPortalAPI_GetRiPortalIntensityAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateRiPortalIntensityAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightPortalAPI_CreateRiPortalIntensityAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiPortalIntensityAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightPortalAPI_CreateRiPortalIntensityAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiPortalIntensityAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightPortalAPI_CreateRiPortalIntensityAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetRiPortalTintAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightPortalAPI_GetRiPortalTintAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateRiPortalTintAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightPortalAPI_CreateRiPortalTintAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiPortalTintAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightPortalAPI_CreateRiPortalTintAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiPortalTintAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiLightPortalAPI_CreateRiPortalTintAttr__SWIG_2(swigCPtr), true);
            return ret;
        }
    }
}