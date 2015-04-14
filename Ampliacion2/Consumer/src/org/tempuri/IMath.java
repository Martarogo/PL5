/**
 * IMath.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface IMath extends java.rmi.Remote {
    public java.lang.Boolean prime(java.lang.Integer value) throws java.rmi.RemoteException;
    public org.datacontract.schemas._2004._07.MathService.Tuple sum(org.datacontract.schemas._2004._07.MathService.Tuple t) throws java.rmi.RemoteException;
    public double[] solveSystem(double[] system) throws java.rmi.RemoteException;
}
