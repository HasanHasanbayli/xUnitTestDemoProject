using Microsoft.AspNetCore.WebUtilities;
using Project.Filter;
using Project.Services.Interfaces;

namespace Project.Services;

public class UriService : IUriService
{
    private readonly string _baseUri;

    public UriService(string baseUri)
    {
        _baseUri = baseUri;
    }

    public Uri GetPageUri(PaginationFilter filter, string route)
    {
        var endpointUri = new Uri(string.Concat(_baseUri, route));

        var modifiedUri =
            QueryHelpers.AddQueryString(endpointUri.ToString(), "pageNumber", filter.PageNumber.ToString());

        modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "pageSize", filter.PageSize.ToString());

        return new Uri(modifiedUri);
    }
}