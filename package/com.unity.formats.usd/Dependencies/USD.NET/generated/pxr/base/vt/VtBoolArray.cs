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

[Preserve]
public class VtBoolArray : Vt_ArrayBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VtBoolArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.VtBoolArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtBoolArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_VtBoolArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

	  public bool this[int index] {
		  get { return GetValue(index); }
		  set { SetValue(index, value); }
	  }
  
  public VtBoolArray() : this(UsdCsPINVOKE.new_VtBoolArray__SWIG_0(), true) {
  }

  public VtBoolArray(VtBoolArray other) : this(UsdCsPINVOKE.new_VtBoolArray__SWIG_1(VtBoolArray.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtBoolArray(uint n) : this(UsdCsPINVOKE.new_VtBoolArray__SWIG_3(n), true) {
  }

  public VtBoolArray(uint n, bool value) : this(UsdCsPINVOKE.new_VtBoolArray__SWIG_4(n, value), true) {
  }

  public void push_back(bool elem) {
    UsdCsPINVOKE.VtBoolArray_push_back(swigCPtr, elem);
  }

  public void pop_back() {
    UsdCsPINVOKE.VtBoolArray_pop_back(swigCPtr);
  }

  public uint size() {
    uint ret = UsdCsPINVOKE.VtBoolArray_size(swigCPtr);
    return ret;
  }

  public uint capacity() {
    uint ret = UsdCsPINVOKE.VtBoolArray_capacity(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = UsdCsPINVOKE.VtBoolArray_empty(swigCPtr);
    return ret;
  }

  public void reserve(uint num) {
    UsdCsPINVOKE.VtBoolArray_reserve(swigCPtr, num);
  }

  public void resize(uint newSize) {
    UsdCsPINVOKE.VtBoolArray_resize(swigCPtr, newSize);
  }

  public void clear() {
    UsdCsPINVOKE.VtBoolArray_clear(swigCPtr);
  }

  public void assign(uint n, bool fill) {
    UsdCsPINVOKE.VtBoolArray_assign(swigCPtr, n, fill);
  }

  public void swap(VtBoolArray other) {
    UsdCsPINVOKE.VtBoolArray_swap(swigCPtr, VtBoolArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsIdentical(VtBoolArray other) {
    bool ret = UsdCsPINVOKE.VtBoolArray_IsIdentical(swigCPtr, VtBoolArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(VtBoolArray lhs, VtBoolArray rhs) {
    bool ret = UsdCsPINVOKE.VtBoolArray_Equals(VtBoolArray.getCPtr(lhs), VtBoolArray.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = UsdCsPINVOKE.VtBoolArray_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(bool[] dest) {
    UsdCsPINVOKE.VtBoolArray_CopyToArray__SWIG_0(swigCPtr, dest);
  }

  public void CopyFromArray(bool[] src) {
    UsdCsPINVOKE.VtBoolArray_CopyFromArray__SWIG_0(swigCPtr, src);
  }

  public void CopyToArray(System.IntPtr dest) {
    UsdCsPINVOKE.VtBoolArray_CopyToArray__SWIG_1(swigCPtr, dest);
  }

  public void CopyFromArray(System.IntPtr src) {
    UsdCsPINVOKE.VtBoolArray_CopyFromArray__SWIG_1(swigCPtr, src);
  }

  protected bool GetValue(int index) {
    bool ret = UsdCsPINVOKE.VtBoolArray_GetValue(swigCPtr, index);
    return ret;
  }

  protected void SetValue(int index, bool value) {
    UsdCsPINVOKE.VtBoolArray_SetValue(swigCPtr, index, value);
  }

}

}