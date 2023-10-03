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

[StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct Matrix3D {

  [MarshalAs(UnmanagedType.R4)]
  private float _m11;

  [MarshalAs(UnmanagedType.R4)]
  private float _m12;

  [MarshalAs(UnmanagedType.R4)]
  private float _m13;

  [MarshalAs(UnmanagedType.R4)]
  private float _m21;

  [MarshalAs(UnmanagedType.R4)]
  private float _m22;

  [MarshalAs(UnmanagedType.R4)]
  private float _m23;
  
  [MarshalAs(UnmanagedType.R4)]
  private float _m31;

  [MarshalAs(UnmanagedType.R4)]
  private float _m32;

  [MarshalAs(UnmanagedType.R4)]
  private float _m33;

  [MarshalAs(UnmanagedType.R4)]
  private float _offsetX;

  [MarshalAs(UnmanagedType.R4)]
  private float _offsetY;
  
  [MarshalAs(UnmanagedType.R4)]
  private float _offsetZ;

  public float M11 {
    get { return _m11; }
    set { _m11 = value; }
  }

  public float M12 {
    get { return _m12; }
    set { _m12 = value; }
  }

  public float M13 {
    get { return _m13; }
    set { _m13 = value; }
  }

  public float M21 {
    get { return _m21; }
    set { _m21 = value; }
  }

  public float M22 {
    get { return _m22; }
    set { _m22 = value; }
  }

  public float M23 {
    get { return _m23; }
    set { _m23 = value; }
  }
  
  public float M31 {
    get { return _m31; }
    set { _m31 = value; }
  }

  public float M32 {
    get { return _m32; }
    set { _m32 = value; }
  }

  public float M33 {
    get { return _m33; }
    set { _m33 = value; }
  }

  public float OffsetX {
    get { return _offsetX; }
    set { _offsetX = value; }
  }

  public float OffsetY {
    get { return _offsetY; }
    set { _offsetY = value; }
  }

  public float OffsetZ {
    get { return _offsetZ; }
    set { _offsetZ = value; }
  }

  public Matrix3D(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33, float offsetX, float offsetY, float offsetZ) {
    _m11 = m11; _m12 = m12; _m13 = m13;
    _m21 = m21; _m22 = m22; _m23 = m23;
    _m31 = m31; _m32 = m32; _m33 = m33;
    _offsetX = offsetX; _offsetY = offsetY; _offsetZ = offsetZ;
  }

  public static Matrix3D Identity {
    get { return _identity; }
  }

  public bool IsIdentity {
    get {
      return _m11 == 1.0f && _m12 == 0.0f && _m13 == 0.0f &&
             _m21 == 0.0f && _m22 == 1.0f && _m23 == 0.0f &&
             _m31 == 0.0f && _m32 == 0.0f && _m33 == 1.0f &&
             _offsetX == 0.0f && _offsetY == 0.0f && _offsetZ == 0.0f;
    }
  }

  public void SetIdentity() {
    this = _identity;
  }

  public static Matrix3D operator *(Matrix3D m0, Matrix3D m1) {
    return new Matrix3D(
      m0._m11 * m1._m11 + m0._m12 * m1._m21 + m0._m13 * m1._m31,
      m0._m11 * m1._m12 + m0._m12 * m1._m22 + m0._m13 * m1._m32,
      m0._m11 * m1._m13 + m0._m12 * m1._m23 + m0._m13 * m1._m33,

      m0._m21 * m1._m11 + m0._m22 * m1._m21 + m0._m23 * m1._m31,
      m0._m21 * m1._m12 + m0._m22 * m1._m22 + m0._m23 * m1._m32,
      m0._m21 * m1._m13 + m0._m22 * m1._m23 + m0._m23 * m1._m33,

      m0._m31 * m1._m11 + m0._m32 * m1._m21 + m0._m33 * m1._m31,
      m0._m31 * m1._m12 + m0._m32 * m1._m22 + m0._m33 * m1._m32,
      m0._m31 * m1._m13 + m0._m32 * m1._m23 + m0._m33 * m1._m33,

      m0._offsetX * m1._m11 + m0._offsetY * m1._m21 + m0._offsetZ * m1._m31 + m1._offsetX,
      m0._offsetX * m1._m12 + m0._offsetY * m1._m22 + m0._offsetZ * m1._m32 + m1._offsetY,
      m0._offsetX * m1._m13 + m0._offsetY * m1._m23 + m0._offsetZ * m1._m33 + m1._offsetZ);
  }

  public static Matrix3D Multiply(Matrix3D m0, Matrix3D m1) {
    return m0 * m1;
  }

  public void Append(Matrix3D matrix) {
    this *= matrix;
  }

  public void Prepend(Matrix3D matrix) {
    this = matrix * this;
  }

  public Matrix3D Scale(float scaleX, float scaleY, float scaleZ) {
    return new Matrix3D(
      scaleX, 0.0f, 0.0f,
      0.0f, scaleY, 0.0f,
      0.0f, 0.0f, scaleZ,
      0.0f, 0.0f, 0.0f);
  }

  public Matrix3D Translate(float transX, float transY, float transZ) {
    return new Matrix3D(
      1.0f, 0.0f, 0.0f,
      0.0f, 1.0f, 0.0f,
      0.0f, 0.0f, 1.0f,
      transX, transY, transZ);
  }

  public Matrix3D RotateX(float angle) {
    float sn, cs;
    GetSinCos(angle, out sn, out cs);
    return new Matrix3D(
      1.0f, 0.0f, 0.0f,
      0.0f, cs, sn,
      0.0f, -sn, cs,
      0.0f, 0.0f, 0.0f);
  }

  public Matrix3D RotateY(float angle) {
    float sn, cs;
    GetSinCos(angle, out sn, out cs);
    return new Matrix3D(
      cs, 0.0f, sn,
      0.0f, 1.0f, 0.0f,
      -sn, 0.0f, cs,
      0.0f, 0.0f, 0.0f);
  }

  public Matrix3D RotateZ(float angle) {
    float sn, cs;
    GetSinCos(angle, out sn, out cs);
    return new Matrix3D(
      cs, sn, 0.0f,
      -sn, cs, 0.0f,
      0.0f, 0.0f, 1.0f,
      0.0f, 0.0f, 0.0f);
  }

  public Point3D Transform(Point3D point) {
    return new Point3D(
      point.X * _m11 + point.Y * _m21 + point.Z * _m31 + _offsetX,
      point.X * _m12 + point.Y * _m22 + point.Z * _m32 + _offsetY,
      point.X * _m13 + point.Y * _m23 + point.Z * _m33 + _offsetZ);
  }

  public Vector3D Transform(Vector3D vector) {
    return new Vector3D(
      vector.X * _m11 + vector.Y * _m21 + vector.Z * _m31,
      vector.X * _m12 + vector.Y * _m22 + vector.Z * _m32,
      vector.X * _m13 + vector.Y * _m23 + vector.Z * _m33);
  }

  public float Determinant {
    get {
      return
        (_m11 * _m22 * _m33 + _m12 * _m23 * _m31 + _m13 * _m21 * _m32) -
        (_m11 * _m23 * _m32 + _m12 * _m21 * _m33 + _m13 * _m22 * _m31);
    }
  }

  public bool HasInverse {
    get { return Math.Abs(Determinant) < 0.0001f; }
  }

  public void Invert() {
    float determinant = Determinant;
    if (Math.Abs(determinant) < 0.0001f) {
      throw new InvalidOperationException("Matrix3D is not Invertible");
    }
    float m11 = (_m22 * _m33 - _m23 * _m32) / determinant;
    float m12 = (_m13 * _m32 - _m12 * _m33) / determinant;
    float m13 = (_m12 * _m23 - _m13 * _m22) / determinant;

    float m21 = (_m23 * _m31 - _m21 * _m33) / determinant;
    float m22 = (_m11 * _m33 - _m13 * _m31) / determinant;
    float m23 = (_m13 * _m21 - _m11 * _m23) / determinant;

    float m31 = (_m21 * _m32 - _m22 * _m31) / determinant;
    float m32 = (_m12 * _m31 - _m11 * _m32) / determinant;
    float m33 = (_m11 * _m22 - _m12 * _m21) / determinant;

    float offX = -_offsetX * m11 - _offsetY * m21 - _offsetZ * m31;
    float offY = -_offsetX * m12 - _offsetY * m22 - _offsetZ * m32;
    float offZ = -_offsetX * m13 - _offsetY * m23 - _offsetZ * m33;

    this = new Matrix3D(
      m11, m12, m13,
      m21, m22, m23,
      m31, m32, m33,
      offX, offY, offZ);
  }

  #region Transform3D helpers
  private void GetSinCos(float angle, out float sn, out float cs) {
    angle %= 360.0f; // Doing the modulo before converting to radians reduces total error
    float radians = angle * (float)(Math.PI / 180.0f);
    sn = (float)Math.Sin(radians);
    cs = (float)Math.Cos(radians);
  }
  #endregion

  #region Identity matrix
  private static readonly Matrix3D _identity =
    new Matrix3D(
      1.0f, 0.0f, 0.0f,
      0.0f, 1.0f, 0.0f,
      0.0f, 0.0f, 1.0f,
      0.0f, 0.0f, 0.0f);
  #endregion

}

}

