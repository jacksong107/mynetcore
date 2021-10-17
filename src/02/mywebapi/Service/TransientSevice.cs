using System;

namespace mywebapi
{
    public interface ITrasientService{}

public class TransientService: ITrasientService{
    public readonly string _operationId;
	public TransientService(){
		_operationId = " TransientService Created Time: " + DateTime.Now + "Guid: " + Guid.NewGuid();
		
	}
	
	public override string  ToString(){
		return _operationId;
}
}
}