﻿namespace ArchitectProg.Kernel.Extensions.Mappers;

public interface IMapper<in TSource, out TDestination>
{
    TDestination Map(TSource source);

    IEnumerable<TDestination> MapCollection(IEnumerable<TSource> source)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        var result = source.Select(x => Map(x)).ToArray();
        return result;
    }
}