using System;

namespace mywebapi
{
    public interface IScopedService{}

public class ScopedService: IScopedService{
    public readonly string _operationId;
	public ScopedService(){
		_operationId = " ScopedService Created Time: " + DateTime.Now + "Guid: " + Guid.NewGuid();
		
	}
	
	public override string  ToString(){
		return _operationId;
}
}
}