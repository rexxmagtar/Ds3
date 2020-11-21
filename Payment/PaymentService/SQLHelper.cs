namespace PaymentService
{
	static class SQLHelper
	{
		public static readonly string UpdateToken = 
			@"	insert into Tokens (Id, MethodId) VALUES(@Id, @MethodId) 
				on duplicate key update Id=@Id, MethodId=@MethodId";
		
		public static readonly string GetMethodId = 
			@"	select MethodId
				from Tokens
				where Id = @Id";
		
		public static readonly string GetMethodInfo = 
			@"	select ServiceId, MethodName
				from Methods
				where Id = @Id";
	}
}
