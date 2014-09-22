/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbml {

 using System;
 using System.Runtime.InteropServices;

/** 
 * @sbmlpackage{core}
 *
@htmlinclude pkg-marker-core.html Base class for SBML validators
 *
 * @htmlinclude not-sbml-warning.html
 *
 * LibSBML implements facilities for verifying that a given SBML document
 * is valid according to the SBML specifications; it also exposes the
 * validation interface so that user programs and SBML Level&nbsp;3 package
 * authors may use the facilities to implement new validators.  There are
 * two main interfaces to libSBML's validation facilities, based on the
 * classes Validator and SBMLValidator.
 *
 * The Validator class is the basis of the system for validating an SBML
 * document against the validation rules defined in the SBML
 * specifications.  The scheme used by Validator relies is compact and uses
 * the @em visitor programming pattern, but it relies on C/C++ features and
 * is not directly accessible from language bindings.  SBMLValidator offers
 * a framework for straightforward class-based extensibility, so that user
 * code can subclass SBMLValidator to implement new validation systems,
 * different validators can be introduced or turned off at run-time, and
 * interfaces can be provided in the libSBML language bindings.
 * SBMLValidator can call Validator functionality internally (as is the
 * case in the current implementation of SBMLInternalValidator) or use
 * entirely different implementation approaches, as necessary.
 *
 * Users of libSBML may already be familiar with the facilities encompassed
 * by the validation system, in the form of the consistency-checking methods
 * defined on SBMLDocument.  The methods SBMLDocument::setConsistencyChecks(@if java int categ, bool onoff@endif),
 * SBMLDocument::checkConsistency(), SBMLDocument::checkInternalConsistency()
 * and other method of that sort are in fact implemented via SBMLValidator,
 * specifically as methods on the class SBMLInternalValidator.
 *
 * Authors may use SBMLValidator as the base class for their own validator
 * extensions to libSBML.  The class SBMLInternalValidator may serve as a
 * code example for how to implement such things.
 */

public class SBMLValidator : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal SBMLValidator(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SBMLValidator obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SBMLValidator obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SBMLValidator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SBMLValidator(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
/**
   * Creates a new SBMLValidator.
   */ public
 SBMLValidator() : this(libsbmlPINVOKE.new_SBMLValidator__SWIG_0(), true) {
    SwigDirectorConnect();
  }

  
/**
   * Copy constructor; creates a copy of an SBMLValidator object.
   *
   * @param orig the object to copy.
   * 
   * @throws @if python ValueError @else SBMLConstructorException @endif
   * Thrown if the argument @p orig is @c null.
   */ public
 SBMLValidator(SBMLValidator orig) : this(libsbmlPINVOKE.new_SBMLValidator__SWIG_1(SBMLValidator.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  
/**
   * Creates and returns a deep copy of this SBMLValidator.
   * 
   * @return a (deep) copy of this SBMLValidator.
   */ public
 SBMLValidator clone() {
    IntPtr cPtr = (SwigDerivedClassHasMethod("clone", swigMethodTypes0) ? libsbmlPINVOKE.SBMLValidator_cloneSwigExplicitSBMLValidator(swigCPtr) : libsbmlPINVOKE.SBMLValidator_clone(swigCPtr));
    SBMLValidator ret = (cPtr == IntPtr.Zero) ? null : new SBMLValidator(cPtr, true);
    return ret;
  }

  
/**
   * Returns the current SBML document in use by this validator.
   * 
   * @return the current SBML document
   *
   * @see setDocument(@if java SBMLDocument doc@endif)
   */ public
 SBMLDocument getDocument() {
    IntPtr cPtr = (SwigDerivedClassHasMethod("getDocument", swigMethodTypes1) ? libsbmlPINVOKE.SBMLValidator_getDocumentSwigExplicitSBMLValidator__SWIG_0(swigCPtr) : libsbmlPINVOKE.SBMLValidator_getDocument__SWIG_0(swigCPtr));
    SBMLDocument ret = (cPtr == IntPtr.Zero) ? null : new SBMLDocument(cPtr, false);
    return ret;
  }

  
/** 
   * Sets the current SBML document to the given SBMLDocument object.
   * 
   * @param doc the document to use for this validation
   * 
   * @return an integer value indicating the success/failure of the
   * validation.  @if clike The value is drawn from the enumeration
   * #OperationReturnValues_t. @endif The possible values returned by this
   * function are
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   *
   * @see getDocument()
   */ public
 int setDocument(SBMLDocument doc) {
    int ret = (SwigDerivedClassHasMethod("setDocument", swigMethodTypes3) ? libsbmlPINVOKE.SBMLValidator_setDocumentSwigExplicitSBMLValidator(swigCPtr, SBMLDocument.getCPtr(doc)) : libsbmlPINVOKE.SBMLValidator_setDocument(swigCPtr, SBMLDocument.getCPtr(doc)));
    return ret;
  }

  
/** 
   * Runs this validator on the current SBML document.
   *
   * @return an integer value indicating the success/failure of the
   * validation.  @if clike The value is drawn from the enumeration
   * #OperationReturnValues_t. @endif The possible values returned by this
   * function are determined by the specific subclasses of this class.
   */ public
 long validate() { return (long)(SwigDerivedClassHasMethod("validate", swigMethodTypes4) ? libsbmlPINVOKE.SBMLValidator_validateSwigExplicitSBMLValidator__SWIG_0(swigCPtr) : libsbmlPINVOKE.SBMLValidator_validate__SWIG_0(swigCPtr)); }

  
/**
   * Clears this validator's list of failures.
   *
   * If you are validating multiple SBML documents with the same validator,
   * call this method after you have processed the list of failures from
   * the last validation run and before validating the next document.
   *
   * @if clike @see getFailures() @endif
   */ public
 void clearFailures() {
    if (SwigDerivedClassHasMethod("clearFailures", swigMethodTypes5)) libsbmlPINVOKE.SBMLValidator_clearFailuresSwigExplicitSBMLValidator(swigCPtr); else libsbmlPINVOKE.SBMLValidator_clearFailures(swigCPtr);
  }

  
/**
   * Adds the given failure to this list of Validators failures.
   *
   * @param err an SBMLError object representing an error or warning
   *
   * @if clike @see getFailures() @endif
   */ public
 void logFailure(SBMLError err) {
    libsbmlPINVOKE.SBMLValidator_logFailure(swigCPtr, SBMLError.getCPtr(err));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Validates the given SBMLDocument object.
   *
   * This is identical to calling setDocument(@if java SBMLDocument d @endif)
   * followed by validate().
   *
   * @param d the SBML document to validate
   *
   * @return the number of validation failures that occurred.  The objects
   * describing the actual failures can be retrieved using getFailures().
   */ public
 long validate(SBMLDocument d) { return (long)libsbmlPINVOKE.SBMLValidator_validate__SWIG_1(swigCPtr, SBMLDocument.getCPtr(d)); }

  
/**
   * Validates the SBML document located at the given @p filename.
   *
   * This is a convenience method that saves callers the trouble of
   * using SBMLReader to read the document first.
   *
   * @param filename the path to the file to be read and validated.
   *
   * @return the number of validation failures that occurred.  The objects
   * describing the actual failures can be retrieved using getFailures().
   */ public
 long validate(string filename) { return (long)libsbmlPINVOKE.SBMLValidator_validate__SWIG_2(swigCPtr, filename); }

  
/**
   * Returns the list of errors or warnings logged during parsing,
   * consistency checking, or attempted translation of this model.
   *
   * Note that this refers to the SBMLDocument object's error log (i.e.,
   * the list returned by SBMLDocument::getErrorLog()).  @em That list of
   * errors and warnings is @em separate from the validation failures
   * tracked by this validator (i.e., the list returned by getFailures()).
   * 
   * @return the SBMLErrorLog used for the SBMLDocument
   * 
   * @if clike @see getFailures() @endif
   */ public
 SBMLErrorLog getErrorLog() {
    IntPtr cPtr = libsbmlPINVOKE.SBMLValidator_getErrorLog(swigCPtr);
    SBMLErrorLog ret = (cPtr == IntPtr.Zero) ? null : new SBMLErrorLog(cPtr, false);
    return ret;
  }

  
/**
   * Returns the Model object stored in the SBMLDocument.
   *
   * It is important to note that this method <em>does not create</em> a
   * Model instance.  The model in the SBMLDocument must have been created
   * at some prior time, for example using SBMLDocument::createModel() 
   * or SBMLDocument::setModel(@if java Model m@endif).
   * This method returns @c null if a model does not yet exist.
   * 
   * @return the Model contained in this validator's SBMLDocument object.
   *
   * @see SBMLDocument::setModel(@if java Model m@endif)
   * @see SBMLDocument::createModel()
   */ public
 Model getModel() {
    IntPtr cPtr = libsbmlPINVOKE.SBMLValidator_getModel__SWIG_0(swigCPtr);
    Model ret = (cPtr == IntPtr.Zero) ? null : new Model(cPtr, false);
    return ret;
  }

  
/** 
   * Returns the number of failures encountered in the last validation run.
   * 
   * This method returns the number of failures logged by this validator.
   * This number only reflects @em this validator's actions; the number may
   * not be the same as the number of errors and warnings logged on the
   * SBMLDocument object's error log (i.e., the object returned by
   * SBMLDocument::getErrorLog()), because other parts of libSBML may log
   * errors and warnings beyond those found by this validator.
   *
   * @return the number of errors logged by this validator. 
   */ public
 long getNumFailures() { return (long)libsbmlPINVOKE.SBMLValidator_getNumFailures(swigCPtr); }

  
/** 
   * Returns the failure object at index n in this validator's list of
   * failures logged during the last run.
   *
   * Callers should use getNumFailures() first, to find out the number
   * of entries in this validator's list of failures.
   *
   * @param n an integer indicating the index of the object to return from
   * the failures list; index values start at 0.
   * 
   * @return the failure at the given index number.
   *
   * @see getNumFailures()
   */ public
 SBMLError getFailure(long n) {
    IntPtr cPtr = libsbmlPINVOKE.SBMLValidator_getFailure(swigCPtr, n);
    SBMLError ret = (cPtr == IntPtr.Zero) ? null : new SBMLError(cPtr, false);
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("clone", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateSBMLValidator_0(SwigDirectorclone);
    if (SwigDerivedClassHasMethod("getDocument", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateSBMLValidator_1(SwigDirectorgetDocument__SWIG_0);
    if (SwigDerivedClassHasMethod("getDocument", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateSBMLValidator_2(SwigDirectorgetDocument__SWIG_1);
    if (SwigDerivedClassHasMethod("setDocument", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateSBMLValidator_3(SwigDirectorsetDocument);
    if (SwigDerivedClassHasMethod("validate", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateSBMLValidator_4(SwigDirectorvalidate__SWIG_0);
    if (SwigDerivedClassHasMethod("clearFailures", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateSBMLValidator_5(SwigDirectorclearFailures);
    libsbmlPINVOKE.SBMLValidator_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(SBMLValidator));
    return hasDerivedMethod;
  }

  private IntPtr SwigDirectorclone() {
    return SBMLValidator.getCPtr(clone()).Handle;
  }

  private IntPtr SwigDirectorgetDocument__SWIG_0() {
    return SBMLDocument.getCPtr(getDocument()).Handle;
  }

  private IntPtr SwigDirectorgetDocument__SWIG_1() {
    return SBMLDocument.getCPtr(getDocument()).Handle;
  }

  private int SwigDirectorsetDocument(IntPtr doc) {
    return setDocument((doc == IntPtr.Zero) ? null : new SBMLDocument(doc, false));
  }

  private uint SwigDirectorvalidate__SWIG_0() {
    return (uint)validate();
  }

  private void SwigDirectorclearFailures() {
    clearFailures();
  }

  public delegate IntPtr SwigDelegateSBMLValidator_0();
  public delegate IntPtr SwigDelegateSBMLValidator_1();
  public delegate IntPtr SwigDelegateSBMLValidator_2();
  public delegate int SwigDelegateSBMLValidator_3(IntPtr doc);
  public delegate uint SwigDelegateSBMLValidator_4();
  public delegate void SwigDelegateSBMLValidator_5();

  private SwigDelegateSBMLValidator_0 swigDelegate0;
  private SwigDelegateSBMLValidator_1 swigDelegate1;
  private SwigDelegateSBMLValidator_2 swigDelegate2;
  private SwigDelegateSBMLValidator_3 swigDelegate3;
  private SwigDelegateSBMLValidator_4 swigDelegate4;
  private SwigDelegateSBMLValidator_5 swigDelegate5;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] {  };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(SBMLDocument) };
  private static Type[] swigMethodTypes4 = new Type[] {  };
  private static Type[] swigMethodTypes5 = new Type[] {  };
}

}
