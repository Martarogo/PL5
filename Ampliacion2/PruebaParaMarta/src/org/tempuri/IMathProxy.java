package org.tempuri;

public class IMathProxy implements org.tempuri.IMath {
  private String _endpoint = null;
  private org.tempuri.IMath iMath = null;
  
  public IMathProxy() {
    _initIMathProxy();
  }
  
  public IMathProxy(String endpoint) {
    _endpoint = endpoint;
    _initIMathProxy();
  }
  
  private void _initIMathProxy() {
    try {
      iMath = (new org.tempuri.MathLocator()).getBasicHttpBinding_IMath();
      if (iMath != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)iMath)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)iMath)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (iMath != null)
      ((javax.xml.rpc.Stub)iMath)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.IMath getIMath() {
    if (iMath == null)
      _initIMathProxy();
    return iMath;
  }
  
  public java.lang.Boolean prime(java.lang.Integer value) throws java.rmi.RemoteException{
    if (iMath == null)
      _initIMathProxy();
    return iMath.prime(value);
  }
  
  public org.datacontract.schemas._2004._07.MathService.Tuple sum(org.datacontract.schemas._2004._07.MathService.Tuple t) throws java.rmi.RemoteException{
    if (iMath == null)
      _initIMathProxy();
    return iMath.sum(t);
  }
  
  public double[] solveSystem(double[] system) throws java.rmi.RemoteException{
    if (iMath == null)
      _initIMathProxy();
    return iMath.solveSystem(system);
  }
  
  
}