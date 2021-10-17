
using System;

namespace mywebapi
{
    public interface ISingletonService{}

public class SingletonService: ISingletonService{
    public readonly string _operationId;
	public SingletonService(){
		_operationId = " SingletonService Created Time: " + DateTime.Now + "Guid: " + Guid.NewGuid();
		
	}
	
	public override string  ToString(){
		return _operationId;
}
}
}