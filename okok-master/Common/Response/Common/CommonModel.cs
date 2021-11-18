using System.Collections.Generic;
using System.Linq;
using System.Net;

public class StatusResponse
{
    public StatusResponse()
    {

    }
    public StatusResponse(int _code, string _mes)
    {
        this.StatusCode = _code;
        this.Message = _mes;
    }
    public int StatusCode { get; set; }
    public string Message { get; set; }
}

public class StatusInvalidParamsResponse : StatusResponse
{
    public StatusInvalidParamsResponse() { }
    public StatusInvalidParamsResponse(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary _modelState, string _message = "Params Invalid")
    {
        Dictionary<string, List<string>> errorList = _modelState
            .Where(x => x.Value.Errors.Count > 0)
            .ToDictionary(
                kvp => kvp.Key,
                kvp => kvp.Value.Errors.Select(e => (string.IsNullOrWhiteSpace(e.ErrorMessage) || string.IsNullOrEmpty(e.ErrorMessage)) ? e.Exception.InnerException.Message : e.ErrorMessage).ToList()
            );

        this.StatusCode = (int)HttpStatusCode.BadRequest;
        this.Message = _message;
        this.Description = errorList;
    }
    public Dictionary<string, List<string>> Description { get; set; }
}