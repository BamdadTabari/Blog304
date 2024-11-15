﻿namespace DataProvider.Base.Operation;
public class OperationResult
{
    public readonly OperationResultStatus Status;
    public readonly bool IsPersistAble;
    public readonly object Value;
    public readonly Dictionary<string, string> OperationValues;

    public OperationResult(OperationResultStatus status, bool isPersistAble = false, object? value = null,
        Dictionary<string, string>? operationValues = null)
    {
        Status = status;
        Value = value;
        IsPersistAble = isPersistAble;
        OperationValues = operationValues;
    }

    public OperationResult(OperationResult operation, bool succeeded)
    {
        Status = succeeded ? OperationResultStatus.Ok : OperationResultStatus.UnProcessable;
        IsPersistAble = operation.IsPersistAble;
        Value = operation.Value;
        OperationValues = operation.OperationValues;
    }

    public bool Succeeded => IsSucceeded(Status);

    private bool IsSucceeded(OperationResultStatus status) => status switch
    {
        _ when
            status == OperationResultStatus.Ok => true,
        _ when
            status == OperationResultStatus.Invalidated ||
            status == OperationResultStatus.NotFound ||
            status == OperationResultStatus.Unauthorized ||
            status == OperationResultStatus.UnProcessable => false,
        _ => false
    };
}
