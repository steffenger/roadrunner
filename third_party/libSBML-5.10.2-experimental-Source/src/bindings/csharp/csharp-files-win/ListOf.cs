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
@htmlinclude pkg-marker-core.html Parent class for libSBML's 'ListOfXYZ' classes.
 *
 * @htmlinclude not-sbml-warning.html
 *
 * The ListOf class in libSBML is a utility class that serves as the parent
 * class for implementing the ListOf__ classes.  It provides methods for
 * working generically with the various SBML lists of objects in a program.
 * LibSBML uses this separate list class rather than ordinary
 * @if conly C@endif@if cpp C++; @endif@if java Java@endif@if python Python@endif lists,
 * so that it can provide the methods and features associated with SBase.
 *
 * *
 * 
 * The various ListOf___ @if conly structures @else classes@endif in SBML
 * are merely containers used for organizing the main components of an SBML
 * model.  In libSBML's implementation, ListOf___
 * @if conly data structures @else classes@endif are derived from the
 * intermediate utility @if conly structure @else class@endif ListOf, which
 * is not defined by the SBML specifications but serves as a useful
 * programmatic construct.  ListOf is itself is in turn derived from SBase,
 * which provides all of the various ListOf___
 * @if conly data structures @else classes@endif with common features
 * defined by the SBML specification, such as 'metaid' attributes and
 * annotations.
 *
 * The relationship between the lists and the rest of an SBML model is
 * illustrated by the following (for SBML Level&nbsp;2 Version&nbsp;4):
 *
 * @htmlinclude listof-illustration.html
 *
 * Readers may wonder about the motivations for using the ListOf___
 * containers in SBML.  A simpler approach in XML might be to place the
 * components all directly at the top level of the model definition.  The
 * choice made in SBML is to group them within XML elements named after
 * %ListOf<em>Classname</em>, in part because it helps organize the
 * components.  More importantly, the fact that the container classes are
 * derived from SBase means that software tools can add information @em about
 * the lists themselves into each list container's 'annotation'.
 *
 * @see ListOfFunctionDefinitions
 * @see ListOfUnitDefinitions
 * @see ListOfCompartmentTypes
 * @see ListOfSpeciesTypes
 * @see ListOfCompartments
 * @see ListOfSpecies
 * @see ListOfParameters
 * @see ListOfInitialAssignments
 * @see ListOfRules
 * @see ListOfConstraints
 * @see ListOfReactions
 * @see ListOfEvents
 *
 * @if conly
 * @note In the C API for libSBML, functions that in other language APIs
 * would be inherited by the various ListOf___ structures not shown in the
 * pages for the individual ListOf___'s.  Instead, the functions are defined
 * on ListOf_t.  <strong>Please consult the documentation for ListOf_t for
 * the many common functions available for manipulating ListOf___
 * structures</strong>.  The documentation for the individual ListOf___
 * structures (ListOfCompartments_t, ListOfReactions_t, etc.) does not reveal
 * all of the functionality available. @endif
 *
 *
 */

public class ListOf : SBase {
	private HandleRef swigCPtr;
	
	internal ListOf(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.ListOf_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.ListOfUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ListOf obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ListOf obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ListOf() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ListOf(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Creates a new ListOf object.
   *
   * @param level the SBML Level; if not assigned, defaults to the
   * value of SBMLDocument::getDefaultLevel().
   *
   * @param version the Version within the SBML Level; if not assigned,
   * defaults to the value of SBMLDocument::getDefaultVersion().
   *
   * *
 * @note Bare ListOf @if conly structures @else objects@endif are
 * impossible to add to SBML models.  The ListOf
 * @if conly structure type@else class@endif is simply the base
 * of <em>other</em> @if conly structure types @else classes@endif in
 * libSBML.  Calling programs are not intended to create bare ListOf
 * @if conly structures @else objects@endif themselves.
   *
   * *
 * @note Attempting to add an object to an SBMLDocument having a different
 * combination of SBML Level, Version and XML namespaces than the object
 * itself will result in an error at the time a caller attempts to make the
 * addition.  A parent object must have compatible Level, Version and XML
 * namespaces.  (Strictly speaking, a parent may also have more XML
 * namespaces than a child, but the reverse is not permitted.)  The
 * restriction is necessary to ensure that an SBML model has a consistent
 * overall structure.  This requires callers to manage their objects
 * carefully, but the benefit is increased flexibility in how models can be
 * created by permitting callers to create objects bottom-up if desired.  In
 * situations where objects are not yet attached to parents (e.g.,
 * SBMLDocument), knowledge of the intented SBML Level and Version help
 * libSBML determine such things as whether it is valid to assign a
 * particular value to an attribute.
 *
 *
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 ListOf(long level, long version) : this(libsbmlPINVOKE.new_ListOf__SWIG_0(level, version), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new ListOf object.
   *
   * @param level the SBML Level; if not assigned, defaults to the
   * value of SBMLDocument::getDefaultLevel().
   *
   * @param version the Version within the SBML Level; if not assigned,
   * defaults to the value of SBMLDocument::getDefaultVersion().
   *
   * *
 * @note Bare ListOf @if conly structures @else objects@endif are
 * impossible to add to SBML models.  The ListOf
 * @if conly structure type@else class@endif is simply the base
 * of <em>other</em> @if conly structure types @else classes@endif in
 * libSBML.  Calling programs are not intended to create bare ListOf
 * @if conly structures @else objects@endif themselves.
   *
   * *
 * @note Attempting to add an object to an SBMLDocument having a different
 * combination of SBML Level, Version and XML namespaces than the object
 * itself will result in an error at the time a caller attempts to make the
 * addition.  A parent object must have compatible Level, Version and XML
 * namespaces.  (Strictly speaking, a parent may also have more XML
 * namespaces than a child, but the reverse is not permitted.)  The
 * restriction is necessary to ensure that an SBML model has a consistent
 * overall structure.  This requires callers to manage their objects
 * carefully, but the benefit is increased flexibility in how models can be
 * created by permitting callers to create objects bottom-up if desired.  In
 * situations where objects are not yet attached to parents (e.g.,
 * SBMLDocument), knowledge of the intented SBML Level and Version help
 * libSBML determine such things as whether it is valid to assign a
 * particular value to an attribute.
 *
 *
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 ListOf(long level) : this(libsbmlPINVOKE.new_ListOf__SWIG_1(level), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new ListOf object.
   *
   * @param level the SBML Level; if not assigned, defaults to the
   * value of SBMLDocument::getDefaultLevel().
   *
   * @param version the Version within the SBML Level; if not assigned,
   * defaults to the value of SBMLDocument::getDefaultVersion().
   *
   * *
 * @note Bare ListOf @if conly structures @else objects@endif are
 * impossible to add to SBML models.  The ListOf
 * @if conly structure type@else class@endif is simply the base
 * of <em>other</em> @if conly structure types @else classes@endif in
 * libSBML.  Calling programs are not intended to create bare ListOf
 * @if conly structures @else objects@endif themselves.
   *
   * *
 * @note Attempting to add an object to an SBMLDocument having a different
 * combination of SBML Level, Version and XML namespaces than the object
 * itself will result in an error at the time a caller attempts to make the
 * addition.  A parent object must have compatible Level, Version and XML
 * namespaces.  (Strictly speaking, a parent may also have more XML
 * namespaces than a child, but the reverse is not permitted.)  The
 * restriction is necessary to ensure that an SBML model has a consistent
 * overall structure.  This requires callers to manage their objects
 * carefully, but the benefit is increased flexibility in how models can be
 * created by permitting callers to create objects bottom-up if desired.  In
 * situations where objects are not yet attached to parents (e.g.,
 * SBMLDocument), knowledge of the intented SBML Level and Version help
 * libSBML determine such things as whether it is valid to assign a
 * particular value to an attribute.
 *
 *
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 ListOf() : this(libsbmlPINVOKE.new_ListOf__SWIG_2(), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new ListOf with a given SBMLNamespaces object.
   *
   * @param sbmlns the set of SBML namespaces that this ListOf should
   * contain.
   *
   * *
 * @note Bare ListOf @if conly structures @else objects@endif are
 * impossible to add to SBML models.  The ListOf
 * @if conly structure type@else class@endif is simply the base
 * of <em>other</em> @if conly structure types @else classes@endif in
 * libSBML.  Calling programs are not intended to create bare ListOf
 * @if conly structures @else objects@endif themselves.
   *
   * *
 * @note Attempting to add an object to an SBMLDocument having a different
 * combination of SBML Level, Version and XML namespaces than the object
 * itself will result in an error at the time a caller attempts to make the
 * addition.  A parent object must have compatible Level, Version and XML
 * namespaces.  (Strictly speaking, a parent may also have more XML
 * namespaces than a child, but the reverse is not permitted.)  The
 * restriction is necessary to ensure that an SBML model has a consistent
 * overall structure.  This requires callers to manage their objects
 * carefully, but the benefit is increased flexibility in how models can be
 * created by permitting callers to create objects bottom-up if desired.  In
 * situations where objects are not yet attached to parents (e.g.,
 * SBMLDocument), knowledge of the intented SBML Level and Version help
 * libSBML determine such things as whether it is valid to assign a
 * particular value to an attribute.
 *
 *
   */ public
 ListOf(SBMLNamespaces sbmlns) : this(libsbmlPINVOKE.new_ListOf__SWIG_3(SBMLNamespaces.getCPtr(sbmlns)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Copy constructor; creates a copy of this ListOf.
   *
   * @param orig the ListOf instance to copy.
   */ public
 ListOf(ListOf orig) : this(libsbmlPINVOKE.new_ListOf__SWIG_4(ListOf.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this ListOf object.
   *
   * @return the (deep) copy of this ListOf object.
   */ public new
 ListOf clone() {
    IntPtr cPtr = libsbmlPINVOKE.ListOf_clone(swigCPtr);
    ListOf ret = (cPtr == IntPtr.Zero) ? null : new ListOf(cPtr, true);
    return ret;
  }

  
/**
   * Adds an item to the end of this ListOf's list of items.
   *
   * This method makes a clone of the @p item handed to it.  This means that
   * when the ListOf object is destroyed, the original items will not be
   * destroyed.  For a method with an alternative ownership behavior, see the
   * ListOf::appendAndOwn(@if java SBase@endif) method.
   *
   * @param item the item to be added to the list.
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbmlcs#LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT@endlink
   *
   * @see appendAndOwn(SBase item)
   * @see appendFrom(ListOf list)
   */ public
 int append(SBase item) {
    int ret = libsbmlPINVOKE.ListOf_append(swigCPtr, SBase.getCPtr(item));
    return ret;
  }

  
/**
   * Adds an item to the end of this ListOf's list of items.
   *
   * This method does not clone the @p item handed to it; instead, it assumes
   * ownership of it.  This means that when the ListOf is destroyed, the item
   * will be destroyed along with it.  For a method with an alternative
   * ownership behavior, see the ListOf::append(SBase item) method.
   *
   * @param item the item to be added to the list.
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbmlcs#LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT@endlink
   *
   * @see append(SBase item)
   * @see appendFrom(ListOf list)
   */ public
 int appendAndOwn(SBase item) {
    int ret = libsbmlPINVOKE.ListOf_appendAndOwn(swigCPtr, SBase.getCPtrAndDisown(item));
    return ret;
  }

  
/**
   * Adds a clone of a list of items to this ListOf's list.
   *
   * Note that because this clones the objects handed to it, the original
   * items will not be destroyed when this ListOf object is destroyed.
   *
   * @param list a list of items to be added.
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbmlcs#LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT@endlink
   *
   * @see append(SBase item)
   * @see appendAndOwn(SBase item)
   */ public new
 int appendFrom(ListOf list) {
    int ret = libsbmlPINVOKE.ListOf_appendFrom(swigCPtr, ListOf.getCPtr(list));
    return ret;
  }

  
/**
   * Inserts an item at a given position in this ListOf's list of items.
   *
   * This variant of the method makes a clone of the @p item handed to it.
   * This means that when the ListOf is destroyed, the original @p item will
   * <em>not</em> be destroyed.
   *
   * @param location the location in the list where to insert the item.
   * @param item the item to be inserted to the list.
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbmlcs#LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT@endlink
   *
   * @see insertAndOwn(int location, SBase item)
   */ public
 int insert(int location, SBase item) {
    int ret = libsbmlPINVOKE.ListOf_insert(swigCPtr, location, SBase.getCPtr(item));
    return ret;
  }

  
/**
   * Inserts an item at a given position in this ListOf's list of items.
   *
   * This variant of the method makes a clone of the @p item handed to it.
   * This means that when the ListOf is destroyed, the original @p item
   * <em>will</em> be destroyed.
   *
   * @param location the location where to insert the item
   * @param item the item to be inserted to the list
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbmlcs#LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT@endlink
   *
   * @see insert(int location, SBase item)
   */ public
 int insertAndOwn(int location, SBase item) {
    int ret = libsbmlPINVOKE.ListOf_insertAndOwn(swigCPtr, location, SBase.getCPtrAndDisown(item));
    return ret;
  }

  
/**
   * Get an item from the list.
   *
   * @param n the index number of the item to get.
   *
   * @return the <em>n</em>th item in this ListOf items, or a null pointer if
   * the index number @p n refers to a nonexistent position in this list.
   *
   * @see size()
   */ public new
 SBase get(long n) {
	SBase ret = (SBase) libsbml.DowncastSBase(libsbmlPINVOKE.ListOf_get__SWIG_0(swigCPtr, n), false);
	return ret;
}

  
/**
   * Returns the first child element found that has the given identifier.
   *
   * This method searches this ListOf's list of items for SBML objects based
   * on their 'id' attribute value in the model-wide <code>SId</code>
   * identifier namespace.
   *
   * @param id string representing the id of the object to find.
   *
   * @return the first element found with the given @p id, or @c null if no
   * such object is found.
   */ public new
 SBase getElementBySId(string id) {
	SBase ret = (SBase) libsbml.DowncastSBase(libsbmlPINVOKE.ListOf_getElementBySId(swigCPtr, id), false);
	return ret;
}

  
/**
   * Returns the first child element found with the given meta-identifier.
   *
   * @param metaid string representing the 'metaid' attribute of the object
   * to find.
   *
   * @return the first element found with the given @p metaid, or @c null if
   * no such object is found.
   */ public new
 SBase getElementByMetaId(string metaid) {
	SBase ret = (SBase) libsbml.DowncastSBase(libsbmlPINVOKE.ListOf_getElementByMetaId(swigCPtr, metaid), false);
	return ret;
}

  
/**
   * Removes all items in this ListOf object.
   *
   * If parameter @p doDelete is @c true (default), all items in this ListOf
   * object are deleted and cleared, and thus the caller doesn't have to
   * delete those items.  Otherwise, all items are cleared only from this
   * ListOf object; the caller is still responsible for deleting the actual
   * items.  (In the latter case, callers are advised to store pointers to
   * all items elsewhere before calling this function.)
   *
   * @param doDelete if @c true (default), all items are deleted and cleared.
   * Otherwise, all items are just cleared and not deleted.
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 void clear(bool doDelete) {
    libsbmlPINVOKE.ListOf_clear__SWIG_0(swigCPtr, doDelete);
  }

  
/**
   * Removes all items in this ListOf object.
   *
   * If parameter @p doDelete is @c true (default), all items in this ListOf
   * object are deleted and cleared, and thus the caller doesn't have to
   * delete those items.  Otherwise, all items are cleared only from this
   * ListOf object; the caller is still responsible for deleting the actual
   * items.  (In the latter case, callers are advised to store pointers to
   * all items elsewhere before calling this function.)
   *
   * @param doDelete if @c true (default), all items are deleted and cleared.
   * Otherwise, all items are just cleared and not deleted.
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 void clear() {
    libsbmlPINVOKE.ListOf_clear__SWIG_1(swigCPtr);
  }

  
/**
   * Removes all items in this ListOf object and deletes its properties too.
   *
   * This performs a call to clear() with an argument of @c true (thus removing
   * all the child objects in the list), followed by calls to various libSBML
   * <code>unset<em>Foo</em></code> methods to delete everything else: CVTerm
   * objects, model history objects, etc.
   *
   * @if cpp Implementations of subclasses of ListOf may need to override
   * this method if different handling of child objects is needed.@endif
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   */ public new
 int removeFromParentAndDelete() {
    int ret = libsbmlPINVOKE.ListOf_removeFromParentAndDelete(swigCPtr);
    return ret;
  }

  
/**
   * Removes the <em>n</em>th item from this ListOf list of items and returns
   * it.
   *
   * The caller owns the returned item and is responsible for deleting it.
   *
   * @param n the index of the item to remove
   *
   * @see size()
   */ public new
 SBase remove(long n) {
	SBase ret = (SBase) libsbml.DowncastSBase(libsbmlPINVOKE.ListOf_remove(swigCPtr, n), true);
	return ret;
}

  
/**
   * Returns number of items in this ListOf list.
   *
   * @return the number of items in this ListOf items.
   */ public
 long size() { return (long)libsbmlPINVOKE.ListOf_size(swigCPtr); }

  
/**
   * Sets this SBML object to child SBML objects (if any).
   * (Creates a child-parent relationship by the parent)
   *
   * Subclasses must override this function if they define
   * one ore more child elements.
   * Basically, this function needs to be called in
   * constructor, copy constructor and assignment operator.
   *
   * @if cpp
   * @see setSBMLDocument()
   * @see enablePackageInternal()
   * @endif
   */ /* libsbml-internal */ public new
 void connectToChild() {
    libsbmlPINVOKE.ListOf_connectToChild(swigCPtr);
  }

  
/**
   * Returns the libSBML type code for this object, namely,
   * @link libsbmlcs#SBML_LIST_OF SBML_LIST_OF@endlink.
   * 
   * *
 * 
 * LibSBML attaches an identifying code to every kind of SBML object.  These
 * are integer constants known as <em>SBML type codes</em>.  The names of all
 * the codes begin with the characters &ldquo;<code>SBML_</code>&rdquo;.
 * @if clike The set of possible type codes for core elements is defined in
 * the enumeration #SBMLTypeCode_t, and in addition, libSBML plug-ins for
 * SBML Level&nbsp;3 packages define their own extra enumerations of type
 * codes (e.g., #SBMLLayoutTypeCode_t for the Level&nbsp;3 Layout
 * package).@endif@if java In the Java language interface for libSBML, the
 * type codes are defined as static integer constants in the interface class
 * {@link libsbmlConstants}.  @endif@if python In the Python language
 * interface for libSBML, the type codes are defined as static integer
 * constants in the interface class @link libsbml@endlink.@endif@if csharp In
 * the C# language interface for libSBML, the type codes are defined as
 * static integer constants in the interface class
 * @link libsbmlcs.libsbml@endlink.@endif  Note that different Level&nbsp;3
 * package plug-ins may use overlapping type codes; to identify the package
 * to which a given object belongs, call the <code>getPackageName()</code>
 * method on the object.
 *
 *
   *
   * @return the SBML type code for this object:
   * @link libsbmlcs#SBML_LIST_OF SBML_LIST_OF@endlink (default).
   *
   * @note The various ListOf classes mostly differ from each other in what they
   * contain.  Hence, one must call getItemTypeCode() to fully determine the
   * class of this SBML object.
   *
   * *
 * @warning <span class='warning'>The specific integer values of the possible
 * type codes may be reused by different Level&nbsp;3 package plug-ins.
 * Thus, to identifiy the correct code, <strong>it is necessary to invoke
 * both getTypeCode() and getPackageName()</strong>.</span>
 *
 *
   *
   * @see getItemTypeCode()
   * @see getElementName()
   * @see getPackageName()
   */ public new
 int getTypeCode() {
    int ret = libsbmlPINVOKE.ListOf_getTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Get the type code of the objects contained in this ListOf.
   *
   * *
 * 
 * LibSBML attaches an identifying code to every kind of SBML object.  These
 * are integer constants known as <em>SBML type codes</em>.  The names of all
 * the codes begin with the characters &ldquo;<code>SBML_</code>&rdquo;.
 * @if clike The set of possible type codes for core elements is defined in
 * the enumeration #SBMLTypeCode_t, and in addition, libSBML plug-ins for
 * SBML Level&nbsp;3 packages define their own extra enumerations of type
 * codes (e.g., #SBMLLayoutTypeCode_t for the Level&nbsp;3 Layout
 * package).@endif@if java In the Java language interface for libSBML, the
 * type codes are defined as static integer constants in the interface class
 * {@link libsbmlConstants}.  @endif@if python In the Python language
 * interface for libSBML, the type codes are defined as static integer
 * constants in the interface class @link libsbml@endlink.@endif@if csharp In
 * the C# language interface for libSBML, the type codes are defined as
 * static integer constants in the interface class
 * @link libsbmlcs.libsbml@endlink.@endif  Note that different Level&nbsp;3
 * package plug-ins may use overlapping type codes; to identify the package
 * to which a given object belongs, call the <code>getPackageName()</code>
 * method on the object.
 *
 *
   *
   * Classes that inherit from the ListOf class should override this method
   * to return the SBML type code for the objects contained in this ListOf.
   * If they do not, this method will return
   * @link libsbmlcs#SBML_UNKNOWN SBML_UNKNOWN@endlink
   *
   * @return The ListOf base class contains no SBML objects, and therefore
   * this method returns @link libsbmlcs#SBML_UNKNOWN SBML_UNKNOWN@endlink.
   *
   * @see getElementName()
   * @see getPackageName()
   */ public new
 int getItemTypeCode() {
    int ret = libsbmlPINVOKE.ListOf_getItemTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the XML element name of this object, which for ListOf, is
   * always @c 'listOf'.
   *
   * @return the XML name of this element.
   */ public new
 string getElementName() {
    string ret = libsbmlPINVOKE.ListOf_getElementName(swigCPtr);
    return ret;
  }

  
/**
   * Enables/Disables the given package with this element and child
   * elements (if any).
   * (This is an internal implementation for enablePackage function)
   *
   * @note Subclasses of the SBML Core package in which one or more child
   * elements are defined must override this function.
   */ /* libsbml-internal */ public new
 void enablePackageInternal(string pkgURI, string pkgPrefix, bool flag) {
    libsbmlPINVOKE.ListOf_enablePackageInternal(swigCPtr, pkgURI, pkgPrefix, flag);
  }

}

}
