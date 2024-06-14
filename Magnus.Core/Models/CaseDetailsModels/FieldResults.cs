using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Magnus.Core.Infrastructure.Resources.Extentions;


namespace Magnus.Core.Models.CaseDetailsModels;

public abstract class FieldResultsCollection<TResult> where TResult : JobResult
{
    //Field collected information
    public List<TResult> Results { get; init; } = new();

    public string? GetValue(TResult queryParam)
    {
        List<TResult> query = Results.Where(r => r.FieldName == queryParam.FieldName).ToList();

        if (query.Count == 0)
            return null;
        if (query.Count == 1)
            return query[0].Answer;

        PropertyInfo[] props = typeof(TResult).GetDistinctProperties(typeof(JobResult));

        foreach (PropertyInfo prop in props)
        {
            query = query.Where(q => prop.GetValue(q)?.ToString() == prop.GetValue(queryParam)?.ToString()).ToList();

            if (query.Count == 0)
                return null;
            if (query.Count == 1)
                return query[0].Answer;
        }

        return null;
    }
}
