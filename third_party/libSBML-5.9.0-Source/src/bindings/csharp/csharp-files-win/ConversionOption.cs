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
@htmlinclude pkg-marker-core.html Class of object that encapsulates a conversion option.
 * 
 * @htmlinclude libsbml-facility-only-warning.html
 *
 * LibSBML provides a number of converters that can perform transformations
 * on SBML documents.  These converters allow their behaviors to be
 * controlled by setting property values.  Converter properties are
 * communicated using objects of class ConversionProperties, and within
 * such objects, individual options are encapsulated using ConversionOption
 * objects.
 *
 * A ConversionOption object consists of four parts:
 * @li A @em key, acting as the name of the option;
 * @li A @em value of this option;
 * @li A @em type for the value; this is chosen from  the enumeration type
 * <a class='el' href='#ConversionOptionType_t'>ConversionOptionType_t</a>; and
 * @li A @em description consisting of a text string that describes the
 * option in some way.
 *
 * There are no constraints on the values of keys or descriptions;
 * authors of SBML converters are free to choose them as they see fit.
 *
 * @section ConversionOptionType_t Conversion option data types
 *
 * An option in ConversionOption must have a data type declared, to
 * indicate whether it is a string value, an integer, and so forth.  The
 * possible types of values are taken from the enumeration <a
 * class='el' href='#ConversionOptionType_t'>ConversionOptionType_t</a>.
 * The following are the possible values:
 * 
 * <p>
 * <center>
 * <table width='90%' cellspacing='1' cellpadding='1' border='0' class='normal-font'>
 *  <tr style='background: lightgray' class='normal-font'>
 *      <td><strong>Enumerator</strong></td>
 *      <td><strong>Meaning</strong></td>
 *  </tr>
 * <tr>
 * <td><code>@link libsbmlcs.libsbml.CNV_TYPE_BOOL CNV_TYPE_BOOL@endlink</code></td>
 * <td>Indicates the value type is a Boolean.</td>
 * </tr>
 * <tr>
 * <td><code>@link libsbmlcs.libsbml.CNV_TYPE_DOUBLE CNV_TYPE_DOUBLE@endlink</code></td>
 * <td>Indicates the value type is a double-sized float.</td>
 * </tr>
 * <tr>
 * <td><code>@link libsbmlcs.libsbml.CNV_TYPE_INT CNV_TYPE_INT@endlink</code></td>
 * <td>Indicates the value type is an integer.</td>
 * </tr>
 * <tr>
 * <td><code>@link libsbmlcs.libsbml.CNV_TYPE_SINGLE CNV_TYPE_SINGLE@endlink</code></td>
 * <td>Indicates the value type is a float.</td>
 * </tr>
 * <tr>
 * <td><code>@link libsbmlcs.libsbml.CNV_TYPE_STRING CNV_TYPE_STRING@endlink</code></td>
 * <td>Indicates the value type is a string.</td>
 * </tr>
 * </table>
 * </center>
 *
 * @see ConversionProperties
 */

public class ConversionOption : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal ConversionOption(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ConversionOption obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ConversionOption obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ConversionOption() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ConversionOption(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
/**
   * Creates a new ConversionOption.
   *
   * This is the general constructor, taking arguments for all aspects of
   * an option.  Other constructors exist with different arguments.
   * 
   * @param key the key for this option
   * @param value an optional value for this option
   * @param type the type of this option
   * @param description the description for this option
   */ public
 ConversionOption(string key, string value, int type, string description) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_0(key, value, type, description), true) {
  }

  
/**
   * Creates a new ConversionOption.
   *
   * This is the general constructor, taking arguments for all aspects of
   * an option.  Other constructors exist with different arguments.
   * 
   * @param key the key for this option
   * @param value an optional value for this option
   * @param type the type of this option
   * @param description the description for this option
   */ public
 ConversionOption(string key, string value, int type) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_1(key, value, type), true) {
  }

  
/**
   * Creates a new ConversionOption.
   *
   * This is the general constructor, taking arguments for all aspects of
   * an option.  Other constructors exist with different arguments.
   * 
   * @param key the key for this option
   * @param value an optional value for this option
   * @param type the type of this option
   * @param description the description for this option
   */ public
 ConversionOption(string key, string value) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_2(key, value), true) {
  }

  
/**
   * Creates a new ConversionOption.
   *
   * This is the general constructor, taking arguments for all aspects of
   * an option.  Other constructors exist with different arguments.
   * 
   * @param key the key for this option
   * @param value an optional value for this option
   * @param type the type of this option
   * @param description the description for this option
   */ public
 ConversionOption(string key) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_3(key), true) {
  }

  
/**
   * Creates a new ConversionOption specialized for string-type options.
   * 
   * @param key the key for this option
   * @param value the value for this option
   * @param description an optional description
   */ public
 ConversionOption(string key, string value, string description) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_4(key, value, description), true) {
  }

  
/**
   * Creates a new ConversionOption specialized for Boolean-type options.
   * 
   * @param key the key for this option
   * @param value the value for this option
   * @param description an optional description
   */ public
 ConversionOption(string key, bool value, string description) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_6(key, value, description), true) {
  }

  
/**
   * Creates a new ConversionOption specialized for Boolean-type options.
   * 
   * @param key the key for this option
   * @param value the value for this option
   * @param description an optional description
   */ public
 ConversionOption(string key, bool value) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_7(key, value), true) {
  }

  
/**
   * Creates a new ConversionOption specialized for double-type options.
   * 
   * @param key the key for this option
   * @param value the value for this option
   * @param description an optional description
   */ public
 ConversionOption(string key, double value, string description) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_8(key, value, description), true) {
  }

  
/**
   * Creates a new ConversionOption specialized for double-type options.
   * 
   * @param key the key for this option
   * @param value the value for this option
   * @param description an optional description
   */ public
 ConversionOption(string key, double value) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_9(key, value), true) {
  }

  
/**
   * Creates a new ConversionOption specialized for float-type options.
   * 
   * @param key the key for this option
   * @param value the value for this option
   * @param description an optional description
   */ public
 ConversionOption(string key, float value, string description) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_10(key, value, description), true) {
  }

  
/**
   * Creates a new ConversionOption specialized for float-type options.
   * 
   * @param key the key for this option
   * @param value the value for this option
   * @param description an optional description
   */ public
 ConversionOption(string key, float value) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_11(key, value), true) {
  }

  
/**
   * Creates a new ConversionOption specialized for integer-type options.
   * 
   * @param key the key for this option
   * @param value the value for this option
   * @param description an optional description
   */ public
 ConversionOption(string key, int value, string description) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_12(key, value, description), true) {
  }

  
/**
   * Creates a new ConversionOption specialized for integer-type options.
   * 
   * @param key the key for this option
   * @param value the value for this option
   * @param description an optional description
   */ public
 ConversionOption(string key, int value) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_13(key, value), true) {
  }

  
/**
   * Copy constructor; creates a copy of an ConversionOption object.
   *
   * @param orig the ConversionOption object to copy.
   * 
   * @throws @if python ValueError @else SBMLConstructorException @endif
   * Thrown if the argument @p orig is @c null.
   */ public
 ConversionOption(ConversionOption orig) : this(libsbmlPINVOKE.new_ConversionOption__SWIG_14(ConversionOption.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/** 
   * Creates and returns a deep copy of this ConversionOption object.
   * 
   * @return a (deep) copy of this ConversionOption object.
   */ public
 ConversionOption clone() {
    IntPtr cPtr = libsbmlPINVOKE.ConversionOption_clone(swigCPtr);
    ConversionOption ret = (cPtr == IntPtr.Zero) ? null : new ConversionOption(cPtr, true);
    return ret;
  }

  
/**
   * Returns the key for this option.
   * 
   * @return the key, as a string.
   */ public
 string getKey() {
    string ret = libsbmlPINVOKE.ConversionOption_getKey(swigCPtr);
    return ret;
  }

  
/**
   * Sets the key for this option.
   * 
   * @param key a string representing the key to set.
   */ public
 void setKey(string key) {
    libsbmlPINVOKE.ConversionOption_setKey(swigCPtr, key);
  }

  
/**
   * Returns the value of this option.
   * 
   * @return the value of this option, as a string.
   */ public
 string getValue() {
    string ret = libsbmlPINVOKE.ConversionOption_getValue(swigCPtr);
    return ret;
  }

  
/**
   * Sets the value for this option.
   * 
   * @param value the value to set, as a string.
   */ public
 void setValue(string value) {
    libsbmlPINVOKE.ConversionOption_setValue(swigCPtr, value);
  }

  
/**
   * Returns the description string for this option.
   * 
   * @return the description of this option.
   */ public
 string getDescription() {
    string ret = libsbmlPINVOKE.ConversionOption_getDescription(swigCPtr);
    return ret;
  }

  
/**
   * Sets the description text for this option.
   * 
   * @param description the description to set for this option.
   */ public
 void setDescription(string description) {
    libsbmlPINVOKE.ConversionOption_setDescription(swigCPtr, description);
  }

  
/**
   * Returns the type of this option
   * 
   * @return the type of this option.
   */ public
 int getType() {
    int ret = libsbmlPINVOKE.ConversionOption_getType(swigCPtr);
    return ret;
  }

  
/**
   * Sets the type of this option.
   * 
   * @param type the type value to use.
   */ public
 void setType(int type) {
    libsbmlPINVOKE.ConversionOption_setType(swigCPtr, type);
  }

  
/**
   * Returns the value of this option as a Boolean.
   * 
   * @return the value of this option.
   */ public
 bool getBoolValue() {
    bool ret = libsbmlPINVOKE.ConversionOption_getBoolValue(swigCPtr);
    return ret;
  }

  
/** 
   * Set the value of this option to a given Boolean value.
   *
   * Invoking this method will also set the type of the option to
   * @link libsbmlcs.libsbml.CNV_TYPE_BOOL CNV_TYPE_BOOL@endlink.
   * 
   * @param value the Boolean value to set
   */ public
 void setBoolValue(bool value) {
    libsbmlPINVOKE.ConversionOption_setBoolValue(swigCPtr, value);
  }

  
/**
   * Returns the value of this option as a @c double.
   * 
   * @return the value of this option.
   */ public
 double getDoubleValue() {
    double ret = libsbmlPINVOKE.ConversionOption_getDoubleValue(swigCPtr);
    return ret;
  }

  
/** 
   * Set the value of this option to a given @c double value.
   *
   * Invoking this method will also set the type of the option to
   * @link libsbmlcs.libsbml.CNV_TYPE_DOUBLE CNV_TYPE_DOUBLE@endlink.
   * 
   * @param value the value to set
   */ public
 void setDoubleValue(double value) {
    libsbmlPINVOKE.ConversionOption_setDoubleValue(swigCPtr, value);
  }

  
/**
   * Returns the value of this option as a @c float.
   * 
   * @return the value of this option as a float
   */ public
 float getFloatValue() {
    float ret = libsbmlPINVOKE.ConversionOption_getFloatValue(swigCPtr);
    return ret;
  }

  
/** 
   * Set the value of this option to a given @c float value.
   *
   * Invoking this method will also set the type of the option to
   * @link libsbmlcs.libsbml.CNV_TYPE_SINGLE CNV_TYPE_SINGLE@endlink.
   * 
   * @param value the value to set
   */ public
 void setFloatValue(float value) {
    libsbmlPINVOKE.ConversionOption_setFloatValue(swigCPtr, value);
  }

  
/**
   * Returns the value of this option as an @c integer.
   * 
   * @return the value of this option, as an int
   */ public
 int getIntValue() {
    int ret = libsbmlPINVOKE.ConversionOption_getIntValue(swigCPtr);
    return ret;
  }

  
/** 
   * Set the value of this option to a given @c int value.
   *
   * Invoking this method will also set the type of the option to
   * @link libsbmlcs.libsbml.CNV_TYPE_INT CNV_TYPE_INT@endlink.
   * 
   * @param value the value to set
   */ public
 void setIntValue(int value) {
    libsbmlPINVOKE.ConversionOption_setIntValue(swigCPtr, value);
  }

}

}
