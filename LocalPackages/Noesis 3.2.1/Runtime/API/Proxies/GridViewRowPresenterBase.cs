//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class GridViewRowPresenterBase : FrameworkElement {
  internal new static GridViewRowPresenterBase CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new GridViewRowPresenterBase(cPtr, cMemoryOwn);
  }

  internal GridViewRowPresenterBase(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(GridViewRowPresenterBase obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public GridViewRowPresenterBase() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_GridViewRowPresenterBase();
  }

  public static DependencyProperty ColumnsProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewRowPresenterBase_ColumnsProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public GridViewColumnCollection Columns {
    set {
      NoesisGUI_PINVOKE.GridViewRowPresenterBase_Columns_set(swigCPtr, GridViewColumnCollection.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewRowPresenterBase_Columns_get(swigCPtr);
      return (GridViewColumnCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}
