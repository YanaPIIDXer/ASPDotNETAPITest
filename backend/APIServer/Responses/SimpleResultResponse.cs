using System;
namespace APIServer.Responses
{
    public class SimpleResultResponse
    {
        public bool Result { get; set; }
        public SimpleResultResponse(bool Result)
        {
            this.Result = Result;
        }
    }
}
