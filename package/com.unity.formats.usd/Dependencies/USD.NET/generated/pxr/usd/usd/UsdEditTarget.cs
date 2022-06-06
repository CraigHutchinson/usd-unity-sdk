//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class UsdEditTarget : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdEditTarget(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdEditTarget obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdEditTarget() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdEditTarget(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public UsdEditTarget() : this(UsdCsPINVOKE.new_UsdEditTarget__SWIG_0(), true) {
  }

  public UsdEditTarget(SdfLayerHandle layer, SdfLayerOffset offset) : this(UsdCsPINVOKE.new_UsdEditTarget__SWIG_1(SdfLayerHandle.getCPtr(layer), SdfLayerOffset.getCPtr(offset)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdEditTarget(SdfLayerHandle layer) : this(UsdCsPINVOKE.new_UsdEditTarget__SWIG_2(SdfLayerHandle.getCPtr(layer)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdEditTarget(SdfLayer layer, SdfLayerOffset offset) : this(UsdCsPINVOKE.new_UsdEditTarget__SWIG_3(SdfLayer.getCPtr(layer), SdfLayerOffset.getCPtr(offset)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdEditTarget(SdfLayer layer) : this(UsdCsPINVOKE.new_UsdEditTarget__SWIG_4(SdfLayer.getCPtr(layer)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdEditTarget(SdfLayerHandle layer, PcpNodeRef node) : this(UsdCsPINVOKE.new_UsdEditTarget__SWIG_5(SdfLayerHandle.getCPtr(layer), PcpNodeRef.getCPtr(node)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdEditTarget(SdfLayer layer, PcpNodeRef node) : this(UsdCsPINVOKE.new_UsdEditTarget__SWIG_6(SdfLayer.getCPtr(layer), PcpNodeRef.getCPtr(node)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static UsdEditTarget ForLocalDirectVariant(SdfLayerHandle layer, SdfPath varSelPath) {
    UsdEditTarget ret = new UsdEditTarget(UsdCsPINVOKE.UsdEditTarget_ForLocalDirectVariant(SdfLayerHandle.getCPtr(layer), SdfPath.getCPtr(varSelPath)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsNull() {
    bool ret = UsdCsPINVOKE.UsdEditTarget_IsNull(swigCPtr);
    return ret;
  }

  public bool IsValid() {
    bool ret = UsdCsPINVOKE.UsdEditTarget_IsValid(swigCPtr);
    return ret;
  }

  public SdfLayerHandle GetLayer() {
    SdfLayerHandle ret = new SdfLayerHandle(UsdCsPINVOKE.UsdEditTarget_GetLayer(swigCPtr), false);
    return ret;
  }

  public SdfPath MapToSpecPath(SdfPath scenePath) {
    SdfPath ret = new SdfPath(UsdCsPINVOKE.UsdEditTarget_MapToSpecPath(swigCPtr, SdfPath.getCPtr(scenePath)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfPrimSpecHandle GetPrimSpecForScenePath(SdfPath scenePath) {
    SdfPrimSpecHandle ret = new SdfPrimSpecHandle(UsdCsPINVOKE.UsdEditTarget_GetPrimSpecForScenePath(swigCPtr, SdfPath.getCPtr(scenePath)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfPropertySpecHandle GetPropertySpecForScenePath(SdfPath scenePath) {
    SdfPropertySpecHandle ret = new SdfPropertySpecHandle(UsdCsPINVOKE.UsdEditTarget_GetPropertySpecForScenePath(swigCPtr, SdfPath.getCPtr(scenePath)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfSpecHandle GetSpecForScenePath(SdfPath scenePath) {
    SdfSpecHandle ret = new SdfSpecHandle(UsdCsPINVOKE.UsdEditTarget_GetSpecForScenePath(swigCPtr, SdfPath.getCPtr(scenePath)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_PcpMapFunction GetMapFunction() {
    SWIGTYPE_p_PcpMapFunction ret = new SWIGTYPE_p_PcpMapFunction(UsdCsPINVOKE.UsdEditTarget_GetMapFunction(swigCPtr), false);
    return ret;
  }

  public UsdEditTarget ComposeOver(UsdEditTarget weaker) {
    UsdEditTarget ret = new UsdEditTarget(UsdCsPINVOKE.UsdEditTarget_ComposeOver(swigCPtr, UsdEditTarget.getCPtr(weaker)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}