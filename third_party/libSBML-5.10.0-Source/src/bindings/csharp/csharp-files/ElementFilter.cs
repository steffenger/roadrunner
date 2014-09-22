/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbmlcs {

 using System;
 using System.Runtime.InteropServices;

/** 
 * @sbmlpackage{core}
 *
@htmlinclude pkg-marker-core.html 
 * @internal
 */

public class ElementFilter : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal ElementFilter(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ElementFilter obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ElementFilter obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ElementFilter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ElementFilter(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ElementFilter() : this(libsbmlPINVOKE.new_ElementFilter(), true) {
    SwigDirectorConnect();
  }

  public virtual bool filter(SBase element) {
    bool ret = (SwigDerivedClassHasMethod("filter", swigMethodTypes0) ? libsbmlPINVOKE.ElementFilter_filterSwigExplicitElementFilter(swigCPtr, SBase.getCPtr(element)) : libsbmlPINVOKE.ElementFilter_filter(swigCPtr, SBase.getCPtr(element)));
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("filter", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateElementFilter_0(SwigDirectorfilter);
    libsbmlPINVOKE.ElementFilter_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ElementFilter));
    return hasDerivedMethod;
  }

  private bool SwigDirectorfilter(IntPtr element) {
    return filter((element == IntPtr.Zero) ? null : new SBase(element, false));
  }

  public delegate bool SwigDelegateElementFilter_0(IntPtr element);

  private SwigDelegateElementFilter_0 swigDelegate0;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(SBase) };
}

}
