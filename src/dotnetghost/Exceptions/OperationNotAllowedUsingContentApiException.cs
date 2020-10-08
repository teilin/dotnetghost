using System;

namespace dotnetghost.Exceptions
{
    public sealed class OperationNotAllowedUsingContentApiException : Exception
    {
        private readonly string _apiUrl;
        private readonly string _resource;
        private readonly string _method;

        public OperationNotAllowedUsingContentApiException(string apiUrl, string resource, string method) 
            : base($"This operation, {resource} - {method}, is not allowed using the content api. Use the admin api insted. Api: {apiUrl}")
        {
            _apiUrl = apiUrl;
            _resource = resource;
            _method = method;
        }

        public override string ToString()
        {
            return $"This operation, {_resource} - {_method}, is not allowed using the content api. Use the admin api insted. Api: {_apiUrl}"
        }
    }
}