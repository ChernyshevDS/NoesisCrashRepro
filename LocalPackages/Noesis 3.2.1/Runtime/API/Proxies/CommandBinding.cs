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
using System.Collections.Generic;
using System.Windows.Input;

namespace Noesis
{

public class CommandBinding : BaseComponent {
  internal new static CommandBinding CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new CommandBinding(cPtr, cMemoryOwn);
  }

  internal CommandBinding(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(CommandBinding obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  #region Events

  #region PreviewCanExecute
  public delegate void PreviewCanExecuteHandler(object sender, CanExecuteRoutedEventArgs e);
  public event PreviewCanExecuteHandler PreviewCanExecute {
    add {
      long ptr = swigCPtr.Handle.ToInt64();
      if (!_PreviewCanExecute.ContainsKey(ptr)) {
        _PreviewCanExecute.Add(ptr, null);

        NoesisGUI_PINVOKE.BindEvent_CommandBinding_PreviewCanExecute(_raisePreviewCanExecute, swigCPtr.Handle);
      }

      _PreviewCanExecute[ptr] += value;
    }
    remove {
      long ptr = swigCPtr.Handle.ToInt64();
      if (_PreviewCanExecute.ContainsKey(ptr)) {

        _PreviewCanExecute[ptr] -= value;

        if (_PreviewCanExecute[ptr] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_CommandBinding_PreviewCanExecute(_raisePreviewCanExecute, swigCPtr.Handle);

          _PreviewCanExecute.Remove(ptr);
        }
      }
    }
  }

  internal delegate void RaisePreviewCanExecuteCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaisePreviewCanExecuteCallback _raisePreviewCanExecute = RaisePreviewCanExecute;

  [MonoPInvokeCallback(typeof(RaisePreviewCanExecuteCallback))]
  private static void RaisePreviewCanExecute(IntPtr cPtr, IntPtr sender, IntPtr e) {
    try {
      if (Noesis.Extend.Initialized) {
        long ptr = cPtr.ToInt64();
        if (sender == IntPtr.Zero && e == IntPtr.Zero) {
          _PreviewCanExecute.Remove(ptr);
          return;
        }
        PreviewCanExecuteHandler handler = null;
        if (!_PreviewCanExecute.TryGetValue(ptr, out handler)) {
          throw new InvalidOperationException("Delegate not registered for PreviewCanExecute event");
        }
        handler?.Invoke(Noesis.Extend.GetProxy(sender, false), new CanExecuteRoutedEventArgs(e, false));
      }
    }
    catch (Exception exception) {
      Noesis.Error.UnhandledException(exception);
    }
  }

  internal static Dictionary<long, PreviewCanExecuteHandler> _PreviewCanExecute =
      new Dictionary<long, PreviewCanExecuteHandler>();
  #endregion

  #region CanExecute
  public delegate void CanExecuteHandler(object sender, CanExecuteRoutedEventArgs e);
  public event CanExecuteHandler CanExecute {
    add {
      long ptr = swigCPtr.Handle.ToInt64();
      if (!_CanExecute.ContainsKey(ptr)) {
        _CanExecute.Add(ptr, null);

        NoesisGUI_PINVOKE.BindEvent_CommandBinding_CanExecute(_raiseCanExecute, swigCPtr.Handle);
      }

      _CanExecute[ptr] += value;
    }
    remove {
      long ptr = swigCPtr.Handle.ToInt64();
      if (_CanExecute.ContainsKey(ptr)) {

        _CanExecute[ptr] -= value;

        if (_CanExecute[ptr] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_CommandBinding_CanExecute(_raiseCanExecute, swigCPtr.Handle);

          _CanExecute.Remove(ptr);
        }
      }
    }
  }

  internal delegate void RaiseCanExecuteCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaiseCanExecuteCallback _raiseCanExecute = RaiseCanExecute;

  [MonoPInvokeCallback(typeof(RaiseCanExecuteCallback))]
  private static void RaiseCanExecute(IntPtr cPtr, IntPtr sender, IntPtr e) {
    try {
      if (Noesis.Extend.Initialized) {
        long ptr = cPtr.ToInt64();
        if (sender == IntPtr.Zero && e == IntPtr.Zero) {
          _CanExecute.Remove(ptr);
          return;
        }
        CanExecuteHandler handler = null;
        if (!_CanExecute.TryGetValue(ptr, out handler)) {
          throw new InvalidOperationException("Delegate not registered for CanExecute event");
        }
        handler?.Invoke(Noesis.Extend.GetProxy(sender, false), new CanExecuteRoutedEventArgs(e, false));
      }
    }
    catch (Exception exception) {
      Noesis.Error.UnhandledException(exception);
    }
  }

  internal static Dictionary<long, CanExecuteHandler> _CanExecute =
      new Dictionary<long, CanExecuteHandler>();
  #endregion

  #region PreviewExecuted
  public delegate void PreviewExecutedHandler(object sender, ExecutedRoutedEventArgs e);
  public event PreviewExecutedHandler PreviewExecuted {
    add {
      long ptr = swigCPtr.Handle.ToInt64();
      if (!_PreviewExecuted.ContainsKey(ptr)) {
        _PreviewExecuted.Add(ptr, null);

        NoesisGUI_PINVOKE.BindEvent_CommandBinding_PreviewExecuted(_raisePreviewExecuted, swigCPtr.Handle);
      }

      _PreviewExecuted[ptr] += value;
    }
    remove {
      long ptr = swigCPtr.Handle.ToInt64();
      if (_PreviewExecuted.ContainsKey(ptr)) {

        _PreviewExecuted[ptr] -= value;

        if (_PreviewExecuted[ptr] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_CommandBinding_PreviewExecuted(_raisePreviewExecuted, swigCPtr.Handle);

          _PreviewExecuted.Remove(ptr);
        }
      }
    }
  }

  internal delegate void RaisePreviewExecutedCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaisePreviewExecutedCallback _raisePreviewExecuted = RaisePreviewExecuted;

  [MonoPInvokeCallback(typeof(RaisePreviewExecutedCallback))]
  private static void RaisePreviewExecuted(IntPtr cPtr, IntPtr sender, IntPtr e) {
    try {
      if (Noesis.Extend.Initialized) {
        long ptr = cPtr.ToInt64();
        if (sender == IntPtr.Zero && e == IntPtr.Zero) {
          _PreviewExecuted.Remove(ptr);
          return;
        }
        PreviewExecutedHandler handler = null;
        if (!_PreviewExecuted.TryGetValue(ptr, out handler)) {
          throw new InvalidOperationException("Delegate not registered for PreviewExecuted event");
        }
        handler?.Invoke(Noesis.Extend.GetProxy(sender, false), new ExecutedRoutedEventArgs(e, false));
      }
    }
    catch (Exception exception) {
      Noesis.Error.UnhandledException(exception);
    }
  }

  internal static Dictionary<long, PreviewExecutedHandler> _PreviewExecuted =
      new Dictionary<long, PreviewExecutedHandler>();
  #endregion

  #region Executed
  public delegate void ExecutedHandler(object sender, ExecutedRoutedEventArgs e);
  public event ExecutedHandler Executed {
    add {
      long ptr = swigCPtr.Handle.ToInt64();
      if (!_Executed.ContainsKey(ptr)) {
        _Executed.Add(ptr, null);

        NoesisGUI_PINVOKE.BindEvent_CommandBinding_Executed(_raiseExecuted, swigCPtr.Handle);
      }

      _Executed[ptr] += value;
    }
    remove {
      long ptr = swigCPtr.Handle.ToInt64();
      if (_Executed.ContainsKey(ptr)) {

        _Executed[ptr] -= value;

        if (_Executed[ptr] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_CommandBinding_Executed(_raiseExecuted, swigCPtr.Handle);

          _Executed.Remove(ptr);
        }
      }
    }
  }

  internal delegate void RaiseExecutedCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaiseExecutedCallback _raiseExecuted = RaiseExecuted;

  [MonoPInvokeCallback(typeof(RaiseExecutedCallback))]
  private static void RaiseExecuted(IntPtr cPtr, IntPtr sender, IntPtr e) {
    try {
      if (Noesis.Extend.Initialized) {
        long ptr = cPtr.ToInt64();
        if (sender == IntPtr.Zero && e == IntPtr.Zero) {
          _Executed.Remove(ptr);
          return;
        }
        ExecutedHandler handler = null;
        if (!_Executed.TryGetValue(ptr, out handler)) {
          throw new InvalidOperationException("Delegate not registered for Executed event");
        }
        handler?.Invoke(Noesis.Extend.GetProxy(sender, false), new ExecutedRoutedEventArgs(e, false));
      }
    }
    catch (Exception exception) {
      Noesis.Error.UnhandledException(exception);
    }
  }

  internal static Dictionary<long, ExecutedHandler> _Executed =
      new Dictionary<long, ExecutedHandler>();
  #endregion

  #endregion

  public ICommand Command {
    get {
      return GetCommandHelper() as ICommand;
    }
    set {
      SetCommandHelper(value);
    }
  }

  public CommandBinding() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_CommandBinding__SWIG_0();
  }

  private object GetCommandHelper() {
    IntPtr cPtr = NoesisGUI_PINVOKE.CommandBinding_GetCommandHelper(swigCPtr);
    return Noesis.Extend.GetProxy(cPtr, false);
  }

  private void SetCommandHelper(object command) {
    NoesisGUI_PINVOKE.CommandBinding_SetCommandHelper(swigCPtr, Noesis.Extend.GetInstanceHandle(command));
  }

}

}

