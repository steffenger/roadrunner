/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.sbml.libsbml;

/** 
 *  Base class for SBML converters.
 <p>
 * <p style='color: #777; font-style: italic'>
This class of objects is defined by libSBML only and has no direct
equivalent in terms of SBML components.  It is a class used in
the implementation of extra functionality provided by libSBML.
</p>

 <p>
 * The {@link SBMLConverter} class is the base class for the various SBML 
 * <em>converters</em>: classes of objects that transform or convert SBML documents.
 * These transformations can involve essentially anything that can be
 * written algorithmically; examples include converting the units of
 * measurement in a model, or converting from one Level+Version combination
 * of SBML to another.
 <p>
 * LibSBML provides a number of built-in converters, and applications can
 * create their own by subclassing {@link SBMLConverter} and following the examples
 * of the existing converters.  The following are the built-in converters
 * in libSBML 5.9.0:
 * <ul>
 * <li> {@link SBMLFunctionDefinitionConverter}
 * <li> {@link SBMLInitialAssignmentConverter}
 * <li> {@link SBMLLevelVersionConverter}
 * <li> {@link SBMLRuleConverter}
 * <li> {@link SBMLStripPackageConverter}
 * <li> {@link SBMLUnitsConverter}
 *
 * </ul> <p>
 * Many converters provide the ability to configure their behavior to some
 * extent.  This is realized through the use of <em>properties</em> that offer
 * different <em>options</em>.  Two related classes implement these features:
 * {@link ConversionProperties} and ConversionOptions.  The default property values
 * for each converter can be interrogated using the method
 * {@link SBMLConverter#getDefaultProperties()} on the converter class.
 */

public class SBMLConverter {
   private long swigCPtr;
   protected boolean swigCMemOwn;

   protected SBMLConverter(long cPtr, boolean cMemoryOwn)
   {
     swigCMemOwn = cMemoryOwn;
     swigCPtr    = cPtr;
   }

   protected static long getCPtr(SBMLConverter obj)
   {
     return (obj == null) ? 0 : obj.swigCPtr;
   }

   protected static long getCPtrAndDisown (SBMLConverter obj)
   {
     long ptr = 0;

     if (obj != null)
     {
       ptr             = obj.swigCPtr;
       obj.swigCMemOwn = false;
     }

     return ptr;
   }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libsbmlJNI.delete_SBMLConverter(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  protected void swigDirectorDisconnect() {
    swigCMemOwn = false;
    delete();
  }

  public void swigReleaseOwnership() {
    swigCMemOwn = false;
    libsbmlJNI.SBMLConverter_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    libsbmlJNI.SBMLConverter_change_ownership(this, swigCPtr, true);
  }

  
/**
   * Creates a new {@link SBMLConverter} object.
   */ public
 SBMLConverter() {
    this(libsbmlJNI.new_SBMLConverter__SWIG_0(), true);
    libsbmlJNI.SBMLConverter_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  
/**
   * Copy constructor; creates a copy of an {@link SBMLConverter} object.
   <p>
   * @param c the {@link SBMLConverter} object to copy.
   <p>
   * @throws SBMLConstructorException 
   * Thrown if the argument <code>orig</code> is <code>null.</code>
   */ public
 SBMLConverter(SBMLConverter c) {
    this(libsbmlJNI.new_SBMLConverter__SWIG_1(SBMLConverter.getCPtr(c), c), true);
    libsbmlJNI.SBMLConverter_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  
/**
   * Creates and returns a deep copy of this {@link SBMLConverter} object.
   <p>
   * @return a (deep) copy of this {@link SBMLConverter} object.
   */ public
 SBMLConverter cloneObject() {
    long cPtr = (getClass() == SBMLConverter.class) ? libsbmlJNI.SBMLConverter_cloneObject(swigCPtr, this) : libsbmlJNI.SBMLConverter_cloneObjectSwigExplicitSBMLConverter(swigCPtr, this);
    return (cPtr == 0) ? null : new SBMLConverter(cPtr, true);
  }

  
/**
   * Returns the SBML document that is the subject of the conversions.
   <p>
   * @return the current {@link SBMLDocument} object.
   */ public
 SBMLDocument getDocument() {
    long cPtr = (getClass() == SBMLConverter.class) ? libsbmlJNI.SBMLConverter_getDocument__SWIG_0(swigCPtr, this) : libsbmlJNI.SBMLConverter_getDocumentSwigExplicitSBMLConverter__SWIG_0(swigCPtr, this);
    return (cPtr == 0) ? null : new SBMLDocument(cPtr, false);
  }

  
/**
   * Returns the default properties of this converter.
   <p>
   * A given converter exposes one or more properties that can be adjusted
   * in order to influence the behavior of the converter.  This method
   * returns the <em>default</em> property settings for this converter.  It is
   * meant to be called in order to discover all the settings for the
   * converter object.  The run-time properties of the converter object can
   * be adjusted by using the method
   * {@link SBMLConverter#setProperties(ConversionProperties props)}.
   <p>
   * @return the default properties for the converter.
   <p>
   * @see #setProperties(ConversionProperties props)
   * @see #matchesProperties(ConversionProperties props)
   */ public
 ConversionProperties getDefaultProperties() {
    return new ConversionProperties((getClass() == SBMLConverter.class) ? libsbmlJNI.SBMLConverter_getDefaultProperties(swigCPtr, this) : libsbmlJNI.SBMLConverter_getDefaultPropertiesSwigExplicitSBMLConverter(swigCPtr, this), true);
  }

  
/**
   * Returns the target SBML namespaces of the currently set properties.
   <p>
   * SBML namespaces are used by libSBML to express the Level+Version of
   * the SBML document (and, possibly, any SBML Level&nbsp;3 packages in
   * use). Some converters' behavior is affected by the SBML namespace
   * configured in the converter.  For example, the actions of
   * {@link SBMLLevelVersionConverter}, the converter for converting SBML documents
   * from one Level+Version combination to another, are fundamentally
   * dependent on the SBML namespaces being targeted.
   <p>
   * @return the {@link SBMLNamespaces} object that describes the SBML namespaces
   * in effect.
   */ public
 SBMLNamespaces getTargetNamespaces() {
  return libsbml.DowncastSBMLNamespaces((getClass() == SBMLConverter.class) ? libsbmlJNI.SBMLConverter_getTargetNamespaces(swigCPtr, this) : libsbmlJNI.SBMLConverter_getTargetNamespacesSwigExplicitSBMLConverter(swigCPtr, this), false);
}

  
/**
   * Predicate returning <code>true</code> if this converter's properties matches a
   * given set of configuration properties.
   <p>
   * @param props the configuration properties to match.
   <p>
   * @return <code>true</code> if this converter's properties match, <code>false</code>
   * otherwise.
   */ public
 boolean matchesProperties(ConversionProperties props) {
    return (getClass() == SBMLConverter.class) ? libsbmlJNI.SBMLConverter_matchesProperties(swigCPtr, this, ConversionProperties.getCPtr(props), props) : libsbmlJNI.SBMLConverter_matchesPropertiesSwigExplicitSBMLConverter(swigCPtr, this, ConversionProperties.getCPtr(props), props);
  }

  
/**
   * Sets the current SBML document to the given {@link SBMLDocument} object.
   <p>
   * @param doc the document to use for this conversion.
   <p>
   * @return integer value indicating the success/failure of the operation.
   *  The set of possible values that may
   * be returned ultimately depends on the specific subclass of
   * {@link SBMLConverter} being used, but the default method can return the
   * following values:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * </ul>
   */ public
 int setDocument(SBMLDocument doc) {
    return (getClass() == SBMLConverter.class) ? libsbmlJNI.SBMLConverter_setDocument(swigCPtr, this, SBMLDocument.getCPtr(doc), doc) : libsbmlJNI.SBMLConverter_setDocumentSwigExplicitSBMLConverter(swigCPtr, this, SBMLDocument.getCPtr(doc), doc);
  }

  
/**
   * Sets the configuration properties to be used by this converter.
   <p>
   * A given converter exposes one or more properties that can be adjusted
   * in order to influence the behavior of the converter.  This method sets
   * the current properties for this converter.
   <p>
   * @param props the {@link ConversionProperties} object defining the properties
   * to set.
   <p>
   * @return integer value indicating the success/failure of the operation.
   *  The set of possible values that may
   * be returned ultimately depends on the specific subclass of
   * {@link SBMLConverter} being used, but the default method can return the
   * following values:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED }
   *
   * </ul> <p>
   * @see #getProperties()
   * @see #matchesProperties(ConversionProperties props)
   */ public
 int setProperties(ConversionProperties props) {
    return (getClass() == SBMLConverter.class) ? libsbmlJNI.SBMLConverter_setProperties(swigCPtr, this, ConversionProperties.getCPtr(props), props) : libsbmlJNI.SBMLConverter_setPropertiesSwigExplicitSBMLConverter(swigCPtr, this, ConversionProperties.getCPtr(props), props);
  }

  
/**
   * Returns the current properties in effect for this converter.
   <p>
   * A given converter exposes one or more properties that can be adjusted
   * in order to influence the behavior of the converter.  This method
   * returns the current properties for this converter; in other words, the
   * settings in effect at this moment.  To change the property values, you
   * can use {@link SBMLConverter#setProperties(ConversionProperties props)}.
   <p>
   * @return the currently set configuration properties.
   <p>
   * @see #setProperties(ConversionProperties props)
   * @see #matchesProperties(ConversionProperties props)
   */ public
 ConversionProperties getProperties() {
    long cPtr = (getClass() == SBMLConverter.class) ? libsbmlJNI.SBMLConverter_getProperties(swigCPtr, this) : libsbmlJNI.SBMLConverter_getPropertiesSwigExplicitSBMLConverter(swigCPtr, this);
    return (cPtr == 0) ? null : new ConversionProperties(cPtr, false);
  }

  
/**
   * Perform the conversion.
   <p>
   * This method causes the converter to do the actual conversion work,
   * that is, to convert the {@link SBMLDocument} object set by
   * {@link SBMLConverter#setDocument(SBMLDocument doc)} and
   * with the configuration options set by
   * {@link SBMLConverter#setProperties(ConversionProperties props)}.
   <p>
   * @return  integer value indicating the success/failure of the operation.
   *  The set of possible values that may
   * be returned depends on the converter subclass; please consult
   * the documentation for the relevant class to find out what the
   * possibilities are.
   */ public
 int convert() {
    return (getClass() == SBMLConverter.class) ? libsbmlJNI.SBMLConverter_convert(swigCPtr, this) : libsbmlJNI.SBMLConverter_convertSwigExplicitSBMLConverter(swigCPtr, this);
  }

}
