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
@htmlinclude pkg-marker-core.html Interface to an XML output stream.
 *
 * @if notclike @internal @endif
 */

public class XMLOutputStream : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal XMLOutputStream(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(XMLOutputStream obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (XMLOutputStream obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~XMLOutputStream() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_XMLOutputStream(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static bool operator==(XMLOutputStream lhs, XMLOutputStream rhs)
  {
    if((Object)lhs == (Object)rhs)
    {
      return true;
    }

    if( ((Object)lhs == null) || ((Object)rhs == null) )
    {
      return false;
    }

    return (getCPtr(lhs).Handle.ToString() == getCPtr(rhs).Handle.ToString());
  }

  public static bool operator!=(XMLOutputStream lhs, XMLOutputStream rhs)
  {
    return !(lhs == rhs);
  }

  public override bool Equals(Object sb)
  {
    if ( ! (sb is XMLOutputStream) )
    {
      return false;
    }

    return this == (XMLOutputStream)sb;
  }

  public override int GetHashCode()
  {
    return swigCPtr.Handle.ToInt32();
  }

  
/**
   * Creates a new XMLOutputStream that wraps stream.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLOutputStream(OStream stream, string encoding, bool writeXMLDecl, string programName, string programVersion) : this(libsbmlPINVOKE.new_XMLOutputStream__SWIG_0(SWIGTYPE_p_std__ostream.getCPtr(stream.get_ostream()), encoding, writeXMLDecl, programName, programVersion), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new XMLOutputStream that wraps stream.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLOutputStream(OStream stream, string encoding, bool writeXMLDecl, string programName) : this(libsbmlPINVOKE.new_XMLOutputStream__SWIG_1(SWIGTYPE_p_std__ostream.getCPtr(stream.get_ostream()), encoding, writeXMLDecl, programName), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new XMLOutputStream that wraps stream.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLOutputStream(OStream stream, string encoding, bool writeXMLDecl) : this(libsbmlPINVOKE.new_XMLOutputStream__SWIG_2(SWIGTYPE_p_std__ostream.getCPtr(stream.get_ostream()), encoding, writeXMLDecl), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new XMLOutputStream that wraps stream.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLOutputStream(OStream stream, string encoding) : this(libsbmlPINVOKE.new_XMLOutputStream__SWIG_3(SWIGTYPE_p_std__ostream.getCPtr(stream.get_ostream()), encoding), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new XMLOutputStream that wraps stream.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLOutputStream(OStream stream) : this(libsbmlPINVOKE.new_XMLOutputStream__SWIG_4(SWIGTYPE_p_std__ostream.getCPtr(stream.get_ostream())), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given XML end element name to this XMLOutputStream.
   */ public
 void endElement(string name, string prefix) {
    libsbmlPINVOKE.XMLOutputStream_endElement__SWIG_0(swigCPtr, name, prefix);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given XML end element name to this XMLOutputStream.
   */ public
 void endElement(string name) {
    libsbmlPINVOKE.XMLOutputStream_endElement__SWIG_1(swigCPtr, name);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given XML end element 'prefix:name' to this
   * XMLOutputStream.
   */ public
 void endElement(XMLTriple triple) {
    libsbmlPINVOKE.XMLOutputStream_endElement__SWIG_2(swigCPtr, XMLTriple.getCPtr(triple));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Turns automatic indentation on or off for this XMLOutputStream.
   */ public
 void setAutoIndent(bool indent) {
    libsbmlPINVOKE.XMLOutputStream_setAutoIndent(swigCPtr, indent);
  }

  
/**
   * Writes the given XML start element name to this XMLOutputStream.
   */ public
 void startElement(string name, string prefix) {
    libsbmlPINVOKE.XMLOutputStream_startElement__SWIG_0(swigCPtr, name, prefix);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given XML start element name to this XMLOutputStream.
   */ public
 void startElement(string name) {
    libsbmlPINVOKE.XMLOutputStream_startElement__SWIG_1(swigCPtr, name);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given XML start element 'prefix:name' to this
   * XMLOutputStream.
   */ public
 void startElement(XMLTriple triple) {
    libsbmlPINVOKE.XMLOutputStream_startElement__SWIG_2(swigCPtr, XMLTriple.getCPtr(triple));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given XML start and end element name to this XMLOutputStream.
   */ public
 void startEndElement(string name, string prefix) {
    libsbmlPINVOKE.XMLOutputStream_startEndElement__SWIG_0(swigCPtr, name, prefix);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given XML start and end element name to this XMLOutputStream.
   */ public
 void startEndElement(string name) {
    libsbmlPINVOKE.XMLOutputStream_startEndElement__SWIG_1(swigCPtr, name);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given XML start and end element 'prefix:name' to this
   * XMLOutputStream.
   */ public
 void startEndElement(XMLTriple triple) {
    libsbmlPINVOKE.XMLOutputStream_startEndElement__SWIG_2(swigCPtr, XMLTriple.getCPtr(triple));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given attribute, name='value' to this XMLOutputStream.
   */ public
 void writeAttribute(string name, string value) {
    libsbmlPINVOKE.XMLOutputStream_writeAttribute__SWIG_0(swigCPtr, name, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given attribute, prefix:name='value' to this XMLOutputStream.
   */ public
 void writeAttribute(string name, string prefix, string value) {
    libsbmlPINVOKE.XMLOutputStream_writeAttribute__SWIG_1(swigCPtr, name, prefix, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given attribute, prefix:name='value' to this
   * XMLOutputStream.
   */ public
 void writeAttribute(XMLTriple triple, string value) {
    libsbmlPINVOKE.XMLOutputStream_writeAttribute__SWIG_2(swigCPtr, XMLTriple.getCPtr(triple), value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given attribute, name='true' or name='false' to this
   * XMLOutputStream.
   */ public
 void writeAttribute(string name, bool value) {
    libsbmlPINVOKE.XMLOutputStream_writeAttribute__SWIG_6(swigCPtr, name, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given attribute, prefix:name='true' or prefix:name='false' to this
   * XMLOutputStream.
   */ public
 void writeAttribute(string name, string prefix, bool value) {
    libsbmlPINVOKE.XMLOutputStream_writeAttribute__SWIG_7(swigCPtr, name, prefix, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given attribute, prefix:name='true' or prefix:name='false'
   * to this XMLOutputStream.
   */ public
 void writeAttribute(XMLTriple triple, bool value) {
    libsbmlPINVOKE.XMLOutputStream_writeAttribute__SWIG_8(swigCPtr, XMLTriple.getCPtr(triple), value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given attribute, name='value' to this XMLOutputStream.
   */ public
 void writeAttribute(string name, double value) {
    libsbmlPINVOKE.XMLOutputStream_writeAttribute__SWIG_9(swigCPtr, name, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given attribute, prefix:name='value' to this XMLOutputStream.
   */ public
 void writeAttribute(string name, string prefix, double value) {
    libsbmlPINVOKE.XMLOutputStream_writeAttribute__SWIG_10(swigCPtr, name, prefix, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given attribute, prefix:name='value' to this
   * XMLOutputStream.
   */ public
 void writeAttribute(XMLTriple triple, double value) {
    libsbmlPINVOKE.XMLOutputStream_writeAttribute__SWIG_11(swigCPtr, XMLTriple.getCPtr(triple), value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given attribute, name='value' to this XMLOutputStream.
   */ public
 void writeAttribute(string name, int value) {
    libsbmlPINVOKE.XMLOutputStream_writeAttribute__SWIG_12(swigCPtr, name, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given attribute, prefix:name='value' to this XMLOutputStream.
   */ public
 void writeAttribute(string name, string prefix, int value) {
    libsbmlPINVOKE.XMLOutputStream_writeAttribute__SWIG_13(swigCPtr, name, prefix, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given attribute, prefix:name='value' to this
   * XMLOutputStream.
   */ public
 void writeAttribute(XMLTriple triple, int value) {
    libsbmlPINVOKE.XMLOutputStream_writeAttribute__SWIG_14(swigCPtr, XMLTriple.getCPtr(triple), value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the given attribute, prefix:name='value' to this XMLOutputStream.
   */ public
 void writeAttribute(string name, string prefix, long value) {
    libsbmlPINVOKE.XMLOutputStream_writeAttribute__SWIG_18(swigCPtr, name, prefix, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Writes the XML declaration:
   * <?xml version='1.0' encoding='...'?>
   */ public
 void writeXMLDecl() {
    libsbmlPINVOKE.XMLOutputStream_writeXMLDecl(swigCPtr);
  }

  
/**
   * Writes an XML comment:
   * <?xml version='1.0' encoding='...'?>
   */ public
 void writeComment(string programName, string programVersion) {
    libsbmlPINVOKE.XMLOutputStream_writeComment(swigCPtr, programName, programVersion);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Decreases the indentation level for this XMLOutputStream.
   */ public
 void downIndent() {
    libsbmlPINVOKE.XMLOutputStream_downIndent(swigCPtr);
  }

  
/**
   * Increases the indentation level for this XMLOutputStream.
   */ public
 void upIndent() {
    libsbmlPINVOKE.XMLOutputStream_upIndent(swigCPtr);
  }

}

}
